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

namespace Login1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var list = App.db.forma.ToList();

            foreach (var item in list)
            {
                if (item.login.ToString().ToLower().Trim().Equals(login.Text.ToLower().Trim()) && item.password.ToLower().Trim().Equals(password.Password.ToString().ToLower().Trim()))
                {
                    MessageBox.Show("Succeed");
                } 
                else
                {
                    MessageBox.Show("Error");
                }
                break;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
            this.Close();
        }
    }
}
