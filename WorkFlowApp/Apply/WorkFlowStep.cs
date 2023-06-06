using System;
using WorkflowApp.Account;

namespace WorkflowApp.Apply
{

    internal interface IWorkflowStep
    {

    }

    // 承認ルート内の承認ステップを表現するクラス
    internal class WorkflowStep : IWorkflowStep
    {
        // ステップ名（表示するときのタイトル）
        private string title;

        // 承認されたか
        private bool approved = false;

        // 承認に必要なPermission
        private Permission needPermission;

        // 次の承認ステップ
        private IWorkFlowStep nextWorkFlowStep;

        // 削除可能か
        private bool deletable = false;

        //実際の承認者
        private User approvedUser;

    }
}
