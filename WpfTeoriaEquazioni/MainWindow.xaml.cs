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
            try
            {
                string str = Convert.ToString(txtInserisci.Text);
                switch (str)
                {
                    case "1":
                        int a = int.Parse(txtA.Text);
                        bool b = IsDetermined(a);
                        if (b)
                            lblRisultato.Content = "l'equazione è determinata";
                        else
                            lblRisultato.Content = "l'equazione non è determinata";
                        break;

                    case "2":
                        int a1 = int.Parse(txtA.Text);
                        int b1 = int.Parse(txtB.Text);
                        bool b2 = IsInconsisted(a1, b1);
                        if (b2)
                            lblRisultato.Content = "l'equazione è impossibile";
                        else
                            lblRisultato.Content = "l'equazione non è impossibile";
                        break;

                    case "3":
                        int a2 = int.Parse(txtA.Text);
                        bool b3 = IsDegree2(a2);
                        if (b3)
                            lblRisultato.Content = "è di secondo grado";
                        else
                            lblRisultato.Content = "non è di secondo grado";
                        break;

                    case "4":
                        int a3 = int.Parse(txtA.Text);
                        int b4 = int.Parse(txtB.Text);
                        int c = int.Parse(txtC.Text);
                        double b5 = Delta(a3, b4, c);
                        lblRisultato.Content = $"Il delta è: {b5} ";
                        break;
                    case "5":
                        int a4 = int.Parse(txtA.Text);
                        int b6 = int.Parse(txtB.Text);
                        int c1 = int.Parse(txtC.Text);
                        string s = Equazione(a4, b6, c1);
                        lblRisultato.Content = s;
                        break;

                    case "6":
                        double a5 = int.Parse(txtA.Text);
                        double b7 = int.Parse(txtB.Text);
                        string s1 = EquationDegree1(a5, b7);
                        lblRisultato.Content = s1;
                        break;


                    default:
                        lblRisultato.Content = "valore inserito non valido";
                        break;

                }
            }catch(Exception)
            {
                lblRisultato.Content = "prima di premere il bottone inserisci\ncosa ti chiede il problema";
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

        private static bool IsDegree2(double a)
        {
            return a != 0;
        }

        private static double Delta(int a, int b, int c)
        {
            return (b * b) - (4 * a * c);
        }

        private static string Equazione(int a, int b, int c)
        {
            double x1 = 0;
            double x2;
            double delta = Delta(a, b, c);
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
