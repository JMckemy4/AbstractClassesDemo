using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle 
    {
        public int NumOfPeople { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("not many people can fit");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("they can scary");
        }


    }
}
