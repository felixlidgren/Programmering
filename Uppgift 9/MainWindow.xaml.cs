using System;
using System.Collections.Generic;
using System.IO.Packaging;
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

namespace Uppgift_9
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

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            string Name = txtName.Text;
            int Age;
            Age = int.Parse(txtAge.Text);

            

            if (Age <= 6 && (bool) (rbtnAlone.IsChecked))
            { 
                lblControl.Content = $"Hej {Name}, du är {Age}år gammal och får se filmer som är barntillåtna.";
            }

            else if (Age > 6 && Age < 11 && (bool) (rbtnAlone.IsChecked)) 
            {
                lblControl.Content = $"Hej {Name}, du är {Age}år gammal och får se filmer med åldersgräns upp till 7år.";
            }

            else if (Age > 10 && Age < 14 && (bool)(rbtnAlone.IsChecked)) 
            {
                lblControl.Content = $"Hej {Name}, du är {Age}år gammal och får se filmer med åldersgräns upp till 11år.";
            }

            else if (Age == 15 && (bool)(rbtnAlone.IsChecked)) 
            {
                lblControl.Content = $"Hej {Name}, du är {Age}år gammal och får se filmer med åldersgräns upp till 15år.";
            }

            else if (Age > 15 && (bool)(rbtnAlone.IsChecked)) 
            { 
                lblControl.Content = $"Hej {Name}, du är {Age}år gammal och får se alla filmer."; 
            }


          

            if (Age <= 6 && (bool)(rbtnAdult.IsChecked))
            {
                lblControl.Content = $"Hej {Name}, du är {Age}år gammal och i vuxet sällskap. Du får se filmer med åldersgräns upp till 7år.";
            }

            else if (Age > 6 && Age < 11 && (bool)(rbtnAdult.IsChecked))
            {
                lblControl.Content = $"Hej {Name}, du är {Age}år gammal och i vuxet sällskap. Du får se filmer med åldersgräns upp till 11år.";
            }

            else if (Age > 10 && Age < 14 && (bool)(rbtnAdult.IsChecked))
            {
                lblControl.Content = $"Hej {Name}, du är {Age}år gammal och i vuxet sällskap. Du får se filmer med åldersgräns upp till 15år.";
            }

            
            
            
            

            
            
            
            


        }


    }
}
