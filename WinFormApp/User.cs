using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormApp
{
    internal class User
    {
        public string FirstName;
        public string LastName;
        public string Username;
        public string Password;

        public User(string firstName, string lastName, string username, string password)
        {
            firstName = FirstName;
            lastName = LastName;
            Username = username;
            Password = password;
        } 

       public User()
        {

        }


    }
}
