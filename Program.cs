// See https://aka.ms/new-console-template for more information
using System;

namespace polymorphApp
{
    class Program
    {
        static void Main()
        {
            Vehicle vehicle = new Vehicle();
            vehicle.Drive();
            vehicle.Stop();
            vehicle.Turn();

            Aeroplane aeroplane = new Aeroplane();
            aeroplane.Drive();
        }
    }
}
