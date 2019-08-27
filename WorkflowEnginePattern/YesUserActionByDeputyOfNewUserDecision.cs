using System;

namespace AKVWorkflowEnginePoC
{
    internal class YesUserActionByDeputyOfNewUserDecision : BaseDecision
    {
        public override void Evaluate()
        {
            base.Evaluate();
            SendNIToNewUser();
            SendOPToOldUser();
        }

        private void SendNIToNewUser()
        {
            Console.WriteLine("SendNIToNewUser()");
        }
        private void SendOPToOldUser()
        {
            Console.WriteLine("SendOPToOldUser()");
        }
    }
}