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

namespace Uppgift_5
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

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            int boxOne, boxTwo, boxSum;
            boxOne = int.Parse(txtBoxOne.Text);
            boxTwo = int.Parse(txtBoxTwo.Text);

            boxSum = boxOne + boxTwo;

            txtBoxSum.Text = boxSum.ToString();


        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            txtBoxOne.Clear();
            txtBoxTwo.Clear();
            txtBoxSum.Clear();
        }
    }
}
