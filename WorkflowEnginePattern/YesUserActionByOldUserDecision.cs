using System;

namespace AKVWorkflowEnginePoC
{
    internal class YesUserActionByOldUserDecision : BaseDecision
    {
        public YesUserActionByOldUserDecision()
        {
        }

        public override void Evaluate()
        {
            base.Evaluate();
            if(OnYes!=null)
            {
                OnYes.Evaluate();
            }
            //SendOPToNewUser();
        }

        //private void SendOPToNewUser()
        //{
        //    Console.WriteLine("SendOPToNewUser()");
        //}
    }
}