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

namespace WpfTeoriaEquazioni
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void bntCalcola_Click(object sender, RoutedEventArgs e)
        {

            

                if (rbtDeterminata.IsChecked == true)
                {
                    Determinata det = new Determinata();
                    det.Show();
                }

                else if(rbtImpossibile.IsChecked == true)
                {
                    Impossibile imp = new Impossibile();
                    imp.Show();
                }


                else if(rbtSecondoGrado.IsChecked == true)
                {
                    Degree2 degree = new Degree2();
                    degree.Show();
                }
                

                else if(rbtDelta.IsChecked == true)
                {
                    Delta delta = new Delta();
                    delta.Show();
                }
                

                else if (rbtEquazione2.IsChecked == true)
                {
                    EquazioneSecondo equazione = new EquazioneSecondo();
                    equazione.Show();

                }
                
                else if(rbtEquazione1.IsChecked == true)
                {
                    EquazionePrimo equazione1 = new EquazionePrimo();
                    equazione1.Show();

                }
                else
                    MessageBox.Show("Prima di premere il bottone seleziona cosa vuoi fare", "Errore", MessageBoxButton.OK, MessageBoxImage.Error);


        }



       

        
    }
}
