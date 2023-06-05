using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Land : Vehicle
    {
        //fields
        int _wheels;


        public Land(string color, int wheels) : base(color)
        {
            Color = color;
            Wheels = wheels;
        }

        public string Color { get; }
        public int Wheels { get => _wheels; set => _wheels = value; }

        public override string ToString()
        {
            return base.ToString() + $" - Number of Wheels: {_wheels}";
        }
    }
}
