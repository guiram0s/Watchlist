﻿using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for DiscoveryView.xaml
    /// </summary>
    public partial class DiscoveryView : UserControl
    {
        private delegate void DELEGATE();
        BackgroundWorker worker;
        public DiscoveryView()
        {
            InitializeComponent();
            worker = new BackgroundWorker();
            DiscoveryView_Load();
        }

        private void DiscoveryView_Load()
        {
            worker.DoWork += worker_DoWork;
            worker.RunWorkerAsync();
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            Delegate del = new DELEGATE(CreateLayout);
            this.Dispatcher.Invoke(del);
        }

        public void CreateLayout()
        {
            var id="";
            MySqlCommand cmd;
            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=watchlistv4;uid=root;pwd=;";
            cnn = new MySqlConnection(connetionString);
            cnn.Open();



            cmd = new MySqlCommand("select titulo,imagem,idFilme from Filme", cnn);
            MySqlDataReader reader = cmd.ExecuteReader();

            List<string[]> content = new List<string[]>();
            while (reader.Read())
            {

                string[] fields = new string[3];
                fields[0] = reader["titulo"].ToString();

                var cnt = reader["imagem"].ToString();
                fields[1] = cnt;
                fields[2] = reader["idFilme"].ToString();
                content.Add(fields);
            }
  
            foreach (string[] fields in content)
            {
                moviePanel movie = new moviePanel();
                movie.Id = fields[2];
                movie.Title = fields[0];
                movie.Image = fields[1];
                movie.Height = 230;
                movie.Width = 150;
                joe.Children.Add(movie);
                
            }
        }

        private void show(object sender, RoutedEventArgs e)
        {
            joe.Children.Clear();
            var a =searchComboBox.Text;
            var id = "";
            MySqlCommand cmd;
            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=watchlistv4;uid=root;pwd=;";
            cnn = new MySqlConnection(connetionString);
            cnn.Open();



            cmd = new MySqlCommand("SELECT filme.idfilme,filme.titulo,filme.imagem FROM filme JOIN filme_has_genero ON filme.idfilme = filme_has_genero.filme_idfilme JOIN genero ON filme_has_genero.filme_idfilme = genero.idgenero WHERE filme_has_genero.genero_idgenero = (select idgenero from genero where nome  = '" + a + "'); ", cnn);
            MySqlDataReader reader = cmd.ExecuteReader();

            List<string[]> content = new List<string[]>();
            while (reader.Read())
            {

                string[] fields = new string[3];
                fields[0] = reader["titulo"].ToString();

                var cnt = reader["imagem"].ToString();
                fields[1] = cnt;
                fields[2] = reader["idFilme"].ToString();
                content.Add(fields);
            }

            foreach (string[] fields in content)
            {
                moviePanel movie = new moviePanel();
                movie.Id = fields[2];
                movie.Title = fields[0];
                movie.Image = fields[1];
                movie.Height = 230;
                movie.Width = 150;
                joe.Children.Add(movie);

            }
        }
    }
}
