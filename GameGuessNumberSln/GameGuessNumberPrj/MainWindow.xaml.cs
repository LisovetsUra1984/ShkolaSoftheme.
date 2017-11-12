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

namespace GameGuessNumberPrj
{
    
   

    public partial class MainWindow : Window
    {
        byte rndNumber;
        byte guessTryCount = 2;
        byte guessTry;

        private void GenerateRnd()
        {
            Random rnd = new Random();
            rndNumber = (byte)rnd.Next(1, 10);
           
        }
          
        public MainWindow()
        {
            InitializeComponent();
            GenerateRnd();

        }

        private void checkBtn_Click(object sender, RoutedEventArgs e)
        {
            byte UserNumber;
            try
            {
                UserNumber = byte.Parse(UserNumberTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show(" Enter only one integer from 1 до 10!!!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                UserNumberTextBox.Text = "";
                return;
                //throw;
            }

            if (rndNumber == UserNumber)
            {
                MessageBox.Show("Congratulations!!!!\rYou guessed the number!!!\rPrize-winning game!!!");
                guessTry = 0;
                GenerateRnd();
            }
            else
            {
                guessTry++;
                MessageBox.Show("You did not guess the number!!!\rTrue № " + guessTry.ToString());
                if (guessTry > guessTryCount)
                {
                    guessTry = 0;
                    GenerateRnd();
                }
            }

            UserNumberTextBox.Text = "";
        }
    }
}


 