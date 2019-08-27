using System;

namespace AKVWorkflowEnginePoC
{
    public class YesSendOPToNewUserDecision : BaseDecision
    {
        public override void Evaluate()
        {
            base.Evaluate();
            SendOPToNewUser();
        }

        private void SendOPToNewUser()
        {
            Console.WriteLine("SendOPToNewUser()");
        }
    }
}