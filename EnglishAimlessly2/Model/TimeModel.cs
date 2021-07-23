using EnglishAimlessly2.ViewModel.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishAimlessly2.Model
{
    public class TimeModel
    {
        public TimeModel() { }
        public TimeModel(double miliseconds, double seconds, double minutes, double hours, double days)
        {
            Miliseconds = miliseconds;
            Seconds = seconds;
            Minutes = minutes;
            Hours = hours;
            Days = days;
        }

        public TimeModel(TimeSpan span)
        {
            Miliseconds = span.TotalSeconds;
            Seconds = span.TotalSeconds;
            Minutes = span.TotalMinutes;
            Hours = span.TotalHours;
            Days = span.TotalDays;
        }
        public double Miliseconds { get; set; }
        public double Seconds { get; set; }
        public double Minutes { get; set; }
        public double Hours { get; set; }
        public double Days { get; set; }
        public void CalculateFromToday(DateTime dateTime)
        {
            TimeSpan a = new TimeSpan(DateTime.Now.Ticks);
            TimeSpan b = new TimeSpan(dateTime.Ticks);
            b = b.Subtract(a);

            TimeModel temp = new TimeModel(b);

            Miliseconds = temp.Miliseconds;
            Seconds = temp.Seconds;
            Minutes = temp.Minutes;
            Hours = temp.Hours;
            Days = temp.Days;
        }
    }
}
