using System;

namespace WorkflowApp.Account
{
    // 申請を作成したり、承認するユーザー
    internal class User
    {
        public User(string id, string password,string name)
        {
            if (string.IsNullOrEmpty(id))
                throw new ArgumentNullException("id");
            if (string.IsNullOrEmpty(password))
                throw new ArgumentNullException("password");
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException("name");
            this.ID = id;
            this.Password = password;
            this.Name = name;
        }

        private string ID { get; set; }
        private string Name { get; set; }
        private string Password { get; set; }
        private Group group { get; set; }
        private Position position { get; set; }
        private Permission permission { get; set; }
    }
}
