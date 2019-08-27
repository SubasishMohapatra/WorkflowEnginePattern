namespace AKVWorkflowEnginePoC
{
    internal class IsV7Changed : ICondition
    {
        public bool IsValid { get => CheckV7Changed(); }

        public bool CheckV7Changed()
        {
            return true;
        }
    }
}