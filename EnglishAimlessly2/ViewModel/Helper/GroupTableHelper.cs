using EnglishAimlessly2.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishAimlessly2.ViewModel.Helper
{
    public class GroupTableHelper
    {
        SQLiteConnection _connection;
        string _databasePath;
        List<GroupModel> _innerList;
        public GroupTableHelper(string databasePath)
        {
            _databasePath = databasePath;
            _innerList = new List<GroupModel>();
            Reload();
        }

        public void CreateTable()
        {
            Open();
            _connection.CreateTable<GroupModel>();
            Close();
        }

        public void Insert(GroupModel newGroup)
        {
            Open();
            _connection.CreateTable<GroupModel>();
            _connection.Insert(newGroup);
            Close();
        }

        public void Update(GroupModel updatedGroup)
        {
            Open();
            _connection.Update(updatedGroup);
            Close();
        }

        public void Remove(GroupModel group)
        {
            Open();
            _connection.Delete(group);
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
            _connection.CreateTable<GroupModel>();
            _innerList = _connection.Table<GroupModel>().ToList();
            Close();
        }

        public List<GroupModel> GetData()
        {
            return _innerList;
        }

        public GroupModel SearchById(int id)
        {
            foreach (GroupModel item in _innerList)
            {
                if (item.Id == id) return item;
            }
            return new();
        }

        public List<GroupModel> SearchByUserId(int id)
        {
            List<GroupModel> temp = new List<GroupModel>();
            foreach (GroupModel item in _innerList)
            {
                if (item.UserId == id) temp.Add(item);
            }
            return temp;
        }

        public List<GroupModel> SearchByName(string name)
        {
            List<GroupModel> temp = new List<GroupModel>();
            foreach (GroupModel item in _innerList)
            {
                if (item.Name == name) temp.Add(item);
            }
            return temp;
        }
    }
}
