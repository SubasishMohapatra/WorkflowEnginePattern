using System;

namespace AKVWorkflowEnginePoC
{
    public  class IsUserActionByOldUser : ICondition
    {
        public bool IsValid { get => CheckUserActionByOldUser(); }

        public bool CheckUserActionByOldUser()
        {
            return true;
        }
    }
}
