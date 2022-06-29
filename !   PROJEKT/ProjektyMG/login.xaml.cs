using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
    /// Logika interakcji dla klasy login.xaml
    /// </summary>
    public partial class login : Window
    {
        public login()
        {
            InitializeComponent();
        }

        private  void ButtonSubmit_Click(object sender, RoutedEventArgs e)
        {
            var UserName = Username.Text;
            var PassWord = Password.Password;

            string connectionString = @"Data Source=MACIEK\SQLEXPRESS;Initial Catalog=P13656_MaciejGurgul;Integrated Security=True";

            using (UserDataContext db = new UserDataContext())
            {
                bool userFound = db.User.Any(user => user.Username == UserName && user.Password == PassWord);
                var query = from st in db.User
                            where st.Username == UserName
                            select st;
                Console.WriteLine(query);

                if (userFound)
                {
                    LogIn();
                    
                }
                else
                {
                    MessageBox.Show("Niepoprawny login lub hasło");
                }

            }
        }

        private void LogIn()
        {
            MainWindow Dashboard = new();
            Dashboard.Show();
            this.Close();
        }
    }
}
