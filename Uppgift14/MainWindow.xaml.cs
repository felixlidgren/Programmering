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
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private bool Birth(string Age)
        {
            bool birth = true;


            foreach (char number in Age)
            {
                if (char.IsLetter(number) == false)
                {

                    birth = true;

                }
                else
                {
                    birth = false;
                    break;
                }
                
            }
            return birth;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string birthYear = txtAge.Text;
            bool newNumbers = Birth(birthYear);

            if (newNumbers == true)
            {
                int age = DateTime.Now.Year - int.Parse(txtAge.Text);
                MessageBox.Show($"Du är {age} år.");
            }
            else if (newNumbers == false)
            {
                MessageBox.Show("Du får enbart mata in siffror");
            }


        }
    }

}
