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

namespace Uppgift12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
        
    {
        int [] value = new int[5]; 
        int count = 0;
        
        


        public MainWindow()
        {
            InitializeComponent();
           
            if (count == 0)
            {
                btnClear.IsEnabled = false;

            }
            txtNumbers.Focus();
                        
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (count < 5)
            {
                value[count] = int.Parse(txtNumbers.Text);
                count++;
                txtNumbers.Focus();
            }

            listBoxValues.ItemsSource = null;
            listBoxValues.ItemsSource = value;

                     
            double sum = value[0] + value[1] + value[2] + value[3] + value[4];
            double medelvärde = sum / 5.0;

            txtMidValue.Text = medelvärde.ToString();
              
            if (count == 5)
            {
                btnOk.IsEnabled = false;
            }
            if (count > 0)
            {
                btnClear.IsEnabled = true;
            }
           
                                   
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            Array.Clear(value, 0, value.Length);
            txtMidValue.Clear();
            txtNumbers.Clear();
            listBoxValues.ItemsSource = null;
            count = 0;
            btnOk.IsEnabled = true;
            btnClear.IsEnabled = false;
            txtNumbers.Focus();
        }
    }



}
