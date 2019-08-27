namespace AKVWorkflowEnginePoC
{
    internal class IsUserActionByDeputyOfOldUser : ICondition
    {
        public bool IsValid { get => CheckUserActionByDeputyOfOldUser(); }

        public bool CheckUserActionByDeputyOfOldUser()
        {
            return false;
        }
    }
}