using DataAccess;
using System;

namespace SampleProject
{
    public class UserLogic
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public UserLogic Create(int id, string name)
        {
            UserDataAccess da = new UserDataAccess();
        }
    }
}
