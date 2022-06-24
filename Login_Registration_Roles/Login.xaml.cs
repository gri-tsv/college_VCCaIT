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
using System.Windows.Shapes;
using System.Windows.Navigation;


namespace wpf_cSharpcorner_Login_Registration_Process
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login
        : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void GoToRegistrationClick(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
        private void ResetButtonLogWin_Click(object sender, RoutedEventArgs e)
        {
            Reset();

        }
        public void Reset()
        {
            LoginTextBoxLogWin.Text = "";
            
            PasswordBoxLogWin.Password = "";
            

        }

        private void CancelButtonLogWin_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string actual_login = LoginTextBoxLogWin.Text;
            string actual_password = PasswordBoxLogWin.Password;
            
            this.NavigationService.Navigate(new Seller());


            switch (actual_login)
            {
                case "Admin":
                    {
                        if (actual_login == "Admin" || actual_password == "Admin")

                            this.NavigationService.Navigate(new Admin());
                        break;
                    }
                case "Seller":
                    {
                        if (actual_login == "Seller" || actual_password == "Seller")
                            this.NavigationService.Navigate(new Seller());
                        break;
                    }
                case "StSeller":
                    {
                        if (actual_login == "Manager" || actual_password == "Manager")
                            this.NavigationService.Navigate(new Manager());
                        break;
                    }

            }

        }

       
    }
    
}
