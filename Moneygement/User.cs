using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneygement
{
    public class User
    {
        // instance variables
        private int _userId;
        private string _username;
        private string _password;
        private string _name;
        private string _email;
        private string _phone;

        // properties
        public int UserId
        {
            get { return _userId; }
        }
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        // methods
        public bool login(string Username, string Password)
        {
            if (Username == "Jono" && Password == "haha")
            {
                return true;
            } 
            else
            {
                return false;
            }
        }
        public bool logout()
        {
            // code here
            return true;
        }
        public void add_account()
        {
            // code here
        }
    }
}
