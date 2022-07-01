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
using System.Text.RegularExpressions;

namespace ProjektyMG
{
    /// <summary>
    /// Logika interakcji dla klasy Reservation.xaml
    /// </summary>
    public partial class Reservation : Window
    {
        public Reservation()
        {
            InitializeComponent();
            Read();
            ReadWorkers();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            ItemList.Items.Clear();
        }
        private void MenuWorkers_Click(object sender, RoutedEventArgs e)
        {
            ListWorker.Items.Clear();
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e) => Create();

        private void ReadButton_Click(object sender, RoutedEventArgs e) => Read();

        private void UpdateButton_Click(object sender, RoutedEventArgs e) => Update();  

        private void DeleteButton_Click(object sender, RoutedEventArgs e) => Delete();

        public void Create()
        {

            using (DbAplicationContext context = new DbAplicationContext())
            {
                var name = NameTextBox.Text;
                var price = PriceTextBox.Text;
                var whoPrepared = WhoPreparedTextBox.Text;

                if (name == null || PriceTextBox == null || whoPrepared == null)
                {
                    MessageBox.Show("Wprowadz dane");
                }
                else
                {
                    context.Bike.Add(new Bike() { Name = name, Price = double.Parse(price), WhoPrepared = long.Parse(whoPrepared) });
                    context.SaveChanges();                  
                }
                Read();
            }
        }

        public void Read()
        {
            using (DbAplicationContext context = new DbAplicationContext())
            {
                ItemList.ItemsSource = context.Bike.ToList();
            }

        }
        public void ReadWorkers()
        {
            using (DbAplicationContext context = new DbAplicationContext())
            {
                ListWorker.ItemsSource = context.Workers.ToList();
            }

        }

        public void Update()
        {
            using (DbAplicationContext context = new DbAplicationContext())
            {
                Bike selectedUser = ItemList.SelectedItem as Bike;

                var name = NameTextBox.Text;
                var price = PriceTextBox.Text;
                var whoPrepared = WhoPreparedTextBox.Text;

                if (name != null && PriceTextBox != null)
                {
                    Bike bike = context.Bike.Find(selectedUser.ID);
                    bike.Name = name;
                    bike.Price = double.Parse(price);
                    bike.WhoPrepared = long.Parse(whoPrepared);

                    context.SaveChanges();
                }
            }
            Read();
        }

        public void Delete()
        {
            using (DbAplicationContext context = new DbAplicationContext())
            {
                Bike selectedUser = ItemList.SelectedItem as Bike;

                if (selectedUser != null)
                {
                    Bike user = context.Bike.Single(x => x.ID == selectedUser.ID);

                    context.Remove(user);
                    context.SaveChanges();
                }
            }
            Read();
        }

        private void OnlyNumber_Preview(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }
    }
}
