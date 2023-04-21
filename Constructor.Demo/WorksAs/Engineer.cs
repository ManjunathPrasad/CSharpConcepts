using Constructor.Demo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor.Demo.WorksAs
{
    public class Engineer : Person, IEngineer
    {
        public void GetWorkDuration()
        {
            Console.WriteLine(new Random().Next(1, 8));
        }
    }
}
