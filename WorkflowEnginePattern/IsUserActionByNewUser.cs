namespace AKVWorkflowEnginePoC
{
    internal class IsUserActionByNewUser : ICondition
    {
        public bool IsValid { get => CheckUserActionByNewUser(); }

        public bool CheckUserActionByNewUser()
        {
            return false;
        }
    }
}