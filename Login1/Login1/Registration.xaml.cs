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

namespace Login1
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
            Update();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            forma forma = new forma()
            {
                login = Login.Text,
                mail = Email.Text,
                password = Pass.Password,
                Id_Role = App.db.Roles.Where(p => p.role == Role.Text).Select(p => p.Id).First()
            };

            App.db.forma.Add(forma);
            App.db.SaveChanges();
            MessageBox.Show("Успешно");

            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        public void Update()
        {
            Role.ItemsSource = App.db.Roles.Select(p => p.role).ToList();
            Role.SelectedIndex = 2;
        }
    }
}
