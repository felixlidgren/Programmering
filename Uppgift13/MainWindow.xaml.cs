using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
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

namespace Uppgift13
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            txtChar.Focus();
        }


        private void btnCount_Click(object sender, RoutedEventArgs e)
        {
            int antalBokstäver = 0;
            char letter = char.Parse(txtChar.Text);
            string text = txtText.Text;


            string[] numbers = { txtText.Text };


            foreach (char rightletter in text) 
            {
                if (rightletter == letter) 
                { 
                    antalBokstäver++; 
                }
                                    
            }
            lblText.Content = $"Det fanns {antalBokstäver}st av bokstaven {letter} i din text";
        }
    }
}
