using System;
using WorkFlowApp.Account;

namespace WorkFlowApp.Apply
{

    internal interface IWorkFlowStep
    {

    }

    // 承認ルート内の承認ステップを表現するクラス
    internal class WorkFlowStep : IWorkFlowStep
    {
        // ステップ名（表示するときのタイトル）
        private string title;

        // 承認されたか
        private bool approved = false;

        // 承認を要求するpermission
        private Permission needPermission;

        // 承認の要求対象User
        private User targetUSer;

        // 次の承認ステップ
        private IWorkFlowStep nextWorkFlowStep;

        // 削除可能か
        private bool deletable = false;

        //実際の承認者
        private User approvedUser;

    }
}
