using System;

namespace AKVWorkflowEnginePoC
{
    internal class SendOpToNewUserAction  : NoDecision
    {
        public SendOpToNewUserAction()
        {
        }

        public override void Evaluate()
        {
            SendOpToNewUser();
            base.Evaluate();
        }

        private void SendOpToNewUser()
        {
            Console.WriteLine("SendOpToNewUser()");
        }
    }
}