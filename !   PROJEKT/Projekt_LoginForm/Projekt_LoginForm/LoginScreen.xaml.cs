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

namespace Projekt_LoginForm
{
    /// <summary>
    /// Logika interakcji dla klasy LoginScreen.xaml
    /// </summary>
    public partial class LoginScreen : Window
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void ButtonSubmit_Click(object sender, RoutedEventArgs e)//MACIEK\SQLEXPRESS01 ProjektMG13656
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=MACIEK\SQLEXPRESS01; Initial Catalog=ProjektMG13656; Integrated Security=True;");

            try
            {
                if(sqlCon.State == ConnectionState.Closed) sqlCon.Open();   
                String query = "SELECT COUNT(1) from UsersTb where UserName=@Username and Password = @Password";
                SqlCommand sqlCmd = new SqlCommand(query,sqlCon);
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@Username", Username.Text);
                sqlCmd.Parameters.AddWithValue("@Password", Password.Password);
                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());

                if(count == 1)
                {
                    MainWindow Dashboard = new();
                    Dashboard.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Nazwa użytkownika lub hasło jest nieprawidłowe");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }
    }
}
