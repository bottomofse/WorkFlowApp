using System;

namespace WorkflowApp.Apply
{
    // ワークフローの承認ルートを表現するクラス
    internal class Workflow
    {
        // 承認ルートの先頭ステップ
        private IWorkflowStep head;

        // 現在のステップ
        // 初期値はnull
        private IWorkflowStep current;

    }
}
