using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpf_cSharpcorner_Login_Registration_Process
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            main_frame.Navigate(new Login());
        }

        private void LoginClick(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            Close();
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            Reset();

        }
        public void Reset()
        {
            LastNameTextBox.Text = "";
            FirstNameTextBox.Text = "";
            LoginTextBox.Text = "";
            PasswordBox.Password = "";
            ConfirmPasswordBox.Password = "";

        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
