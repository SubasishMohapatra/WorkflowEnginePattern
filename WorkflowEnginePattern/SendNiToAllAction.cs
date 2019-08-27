using System;

namespace AKVWorkflowEnginePoC
{
    internal class SendNiToAllAction : NoDecision
    {
        public SendNiToAllAction()
        {
        }

        public override void Evaluate()
        {
            SendNIToAll();
            base.Evaluate();
        }

        private void SendNIToAll()
        {
            Console.WriteLine("SendNIToAll()");
        }
    }
}