using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace GrieeX.GrieeXBase
{      
    public class DateAndTime
    {
        public static long DateDiff(Enums.DateInterval interval, DateTime dt1, DateTime dt2)
        {
            return DateDiff(interval, dt1, dt2, System.Globalization.DateTimeFormatInfo.CurrentInfo.FirstDayOfWeek);
        }

        private static int GetQuarter(int nMonth)
        {
            if (nMonth <= 3)
                return 1;
            if (nMonth <= 6)
                return 2;
            if (nMonth <= 9)
                return 3;
            return 4;
        }

        public static long DateDiff(Enums.DateInterval interval, DateTime dt1, DateTime dt2, DayOfWeek eFirstDayOfWeek)
        {
            if (interval == Enums.DateInterval.Year)
                return dt2.Year - dt1.Year;

            if (interval == Enums.DateInterval.Month)
                return (dt2.Month - dt1.Month) + (12 * (dt2.Year - dt1.Year));

            TimeSpan ts = dt2 - dt1;

            if (interval == Enums.DateInterval.Day || interval == Enums.DateInterval.DayOfYear)
                return Round(ts.TotalDays);

            if (interval == Enums.DateInterval.Hour)
                return Round(ts.TotalHours);

            if (interval == Enums.DateInterval.Minute)
                return Round(ts.TotalMinutes);

            if (interval == Enums.DateInterval.Second)
                return Round(ts.TotalSeconds);

            if (interval == Enums.DateInterval.Weekday)
            {
                return Round(ts.TotalDays / 7.0);
            }

            if (interval == Enums.DateInterval.WeekOfYear)
            {
                while (dt2.DayOfWeek != eFirstDayOfWeek)
                    dt2 = dt2.AddDays(-1);
                while (dt1.DayOfWeek != eFirstDayOfWeek)
                    dt1 = dt1.AddDays(-1);
                ts = dt2 - dt1;
                return Round(ts.TotalDays / 7.0);
            }

            if (interval == Enums.DateInterval.Quarter)
            {
                double d1Quarter = GetQuarter(dt1.Month);
                double d2Quarter = GetQuarter(dt2.Month);
                double d1 = d2Quarter - d1Quarter;
                double d2 = (4 * (dt2.Year - dt1.Year));
                return Round(d1 + d2);
            }

            return 0;

        }

        private static long Round(double dVal)
        {
            if (dVal >= 0)
                return (long)Math.Floor(dVal);
            return (long)Math.Ceiling(dVal);
        }
    } 
}
