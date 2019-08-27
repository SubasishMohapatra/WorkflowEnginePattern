using System;
using System.Collections.Generic;
using System.Text;

namespace AKVWorkflowEnginePoC
{
    class IsNewUserPartOfAKV : ICondition
    {
        public bool IsValid { get => CheckIsNewUserPartOfAKV(); }

        private bool CheckIsNewUserPartOfAKV()
        {
            return false;
        }
    }
}
