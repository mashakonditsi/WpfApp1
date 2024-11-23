using System;
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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для kostyanolegovich.xaml
    /// </summary>
    public partial class kostyanolegovich : Window
    {
        public kostyanolegovich()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (RadioBut.IsChecked == true)
            {
                MessageBox.Show("wrong");
            }
        }
    }
}
