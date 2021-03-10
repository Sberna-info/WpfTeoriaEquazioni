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
    /// Logica di interazione per Delta.xaml
    /// </summary>
    public partial class Delta : Window
    {
        public Delta()
        {
            InitializeComponent();
        }

        private void bntCalcola_Click(object sender, RoutedEventArgs e)
        {
            try
            {


                int a3 = int.Parse(txtA.Text);
                int b4 = int.Parse(txtB.Text);
                int c = int.Parse(txtC.Text);
                double b5 = Delta1(a3, b4, c);
                lblRisultato.Content = $"Il delta è: {b5} ";
            }catch(Exception)
            {
                MessageBox.Show("Prima di premere il bottone inserisci cosa ti chiede il problema", "Errore", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private static double Delta1(int a, int b, int c)
        {
            return (b * b) - (4 * a * c);
        }
    }
}
