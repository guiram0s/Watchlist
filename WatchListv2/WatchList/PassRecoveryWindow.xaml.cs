using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WatchList
{
    /// <summary>
    /// Interaction logic for PassRecoveryWindow.xaml
    /// </summary>
    public partial class PassRecoveryWindow : Window
    {
        public PassRecoveryWindow()
        {
            InitializeComponent();
        }
        //------Placeholders--------
        private void Fill_Username(object sender, RoutedEventArgs e)
        {
            if (txtBoxUser.Text == "")
            {
                txtBoxUser.Text = "Nome de utilizador";
            }

        }

        private void Empty_Username(object sender, RoutedEventArgs e)
        {
            if (txtBoxUser.Text == "Nome de utilizador")
            {
                txtBoxUser.Text = "";
            }

        }
        //-------------------------------------
        public void SendEmail(object sender, RoutedEventArgs e)
        {
            
            try
            {
                var idUser="";
                var recuperacao = "";
                var user = txtBoxUser.Text;
                if (user != "")
                {
                    MySqlConnection con = new MySqlConnection("server=localhost;database=watchlistv4;uid=root;pwd=;");
                    con.Open();
                    using (MySqlCommand command2 = new MySqlCommand("SELECT idUtilizador,recuperacao from Utilizador where nome='" + user + "'", con))
                    {
                        MySqlDataReader reader2 = command2.ExecuteReader();
                        while (reader2.Read())
                        {
                            idUser = reader2["idUtilizador"].ToString();
                            recuperacao = reader2["recuperacao"].ToString();
                        }
                    }
                    con.Close();
                    var newPass = GenerateToken();
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("update Utilizador SET password = '" + newPass + "' where idutilizador= '" + idUser + "'", con);
                    cmd.ExecuteReader();
                    con.Close();

                    string fromAddress = "WatchListService@gmail.com";
                    string toAddress = recuperacao;
                    System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage(fromAddress, toAddress);

                    message.Subject = "A sua nova palavra-passe";
                    message.Body = "<b>" + newPass + "</b>";
                    

                    
                    message.IsBodyHtml = true;

                    
                    message.Priority = System.Net.Mail.MailPriority.High;


                    System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587);

                    
                    client.EnableSsl = true;

                    
                    client.Credentials = new System.Net.NetworkCredential(fromAddress, "yvwehcemolpqddvt");

                    
                    client.Send(message);
                    MessageBox.Show("Nova palavra-passe enviada para o seu email de recuperação");
                }
                else
                {
                    MessageBox.Show("Não tem um Email de recuperação definido. Tente contactar o suporte em WatchListService@gmail.com ");
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }

        public string GenerateToken()
        {
            using (RNGCryptoServiceProvider cryptRNG = new RNGCryptoServiceProvider())
            {
                byte[] tokenBuffer = new byte[8];
                cryptRNG.GetBytes(tokenBuffer);
                return Convert.ToBase64String(tokenBuffer);
            }
        }
        public void CloseWindow(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }
    }
}
