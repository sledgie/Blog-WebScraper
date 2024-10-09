using BlogWebScraper.ObjectRepository;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using UiPath.CodedWorkflows;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.Excel;
using UiPath.Excel.Activities;
using UiPath.Excel.Activities.API;
using UiPath.Excel.Activities.API.Models;
using UiPath.Orchestrator.Client.Models;
using UiPath.Testing;
using UiPath.Testing.Activities.TestData;
using UiPath.Testing.Activities.TestDataQueues.Enums;
using UiPath.Testing.Enums;
using UiPath.UIAutomationNext.API.Contracts;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;
using System.Threading.Tasks;
using UiPath.Activities.Contracts;

namespace BlogWebScraper
{
    public class WorkflowRunnerService
    {
        private readonly Func<string, IDictionary<string, object>, TimeSpan?, bool, InvokeTargetSession, IDictionary<string, object>> _runWorkflowHandler;
        public WorkflowRunnerService(Func<string, IDictionary<string, object>, TimeSpan?, bool, InvokeTargetSession, IDictionary<string, object>> runWorkflowHandler)
        {
            _runWorkflowHandler = runWorkflowHandler;
        }

        /// <summary>
        /// Invokes the cloudacademy.xaml
        /// </summary>
        public void cloudacademy(string BreakTriggerScopeInArgument)
        {
            var result = _runWorkflowHandler(@"cloudacademy.xaml", new Dictionary<string, object>{{"BreakTriggerScopeInArgument", BreakTriggerScopeInArgument}}, default, default, default);
        }

        /// <summary>
        /// Invokes the xebia-blog.xaml
        /// </summary>
        public void xebia_blog(string BreakTriggerScopeInArgument)
        {
            var result = _runWorkflowHandler(@"xebia-blog.xaml", new Dictionary<string, object>{{"BreakTriggerScopeInArgument", BreakTriggerScopeInArgument}}, default, default, default);
        }

        /// <summary>
        /// Invokes the theseattledataguy.xaml
        /// </summary>
        public void theseattledataguy(string BreakTriggerScopeInArgument)
        {
            var result = _runWorkflowHandler(@"theseattledataguy.xaml", new Dictionary<string, object>{{"BreakTriggerScopeInArgument", BreakTriggerScopeInArgument}}, default, default, default);
        }

        /// <summary>
        /// Invokes the FileChecker.cs
        /// </summary>
        public (bool hasErrors, bool existing) FileChecker(string path, string fileName)
        {
            var result = _runWorkflowHandler(@"FileChecker.cs", new Dictionary<string, object>{{"path", path}, {"fileName", fileName}}, default, default, default);
            return ((bool)result["hasErrors"], (bool)result["existing"]);
        }

        /// <summary>
        /// Invokes the bitstrapped.xaml
        /// </summary>
        public void bitstrapped()
        {
            var result = _runWorkflowHandler(@"bitstrapped.xaml", new Dictionary<string, object>{}, default, default, default);
        }

        /// <summary>
        /// Invokes the Main.xaml
        /// </summary>
        public void Main()
        {
            var result = _runWorkflowHandler(@"Main.xaml", new Dictionary<string, object>{}, default, default, default);
        }
    }
}