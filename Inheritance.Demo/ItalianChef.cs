using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Demo
{
    public class ItalianChef : Chef
    {
        public override void MakeSalad()
        {
            Console.WriteLine($"Italian Chef has made Salad");
        }

        public override void BakeChicken()
        {
            Console.WriteLine($"Italian Chef baked Chicken");
        }

        public override void ChefSpecial()
        {
            Console.WriteLine("Italian Chef's Special is delicious Ribs");
        }
    }
}
