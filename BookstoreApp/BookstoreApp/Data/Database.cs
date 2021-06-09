using BookstoreApp.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreApp.Data
{
    class Database
    {
        private readonly SQLiteAsyncConnection _database;
        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<UserLogin>().Wait();
        }

        public Task<int> CreateUserAsync(UserLogin user)
        {
            return _database.InsertAsync(user);
        }
    }
}
