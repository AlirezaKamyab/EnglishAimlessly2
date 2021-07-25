using EnglishAimlessly2.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishAimlessly2.ViewModel.Helper
{
    public class WordTableHelper
    {
        SQLiteConnection _connection;
        string _databasePath;
        List<WordModel> _innerList;
        public WordTableHelper(string databasePath)
        {
            _databasePath = databasePath;
            _innerList = new List<WordModel>();
            Reload();
        }

        public void CreateTable()
        {
            Open();
            _connection.CreateTable<WordModel>();
            Close();
        }

        public void Insert(WordModel newWord)
        {
            Open();
            _connection.CreateTable<WordModel>();
            _connection.Insert(newWord);
            Close();
        }

        public void Update(WordModel updatedWord)
        {
            Open();
            _connection.Update(updatedWord);
            Close();
        }

        public void Remove(WordModel word)
        {
            Open();
            _connection.Delete(word);
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
            _connection.CreateTable<WordModel>();
            _innerList = _connection.Table<WordModel>().ToList();
            Close();
        }

        public List<WordModel> GetData()
        {
            return _innerList;
        }

        public WordModel SearchById(int id)
        {
            foreach (WordModel item in _innerList)
            {
                if (item.Id == id) return item;
            }
            return new();
        }

        public List<WordModel> SearchByUserId(int id)
        {
            List<WordModel> temp = new List<WordModel>();
            foreach (WordModel item in _innerList)
            {
                if (item.UserId == id) temp.Add(item);
            }
            return temp;
        }

        public List<WordModel> SearchByName(string name)
        {
            List<WordModel> temp = new List<WordModel>();
            foreach (WordModel item in _innerList)
            {
                if (item.Name == name) temp.Add(item);
            }
            return temp;
        }

        public List<WordModel> SearchByGroupId(int id)
        {
            List<WordModel> temp = new List<WordModel>();
            foreach(WordModel item in _innerList)
            {
                if (item.GroupId == id) temp.Add(item);
            }
            return temp;
        }

        public int CountItemsInsideGroup(int groupId)
        {
            int counter = 0;
            foreach(WordModel item in _innerList)
            {
                if (item.GroupId == groupId) counter++;
            }
            return 0;
        }

        public List<WordModel> SearchWordsByPractice(int groupId, int practiceCount, bool maxCount = true)
        {
            List<WordModel> temp = new List<WordModel>();
            foreach (WordModel item in _innerList)
            {
                if(item.GroupId == groupId)
                {
                    if (maxCount)
                    {
                        if (item.PracticeCount <= practiceCount) temp.Add(item);
                    }
                    else
                    {
                        if (item.PracticeCount == practiceCount) temp.Add(item);
                    }
                }
            }

            return temp;
        }

        public SortedList<long, WordModel> GetSortedDueTime(GroupModel fromGroup)
        {
            SortedList<long, WordModel> pairs = new SortedList<long, WordModel>();
            foreach(WordModel item in _innerList)
            {
                long time = (long)DateTimeHelper.NextWordPracticeSpan(item).Miliseconds;
                WordModel temp;

                while (true) 
                {
                    if (!pairs.TryGetValue(time, out temp)) break;
                    time++;
                }
                if (item.GroupId == fromGroup.Id && time <= 0) pairs.Add(time, item);
            }

            return pairs;
        }
    }
}
