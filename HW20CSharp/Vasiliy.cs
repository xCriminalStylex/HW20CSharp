using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW20CSharp
{
    public class Vasiliy : Mens
    {
        public override void Build()
        {
            Console.WriteLine("I built my own house.");
        }

        public override void Dig()
        {
            Console.WriteLine("I can dig, I can not dig.");
        }

        public override void Eat()
        {
            Console.WriteLine("Haven't eaten yet today.");
        }

        public override void Walk(int distance)
        {
            Console.WriteLine($"Walked today {distance} meters.");
        }
        public void Singing()
        {
            Console.WriteLine("I sing well.");
        }
        public void Learn()
        {
            Console.WriteLine("I'm studying at the institute.");
        }
    }
}
