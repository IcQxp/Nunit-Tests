using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Логика взаимодействия для Conference.xaml
    /// </summary>
    public partial class Conference : Page
    {
        public Conference()
        {
            InitializeComponent();
            if (Application.Current.MainWindow is MainWindow mainWindow)
            { ConfName.Content = mainWindow.confNow.ToString(); }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        { this.NavigationService.Navigate(new Uri("Main.xaml", UriKind.Relative)); }

        private void SendBTN_Click(object sender, RoutedEventArgs e)
        {
            if (MessageTB.Text.Trim() != "")
                ListBoxT.Items.Add(MessageTB.Text);
            MessageTB.Text = "";
        }
    }
}
