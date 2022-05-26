using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OAIP3004
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            imageList1.Images.Add(Image.FromFile(@"N:\Колледж\3 курс\ОАИП\OAIP3004\OAIP3004\flag-Argentina.png"));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
