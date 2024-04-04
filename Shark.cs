using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SInif1
{
    internal class Shark : Fish
    {
        public override void Eat()
        {
            Console.WriteLine(" balikda yemek yedi ");
        }
    }
}
