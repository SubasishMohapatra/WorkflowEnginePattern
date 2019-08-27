namespace AKVWorkflowEnginePoC
{
    internal class IsUserActionByDeputyOfNewUser : ICondition
    {
        public bool IsValid { get => CheckUserActionByDeputyOfNewUser(); }

        public bool CheckUserActionByDeputyOfNewUser()
        {
            return false;
        }
    }
}