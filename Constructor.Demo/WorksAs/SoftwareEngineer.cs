using Constructor.Demo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor.Demo.WorksAs
{
    public class SoftwareEngineer : Engineer, ISoftwareEngineer
    {
        public override int GetWorkDuration()
        {
            int numberOfHours = new Random().Next(1, 12);
            Console.WriteLine(numberOfHours);
            return numberOfHours;
        }
        public void GetCodingExperience()
        {
            Console.WriteLine($"Software Engineer has {new Random().Next(1, 10)} years of Experience");
        }

        public override void UpdateWorkDuration ()
        {
            GetWorkDuration();
        }
    }
}
