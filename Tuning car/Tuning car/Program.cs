using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuning_car
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Console.WriteLine("Color my car is-" + car1.Color);
            Console.WriteLine("We send to tuning studio");
            TuningAtelier.TuneCar(car1);
            Console.WriteLine("Checking the quality of car tuning");
            Console.WriteLine("Сolor of my car-" + car1.Color);
            Console.ReadLine();






        }
    }
}
