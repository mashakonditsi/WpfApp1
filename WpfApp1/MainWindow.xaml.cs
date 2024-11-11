﻿using System;
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
        private string imgsourse1 = @"\\sysprofiles.adm.vvsu.ru\STUDENTRPROFILES$\volohma\Downloads\png-transparent-blue-pepsi-can-pepsi-soft-drink-coca-cola-beer-pepsi-blue-food-electric-blue-thumbnail.png";
        private string imgsourse2 = @"\\sysprofiles.adm.vvsu.ru\STUDENTRPROFILES$\volohma\Downloads\017def90128415.5e0e88c6d3df0.png";
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

        
    }
}
