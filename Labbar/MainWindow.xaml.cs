using System.Windows;

namespace Labbar
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
        //event handler när klickar på knappen ska ett hello message uppkomma
        private void BtnHelloMessage_Click(object sender, RoutedEventArgs e)
        {
            //Hit kommer användaren när knappen klickats
            // Använd en messagebox
            //MessageBox är ett objekt programmeringsspråket är i objekt
            // objekt kan ha egenskaper och objekt kan ha metoder och kan göra något
            //Lådorna indeikerar att det är metoder
            //Alla metoder har ALLTID parentes

            MessageBox.Show("Du tryckte på mig!");

            // Lär dig att använda debuggern!!!!!
            // Klicka i det grå fältet
        }
    }
}
