using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuning_car
{
    
    class Car
    {
        private string _Model;
        private int _Year;
        private string _Color;

        public string Model
        {
            get { return _Model; }
            set { _Model = value; }
        }

        public int Year
        {
            get { return _Year; }
            set { _Year = value; }
        }

        public string Color
        {
            get { return _Color; }
            set { _Color = value; }
        }
        public Car(string m = "Audi",int y = 2000,string c = "green")
        {
            Model = m;
            Year = y;
            Color = c;

        }

    }
}
