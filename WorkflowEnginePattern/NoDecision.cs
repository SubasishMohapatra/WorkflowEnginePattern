namespace AKVWorkflowEnginePoC
{
    public class NoDecision : BaseDecision
    {
        public override void Evaluate()
        {
            if (OnYes != null)
            {
                OnYes.Evaluate();
            }
        }

    }
}