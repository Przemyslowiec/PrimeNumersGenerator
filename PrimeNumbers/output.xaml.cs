using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace PrimeNumbers
{
    /// <summary>
    /// Interaction logic for output.xaml
    /// </summary>
    public partial class output : Window
    {
        public output()
        {
            InitializeComponent();
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "defalutfilename.txt";
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            string[] st = Prime.Text.Split('\n');
            if (saveFileDialog.ShowDialog() == true)
                //File.WriteAllText();
            File.WriteAllLines(saveFileDialog.FileName, st);
        }
    }
}
