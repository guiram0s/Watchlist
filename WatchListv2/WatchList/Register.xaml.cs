using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace WatchList
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Page
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Login());

        }
		//--------------------Placeholders------------------------------------------------------
		private void Fill_Username(object sender, RoutedEventArgs e)
		{
			if (Registo_username.Text == "")
            {
				Registo_username.Text = "Nome de utilizador";
			}

		}

		private void Fill_Password(object sender, RoutedEventArgs e)
		{
			
			if (Registo_password.Password == "")
			{
				Registo_password.Password = "Password";
			}

		}

		private void Fill_Email(object sender, RoutedEventArgs e)
		{
			if (Registo_email.Text == "")
			{
				Registo_email.Text = "Email";
			}

		}

		private void Empty_Username(object sender, RoutedEventArgs e)
		{
			if (Registo_username.Text == "Nome de utilizador")
			{
				Registo_username.Text = "";
			}
		
		}

		private void Empty_Password(object sender, RoutedEventArgs e)
		{
			if (Registo_password.Password == "Password")
			{
				Registo_password.Password = "";
			}
		}

		private void Empty_Email(object sender, RoutedEventArgs e)
		{
				if (Registo_email.Text == "Email")
				{
					Registo_email.Text = "";
				}
		}

		//--------------------Mostrar Password------------------------------------------------------

		private void OnMouseDown(object sender, MouseButtonEventArgs e)
		{
			String pass = Registo_password.Password;
			Registo_password_show.Visibility = Visibility.Visible;
			Registo_password.Visibility = Visibility.Hidden;
			Registo_password_show.Text = pass;
		}
		
		private void OnMouseUp(object sender, MouseButtonEventArgs e)
		{
			Registo_password_show.Visibility = Visibility.Hidden;
			Registo_password.Visibility = Visibility.Visible;
		}
		//---------------------------------------------------------------------------------

		private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.ShutdownMode = ShutdownMode.OnExplicitShutdown;
            Application.Current.Shutdown();
        }

		//--------Verificar endereço de Email-----------------
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

		

        String nm;
		private void Button_Click_2(object sender, RoutedEventArgs e)
        {
			String nome = Registo_username.Text;
			String email = Registo_email.Text;
			String password = Registo_password.Password;
			
			this.nm = nome;

			MySqlCommand cmd;
			string connetionString = null;
			MySqlConnection cnn;
			connetionString = "server=localhost;database=watchlistv4;uid=root;pwd=;";
			cnn = new MySqlConnection(connetionString);

			String msg = "" + nome;
			msg += " \n";

			if (!string.IsNullOrEmpty(nome.Trim()) && !string.IsNullOrEmpty(password.Trim()) && !string.IsNullOrEmpty(email.Trim()))
			{
				if (password.Length >= 7)
				{
					if (isValid(email) == true)
					{
						
						try
						{
							cnn.Open();
							
							bool exists = false;

                            // cria comando para verificar se o Utilizador já existe
                            using (cmd = new MySqlCommand("select count(*) from Utilizador where nome = @nome", cnn))
                            {
                                cmd.Parameters.AddWithValue("nome", Registo_username.Text);
                                exists = (int)(long)cmd.ExecuteScalar() > 0;
                            }

							// se já exister mostra uma mensagem de erro
							if (exists)
							{
								ErrorLabel.Visibility = 0;
								ErrorLabel.Content = "* Este utilizador já existe";
							}
							else
							{
								// se não existir registar
								using (cmd = new MySqlCommand("INSERT INTO Utilizador (nome,email,password) values (@nome, @email, @password) ", cnn))
								{
									cmd.Parameters.AddWithValue("nome", Registo_username.Text);
									cmd.Parameters.AddWithValue("email", Registo_email.Text);
									cmd.Parameters.AddWithValue("password", Registo_password.Password);

									cmd.ExecuteNonQuery();
								}
								var idUtil = "";
								using (MySqlCommand command2 = new MySqlCommand("SELECT idUtilizador from Utilizador where nome='" + nome + "'", cnn))
								{
									MySqlDataReader reader2 = command2.ExecuteReader();
									while (reader2.Read())
									{
										idUtil = reader2["idUtilizador"].ToString();
									}
								}
								cnn.Close();
								cnn.Open();

								MessageBox.Show("Conta Criada! ");

							}
                            cnn.Close();
						}
						catch (Exception ex)
						{
							cnn.Close();
							MessageBox.Show("Erro ! ");
                            Console.WriteLine(ex);
						}
						
					}
					else
					{
						ErrorLabel.Visibility = 0;
						ErrorLabel.Content = "* O endereço de Email nâo é válido";
					}
				}
				else
				{
					ErrorLabel.Visibility = 0;
					ErrorLabel.Content = "* A password tem que ter pelo menos 7 caracteres";
				}
			}
			else
			{
				ErrorLabel.Visibility = 0;
				ErrorLabel.Content = "* Por-favor insira todas as informações";
			}
		}

    }
}
