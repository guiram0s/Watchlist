using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace WatchList
{
    class moviePanel : WrapPanel
    {
        private string _image;
        private string _title;
        private string _Id;

        Label title = new Label();
        Image image = new Image();

        public string Id
        {
            get
            {
                return _Id;
            }

            set
            {
                _Id = value;
            }
        }

        public string Image
        {
            get
            {
                return _image;
            }

            set
            {
                _image = value;
                if (_image != null)
                {
                    System.IO.DirectoryInfo directory = new DirectoryInfo(_image);
                    var a = directory.FullName;
                    a = a.Replace(@"\", "/");
                    string s = a.Substring(0, a.IndexOf("bin"));
                    string final = s + "Contents/"+ _image;
                    image.Source = new BitmapImage(new Uri(final));

                }
            }
        }
        public string Title
        {
            get
            {
                return _title;
            }

            set
            {
                _title = value;
                if (_title != null)
                {
                    title.Content = _title;
                    
                }
            }
        }


        public moviePanel()
        {
            image.Width = 135;
            image.Height = 190;
            image.Stretch = Stretch.Fill;
            title.Width = 145;
            var converter = new System.Windows.Media.BrushConverter();
            var brush = (Brush)converter.ConvertFromString("#FFFFFF");
            title.Foreground = brush;
            title.FontSize = 12;
            
            image.MouseDown += (sender, args) =>
            {
                var id_ = this.Id;
                var newWindow = new MovieWindow(id_);
                newWindow.Show();
            };

            Create();

        }

        private void Create()
        {

            this.Children.Add(title);
            this.Children.Add(image);
        }
    }
}
