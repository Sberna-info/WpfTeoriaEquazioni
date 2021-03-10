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
    /// Logica di interazione per EquazionePrimo.xaml
    /// </summary>
    public partial class EquazionePrimo : Window
    {
        public EquazionePrimo()
        {
            InitializeComponent();
        }

        private void bntCalcola_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                double a5 = int.Parse(txtA.Text);
                double b7 = int.Parse(txtB.Text);
                string s1 = EquationDegree1(a5, b7);
                lblRisultato.Content = s1;
            }catch(Exception)
            {
                MessageBox.Show("Prima di premere il bottone inserisci cosa ti chiede il problema", "Errore", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        
        private static bool IsDetermined(double a)
        {
            return a != 0;
        }
        private static bool IsInconsisted(double a, double b)
        {
            return (a == 0 && b == 0);
        }
        private static string EquationDegree1(double a, double b)
        {
            if (IsDetermined(a))
            {
                double x = b / a;
                return $"x - {x}";
            }
            else if (IsInconsisted(a, b))
            {
                return "l'equazione è Impossibile";
            }
            return "l'equazione è indeterminata";
        }
    }
}
