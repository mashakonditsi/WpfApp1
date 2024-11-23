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
    /// Логика взаимодействия для masa.xaml
    /// </summary>
    public partial class masa : Window
    {
        public masa()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int balls = 0;
              if (RadioBut3.IsChecked == true)
                {
                balls++;
                }
            if (RadioButt2.IsChecked == true)
            {
                balls++;
            }
            if (RadioButto.IsChecked == true)
            {
                balls++;
            }
            if (RadioButton3.IsChecked == true)
            {
                balls++;
            }
            if (balls == 0)
            {
                MessageBox.Show(" капец 0");
            }
            else if (balls == 1)
            {
                MessageBox.Show(" у вас 1");
            }
            else if (balls == 2)
            {
                MessageBox.Show(" normas pivas 2");
            }
            else if (balls == 3)
            {
                MessageBox.Show(" три правильно ");
            }
            else if (balls == 4)
            {
                MessageBox.Show(" legenda 4 pravilno");
            }

        }
    }
}
