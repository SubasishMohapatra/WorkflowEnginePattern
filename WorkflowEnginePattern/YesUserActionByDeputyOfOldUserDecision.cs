using System;

namespace AKVWorkflowEnginePoC
{
    internal class YesUserActionByDeputyOfOldUserDecision : BaseDecision
    {
        public override void Evaluate()
        {
            base.Evaluate();
            SendNIToOldUser();
            if(OnYes!=null)
            {
                OnYes.Evaluate();
            }
        }

        private void SendNIToOldUser()
        {
            Console.WriteLine("SendNIToOldUser()");
        }
        //private void SendOPToNewUser()
        //{
        //    Console.WriteLine("SendOPToNewUser()");
        //}
    }
}