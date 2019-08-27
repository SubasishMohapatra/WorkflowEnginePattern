namespace AKVWorkflowEnginePoC
{
    /// <summary>
    /// WorkflowEngine
    /// </summary>
    public class WorkflowEngine
    {
        private IDecision startDecision;

        public void ComposeWorkflow()
        {
            UserActionByDeputyOfNewUserDecision userActionByDeputyOfNewUserDecision = new UserActionByDeputyOfNewUserDecision()
            {
                Condition = new IsUserActionByDeputyOfNewUser(),
                OnYes = new YesUserActionByDeputyOfNewUserDecision(),
                OnNo = new NoUserActionByDeputyOfNewUserDecision()
            };

            UserActionByNewUserDecision userActionByNewUserDecision = new UserActionByNewUserDecision()
            {
                Condition = new IsUserActionByNewUser(),
                OnYes = new YesUserActionByNewUserDecision(),
                OnNo = userActionByDeputyOfNewUserDecision
            };
            SendNIToNewUserDecision sendNIToNewUserDecision = new SendNIToNewUserDecision()
            {
                Condition = new IsUserActionByDeputyOfNewUser(),
                OnYes = new YesSendNIToNewUserDecision(),
                OnNo = new YesSendOPToNewUserDecision()
            };
            YesUserActionByDeputyOfOldUserDecision yesUserActionByDeputyOfOldUserDecision = new YesUserActionByDeputyOfOldUserDecision()
            {
                OnYes = sendNIToNewUserDecision
            };
            UserActionByDeputyOfOldUserDecision userActionByDeputyOfOldUserDecision = new UserActionByDeputyOfOldUserDecision()
            {
                Condition = new IsUserActionByDeputyOfOldUser(),
                OnYes = yesUserActionByDeputyOfOldUserDecision,
                OnNo = userActionByNewUserDecision
            };

            YesUserActionByOldUserDecision yesUserActionByOldUserDecision = new YesUserActionByOldUserDecision()
            {
                OnYes = sendNIToNewUserDecision
            };
            UserActionByOldUserDecision userActionByOldUserDecision = new UserActionByOldUserDecision()
            {
                Condition = new IsUserActionByOldUser(),
                OnYes = yesUserActionByOldUserDecision,
                OnNo = userActionByDeputyOfOldUserDecision
            };

            NewUserPartOfAKVDecision newUserPartOfAKVDecision = new NewUserPartOfAKVDecision()
            {
                Condition = new IsNewUserPartOfAKV(),
                OnYes = userActionByOldUserDecision,
                OnNo = new NoNewUserPartOfAKVDecision() { OnYes = userActionByOldUserDecision }
            };
            var yesIsV7ChangedDecision= new BaseDecision()
            {
                Condition = new IsUserActionByNewUser(),
                OnYes = new AutoApproveAction(),
                OnNo = new BaseDecision()
                {
                    Condition = new IsUserActionByDeputyOfNewUser(),
                    OnYes =  new AutoApproveAction() { OnYes = new SendNiToNewUserAction() },
                    OnNo = new SendOpToNewUserAction()
                }
            };
            IsV7ChangedDecision isV7ChangedDecision = new IsV7ChangedDecision()
            {
                Condition = new IsV7Changed(),
                OnYes = yesIsV7ChangedDecision,
                OnNo = new AutoApproveAction() { OnYes=new SendNiToNewUserAction()}
            };
            var userActionByV7DeputyDecision = new BaseDecision()
            {
                Condition = new IsUserActionByV7Deputy(),
                OnYes = new BaseDecision(){
                    Condition=new IsV7Changed(),
                    OnYes= yesIsV7ChangedDecision,
                    OnNo = new AutoApproveAction() { OnYes = new SendNiToAllAction() }
                },
                OnNo = newUserPartOfAKVDecision
            };
            UserActionByV7Decision userActionByV7Decision = new UserActionByV7Decision()
            {
                Condition = new IsUserActionByV7(),
                OnYes = isV7ChangedDecision,
                OnNo = userActionByV7DeputyDecision
            };
            startDecision = userActionByV7Decision;
        }

        public void StartWorkflow()
        {
            startDecision?.Evaluate();
        }
    }
}
