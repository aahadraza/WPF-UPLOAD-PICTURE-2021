using System;
using System.Windows;
using System.Windows.Media.Imaging;
using Microsoft.Win32;

namespace WpfSavePhotoToOracle
{
    /// <summary>  
    /// Interaction logic for Window1.xaml  
    /// </summary>  
    public partial class Window1 : Window
    {
        private object imgPhoto;

        public Window1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true)
            {
                imgPhoto = new BitmapImage(new Uri(op.FileName));
            }

        }
    }
}
