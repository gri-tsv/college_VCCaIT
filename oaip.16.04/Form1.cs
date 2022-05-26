using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oaip16._04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] countries = { "Бразилия", "Аргентина", "Чили", "Уругвай", "Колумбия" };
            listBox1.Items.AddRange(countries);

            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == true)
            {
                MessageBox.Show("Проверка выполнена");
            }
            else
            {
                MessageBox.Show("Проверка отменена");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // приводим отправителя к элементу типа RadioButton
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                MessageBox.Show("Вы выбрали " + radioButton.Text);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // приводим отправителя к элементу типа RadioButton
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                MessageBox.Show("Вы выбрали " + radioButton.Text);
            }
        }

        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listBox1.Items.Insert(1, "Парагвай");
            //listBox1.Items.Remove("Чили");
            //listBox1.Items.RemoveAt(3);
            //listBox1.Items.Clear();
            //listBox1.SetSelected(2, true);

            string selectedCountry = listBox1.SelectedItem.ToString();
            MessageBox.Show(selectedCountry);
        }
    }
}