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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Studente_per_un_giorno
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string nome = (txtnome.Text);
            string cognome = (txtcognome.Text);
            string data = db_data.SelectedDate.Value.ToLongDateString();
            lbl_ris.Content = $"ciao {nome} {cognome} il tuo compleanno è il {data} ";
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            btnPrint.IsEnabled = true;
        }
        private void CheckBox_UnChecked(object sender, RoutedEventArgs e)
        {
            btnPrint.IsEnabled = false;
        }

        private void btnPrint_Click(object sender, RoutedEventArgs e)
        {
            if (data = )
        }
    }
}
