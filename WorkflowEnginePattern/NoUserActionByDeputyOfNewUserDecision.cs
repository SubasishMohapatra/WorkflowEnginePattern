using System;

namespace AKVWorkflowEnginePoC
{
    internal class NoUserActionByDeputyOfNewUserDecision : BaseDecision
    {
        public override void Evaluate()
        {
            base.Evaluate();
            SendOPToOldUser();
            SendOPToNewUser();
        }

        private void SendOPToNewUser()
        {
            Console.WriteLine("SendOPToNewUser()");
        }
        private void SendOPToOldUser()
        {
            Console.WriteLine("SendOPToOldUser()");
        }
    }
}