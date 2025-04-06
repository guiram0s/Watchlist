using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WatchList
{

    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Abrir_Registo(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Register());
        }

        private void Fechar(object sender, RoutedEventArgs e)
        {
            Application.Current.ShutdownMode = ShutdownMode.OnExplicitShutdown;
            Application.Current.Shutdown();
        }

        //---------------Placeholders-------------
        public void Fill_Username(object sender, RoutedEventArgs e)
        {
            if (login_username.Text == "")
            {
                login_username.Text = "Nome de utilizador";
            }

        }

        private void Fill_Password(object sender, RoutedEventArgs e)
        {

            if (login_password.Password == "")
            {
                login_password.Password = "Password";
            }

        }

        private void Empty_Username(object sender, RoutedEventArgs e)
        {
            if (login_username.Text == "Nome de utilizador")
            {
                login_username.Text = "";
            }

        }

        private void Empty_Password(object sender, RoutedEventArgs e)
        {
            if (login_password.Password == "Password")
            {
                login_password.Password = "";
            }
        }

        //--------------------------------------------------------------------

        private void Fazer_Login(object sender, RoutedEventArgs e)
        {
            if (login_username.Text.Length == 0)
            {
                label_login.Visibility = 0;
                label_login.Content = "* Enter an Username.";
                login_username.Focus();
            }
            else if (login_password.Password.Length == 0)
            {

                label_login.Visibility = 0;
                label_login.Content = "* Enter a valid email.";
                login_password.Focus();
            }
            else
            {
                try
                {
                    string username = login_username.Text;
                    string password = login_password.Password;
                    MySqlConnection con = new MySqlConnection("server=localhost;database=watchlistv4;uid=root;pwd=;");
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("Select * from Utilizador where nome='" + username + "'  and password='" + password + "'", con);
                    cmd.CommandType = CommandType.Text;
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = cmd;
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    if (dataSet.Tables[0].Rows.Count > 0)
                    {
                        string username0 = dataSet.Tables[0].Rows[0]["Nome"].ToString();
                        login_username.Text = username0;
                        MessageBox.Show("Bem-vindo " + username0 + "!");
                        Session.LoggedIn = true;
                        Session.UserName = username0;
                        con.Close();
                        con.Open();
                        using (MySqlCommand command2 = new MySqlCommand("SELECT idUtilizador from Utilizador where nome='" + username0 + "'", con))
                        {
                            MySqlDataReader reader2 = command2.ExecuteReader();
                            while (reader2.Read())
                            {
                                Session.Id = reader2["idUtilizador"].ToString();
                            }
                        }
                        var newWindow = new HomeWindow();
                        newWindow.Show();

                        Window windowToClose = Window.GetWindow(this);
                        windowToClose.Close();
       
                    }
                    else
                    {
                        label_login.Visibility = 0;
                        label_login.Content = "* Sorry! Please enter existing Username/password.";
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }

        public void SendEmail(object sender, RoutedEventArgs e)
        {
            PassRecoveryWindow w = new PassRecoveryWindow();
            w.Show();
        }
    }
}
