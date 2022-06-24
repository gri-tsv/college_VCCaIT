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
    /// Логика взаимодействия для Seller.xaml
    /// </summary>
    public partial class Seller : Page
    {
        
        public Seller()
        {
            InitializeComponent();
        }

        private void AddOrderButtonClick(object sender, RoutedEventArgs e)
        {
            // данные которые нужно добавить в бд
            string actual_id = NewOrderTextBox.Text;
            string actual_client = NewClientTextBox.Text;
            string actual_service = NewServiceTextBox.Text;

            
        }

        
    }
}
