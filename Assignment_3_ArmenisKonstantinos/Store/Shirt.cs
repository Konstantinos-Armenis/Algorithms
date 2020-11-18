using Assignment_3_ArmenisKonstantinos.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_ArmenisKonstantinos.Store
{
    class Shirt
    {
        public Color Color { get; set; }
        public Fabric Fabric { get; set; }
        public Size Size { get; set; }


        public Shirt() { }

        public Shirt(Color color, Size size, Fabric fabric)
        {
            Color = color;
            Fabric = fabric;
            Size = size;
        }

        public void Output()
        {
            Console.WriteLine("{0, 12} | {1, 12} |  {2, 12}", Color, Size, Fabric);
        }

        public string CalculatePrice(int num)
        {
            if (num == 0)
                return "You have to pay 25 $";
            else if (num == 1)
                return "You have to pay 23 $";
            else if (num == 2)
                return "You have to pay 38 $";
            else if (num == 3)
                return "You have to pay 21 $";
            else if (num == 4)
                return "You have to pay 20 $";
            else if (num == 5)
                return "You have to pay 15 $";
            else if (num == 6)
                return "You have to pay 19 $";
            else
                return "You have to pay 0 $";
        }
    }
}
