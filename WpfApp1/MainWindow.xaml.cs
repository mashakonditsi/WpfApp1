using System;
using Microsoft.Win32;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window2 window = new Window2();
            window.Show();
            this.Close();

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ПРиложение zакрылось");
            Application.Current.Shutdown();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
           OpenFileDialog openFileDialog = new OpenFileDialog { Filter = "ImageFiles| *.jpg; *.jpeg; *.png; *.gif; *bmp;"};
            if(openFileDialog.ShowDialog()==true)
            {
                BitmapImage bitmapImage = new BitmapImage(new Uri(openFileDialog.FileName));    
                DisplayImage.Source= bitmapImage;

            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            kostyanolegovich window = new kostyanolegovich();
            window.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            masa window = new masa();
            window.Show();
            this.Close();
        }
    }
}
