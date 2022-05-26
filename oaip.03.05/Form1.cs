using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OAIP305
{
    public partial class Form1 : Form
    {
        int koef = 1;
        public Form1()
        {
            InitializeComponent();
            trackBar1.Scroll += trackBar1_Scroll;

            this.Width = 400;
            button1.Width = 40;
            button1.Left = 40;
            button1.Text = "";
            button1.BackColor = Color.Aqua;

            timer1.Interval = 500; // 500 миллисекунд
            timer1.Enabled = true;
            button1.Click += button1_Click;
            timer1.Tick += timer1_Tick;
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            if (button1.Left == (this.Width - button1.Width - 10))
            {
                koef = -1;
            }
            else if (button1.Left == 0)
            {
                koef = 1;
            }
            button1.Left += 10 * koef;
        }
        // обработчик нажатия на кнопку
        void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = String.Format("Текущее значение: {0}", trackBar1.Value);
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
