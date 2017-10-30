using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalkConsoleAppPRG
{
    class Program
    {
        static void PrintMenu()
        {
            Console.WriteLine("1)Сложить два числа");
            Console.WriteLine("2)Вычесть два числа");
            Console.WriteLine("3)Умножить два числа");
            Console.WriteLine("4)Разделить два числа");
            Console.WriteLine("5)Деление с остатком %");



            Console.Write("Выберите действие");
        }

        static void AddTwoNumbers()
        {
            Console.WriteLine("Введите первое число");
            string num1Str;
            num1Str = Console.ReadLine();
            string num2Str;
            Console.WriteLine("Введите второе число");
            num2Str = Console.ReadLine();
            //Преобразуем строки в числа
            double num1;
            num1 = Convert.ToDouble(num1Str);
            double num2;
            num2 = Convert.ToDouble(num2Str);
            //Производим вычисления
            double res;
            res = num1 + num2;
            //Отобразить результат
            Console.WriteLine("Резульат сложения - " + res);
            Console.ReadLine();




        }
        static void SubtractionTwoNumbers()
        {

            Console.WriteLine("Введите первое число");
            string num1Str;
            num1Str = Console.ReadLine();
            string num2Str;
            Console.WriteLine("Введите второе число");
            num2Str = Console.ReadLine();
            //Преобразуем строки в числа
            double num1;
            num1 = Convert.ToDouble(num1Str);
            double num2;
            num2 = Convert.ToDouble(num2Str);
            //Производим вычисления
            double res;
            res = num1 - num2;
            //Отобразить результат
            Console.WriteLine("Резульат вычитания -" + res);
            Console.ReadLine();
        }
        static void multiplue()
        {

            Console.WriteLine("Введите первое число");
            string numq1Str;
            numq1Str = Console.ReadLine();
            string num2Str;
            Console.WriteLine("Введите второе число");
            num2Str = Console.ReadLine();
            //Преобразуем строки в числа
            double num1;
            num1 = Convert.ToDouble(numq1Str);
            double num2;
            num2 = Convert.ToDouble(num2Str);
            //Производим вычисления
            double res;
            res = num1 * num2;
            //Отобразить результат
            Console.WriteLine("Резульат умножения * " + res);
            Console.ReadLine();

        }

        static void Divide()
        {
            Console.WriteLine("Введите первое число");
            string numq1Str;
            numq1Str = Console.ReadLine();
            string num2Str;
            Console.WriteLine("Введите второе число");
            num2Str = Console.ReadLine();
            //Преобразуем строки в числа
            double num1;
            num1 = Convert.ToDouble(numq1Str);
            double num2;
            num2 = Convert.ToDouble(num2Str);
            //Производим вычисления
            double res;
            res = num1 / num2;
            //Отобразить результат
            Console.WriteLine("Резульат деления -/" + res);
            Console.ReadLine();
        }
        static void remainder()
        {
            Console.WriteLine("Введите первое число");
            string numq1Str;
            numq1Str = Console.ReadLine();
            string num2Str;
            Console.WriteLine("Введите второе число");
            num2Str = Console.ReadLine();
            //Преобразуем строки в числа
            double num1;
            num1 = Convert.ToDouble(numq1Str);
            double num2;
            num2 = Convert.ToDouble(num2Str);
            //Производим вычисления
            double res;
            res = num1 % num2;
            //Отобразить результат
            Console.WriteLine("Резульат сложения % " +res);
            Console.ReadLine();
        }



            static void Main(string[] args)
        {
           
            

            Console.WriteLine("Calculator");
            //Печатам в консоле меню для пользователя
              PrintMenu();
            string Action;
            //Пользаватель вводит текст
            Action = Console.ReadLine();
            // Console.WriteLine("Action is-" + Action);
            //  Console.ReadLine();
            //Принимаем решение
            if(Action=="1")
            {
                AddTwoNumbers();
            }
            if (Action == "2") { SubtractionTwoNumbers(); }
            if (Action == "3") { multiplue(); }
        
            if (Action == "4") { Divide(); }
            if (Action == "5") { remainder(); }
            

        }
    }
}
