using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hads_addad
{
    public partial class Form1 : Form
    {
        Random r;
        int computer_number;
        int count = 0;
        public Form1()
        {
            InitializeComponent();
            r = new Random();
            computer_number = r.Next(0, 100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //foreach(Control c in this.Controls)
            //{
            //    if (c is TextBox)
            //    {
            //        c.ResetText();
            //    }
            //}
            int user_number = Convert.ToInt32(textBox1.Text);
            if (user_number == computer_number)
            {
                label1.Text = " شمابرنده شده اید ";
                label2.Text = Convert.ToString(count);
            }
            else if (user_number < computer_number)
            {
                count++;
                label1.Text = " عدد بزرگتر انتخاب کن ";
            }
            else if (user_number > computer_number)
            {
                count++;
                label1.Text = " عدد کوچکتر انتخاب کن ";
            }

            foreach (Control c in this.Controls)
            {
                if(c.GetType() == typeof(TextBox))
                {
                    c.ResetText();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
