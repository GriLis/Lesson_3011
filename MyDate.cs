using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar_3011
{
    public class MyDate
    {
        int day;
        int month;
        int year;
        int[] days = new int[13];

        enum Months
        {
            January = 1,
            February = 2,
            March = 3,
            April = 4,
            May = 5,
            June = 6,
            July = 7,
            August = 8,
            September = 9,
            October = 10,
            November = 11,
            December = 12
        }

        public MyDate(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;

            for (int i = 1; i < days.Length; i++)
            {
                if (i == (int)Months.January |
                    i == (int)Months.March |
                    i == (int)Months.May |
                    i == (int)Months.July |
                    i == (int)Months.August |
                    i == (int)Months.October |
                    i == (int)Months.December)
                    days[i] = 31;
                else if (i == (int)Months.April |
                    i == (int)Months.June |
                    i == (int)Months.September |
                    i == (int)Months.November)
                    days[i] = 30;
                else
                    if (isVisYear(year))
                    days[i] = 29;
                else
                    days[i] = 28;
            }
        }

        public void setDate(int d, int m, int y)
        {
            day = d;
            month = m;
            year = y;
        }

        public void nextDate()
        {
            if (days[month] >= day + 1)
                day += 1;
            else
            {
                day = 1;

                if (month + 1 < 13)
                    month += 1;
                else
                {
                    month = 1;
                    year += 1;
                }
            }

            setDate(day, month, year);
        }

        public void predDate()
        {
            if (day > 1)
                day -= 1;
            else
            {
                if (month - 1 > 0)
                    month -= 1;
                else
                {
                    month = 12;
                    year -= 1;
                }

                day = days[month];
            }

            setDate(day, month, year);
        }

        bool isVisYear(int year)
        {
            bool isVis = false;

            if ((year % 4 == 0 & year % 100 != 0) | (year % 400 == 0))
                isVis = true;

            return isVis;
        }

        public void visualDate(TextBox tb_day, TextBox tb_month, TextBox tb_year, Label label)
        {
            Months currentmonth = (Months)month;
            label.Text = day.ToString() + " " + currentmonth.ToString() + " " + year.ToString();
            tb_day.Text = day.ToString();
            tb_month.Text = month.ToString();
            tb_year.Text = year.ToString();
        }

        public bool isCorrect()
        {
            bool isCorrect = false;

            if (month > 0 && month <= 12 && day > 0 && day <= days[month] && year > 10)
                isCorrect = true;

            return isCorrect;
        }
    }
}
