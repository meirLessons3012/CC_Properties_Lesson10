using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_Properties_Lesson10
{
    internal class Table
    {
        public static int Counter { get; set; }
        public ConsoleColor Color { get; set; }
        public double Price { get; private set; } = 3.2;
        public string Manufacturer { get; } = "";

        public Table()
        {
            Counter++;
        }

        public Table(ConsoleColor color, double price, string manufacturer) : this()
        {
            Color = color;
            Price = price;
            Manufacturer = manufacturer;

        }

    }
}
