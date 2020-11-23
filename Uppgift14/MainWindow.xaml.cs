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

namespace Uppgift14
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int[] letter = new int[3];
        public MainWindow()
        {
            InitializeComponent();
        }

        private bool Birth(string Age)
        {
            string birth = txtAge.Text;
            int year = DateTime.Now.Year;
            

            if (string.Concat(birth).All(char.IsDigit))
            {

                int age = int.Parse(txtAge.Text);
                int Sum = year - age;

                MessageBox.Show($"Du är {Sum}år gammal.");
                return Age;

            }

            else if 
            {
                MessageBox.Show("Du kan enbart använda siffror");
                return Age;
            }
        }







        private void Button_Click(object sender, RoutedEventArgs e)
        {

            





        }
    }

}
