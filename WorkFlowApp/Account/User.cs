using System;

namespace WorkflowApp.Account
{
    // 申請を作成したり、承認するユーザー
    internal class User
    {
        public User()
        {

        }

        private string ID { get; set; }
        private string Name { get; set; }
        private string Password { get; set; }
        private Group group { get; set; }
        private Position position { get; set; }
        private Permission permission { get; set; }
    }
}
