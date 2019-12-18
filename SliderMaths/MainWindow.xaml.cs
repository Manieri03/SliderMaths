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

namespace SliderMaths
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

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            txtn1.IsEnabled = true;
            txtn2.IsEnabled = true;
            txtdiv.IsEnabled = true;
            txtmol.IsEnabled = true;
            txtsom.IsEnabled = true;
            txtsot.IsEnabled = true;
            slid1.IsEnabled = true;
            slid2.IsEnabled = true;
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            txtn1.IsEnabled = false;
            txtn2.IsEnabled = false;
            txtdiv.IsEnabled = false;
            txtmol.IsEnabled = false;
            txtsom.IsEnabled = false;
            txtsot.IsEnabled = false;
            slid1.IsEnabled = false;
            slid2.IsEnabled = false;
        }

        private void slid1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double n1 = (double)slid1.Value;
            double n2= (double)slid2.Value;


            double somma = n1+n2;
            txtsom.Text = somma.ToString();

            
            double molt = n1 * n2;
            txtmol.Text = molt.ToString();

            double sot = n1 - n2;
            txtsot.Text = sot.ToString();

            if (n2<=0)
            {
                txtdiv.Text = "Impossibile";
            }
            else
            {
                double div = n1 / n2;
                txtdiv.Text = div.ToString();
            }
        
        }

        private void slid2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double n1 = (double)slid1.Value;
            double n2 = (double)slid2.Value;
            double somma = n1 + n2;
            txtsom.Text = somma.ToString();

            double molt = n1 * n2;
            txtmol.Text = molt.ToString();

            double sot = n1 - n2;
            txtsot.Text = sot.ToString();

            if (n2 <= 0)
            {
                txtdiv.Text = "Impossibile";
            }
            else
            {
                double div = n1 / n2;
                txtdiv.Text = div.ToString();
            }
        }
    }
}
