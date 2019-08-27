using System;

namespace AKVWorkflowEnginePoC
{
    public  class IsUserActionByV7 : ICondition
    {
        public bool IsValid { get => CheckUserActionByV7(); }

        public bool CheckUserActionByV7()
        {
            return false;
        }
    }
}
