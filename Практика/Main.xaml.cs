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
using ClassLibrary1;
namespace Практика
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        private List<ConferenceClass> confs;
        public Main()
        {
            InitializeComponent();
            ConferenceClass c1 = new ConferenceClass(1);
            ConferenceClass c2 = new ConferenceClass(2);
            confs = new List<ConferenceClass>() { c1, c2 };
        }

        private void join_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(confTB.Text);

            var conference = confs.FirstOrDefault(c => c.Id == id);

            if (conference != null)
            {
                if (Application.Current.MainWindow is MainWindow mainWindow)
                {
                    mainWindow.confNow = id.ToString();
                }
                this.NavigationService.Navigate(new Uri("Conference.xaml", UriKind.Relative));
            }
            else
            { MessageBox.Show("Нет комнаты"); }

        }

        private void create_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(confTB.Text);
            var conference = confs.FirstOrDefault(c => c.Id == id);
            if (conference != null)
            { MessageBox.Show("Комната уже создана"); }
            else
            {
                conference = new ConferenceClass(id);
                confs.Add(conference);
                MessageBox.Show("Комната создана");
            }

        }
    }
}
