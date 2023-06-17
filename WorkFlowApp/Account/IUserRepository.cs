using System;

namespace WorkflowApp.Account
{
    internal interface IUserRepository
    {
        public void save();

        public void delete();

        public void update();

    }
}
