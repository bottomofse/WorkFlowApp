using System;
namespace WorkflowApp.Account
{
    internal interface IAccountRepository
    {
        public void save();
        public void delete();
    }
}
