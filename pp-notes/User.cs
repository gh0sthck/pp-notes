using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pp_notes
{
    public class User
    {

        int id = -1;
        string username;
        string password;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public User(string Password, string Username, int Id = -1)
        {
            username = Username;
            password = Password;
            id = Id;
        }

    }
}
