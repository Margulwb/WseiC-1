using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Logika interakcji dla klasy AdminPanel.xaml
    /// </summary>
    public partial class AdminPanel : Window
    {
        public AdminPanel()
        {
            InitializeComponent();
            Read();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            ModelList.Items.Clear();
        }

        private void PriceTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e) => Create();

        private void UpdateButton_Click(object sender, RoutedEventArgs e) => Update();

        private void DeleteButton_Click(object sender, RoutedEventArgs e) => Delete();
        public void Read()
        {
            using (DbAplicationContext context = new DbAplicationContext())
            {
                ModelList.ItemsSource = context.ModelBike.ToList();
            }

        }

        public void Create()
        {

            using (DbAplicationContext context = new DbAplicationContext())
            {
                var mark = MarkTextBox.Text;
                var wheleSize = WheleSizeTextBox.Text;
                var numberGear = NumberGearTextBox.Text;

                if (mark == null || wheleSize== null || numberGear == null)
                {
                    MessageBox.Show("Wprowadz dane");
                }
                else
                {
                    context.ModelBike.Add(new ModelBike() { Mark = mark, WheelSize = int.Parse(wheleSize), NumberGears= int.Parse(numberGear) });
                    context.SaveChanges();
                }
                Read();
            }
        }

        public void Update()
        {
            using (DbAplicationContext context = new DbAplicationContext())
            {
                ModelBike selectedModelBike = ModelList.SelectedItem as ModelBike;

                var mark = MarkTextBox.Text;
                var wheleSize = WheleSizeTextBox.Text;
                var numberGear = NumberGearTextBox.Text;

                if (mark != null && wheleSize != null && numberGear != null)
                {
                    ModelBike model = context.ModelBike.Find(selectedModelBike.ID);
                    model.Mark = mark;
                    model.WheelSize = int.Parse(wheleSize);
                    model.NumberGears = int.Parse(numberGear);

                    context.SaveChanges();
                }
            }
            Read();
        }
        public void Delete()
        {
            using (DbAplicationContext context = new DbAplicationContext())
            {
                ModelBike selectedModelBike = ModelList.SelectedItem as ModelBike;

                if (selectedModelBike != null)
                {
                    ModelBike user = context.ModelBike.Single(x => x.ID == selectedModelBike.ID);

                    context.Remove(user);
                    context.SaveChanges();
                }
            }
            Read();
        }
    }
}
