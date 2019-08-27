using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueStructEnumHomework
{
    public class DateCompare
    {
        private static Date date1 = new Date() { Year = 1000, Month = 1 };

        private static Date date2 = new Date() { Year = 2000, Month = 1 };

        private const int MAX_MONTH = 12;

        public static void CompareDate(Date date)
        {
            if (isInRange(date))
            {
                Console.WriteLine(Answer.Fit);
            }
            else
            {
                Console.WriteLine(string.Concat(Answer.Dont," ", Answer.Fit));
            }  
        }

        private static bool isInRange(Date date)
        {
            if ((date.Month > 0 && date.Month <= MAX_MONTH) && (date.Year >= date1.Year && date.Year < date2.Year) || (date.Year == date2.Year && date.Month == date2.Month))
            {
                return true; 
            }
            return false;
        }

        private enum Answer
        {
            Fit,
            Dont
        }
    }

    public struct Date
    {
        public int Year { get; set; }

        public int Month { get; set; }
    }
}
