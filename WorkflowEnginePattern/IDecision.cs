namespace AKVWorkflowEnginePoC
{
    public interface IDecision
    {
        ICondition Condition { get; set; }
        IDecision OnYes { get; set; }
        IDecision OnNo { get; set; }
        void Evaluate();
    }
}
