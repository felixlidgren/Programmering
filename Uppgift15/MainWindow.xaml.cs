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

namespace Uppgift15
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int vokaler = 0;
        char[] smallVowels = { 'a', 'e', 'i', 'o', 'u', 'y', 'å', 'ä', 'ö' };
        char[] bigVowels = { 'A', 'E', 'I', 'O', 'U', 'Y', 'Å', 'Ä', 'Ö' };
        string allVowels = "aouåeiyäöAOUÅEIYÄÖ";

        public MainWindow()
        {
            InitializeComponent();

           
        }
            public bool IsVowel(char Vokal) 
            {
                
                bool aVowel = false;

                foreach (char vok in allVowels)
                {
                    if (vok == Vokal)
                    {
                        aVowel = true;
                        break;

                    }
                }
                return aVowel;
            }
                   
            private int NumberOfvowels(string HittaVokaler)
            {

                string text = txtBox.Text;

                foreach (char vowels in HittaVokaler)
                {

                for (int i = 0; i < smallVowels.Length; i++)
                {

                        if (vowels == smallVowels[i] || vowels == bigVowels[i])
                        {
                            vokaler++;
                        }

                    }

                }

                return vokaler;

            }



            public string ConvertLetter(string HittaVokaler)
            {
                string converter = "";
                



                foreach (char character in HittaVokaler)
                {
                    bool vow = BigVowels(character);
                    bool smallVow = SmallVowels(character);

                    if (vow == true) 
                    {
                         converter += "Ö";
                    }
                        
                    else if (smallVow == true) 
                    {
                        converter += "ö";
                    }

                    else
                    {
                        converter += character.ToString();
                    }
                }
                return converter;


            }

        public bool BigVowels(char letter)
        {

            string big = "AOUÅEIYÄÖ";
            
            bool ifBig = false;
            


            foreach (char vow in big)
            {
                if (vow == letter)
                {
                    ifBig = true;
                    break;
                }
                
            }
            return ifBig;
        }
        
        public bool SmallVowels (char letter) 
        { 
            string small = "aouåeiyäö";
            bool ifSmall = false;

                foreach (char vow in small)
                { 
                    if (vow == letter)
                    {
                        ifSmall = true;
                        break;

                    }

                    
                }
                return ifSmall;
        }

            private void btnConvert_Click(object sender, RoutedEventArgs e)
            {
                lblVowels.Content = $"Antal vokaler i texten är: {NumberOfvowels(txtBox.Text)}";
                vokaler = 0;

                lblConvert.Content = ConvertLetter(txtBox.Text);
            
            }
    }
}
