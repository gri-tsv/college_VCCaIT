    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OAIP405
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

            button2.Click += button2_Click;
            button3.Click += button3_Click;
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            nameBox.Validating += nameBox_Validating;
            ageBox.Validating += ageBox_Validating;
        }
        private void nameBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(nameBox.Text))
            {
                errorProvider1.SetError(nameBox, "Не указано имя!");
            }
            else if (nameBox.Text.Length < 4)
            {
                errorProvider1.SetError(nameBox, "Слишком короткое имя!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void ageBox_Validating(object sender, CancelEventArgs e)
        {
            int age = 0;
            if (String.IsNullOrEmpty(ageBox.Text))
            {
                errorProvider1.SetError(ageBox, "Не указан возраст!");
            }
            else if (!Int32.TryParse(ageBox.Text, out age))
            {
                errorProvider1.SetError(ageBox, "Некорретный возраст!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Окрасить кнопку в красный цвет?",
            "Сообщение",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.Yes)
                button1.BackColor = Color.Red;



            this.TopMost = true;
        }

        // сохранение файла
        void button2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            // сохраняем текст в файл
            System.IO.File.WriteAllText(filename, textBox1.Text);
            MessageBox.Show("Файл сохранен");
        }
        // открытие файла
        void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            // читаем файл в строку
            string fileText = System.IO.File.ReadAllText(filename);
            textBox1.Text = fileText;
            MessageBox.Show("Файл открыт");
        }

       
    }
}
