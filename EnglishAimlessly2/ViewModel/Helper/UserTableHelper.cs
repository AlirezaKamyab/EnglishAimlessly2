using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnglishAimlessly2.Model;
using SQLite;

namespace EnglishAimlessly2.ViewModel.Helper
{
    public class UserTableHelper
    {
        SQLiteConnection _connection;
        string _databasePath;
        List<UserModel> _innerList;
        public UserTableHelper(string databasePath)
        {
            _databasePath = databasePath;
            _innerList = new List<UserModel>();
            Reload();
        }

        public void CreateTable()
        {
            Open();
            _connection.CreateTable<UserModel>();
            Close();
        }

        public void Insert(UserModel newUser)
        {
            Open();
            _connection.CreateTable<UserModel>();
            _connection.Insert(newUser);
            Close();
        }

        public void Update(UserModel updatedUser)
        {
            Open();
            _connection.Update(updatedUser);
            Close();
        }

        public void Remove(UserModel user)
        {
            Open();
            _connection.Delete(user);
            Close();
        }

        public void Open()
        {
            _connection = new SQLiteConnection(_databasePath);
        }

        public void Close()
        {
            _connection.Close();
            _connection.Dispose();
        }

        public void Reload()
        {
            Open();
            _connection.CreateTable<UserModel>();
            _innerList = _connection.Table<UserModel>().ToList();
            Close();
        }

        public List<UserModel> GetData()
        {
            return _innerList;
        }

        public UserModel SearchByUsername(string username)
        {
            foreach(UserModel um in _innerList)
            {
                if (um.Username == username) return um;
            }
            return new UserModel() { Id = -1 };
        }

        public UserModel SearchById(int Id)
        {
            foreach (UserModel um in _innerList)
            {
                if (um.Id == Id) return um;
            }
            return new UserModel() { Id = -1 };
        }

        public UserModel SearchByEmail(string email)
        {
            foreach (UserModel userModel in _innerList)
            {
                if (userModel.Email == email) return userModel;
            }
            return new UserModel() { Id = -1 };
        }

        public bool isValidCredential(string username, string password)
        {
            UserModel user = SearchByUsername(username);
            if (user.Id == -1) return false;
            return user.Password == password;
        }
    }
}
