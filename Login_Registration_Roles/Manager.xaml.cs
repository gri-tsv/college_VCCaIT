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
    /// Логика взаимодействия для Manager.xaml
    /// </summary>
    public partial class Manager : Page
    {
        public Manager()
        {
            InitializeComponent();
        }
        private void AddOrderButtonManagerClick(object sender, RoutedEventArgs e)
        {
            // данные которые нужно добавить в бд
            string actual_id = NewOrderTextBoxManager.Text;
            string actual_client = NewClientTextBoxManager.Text;
            string actual_service = NewServiceTextBoxManager.Text;


        }
    }
}
