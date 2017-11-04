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

namespace registration_form
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void canselbtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private bool OnlyLettersLessThen255(string str)
        {
            bool cond1 = false;
            cond1 = str.Length < 255;

            bool cond2 = true;
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                if (System.Char.IsLetter(ch) == false) cond2 = false;


            } 
            return cond1 && cond2;
        }

        private void register_btn_Click(object sender, RoutedEventArgs e)
        {
            //Для поля First Name
            if (!OnlyLettersLessThen255(FirstNameTextBox.Text))
            {
                MessageBox.Show("There are error in First Name.");
            }

            //Для поля Last Name
            if (!OnlyLettersLessThen255(LastNameTextBox.Text))
            {
                MessageBox.Show("There are error in Last Name.");
            }

            //Для поля Birth Date
            if (!OnlyBirthDate(BirthDateTextBox.Text))
            {
                MessageBox.Show("There are error in Birth Date.");
            }

            //Для поля Gender
            if (!OnlyMaleFemale(GenderTextBox.Text))
            {
                MessageBox.Show("There are error in Gender.");
            }

            //Для поля Email
            if (!OnlyEmail(EmailTextBox.Text))
            {
                MessageBox.Show("There are error in Email.");
            }

            //Для поля Phone Number
            if (!OnlyPhoneNumber(PhoneNumberTextBox.Text))
            {
                MessageBox.Show("There are error in Phone Number.");
            }

            //Для поля Additional info
            if (!OnlyAdditionalInfo(AdditionalInfoTextBox.Text))
            {
                MessageBox.Show("There are error in Additional info.");
            }

        }

        private bool OnlyBirthDate(string str)

        {
            bool cond1 = false;
            string dayStr = "";
            string monthStr = "";
            string yearStr = "";
            string[] dataStr1 = str.Split(new char[] { '.' });
            string[] dataStr2 = str.Split(new char[] { ',' });
            string[] dataStr3 = str.Split(new char[] { '/' });

            if(dataStr1.Length==3)
                {
                dayStr = dataStr1[0];
                monthStr = dataStr1[1];
                yearStr = dataStr1[2];

            }

             else if (dataStr1.Length == 3)
            {
                dayStr = dataStr2[0];
                monthStr = dataStr2[1];
                yearStr = dataStr2[2];

            }
            else if (dataStr1.Length == 3)
            {
                dayStr = dataStr3[0];
                monthStr = dataStr3[1];
                yearStr = dataStr3[2];

            }
            int.TryParse(dayStr, out int day);
            if ((day > 0) & (day < 32)) 
            {
                cond1 = true;
            }

            //Проверяем месяц
            bool cond2 = false;
            int.TryParse(monthStr, out int month);
            if ((month > 0) & (month < 13))
            {
                cond2 = true;
            }

            //Проверяем год
            bool cond3 = false;
            int.TryParse(yearStr, out int year);
            int curYear = System.DateTime.Now.Year;
            if ((year > 1899) && (year < curYear + 1))
            {
                cond3 = true;
            }

            return cond1 && cond2 && cond3;
        }

        private bool OnlyMaleFemale(string str)
        {
            str = str.ToLower();
            if ((str == "male") || (str == "female"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool OnlyEmail(string str)
        {
            //Проверяем количество символов
            bool cond1 = false;
            if (str.Length < 255)
            {
                cond1 = true;
            }
            else cond1 = false;

            //Проверяем наличие одного символа @
            string[] emailTokens = str.Split(new Char[] { '@' });
            bool cond2 = false;
            if (emailTokens.Length == 2)
                cond2 = true;

            return cond1 && cond2;
        }

        private bool OnlyPhoneNumber(string str)
        {
            bool cond1 = false;
            int c = str.Length;
            if (c == 12) cond1 = true;

            bool cond2 = true;
            for (int i = 0; i < c; i++)
            {
                if (!System.Char.IsDigit(str[i]))
                {
                    cond2 = false;
                    break;
                }
            }

            return cond1 && cond2;
        }

        private bool OnlyAdditionalInfo(string str)
        {
            return str.Length < 2000;
        }

        //Выполнить все проверки в одном блоке
        private void Validate()
        {

        }
       

    }



       }
