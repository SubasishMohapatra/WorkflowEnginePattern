using System;

namespace AKVWorkflowEnginePoC
{
    public class YesUserActionByV7Decision : BaseDecision
    {
        public YesUserActionByV7Decision()
        {
        }

        public override void Evaluate()
        {
            base.Evaluate();
            InitiateAutoApproval();
            SendNIToAll();
        }

        private void SendNIToAll()
        {
            Console.WriteLine("SendNIToAll()");
        }

        private void InitiateAutoApproval()
        {
            Console.WriteLine("InitiateAutoApproval()");
        }
    }
}
