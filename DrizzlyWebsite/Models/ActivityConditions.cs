using System;
using System.Collections.Generic;

namespace DrizzlyWebsite.Models
{
    public class ActivityConditions
    {
        public int Id;

        public int? MinTemp { get; set; }
       
        public int? MaxTemp { get; set; }
        
        public HashSet<Day> PossibleDays { get; set; }
        
        // Activity foreign key
        public int ActivityId { get; set; }
        
        public Activity Activity { get; set; }
    }

    public class Time
    {
        private int _hour;
        
        public int Hour
        {
            get => _hour;
            set
            {
                if (value >= 0 && value <= 23)
                {
                    _hour = value;
                }
                else
                {
                    throw new Exception("Hour problem !");
                }
            }
        }

        private int _minute;

        public int Minute
        {
            get => _minute;
            set
            {
                if (value >= 0 && value <= 59)
                {
                    _minute = value;
                }
                else
                {
                    throw new Exception("Minute problem !");
                }
            }
        }

        public Time(int hour, int minute)
        {
            Hour = hour;
            Minute = minute;
        }
        
    }

    public enum Day
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}