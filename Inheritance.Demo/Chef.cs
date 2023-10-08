using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Demo
{
    public class Chef
    {
        public virtual void MakeSalad()
        {
            Console.WriteLine($"Chef has made Salad");
        }

        public virtual void BakeChicken()
        {
            Console.WriteLine($"Chef baked Chicken");
        }

        public virtual void ChefSpecial()
        {
            Console.WriteLine("Chef's Special is delicious Ribs");
        }
    }
}
