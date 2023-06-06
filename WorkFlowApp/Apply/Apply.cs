using System;

namespace WorkflowApp.Apply
{
    //ワークフローの申請を表現するクラス
    internal class Apply
    {
        // 申請は承認用のワークフローを一つ所持する
        private Workflow workflow { get; set; }

    }
}
