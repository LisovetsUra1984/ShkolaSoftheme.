using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZZZodiak
{
    class Program
    {
      
        
            static bool DateValidate(string str)
            {
                //Проверяем день
                bool cond1 = false;
                string dayStr = "00";
                string monthStr = "00";
                string yearStr = "0000";
                string[] dateStr1 = str.Split(new Char[] { '.' });
                string[] dateStr2 = str.Split(new Char[] { ',' });
                string[] dateStr3 = str.Split(new Char[] { '/' });
                if (dateStr1.Length == 3)
                {
                    dayStr = dateStr1[0];
                    monthStr = dateStr1[1];
                    yearStr = dateStr1[2];
                }
                else if (dateStr2.Length == 3)
                {
                    dayStr = dateStr2[0];
                    monthStr = dateStr1[1];
                    yearStr = dateStr1[2];
                }
                else if (dateStr3.Length == 3)
                {
                    dayStr = dateStr3[0];
                    monthStr = dateStr1[1];
                    yearStr = dateStr1[2];
                }
                int.TryParse(dayStr, out int day);
                if ((day > 0) & (day < 32))
                {
                    cond1 = true;
                }

              
                bool cond2 = false;
                int.TryParse(monthStr, out int month);
                if ((month > 0) & (month < 13))
                {
                    cond2 = true;
                }

                
                bool cond3 = false;
                int.TryParse(yearStr, out int year);
                int curYear = System.DateTime.Now.Year;
                if ((year > 1899) && (year < curYear + 1))
                {
                    cond3 = true;
                }

                return cond1 && cond2 && cond3;
            }

            static string InputDate()
            {
                again:
                Console.Write("Enter the date of birth in the format (day.month.Year):");

            string dateStr = Console.ReadLine();

                if (!DateValidate(dateStr))
                {
                    Console.WriteLine("Please enter the date in the required format and in the correct range.");
                    goto again;
                }
                else
                {
                    Console.WriteLine("Thank you.");
                }

                return dateStr;
            }

            static string[] ParseDMY(string str)
            {
                string[] dateArr;

                string[] dateArr1 = str.Split(new char[] { '.' });
                string[] dateArr2 = str.Split(new char[] { ',' });
                string[] dateArr3 = str.Split(new char[] { '/' });

                if (dateArr1.Length == 3)
                    dateArr = dateArr1;
                else if (dateArr2.Length == 3)
                    dateArr = dateArr2;
                else dateArr = dateArr3;

                return dateArr;
            }

            static void Main(string[] args)
            {
                //Просим пользователя ввести дату
                string dateStr = InputDate();

                string[] dateArr = ParseDMY(dateStr);

                Int16 day = Convert.ToInt16(dateArr[0]);
                Int16 month = Convert.ToInt16(dateArr[1]);
                Int16 year = Convert.ToInt16(dateArr[2]);

                if (((month == 3) && ((21 <= day) && (day <= 31))) || ((month == 4) && ((1 <= day) && (day <= 19))))
                    Console.WriteLine("Zodiac sign - " + "Aries.");

                else if (((month == 4) && ((21 <= day) && (day <= 31))) || ((month == 5) && ((1 <= day) && (day <= 20))))
                    Console.WriteLine("Zodiac sign - " + "Taurus.");


            else if (((month == 5) && ((21 <= day) && (day <= 31))) || ((month == 6) && ((1 <= day) && (day <= 20))))
                Console.WriteLine("Zodiac sign - " + "Twins.");

            else if (((month == 6) && ((21 <= day) && (day <= 31))) || ((month == 7) && ((1 <= day) && (day <= 22))))
                Console.WriteLine("Zodiac sign - " + "Cancer.");


            else if (((month == 7) && ((23 <= day) && (day <= 31))) || ((month == 8) && ((1 <= day) && (day <= 22))))
                Console.WriteLine("Zodiac sign - " + "Lion.");

            else if (((month == 8) && ((23 <= day) && (day <= 31))) || ((month == 9) && ((1 <= day) && (day <= 23))))
                Console.WriteLine("Zodiac sign - " + "Virgo.");

            else if (((month == 9) && ((24 <= day) && (day <= 31))) || ((month == 10) && ((1 <= day) && (day <= 23))))
                Console.WriteLine("Zodiac sign - " + "Libra.");


            else if (((month == 10) && ((24 <= day) && (day <= 31))) || ((month == 11) && ((1 <= day) && (day <= 21))))
                Console.WriteLine("Zodiac sign - " + "Scorpio.");

            else if (((month == 11) && ((22 <= day) && (day <= 31))) || ((month == 12) && ((1 <= day) && (day <= 21))))
                Console.WriteLine("Zodiac sign - " + "Стрелец.");

            else if (((month == 12) && ((22 <= day) && (day <= 31))) || ((month == 01) && ((1 <= day) && (day <= 21))))
                Console.WriteLine("Zodiac sign - " + "Capricorn.");

            else if (((month == 01) && ((22 <= day) && (day <= 31))) || ((month == 02) && ((1 <= day) && (day <= 18))))
                Console.WriteLine("Zodiac sign - " + "Aquarius.");

            else if (((month == 02) && ((19 <= day) && (day <= 31))) || ((month == 03) && ((1 <= day) && (day <= 20))))
                Console.WriteLine("Zodiac sign - " + "Fish.");


            else
                    Console.WriteLine("Insufficient data!!!");

                Console.ReadLine();
            }

        }
    }

