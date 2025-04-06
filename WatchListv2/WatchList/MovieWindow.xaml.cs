using MySqlConnector;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for MovieWindow.xaml
    /// </summary>
    public partial class MovieWindow : Window
    {
        private string v;
        public int isPlaying = 0;
        public string isInUserList = "";
        public MovieWindow()
        {
            InitializeComponent();

        }
        
        public MovieWindow(string v)
        {
            this.v = v;
            InitializeComponent();
            var resum = "";
            var titul = "";
            var traile = "";
            MySqlCommand cmd;
            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=watchlistv4;uid=root;pwd=;";
            cnn = new MySqlConnection(connetionString);
            cnn.Open();
            cmd = new MySqlCommand("select titulo,resumo,trailer from Filme where idFilme='" + v + "'", cnn);
            MySqlDataReader reader2 = cmd.ExecuteReader();
            while (reader2.Read())
            {
                titul = reader2["titulo"].ToString();
                resum = reader2["resumo"].ToString();
                traile = reader2["trailer"].ToString();
            }
            resumo.Text = resum;
            Titulo.Content = titul;
            cnn.Close();
            video_manager();

            System.IO.DirectoryInfo directory = new DirectoryInfo(traile);
            var z = directory.FullName;
            z = z.Replace(@"\", "/");
            string s = z.Substring(0, z.IndexOf("bin"));
            string final = s + "Contents/" + traile;
            

            video.Source = new Uri(final);
            video.Play();
            video.Pause();

            var avgRate = "";
            cnn.Open();
            cmd = new MySqlCommand("SELECT AVG(rating) FROM utilizador_has_filme where filme_idFilme='" + v + "'", cnn);
            var result = cmd.ExecuteScalar(); 
            cnn.Close();
            
            cnn.Open();
            cmd = new MySqlCommand("SELECT visto FROM filme where idFilme='" + v + "'", cnn);
            var num = cmd.ExecuteScalar();
            cnn.Close();
            var numint = (int)num;
            var total = numint + 1;
            cnn.Open();
            cmd = new MySqlCommand("UPDATE filme SET visto = '" + total + "' WHERE  idFilme='" + v + "'", cnn);
            var numupd = cmd.ExecuteScalar();
            cnn.Close();

            if (result.ToString() != "")
            {
                var a = result.ToString();
                Double temp;
                Boolean isOk = Double.TryParse(a, out temp);
                var value = isOk ? temp : 0;
                avgRateLabel.Content = value.ToString()+"/5";
            }
            else{
                avgRateLabel.Content = "N/A";
            }

            cnn.Open();
            cmd = new MySqlCommand("select filme_idFilme from utilizador_has_filme where utilizador_idUtilizador='" + Session.Id + "' and filme_idFilme = '" + v + "'", cnn);
            MySqlDataReader reader3 = cmd.ExecuteReader();
            while (reader3.Read())
            {
                isInUserList = reader3["filme_idFilme"].ToString();
            }
            cnn.Close();

            if (isInUserList == "")
            {
                rateLabel.Visibility = Visibility.Hidden;
                rateComboBox.Visibility = Visibility.Hidden;
                statusLabel.Visibility = Visibility.Hidden;
                statusComboBox.Visibility = Visibility.Hidden;
            }
            else{

                cnn.Open();
                cmd = new MySqlCommand("select status from utilizador_has_filme WHERE utilizador_idUtilizador = '" + Session.Id + "' and filme_idFilme = '" + v + "'", cnn);
                MySqlDataReader reader5 = cmd.ExecuteReader();
                while (reader5.Read())
                {
                    statusComboBox.Text = reader5["status"].ToString();
                }
                cnn.Close();

                cnn.Open();
                cmd = new MySqlCommand("select rating from utilizador_has_filme WHERE utilizador_idUtilizador = '" + Session.Id + "' and filme_idFilme = '" + v + "'", cnn);
                MySqlDataReader reader4 = cmd.ExecuteReader();
                while (reader4.Read())
                {
                    rateComboBox.Text = reader4["rating"].ToString();
                }
                cnn.Close();
            }

        }

        private void Close_Window(object sender, RoutedEventArgs e)
        {
            var a = rateComboBox.Text;
            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=watchlistv4;uid=root;pwd=;";
            cnn = new MySqlConnection(connetionString);
            if (a != "")
            {
                try
                {

                    cnn.Open();
                    using (MySqlCommand command3 = new MySqlCommand("UPDATE utilizador_has_filme SET rating = '" + a + "' WHERE utilizador_idUtilizador = '" + Session.Id + "' and filme_idFilme = '" + v + "' ", cnn))
                    {
                        command3.ExecuteNonQuery();
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Erro!");
                }
                cnn.Close();
            }

            var b = statusComboBox.Text;
            if (b != "")
            {
                try
                {
                    cnn.Open();
                    using (MySqlCommand command4 = new MySqlCommand("UPDATE utilizador_has_filme SET status = '" + b + "' WHERE utilizador_idUtilizador = '" + Session.Id + "' and filme_idFilme = '" + v + "' ", cnn))
                    {
                        command4.ExecuteNonQuery();
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Erro!");
                }
            }
            cnn.Close();
            this.Close();
            
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }
        private void video_manager()
        {
            
            System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(TimerTick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
        }

        public void TimerTick(object sender, EventArgs e)
        {
            duracaoSlider.Value = video.Position.TotalSeconds;
        }

        private void duracaoSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            TimeSpan ts = TimeSpan.FromSeconds(e.NewValue);
            video.Position = ts;
        }

        private void volSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            video.Volume = volSlider.Value;
        }

        private void video_MediaOpened(object sender, RoutedEventArgs e)
        {
            if (video.NaturalDuration.HasTimeSpan)
            {
                TimeSpan ts = TimeSpan.FromMilliseconds(video.NaturalDuration.TimeSpan.TotalMilliseconds);
                duracaoSlider.Maximum = ts.TotalSeconds;
            }

        }

        
        public void Button_Click(object sender, RoutedEventArgs e)
        {
            
            if (isPlaying==1)
            {
                video.Pause();
                PlayButton.Content = FindResource("Play");
                isPlaying = 0;
            }
            else
            {
                video.Play();
                PlayButton.Content = FindResource("Pause");
                isPlaying = 1;
            }
        }


        private void Addbtn(object sender, RoutedEventArgs e)
        {
            statusLabel.Visibility = Visibility.Visible;
            statusComboBox.Visibility = Visibility.Visible;
            rateLabel.Visibility = Visibility.Visible;
            rateComboBox.Visibility = Visibility.Visible;
            MySqlCommand cmd;
            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=watchlistv4;uid=root;pwd=;";
            cnn = new MySqlConnection(connetionString);
            try
            {
                
                cnn.Open();
                using (MySqlCommand command3 = new MySqlCommand("INSERT INTO utilizador_has_filme(filme_idFilme,utilizador_idUtilizador) values (@value1, @value2)", cnn))
                {
                    command3.Parameters.AddWithValue("value1", v);
                    command3.Parameters.AddWithValue("value2", Session.Id);
                    command3.ExecuteNonQuery();
                }
                MessageBox.Show("Filme adicionado á sua lista! ");
            }
            
            catch(Exception ex)
            {
                MessageBox.Show("O Filme já está na sua lista!");
            }
        }

    }
}
