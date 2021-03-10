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
    /// Logica di interazione per EquazioneSecondo.xaml
    /// </summary>
    public partial class EquazioneSecondo : Window
    {
        public EquazioneSecondo()
        {
            InitializeComponent();
        }

        private void bntCalcola_Click(object sender, RoutedEventArgs e)
        {
            try
            {


                int a4 = int.Parse(txtA.Text);
                int b6 = int.Parse(txtB.Text);
                int c1 = int.Parse(txtC.Text);
                string s = Equazione(a4, b6, c1);
                lblRisultato.Content = s;
            }
            catch (Exception)
            {
                MessageBox.Show("Prima di premere il bottone inserisci cosa ti chiede il problema", "Errore", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private static string Equazione(int a, int b, int c)
        {
            double delta = (b * b) - (4 * a * c);
            double x1 = 0;
            double x2;
            if (delta == 0)
                return $"x - {x1}";
            else if (delta < 0)
                return "l'equazione è Impossibile";
            else
            {
                x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                return $"x1 - {x1} x2 - {x2}";
            }
        }
    }
}
