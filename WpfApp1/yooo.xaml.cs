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
    /// Логика взаимодействия для yooo.xaml
    /// </summary>
    public partial class yooo : Window
    {
        public yooo()
        {
            InitializeComponent();
        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DatePicker datePicker = (DatePicker)sender;
            
           
        }

        private void cal_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            Calendar cal = (Calendar)sender;
            TB1.Text = cal.SelectedDate.Value.ToShortDateString();
        }
    }
}
