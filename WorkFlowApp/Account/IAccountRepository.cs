using System;
namespace WorkflowApp.Account
{
    internal interface IAccountRepository
    {
        public void login();
        public void logout();
    }
}
