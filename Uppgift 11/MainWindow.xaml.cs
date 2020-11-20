using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace Uppgift_11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        int changeValue = 5;

        public MainWindow()
        {
            InitializeComponent();

            progressBar.Value = (int)progressBar.Value;

            progressBar.Value = 50;
        }

       
        private void btnGood_Click(object sender, RoutedEventArgs e)
        {
            
           progressBar.Value = progressBar.Value + changeValue;

            lblValue.Content = $"{progressBar.Value} %";
        }

        private void btnBad_Click(object sender, RoutedEventArgs e)
        {
            progressBar.Value = progressBar.Value - changeValue;

            lblValue.Content = $"{progressBar.Value} %"; 
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            string value = txtNumber.Text;
            int number = 0, correct = 0;
            int randomNumber = 0;

            number = int.Parse(value);

            int chance = Convert.ToInt32(progressBar.Value);


            Random numOfTries = new Random();
           
            

            for (int i = 0; i < number; i++)
            {
                randomNumber = numOfTries.Next(100);
                if (randomNumber <= chance)
                {
                    correct++;
                }

                
            }

               
            lblRightWay.Content = $"{number - correct} på rätt håll!";
            lblWrongWay.Content = $"{correct} på fel håll!";

                                              
          
                        
        }
    }
}
