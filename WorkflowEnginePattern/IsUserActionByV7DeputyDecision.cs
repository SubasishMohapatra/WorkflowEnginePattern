namespace AKVWorkflowEnginePoC
{
    internal class IsUserActionByV7Deputy : ICondition
    {
        public bool IsValid { get => CheckIsUserActionByV7Deputy(); }

        public bool CheckIsUserActionByV7Deputy()
        {
            return false;
        }
    }
}