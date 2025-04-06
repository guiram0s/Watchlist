using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
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
    /// Interaction logic for ListView.xaml
    /// </summary>
    public partial class ListView : UserControl
    {
        public DataView fillDatagrid { get; set; }
        public ListView()
        {
            InitializeComponent();
            MySqlCommand cmd;
            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=watchlistv4;uid=root;pwd=;";
            cnn = new MySqlConnection(connetionString);
            cnn.Open();
            
             
            fillDatagrid = GetDataList().AsDataView();
            foreach (var movie in fillDatagrid)
            {
                datagridList.Items.Add(movie);
            }
            

        }

        private DataTable GetDataList()
        {
            DataTable dtMovies = new DataTable();

            MySqlCommand cmd;
            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=watchlistv4;uid=root;pwd=;";
            cnn = new MySqlConnection(connetionString);
            cnn.Open();

            using (MySqlCommand command3 = new MySqlCommand("SELECT filme.idfilme,filme.titulo,filme.duracao,filme.ano, utilizador_has_filme.rating, utilizador_has_filme.status FROM filme LEFT JOIN utilizador_has_filme ON filme.idfilme = utilizador_has_filme.filme_idfilme where utilizador_idutilizador='" + Session.Id + "'", cnn))
            {
                MySqlDataReader reader3 = command3.ExecuteReader();
                dtMovies.Load(reader3);

            }
            cnn.Close();

            return dtMovies;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataRowView a = (DataRowView)((Button)e.Source).DataContext;
            var id_ = a["idfilme"].ToString();
            var newWindow = new MovieWindow(id_);
            newWindow.Show();
        }

        private void Remove(object sender, RoutedEventArgs e)
        {
            DataRowView a = (DataRowView)((Button)e.Source).DataContext;
            var id_ = a["idfilme"].ToString();

            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=watchlistv4;uid=root;pwd=;";
            cnn = new MySqlConnection(connetionString);
            cnn.Open();

            MySqlCommand command3 = new MySqlCommand("DELETE FROM utilizador_has_filme where utilizador_idutilizador='" + Session.Id + "' and filme_idfilme='" + id_ + "'", cnn);
            command3.ExecuteNonQuery();
            
            cnn.Close();

            datagridList.Items.Clear();
            fillDatagrid = GetDataList().AsDataView();
            foreach (var movie in fillDatagrid)
            {
                datagridList.Items.Add(movie);
            }
        }


        private void a_ver(object sender, RoutedEventArgs e)
        {
            datagridList.Items.Clear();

            DataTable dtMovies = new DataTable();

            MySqlCommand cmd;
            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=watchlistv4;uid=root;pwd=;";
            cnn = new MySqlConnection(connetionString);
            cnn.Open();

            using (MySqlCommand command3 = new MySqlCommand("SELECT filme.idfilme,filme.titulo,filme.duracao,filme.ano, utilizador_has_filme.rating, utilizador_has_filme.status FROM filme LEFT JOIN utilizador_has_filme ON filme.idfilme = utilizador_has_filme.filme_idfilme where utilizador_idutilizador='" + Session.Id + "' and status='A ver'", cnn))
            {
                MySqlDataReader reader3 = command3.ExecuteReader();
                dtMovies.Load(reader3);

            }
            cnn.Close();
            fillDatagrid = dtMovies.AsDataView();
            foreach (var movie in fillDatagrid)
            {
                datagridList.Items.Add(movie);
            }
        }

        private void Visto(object sender, RoutedEventArgs e)
        {
            datagridList.Items.Clear();

            DataTable dtMovies = new DataTable();

            MySqlCommand cmd;
            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=watchlistv4;uid=root;pwd=;";
            cnn = new MySqlConnection(connetionString);
            cnn.Open();

            using (MySqlCommand command3 = new MySqlCommand("SELECT filme.idfilme,filme.titulo,filme.duracao,filme.ano, utilizador_has_filme.rating, utilizador_has_filme.status FROM filme LEFT JOIN utilizador_has_filme ON filme.idfilme = utilizador_has_filme.filme_idfilme where utilizador_idutilizador='" + Session.Id + "' and status='Visto'", cnn))
            {
                MySqlDataReader reader3 = command3.ExecuteReader();
                dtMovies.Load(reader3);

            }
            cnn.Close();
            fillDatagrid = dtMovies.AsDataView();
            foreach (var movie in fillDatagrid)
            {
                datagridList.Items.Add(movie);
            }
        }

        private void Planeio_ver(object sender, RoutedEventArgs e)
        {
            datagridList.Items.Clear();

            DataTable dtMovies = new DataTable();

            MySqlCommand cmd;
            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=watchlistv4;uid=root;pwd=;";
            cnn = new MySqlConnection(connetionString);
            cnn.Open();

            using (MySqlCommand command3 = new MySqlCommand("SELECT filme.idfilme,filme.titulo,filme.duracao,filme.ano, utilizador_has_filme.rating, utilizador_has_filme.status FROM filme LEFT JOIN utilizador_has_filme ON filme.idfilme = utilizador_has_filme.filme_idfilme where utilizador_idutilizador='" + Session.Id + "' and status='Planeio ver'", cnn))
            {
                MySqlDataReader reader3 = command3.ExecuteReader();
                dtMovies.Load(reader3);

            }
            cnn.Close();
            fillDatagrid = dtMovies.AsDataView();
            foreach (var movie in fillDatagrid)
            {
                datagridList.Items.Add(movie);
            }
        }

        private void Largado(object sender, RoutedEventArgs e)
        {
            datagridList.Items.Clear();

            DataTable dtMovies = new DataTable();

            MySqlCommand cmd;
            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=watchlistv4;uid=root;pwd=;";
            cnn = new MySqlConnection(connetionString);
            cnn.Open();

            using (MySqlCommand command3 = new MySqlCommand("SELECT filme.idfilme,filme.titulo,filme.duracao,filme.ano, utilizador_has_filme.rating, utilizador_has_filme.status FROM filme LEFT JOIN utilizador_has_filme ON filme.idfilme = utilizador_has_filme.filme_idfilme where utilizador_idutilizador='" + Session.Id + "' and status='Largado'", cnn))
            {
                MySqlDataReader reader3 = command3.ExecuteReader();
                dtMovies.Load(reader3);

            }
            cnn.Close();
            fillDatagrid = dtMovies.AsDataView();
            foreach (var movie in fillDatagrid)
            {
                datagridList.Items.Add(movie);
            }
        }

        private void Em_pausa(object sender, RoutedEventArgs e)
        {
            datagridList.Items.Clear();

            DataTable dtMovies = new DataTable();

            MySqlCommand cmd;
            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=watchlistv4;uid=root;pwd=;";
            cnn = new MySqlConnection(connetionString);
            cnn.Open();

            using (MySqlCommand command3 = new MySqlCommand("SELECT filme.idfilme,filme.titulo,filme.duracao,filme.ano, utilizador_has_filme.rating, utilizador_has_filme.status FROM filme LEFT JOIN utilizador_has_filme ON filme.idfilme = utilizador_has_filme.filme_idfilme where utilizador_idutilizador='" + Session.Id + "' and status='Em pausa'", cnn))
            {
                MySqlDataReader reader3 = command3.ExecuteReader();
                dtMovies.Load(reader3);

            }
            cnn.Close();
            fillDatagrid = dtMovies.AsDataView();
            foreach (var movie in fillDatagrid)
            {
                datagridList.Items.Add(movie);
            }
        }

        private void Todos(object sender, RoutedEventArgs e)
        {
            datagridList.Items.Clear();

            fillDatagrid = GetDataList().AsDataView();
            foreach (var movie in fillDatagrid)
            {
                datagridList.Items.Add(movie);
            }
        }
    }
}
