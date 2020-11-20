using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
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

namespace Uppgift_10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();
        int randomNumber;
        int antalGissningar;

           
                
        public MainWindow()
        {
            InitializeComponent();
            
            btnGuess.IsEnabled = false;
            
        }

        private void btnRandomizer_Click(object sender, RoutedEventArgs e)
        {
            
            randomNumber = random.Next(0, 1000);

            btnGuess.IsEnabled = true;
                       
        }

        private void btnGuess_Click(object sender, RoutedEventArgs e)
        {


            antalGissningar++;
                
                        
            string number = txtBox.Text;
            int guess = int.Parse(number);

            int hundra = 100;
            
            
            if (guess == randomNumber)
            {
                lblAnswer.Content = $"Grattis!!! Du gissade rätt på " + antalGissningar + " försöket!";
            }

            else if (guess > hundra + randomNumber )
            { lblAnswer.Content = "Din gissning var alldeles för stor."; }

            else if (guess < randomNumber - hundra )
            { lblAnswer.Content = "Din gissning var alldeles för liten."; }

            else if (guess > randomNumber && guess < randomNumber + hundra )
            { lblAnswer.Content = "Din gissning var lite för stor."; }

            else if ( guess < randomNumber && guess > randomNumber - hundra)
            { lblAnswer.Content = "Din gissning var lite för liten ."; }

        }

    }
}
