using System;

namespace AKVWorkflowEnginePoC
{
    internal class YesUserActionByNewUserDecision : BaseDecision
    {
        public YesUserActionByNewUserDecision()
        {
        }

        public override void Evaluate()
        {
            base.Evaluate();
            SendOPToOldUser();
        }

        private void SendOPToOldUser()
        {
            Console.WriteLine("SendOPToOldUser()");
        }
    }
}