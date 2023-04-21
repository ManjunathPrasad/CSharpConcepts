﻿using Constructor.Demo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor.Demo.WorksAs
{
    public class SoftwareEngineer : IEngineer, ISoftwareEngineer
    {
        public void GetWorkDuration()
        {
            Console.WriteLine(new Random().Next(1, 10));
        }
        public void GetCodingExperience()
        {
            Console.WriteLine($"Software Engineer has {new Random().Next(1, 10)} years of Experience");
        }
    }
}
