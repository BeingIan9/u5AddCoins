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

namespace U5AddCoins
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Global Variables
        int toonies = new int();
        int loonies = new int();
        int quarters = new int();
        int dimes = new int();
        int nickels = new int();
        double toonievalue = 2;
        double loonievalue = 1;
        double quartervalue = 0.25;
        double dimevalue = 0.10;
        double nickelvalue = 0.05;
        double totalvalue;
       

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(txttoonies.Text, out toonies);
            int.TryParse(txtloonies.Text, out loonies);
            int.TryParse(txtquarters.Text, out quarters);
            int.TryParse(txtdimes.Text, out dimes);
            int.TryParse(txtnickels.Text, out nickels);

            totalvalue = toonies * toonievalue;
            totalvalue = totalvalue + loonies * loonievalue;
            totalvalue = totalvalue + quarters * quartervalue;
            totalvalue = totalvalue + dimes * dimevalue;
            totalvalue = totalvalue + nickels * nickelvalue;

            if(totalvalue < 5)
            {
                lbloutput.Content = "The total value of your coins is $" + totalvalue + ", Yikes someone needs to learn how to save!";
            }
            else if(5 < totalvalue)
            {
                lbloutput.Content = "The total value of your coins is $" + totalvalue + ", Wow look at the big bucks!";
            }
          


            
        }
    }
}
