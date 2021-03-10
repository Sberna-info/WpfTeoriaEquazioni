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
    /// Logica di interazione per Impossibile.xaml
    /// </summary>
    public partial class Impossibile : Window
    {
        public Impossibile()
        {
            InitializeComponent();
        }

        private void bntCalcola_Click(object sender, RoutedEventArgs e)
        {
            try
            {


                int a1 = int.Parse(txtA.Text);
                int b1 = int.Parse(txtB.Text);
                bool b2 = IsInconsisted(a1, b1);
                if (b2)
                    lblRisultato.Content = "l'equazione è impossibile";
                else
                    lblRisultato.Content = "l'equazione non è impossibile";
            }catch(Exception)
            {
                MessageBox.Show("Prima di premere il bottone inserisci cosa ti chiede il problema", "Errore", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private static bool IsInconsisted(double a, double b)
        {
            return (a == 0 && b == 0);
        }
    }
}
