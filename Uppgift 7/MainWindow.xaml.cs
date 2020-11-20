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

namespace Uppgift_7
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int nrOne = 0, nrTwo = 0, helTal = 0, rest = 0;

            nrOne = int.Parse(txtBoxOne.Text);
            nrTwo = int.Parse(txtBoxTwo.Text);
            helTal = nrOne / nrTwo;
            rest = nrOne % nrTwo;

            txtBoxHeltal.Text = helTal.ToString();
            txtBoxRest.Text = rest.ToString();

                  }
    }
}
