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
        public virtual int GetWorkDuration()
        {
            int numberOfHours = new Random().Next(1,10);
            Console.WriteLine($"Number of Hours of work = {numberOfHours}");
            return numberOfHours;
        }

        public virtual void UpdateWorkDuration()
        {
            int workDuration = GetWorkDuration();

            if(workDuration > 8)
            {
                Console.WriteLine("Engineer worked Over time");
            }
        }
    }
}
