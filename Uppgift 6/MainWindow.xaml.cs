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

namespace Uppgift_6
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

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            double boxOne = 0, boxTwo = 0, boxSum = 0;


            boxOne = double.Parse(txtBoxOne.Text);
            boxTwo = double.Parse(txtBoxTwo.Text);
            boxSum = boxOne + boxTwo;

            txtBoxSum.Text = Math.Round (boxSum, 2).ToString();

            lblNamn.Content = "Summa";
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            double boxOne = 0, boxTwo = 0, boxSum = 0;

            boxOne = double.Parse(txtBoxOne.Text);
            boxTwo = double.Parse(txtBoxTwo.Text);
            boxSum = boxOne - boxTwo;

            txtBoxSum.Text = Math.Round (boxSum, 2).ToString();

            lblNamn.Content = "Differens";
        }

        private void btnMult_Click(object sender, RoutedEventArgs e)
        {
            double boxOne = 0, boxTwo = 0, boxSum = 0;
          
            boxOne = double.Parse(txtBoxOne.Text);
            boxTwo = double.Parse(txtBoxTwo.Text);
            boxSum = boxOne * boxTwo;

            txtBoxSum.Text = Math.Round (boxSum, 2).ToString();

            lblNamn.Content = "Produkt";


        }

        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {
            double boxOne = 0, boxTwo = 0, boxSum = 0;

            boxOne = double.Parse(txtBoxOne.Text);
            boxTwo = double.Parse(txtBoxTwo.Text);
            boxSum = boxOne / boxTwo;

            txtBoxSum.Text = Math.Round (boxSum, 2).ToString();

            lblNamn.Content = "Kvot";

        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtBoxOne.Clear();
            txtBoxTwo.Clear();
            txtBoxSum.Clear();

            lblNamn.Content = "Resultat";
           
        }
    }
}
