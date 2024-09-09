using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Pkw
    {
        private Motor _motor = new Motor();

        public void Fahren()
        {
            Console.WriteLine("Pkw Fährt");
        }
    }
}