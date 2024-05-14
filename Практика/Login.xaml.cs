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

namespace Практика
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            var users = new Dictionary<string, string>()
            {
                { "first", "123"},
                { "second", "456"},
                { "Darya", "789"} 
            };
            string loginUser = loginTB.Text.Trim();
                string password = passwordTB.Password.Trim();
            if (users.ContainsKey(loginUser) && users[loginUser] == password)
            {
                Frame frame = (Frame)this.Parent;
                if (Application.Current.MainWindow is MainWindow mainWindow)
                {
                    mainWindow.username = loginUser; 
                    mainWindow.usernameLogin.Content=mainWindow.username;
                }
                this.NavigationService.Navigate(new Uri("Main.xaml", UriKind.Relative));
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль");
            }
        }
    }
}
