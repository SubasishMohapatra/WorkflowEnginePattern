using System;

namespace AKVWorkflowEnginePoC
{
    internal class SendNiToNewUserAction : NoDecision
    {
        public SendNiToNewUserAction()
        {
        }

        public override void Evaluate()
        {
            SendNIToNewUser();
            base.Evaluate();
        }

        private void SendNIToNewUser()
        {
            Console.WriteLine("SendNIToNewUser()");
        }
    }
}