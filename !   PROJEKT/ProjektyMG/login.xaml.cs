using System;
using System.Data;
using System.Linq;
using System.Windows;

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
            var UserName = Username.Text; //tu masz dane jaki uzytkownik
            var PassWord = Password.Password;

            using (DbAplicationContext db = new())
            {
                bool userFound = db.Users.Any(user => user.Username == UserName && user.Password == PassWord);
                var query = from st in db.Users
                            where st.Username == UserName
                            select st;

                if (userFound)
                {
                    LogIn();
                    //moze tu cos dodaj
                    
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
