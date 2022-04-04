using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphApp
{
    internal class Vehicle
    {
        public void Drive()
        {
            Console.WriteLine("Drive");
        }

        public void Turn()
        {
            Console.WriteLine("Turn");
        }

        public void Stop()
        {
            Console.WriteLine("Stop");
        }
    }

    class Aeroplane : Vehicle
    {
        public void Drive()
        {
            Console.WriteLine("I am flying");
        }
    }
}
