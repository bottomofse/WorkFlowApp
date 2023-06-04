using System;

namespace WorkFlowApp.Apply
{
    // ワークフローの承認ルートを表現するクラス
    internal class WorkFlow
    {
        // 承認ルートの先頭ステップ
        private IWorkFlowStep head;

        // 次に承認するステップ
        private IWorkFlowStep current;

    }
}
