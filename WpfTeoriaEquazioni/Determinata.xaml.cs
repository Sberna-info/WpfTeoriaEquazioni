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

namespace WpfTeoriaEquazioni
{
    /// <summary>
    /// Logica di interazione per Determinata.xaml
    /// </summary>
    public partial class Determinata : Window
    {
        public Determinata()
        {
            InitializeComponent();
        }

        private void bntCalcola_Click(object sender, RoutedEventArgs e)
        {
            try
            {


                double a = double.Parse(txtA.Text);
                bool b = IsDetermined(a);
                if (b)
                    lblRisultato.Content = "L'equazione è determinata";
                else
                    lblRisultato.Content = "L'equazione non è determinata";
            }catch(Exception)
            {
                MessageBox.Show("Prima di premere il bottone inserisci cosa ti chiede il problema", "Errore", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private static bool IsDetermined(double a)
        {
            return a != 0;
        }
    }
}
