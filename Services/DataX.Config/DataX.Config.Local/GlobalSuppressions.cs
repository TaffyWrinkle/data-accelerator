﻿
// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1707:Remove the underscores from member name DataX.Config.Local.LocalSparkClient.ConfigSettingName_LocalRootFolder.", Justification = "Critical issues only", Scope = "member", Target = "~F:DataX.Config.Local.LocalSparkClient.ConfigSettingName_LocalRootFolder")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1707:Remove the underscores from member name DataX.Config.Local.LocalSparkClient.ConfigSettingName_SparkHomeFolder.", Justification = "Critical issues only", Scope = "member", Target = "~F:DataX.Config.Local.LocalSparkClient.ConfigSettingName_SparkHomeFolder")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1307:The behavior of 'string.StartsWith(string)' could vary based on the current user's locale settings. Replace this call in 'DataX.Config.Local.BsonDocumentExtension.SetField(LiteDB.BsonDocument, string, LiteDB.BsonValue)' with a call to 'string.StartsWith(string, System.StringComparison)'.", Justification = "Critical issues only", Scope = "member", Target = "~M:DataX.Config.Local.BsonDocumentExtension.SetField(LiteDB.BsonDocument,System.String,LiteDB.BsonValue)~System.Boolean")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1801:Parameter state of method .ctor is never used. Remove the parameter or use it in the method body.", Justification = "Critical issues only", Scope = "member", Target = "~M:DataX.Config.Local.ConsoleLogger.LoggerScope`1.#ctor(`0)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1822:Member WriteLine does not access instance data and can be marked as static (Shared in VisualBasic)", Justification = "Critical issues only", Scope = "member", Target = "~M:DataX.Config.Local.ConsoleLogger.WriteLine(System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1054:Change the type of parameter secretUri of method KeyVaultClient.ResolveSecretUriAsync(string) from string to System.Uri, or provide an overload to KeyVaultClient.ResolveSecretUriAsync(string) that allows secretUri to be passed as a System.Uri object.", Justification = "Critical issues only", Scope = "member", Target = "~M:DataX.Config.Local.KeyVaultClient.ResolveSecretUriAsync(System.String)~System.Threading.Tasks.Task{System.String}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA2007:Do not directly await a Task without calling ConfigureAwait", Justification = "Critical issues only", Scope = "member", Target = "~M:DataX.Config.Local.LocalDesignTimeStorage.DeleteByName(System.String,System.String)~System.Threading.Tasks.Task{DataX.Contract.Result}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1307:The behavior of 'string.Replace(string, string)' could vary based on the current user's locale settings. Replace this call in 'DataX.Config.Local.LocalDesignTimeStorage.Desanitize(string)' with a call to 'string.Replace(string, string, System.StringComparison)'.", Justification = "Critical issues only", Scope = "member", Target = "~M:DataX.Config.Local.LocalDesignTimeStorage.Desanitize(System.String)~System.String")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1822:Member DropCollection does not access instance data and can be marked as static (Shared in VisualBasic)", Justification = "Critical issues only", Scope = "member", Target = "~M:DataX.Config.Local.LocalDesignTimeStorage.DropCollection(System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1307:The behavior of 'string.Replace(string, string)' could vary based on the current user's locale settings. Replace this call in 'DataX.Config.Local.LocalDesignTimeStorage.Sanitize(string)' with a call to 'string.Replace(string, string, System.StringComparison)'.", Justification = "Critical issues only", Scope = "member", Target = "~M:DataX.Config.Local.LocalDesignTimeStorage.Sanitize(System.String)~System.String")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA2007:Do not directly await a Task without calling ConfigureAwait", Justification = "Critical issues only", Scope = "member", Target = "~M:DataX.Config.Local.LocalDesignTimeStorage.SaveByName(System.String,System.String,System.String)~System.Threading.Tasks.Task{DataX.Contract.Result}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA2007:Do not directly await a Task without calling ConfigureAwait", Justification = "Critical issues only", Scope = "member", Target = "~M:DataX.Config.Local.LocalDesignTimeStorage.UpdatePartialByName(System.String,System.String,System.String,System.String)~System.Threading.Tasks.Task{DataX.Contract.Result}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1305:The behavior of 'int.ToString()' could vary based on the current user's locale settings. Replace this call in 'LocalSparkClient.GetJobInfo(JToken)' with a call to 'int.ToString(IFormatProvider)'.", Justification = "Critical issues only", Scope = "member", Target = "~M:DataX.Config.Local.LocalSparkClient.GetJobInfo(Newtonsoft.Json.Linq.JToken)~System.Threading.Tasks.Task{DataX.Config.SparkJobSyncResult}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1822:Member IsSparkJobProcess does not access instance data and can be marked as static (Shared in VisualBasic)", Justification = "Critical issues only", Scope = "member", Target = "~M:DataX.Config.Local.LocalSparkClient.IsSparkJobProcess(System.Diagnostics.Process,DataX.Config.Local.LocalBatchResult)~System.Boolean")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1305:The behavior of 'string.Format(string, params object[])' could vary based on the current user's locale settings. Replace this call in 'LocalSparkClient.StartLocalSparkJob(LocalJobSubmissionInfo)' with a call to 'string.Format(IFormatProvider, string, params object[])'.", Justification = "Critical issues only", Scope = "member", Target = "~M:DataX.Config.Local.LocalSparkClient.StartLocalSparkJob(DataX.Config.Local.LocalJobSubmissionInfo)~DataX.Config.Local.LocalBatchResult")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1305:The behavior of 'int.ToString()' could vary based on the current user's locale settings. Replace this call in 'LocalSparkClient.StopLocalSparkJob(LocalBatchResult)' with a call to 'int.ToString(IFormatProvider)'.", Justification = "Critical issues only", Scope = "member", Target = "~M:DataX.Config.Local.LocalSparkClient.StopLocalSparkJob(DataX.Config.Local.LocalBatchResult)~System.Boolean")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1305:The behavior of 'int.ToString()' could vary based on the current user's locale settings. Replace this call in 'LocalSparkClient.SubmitJob(JToken)' with a call to 'int.ToString(IFormatProvider)'.", Justification = "Critical issues only", Scope = "member", Target = "~M:DataX.Config.Local.LocalSparkClient.SubmitJob(Newtonsoft.Json.Linq.JToken)~System.Threading.Tasks.Task{DataX.Config.SparkJobSyncResult}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA2007:Do not directly await a Task without calling ConfigureAwait", Justification = "Critical issues only", Scope = "member", Target = "~M:DataX.Config.Local.RuntimeTimeStorage.SaveFile(System.String,System.String)~System.Threading.Tasks.Task{System.String}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA2007:Do not directly await a Task without calling ConfigureAwait", Justification = "Critical issues only", Scope = "member", Target = "~M:DataX.Config.Local.RuntimeTimeStorage.SaveToLocal(System.String,System.String)~System.Threading.Tasks.Task")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA2007:Do not directly await a Task without calling ConfigureAwait", Justification = "Critical issues only", Scope = "member", Target = "~M:DataX.Config.Local.TemplateInitializer.AddTemplateFromResourceFile(System.String,System.String)~System.Threading.Tasks.Task{DataX.Contract.Result}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA2007:Do not directly await a Task without calling ConfigureAwait", Justification = "Critical issues only", Scope = "member", Target = "~M:DataX.Config.Local.TemplateInitializer.Initialize~System.Threading.Tasks.Task{DataX.Contract.Result}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA2007:Do not directly await a Task without calling ConfigureAwait", Justification = "Critical issues only", Scope = "member", Target = "~M:DataX.Config.Local.TemplateInitializer.InsertTemplateToCommonData(System.String,System.String)~System.Threading.Tasks.Task{DataX.Contract.Result}")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Build", "CA1707:Remove the underscores from member name DataX.Config.Local.LocalDesignTimeStorage._LocalDb.", Justification = "Critical issues only", Scope = "member", Target = "~P:DataX.Config.Local.LocalDesignTimeStorage._LocalDb")]
