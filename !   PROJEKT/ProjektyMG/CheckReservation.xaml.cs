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

namespace ProjektyMG
{
    /// <summary>
    /// Logika interakcji dla klasy CheckReservation.xaml
    /// </summary>
    public partial class CheckReservation : Window
    {
        public CheckReservation()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Dashboard = new();
            Dashboard.Show();
            this.Close();
        }
    }
}
