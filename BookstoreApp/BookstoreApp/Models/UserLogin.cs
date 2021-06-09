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
    }
}
