﻿// *********************************************************************
// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License
// *********************************************************************
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using DataX.Config.ConfigDataModel;
using DataX.Config.Templating;
using DataX.Contract;
using System;
using System.Composition;
using System.Linq;
using System.Threading.Tasks;

namespace DataX.Config
{
    [Shared]
    [Export]
    public class FlowDataManager
    {
        public const string DataCollectionName = "flows";
        public const string CommonDataName_DefaultFlowConfig = "defaultFlowConfig";

        [ImportingConstructor]
        public FlowDataManager(ConfigGenConfiguration configuration, IDesignTimeConfigStorage storage, ICommonDataManager commonsData)
        {
            Storage = storage;
            Configuration = configuration;
            CommonsData = commonsData;
        }

        private IDesignTimeConfigStorage Storage { get; }
        private ConfigGenConfiguration Configuration { get; }
        private ICommonDataManager CommonsData { get; }

        public async Task<FlowConfig> GetByName(string flowName)
        {
            var json = await this.Storage.GetByName(flowName, DataCollectionName);
            return FlowConfig.From(json);
        }

        public async Task<FlowConfig> GetDefaultConfig(TokenDictionary tokens = null)
        {
            var config = await CommonsData.GetByName(CommonDataName_DefaultFlowConfig);
            if(tokens != null)
            {
                config = tokens.Resolve(config);
            }

            return FlowConfig.From(config);
        }

        public async Task<FlowConfig> GetByNameWithDefaultMerged(string flowName)
        {
            // Call Storage client to get back the associated flow config
            var config = await this.GetByName(flowName);
            if (config == null)
            {
                throw new ConfigGenerationException($"Flow '{flowName}' does not exist");
            }

            // also get the common flow config template
            var defaultConfig = await this.GetDefaultConfig();
            // Combine flow config and the default template, overwrite the default value if there are any, also check for required field defined in the default template
            var combinedConfig = config.RebaseOn(defaultConfig);

            return combinedConfig;
        }

        public async Task<Result> UpdateJobNamesForFlow(string flowName, string[] upsertedJobNames)
        {
            var json = JsonConvert.SerializeObject(upsertedJobNames);
            return await this.Storage.UpdatePartialByName(json, FlowConfig.JsonFieldName_JobNames, flowName, DataCollectionName);
        }

        public async Task<Result> UpdateMetricsForFlow(string flowName, MetricsConfig metrics)
        {
            return await this.Storage.UpdatePartialByName(metrics.ToString(), FlowConfig.JsonFieldName_Metrics, flowName, DataCollectionName);
        }

        public Task<Result> UpdateGuiForFlow(string name, JToken gui)
        {
            return this.Storage.UpdatePartialByName(gui?.ToString(), FlowConfig.JsonFieldName_Gui, name, DataCollectionName);
        }

        public async Task<FlowConfig[]> GetAll()
        {
            var jsons = await this.Storage.GetAll(DataCollectionName);
            return jsons.Select(FlowConfig.From).ToArray();
        }

        public async Task<FlowConfig[]> GetAllActive()
        {
            var jsons = await this.Storage.GetByFieldValue("false", "disabled", DataCollectionName);
            return jsons.Select(FlowConfig.From).ToArray();
        }

        public async Task<Result> Upsert(FlowConfig config)
        {
            if (config == null)
            {
                return new FailedResult("input config for the flow is null");
            }
            else if(string.IsNullOrWhiteSpace(config.Name))
            {
                return new FailedResult("name of the flow cannot be empty");
            }
            else
            {
                return await this.Storage.SaveByName(config.Name, config.ToString(), DataCollectionName);
            }
        }


        /// <summary>
        /// Delete the flow config
        /// </summary>
        /// <param name="config"></param>
        /// <returns></returns>
        public async Task<Result> DeleteByName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return new FailedResult("name of the flow cannot be empty");
            }
            else
            {
                return await this.Storage.DeleteByName(name, DataCollectionName);
            }
        }
    }
}
