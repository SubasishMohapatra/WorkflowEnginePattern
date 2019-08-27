using System;

namespace AKVWorkflowEnginePoC
{
    class Program
    {
        static void Main(string[] args)
        {
            var workFlowEngine = new WorkflowEngine();
            workFlowEngine.ComposeWorkflow();
            workFlowEngine.StartWorkflow();
            Console.ReadLine();
        }
    }
}
