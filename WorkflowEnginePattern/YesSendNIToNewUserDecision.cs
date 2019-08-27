using System;

namespace AKVWorkflowEnginePoC
{
    public class YesSendNIToNewUserDecision : BaseDecision
    {
        public override void Evaluate()
        {
            base.Evaluate();
            SendNIToNewUser();
        }

        private void SendNIToNewUser()
        {
            Console.WriteLine("SendNIToNewUser()");
        }
    }
}