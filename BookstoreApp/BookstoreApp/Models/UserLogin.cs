using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookstoreApp.Models
{
    class UserLogin
    {
        [PrimaryKey][AutoIncrement]
        public int ID { get; set; }
        public string email { get; set; }
        public string password { get; set; }

        public UserLogin() { }
        public UserLogin(string email, string password)
        {
            this.email = email;
            this.password = password;
        }

        public bool CheckInfo()
        {
            if (!this.email.Equals("") && !this.password.Equals(""))
                return true;
            else
                return false;
        }
    }
}
