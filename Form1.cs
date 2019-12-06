using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar_3011
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MyDate date;

        private void setdatebtn_Click(object sender, EventArgs e)
        {
            if(daybox.Text != "" && monthbox.Text != "" && yearbox.Text != "")
            {
                date = new MyDate(Convert.ToInt32(daybox.Text), Convert.ToInt32(monthbox.Text), Convert.ToInt32(yearbox.Text));
                if (date.isCorrect())
                {
                    date.visualDate(daybox, monthbox, yearbox, datelabel);
                }
            }
        }

        private void nextdatebtn_Click(object sender, EventArgs e)
        {
            if (date != null)
            {
                date.nextDate();
                date.visualDate(daybox, monthbox, yearbox, datelabel);
            }
        }

        private void prevdatebtn_Click(object sender, EventArgs e)
        {
            if (date != null)
            {
                date.predDate();
                date.visualDate(daybox, monthbox, yearbox, datelabel);
            }
        }
    }
}
