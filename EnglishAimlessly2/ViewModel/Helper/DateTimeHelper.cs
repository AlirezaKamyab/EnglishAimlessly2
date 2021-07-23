using EnglishAimlessly2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishAimlessly2.ViewModel.Helper
{
    public class DateTimeHelper
    {
        public static TimeModel GetTimeModel(DateTime origin, DateTime destination)
        {
            TimeSpan a = new TimeSpan(origin.Ticks);
            TimeSpan b = new TimeSpan(destination.Ticks);
            b = b.Subtract(a);
            TimeModel time = new TimeModel(b);
            return time;
        }

        public static TimeModel NextWordPracticeSpan(WordModel word)
        {
            if (word == null) return new TimeModel(0, 0, 0, 0, 0);
            TimeModel temp = GetTimeModel(DateTime.Now, word.DueDate);
            return temp;
        }

        public static TimeModel LastPracticeSpan(WordModel word)
        {
            if (word == null) return new TimeModel(0, 0, 0, 0, 0);
            TimeModel temp = GetTimeModel(word.UpdatedDate, DateTime.Now);
            return temp;
        }
    }
}
