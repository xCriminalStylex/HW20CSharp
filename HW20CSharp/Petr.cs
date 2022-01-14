using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW20CSharp
{
    public class Petr : Mens
    {
        public override void Build()
        {
            Console.WriteLine("Trying to build a garage.");
        }

        public override void Dig()
        {
            Console.WriteLine("Digging potatoes yesterday.");
        }

        public override void Eat()
        {
            Console.WriteLine("When is dinner already?");
        }

        public override void Walk(int distance)
        {
            Console.WriteLine($"Went camping in the summer, walked {distance} meters.");
        }
        public void Music()
        {
            Console.WriteLine("I play the piano.");
        }
        public void Diving(int time)
        {
            Console.WriteLine($"I may not breathe underwater {time} seconds.");
        }
    }
}
