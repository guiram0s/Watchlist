using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
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

namespace WatchList.View
{
    /// <summary>
    /// Interaction logic for AccountView.xaml
    /// </summary>
    public partial class AccountView : UserControl
    {
        public AccountView()
        {
            InitializeComponent();
            MySqlCommand cmd;
            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=watchlistv4;uid=root;pwd=;";
            cnn = new MySqlConnection(connetionString);

            cnn.Open();
            bool exists = false;

            
            cmd = new MySqlCommand("select nome,email,password,recuperacao from Utilizador where idUtilizador = '" + Session.Id + "'", cnn);
            MySqlDataReader reader2 = cmd.ExecuteReader();
            while (reader2.Read())
            {
                User_username.Text = reader2["nome"].ToString();
                User_email.Text = reader2["email"].ToString();
                User_password.Password = reader2["password"].ToString();
                User_recuperacao.Text = reader2["recuperacao"].ToString();
            }

        }


        private void savesetting(object sender, RoutedEventArgs e)
        {
            var nome = User_username.Text;
            var email = User_email.Text;
            var pass = User_password.Password;
            var recup = User_recuperacao.Text;
            Session.UserName= User_username.Text;
            if (!string.IsNullOrEmpty(nome.Trim()) && !string.IsNullOrEmpty(pass.Trim()) && !string.IsNullOrEmpty(email.Trim()))
            {
                if (pass.Length >= 7)
                {
                    
                        if (isValid(email) == true)
                        {
                            if (isValid(recup) == true)
                            {
                                MySqlCommand cmd;
                                string connetionString = null;
                                MySqlConnection cnn;
                                connetionString = "server=localhost;database=watchlistv4;uid=root;pwd=;";
                                cnn = new MySqlConnection(connetionString);
                                cnn.Open();

                                cmd = new MySqlCommand("update Utilizador SET nome = '" + nome + "',email = '" + email + "',password = '" + pass + "',recuperacao = '" + recup + "' where idutilizador= '" + Session.Id + "'", cnn);
                                cmd.ExecuteReader();
                                MessageBox.Show("Dados atualizados!");
                            }
                            else
                            {
                                MessageBox.Show("Email de recuperação inválido");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Email inválido");
                        }
                    
                }
                else
                {
                    MessageBox.Show("Password tem quer ser maior que 7 caracteres");
                }
            }
            else
            {
                MessageBox.Show("Nome inválido");
            }

        }

        public Boolean isValid(String email0)
        {
            try
            {
                MailAddress m = new MailAddress(email0);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        
        private void trocaraccount(object sender, RoutedEventArgs e)
        {
            MainWindow win2 = new MainWindow();
            win2.Show();

            for (int i = 0; i < Application.Current.Windows.OfType<Window>().
            Where(w => w.IsVisible).Count(); i++)
            {
                Window windowToHide = Application.Current.Windows[i];
                windowToHide.Visibility = Visibility.Collapsed;
            }
        }

        private void OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            String pass = User_password.Password;
            User_password_show.Visibility = Visibility.Visible;
            User_password.Visibility = Visibility.Hidden;
            User_password_show.Text = pass;
        }

        private void OnMouseUp(object sender, MouseButtonEventArgs e)
        {
            User_password_show.Visibility = Visibility.Hidden;
            User_password.Visibility = Visibility.Visible;
        }
    }
}
