using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormApp
{
     public class User
    {
        public string FirstName;
        public string LastName;
        public string Username;
        public string Password;

        public User(string firstName, string lastName, string username, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Username = username;
            Password = password;
        } 

       public User()
        {

        }


    }
}
