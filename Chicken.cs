using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SInif1
{
    internal class Chicken : Bird
    {
        public override void Eat()
        {
            Console.WriteLine("den yeyen cuce");
        }
        public override void Fly()
        {
            Console.WriteLine(" cuce uca bilmir yumurtlayir");
        }
    }
}
