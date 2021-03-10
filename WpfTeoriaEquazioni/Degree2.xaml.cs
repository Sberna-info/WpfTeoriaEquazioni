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
    /// Logica di interazione per Degree2.xaml
    /// </summary>
    public partial class Degree2 : Window
    {
        public Degree2()
        {
            InitializeComponent();
        }

        private void bntCalcola_Click(object sender, RoutedEventArgs e)
        {
            try
            {


                int a2 = int.Parse(txtA.Text);
                bool b3 = IsDegree2(a2);
                if (b3)
                    lblRisultato.Content = "l'equazione è di secondo grado";
                else
                    lblRisultato.Content = "l'equazione non è di secondo grado";
            }catch(Exception)
            {
                MessageBox.Show("Prima di premere il bottone inserisci cosa ti chiede il problema", "Errore", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private static bool IsDegree2(double a)
        {
            return a != 0;
        }
    }
}
