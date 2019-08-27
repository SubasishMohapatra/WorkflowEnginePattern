using System;

namespace AKVWorkflowEnginePoC
{
    internal class NoNewUserPartOfAKVDecision : BaseDecision
    {
        public override void Evaluate()
        {
            base.Evaluate();
            SendOPToV7();
            OnYes.Evaluate();
        }

        private void SendOPToV7()
        {
            Console.WriteLine("SendOPtoV7");
        }
    }
}