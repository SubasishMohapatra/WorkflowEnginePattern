using System;

namespace AKVWorkflowEnginePoC
{
    public class AutoApproveAction : NoDecision
    {
        public AutoApproveAction()
        {
        }

        public override void Evaluate()
        {
            AutoApproval();
            base.Evaluate();
        }

        private void AutoApproval()
        {
            Console.WriteLine("AutoApproval()");
        }
    }
}