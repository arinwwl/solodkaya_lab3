using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solodkaya_lab3
{
    public class Date
    {
        private uint year;
        private uint month;
        private uint day;

        public Date()
        {
            year = 0;
            month = 0;
            day = 0;
        }

        public Date(uint year, uint month, uint day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }

        public Date(string dateStr)
        {
            string[] dateParts = dateStr.Split('.');
            if (dateParts.Length != 3)
            {
                throw new ArgumentException("Invalid date format");
            }

            year = uint.Parse(dateParts[0]);
            month = uint.Parse(dateParts[1]);
            day = uint.Parse(dateParts[2]);
        }

        public void SetDate(uint year, uint month, uint day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }

        public bool IsLeapYear()
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }

        public uint GetYear()
        {
            return year;
        }

        public uint GetMonth()
        {
            return month;
        }

        public uint GetDay()
        {
            return day;
        }

        public int CompareTo(Date other)
        {
            int yearComparison = year.CompareTo(other.year);
            if (yearComparison != 0)
            {
                return yearComparison;
            }

            int monthComparison = month.CompareTo(other.month);
            if (monthComparison != 0)
            {
                return monthComparison;
            }

            return day.CompareTo(other.day);
        }

        public int GetDaysBetween(Date other)
        {
            DateTime date1 = new DateTime((int)year, (int)month, (int)day);
            DateTime date2 = new DateTime((int)other.year, (int)other.month, (int)other.day);
            TimeSpan span = date2.Subtract(date1);
            return span.Days;
        }

        public void AddDays(int numDays)
        {
            DateTime currentDate = new DateTime((int)year, (int)month, (int)day);
            DateTime newDate = currentDate.AddDays(numDays);
            year = (uint)newDate.Year;
            month = (uint)newDate.Month;
            day = (uint)newDate.Day;
        }

        public void SubtractDays(int numDays)
        {
            DateTime currentDate = new DateTime((int)year, (int)month, (int)day);
            DateTime newDate = currentDate.AddDays(-numDays);
            year = (uint)newDate.Year;
            month = (uint)newDate.Month;
            day = (uint)newDate.Day;
        }
    }
}
