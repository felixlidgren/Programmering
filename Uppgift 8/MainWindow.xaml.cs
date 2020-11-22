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

namespace Uppgift_8
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

        private void btnSum_Click(object sender, RoutedEventArgs e)
        {
            double knutingar = 0.1257, siklar = 3.64, galleoner = 62.02, Sumtotal;

            knutingar = double.Parse(txtBox1.Text)*0.1257;
            siklar = double.Parse(txtBox2.Text)*3.64;
            galleoner = double.Parse(txtBox3.Text)*62.02;
            Sumtotal = knutingar + siklar + galleoner;

            Sumtotal = Math.Round(Sumtotal, 0);

            lblSek.Content = $"{Sumtotal} SEK";
        }
    }
}
