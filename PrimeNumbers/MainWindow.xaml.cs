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

namespace PrimeNumbers
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

     
        private void Clicked(object sender, RoutedEventArgs e)
        {
            int v =0;
            int.TryParse(val.Text,out v);
            v = v + 1;
           
            bool[] tab1 = new bool[Convert.ToInt32(v)];
            
            for (int i=1; i<=v; i++)
            {
                tab1[i - 1] = true;
            }

            double sqrt = (Math.Sqrt(v));

           // wykreślanie liczb złożonych
            for (int i = 2; i < sqrt; i++)
            {
                for (int k = i; k < tab1.Length; k += i)
                {
                    if (k != i)
                    {
                        tab1[k] = false;
                    }
                }
            }
            string to_return = String.Empty;
            //wypisanie liczb pierwszych
            int counter = 0;
            for (int i = 2; i < tab1.Length; i++)
            {
                if (tab1[i] == true)
                {
                    to_return += i;
                    to_return += " ";
                    counter++;
                    if (counter % 5 == 0)
                    {
                        to_return += "\n";
                    }
                }
            }
            output o = new output();
            o.Prime.Text = to_return;
            o.Show();
            //MessageBox.Show(to_return, "Prime numbers");
        }
    }
}
