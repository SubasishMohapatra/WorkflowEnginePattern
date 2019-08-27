using System;

namespace AKVWorkflowEnginePoC
{
    public class BaseDecision:IDecision
    {
        public ICondition Condition { get; set; }
        public IDecision OnYes { get; set; }
        public IDecision OnNo { get; set; }

        public virtual void Evaluate()
        {
            if (Condition == null) return;
            if (Condition.IsValid)
            {
                if (OnYes != null) OnYes.Evaluate();
            }
            else
            {
                if (OnNo != null) OnNo.Evaluate();
            }
        }
        
    }
}