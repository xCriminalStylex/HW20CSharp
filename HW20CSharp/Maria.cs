using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW20CSharp
{
    public class Maria : Womens
    {
        public override void Cook()
        {
            Console.WriteLine("I am a good cook. No one has died yet.");
        }

        public override void Eat()
        {
            Console.WriteLine("I've already had breakfast. Now I'm not hungry.");
        }

        public override void Laundry()
        {
            Console.WriteLine("Need to do the laundry today.");
        }

        public override void Walk(int distance)
        {
            Console.WriteLine($"I have {distance} meters to walk home.");
        }
        public void Work(int time)
        {
            Console.WriteLine($"I work {time} hours every day except Saturday and Sunday.");
        }
        public void Draw()
        {
            Console.WriteLine("In my free time I paint landscapes.");
        }
    }
}
