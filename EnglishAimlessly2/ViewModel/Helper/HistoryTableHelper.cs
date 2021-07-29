using EnglishAimlessly2.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishAimlessly2.ViewModel.Helper
{
    public class HistoryTableHelper
    {
        SQLiteConnection _connection;
        string _databasePath;
        List<HistoryModel> _innerList;
        public HistoryTableHelper(string databasePath)
        {
            _databasePath = databasePath;
            _innerList = new List<HistoryModel>();
            Reload();
        }

        public void CreateTable()
        {
            Open();
            _connection.CreateTable<HistoryModel>();
            Close();
        }

        public void Insert(HistoryModel newHistory)
        {
            Open();
            _connection.CreateTable<HistoryModel>();
            _connection.Insert(newHistory);
            Close();
        }

        public void Update(HistoryModel updateHistory)
        {
            Open();
            _connection.Update(updateHistory);
            Close();
        }

        public void Remove(HistoryModel history)
        {
            Open();
            _connection.Delete(history);
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
            _connection.CreateTable<HistoryModel>();
            _innerList = _connection.Table<HistoryModel>().ToList();
            Close();
        }

        public List<HistoryModel> GetData()
        {
            return _innerList;
        }

        public HistoryModel SearchById(int id)
        {
            foreach (HistoryModel item in _innerList)
            {
                if (item.Id == id) return item;
            }
            return new HistoryModel();
        }

        public List<HistoryModel> SearchByUserId(int id)
        {
            List<HistoryModel> temp = new List<HistoryModel>();
            foreach (HistoryModel item in _innerList)
            {
                if (item.UserId == id) temp.Add(item);
            }
            return temp;
        }

        public List<HistoryModel> SearchByWord(string word)
        {
            List<HistoryModel> temp = new List<HistoryModel>();
            foreach (HistoryModel item in _innerList)
            {
                if (item.Word == word) temp.Add(item);
            }
            return temp;
        }

        public List<HistoryModel> SearchByGroupId(int id)
        {
            List<HistoryModel> temp = new List<HistoryModel>();
            foreach (HistoryModel item in _innerList)
            {
                if (item.GroupId == id) temp.Add(item);
            }
            return temp;
        }

        public int CountItemsByWordId(int wordId)
        {
            int counter = 0;
            foreach (HistoryModel item in _innerList)
            {
                if (item.WordId == wordId) counter++;
            }
            return 0;
        }

        public List<HistoryModel> SearchHistoryByWordId(int wordId)
        {
            List<HistoryModel> temp = new List<HistoryModel>();
            foreach (HistoryModel item in _innerList)
            {
                if (item.WordId == wordId) temp.Add(item);
            }

            return temp;
        }

        public List<HistoryModel> SearchHistoryByGroupId(int groupId)
        {
            List<HistoryModel> temp = new List<HistoryModel>();
            foreach (HistoryModel item in _innerList)
            {
                if (item.GroupId == groupId) temp.Add(item);
            }

            return temp;
        }
    }
}
