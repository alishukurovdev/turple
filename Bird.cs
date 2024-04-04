using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SInif1
{
    internal abstract class Bird : Animal
    {
        //public abstract void Fly();
        public virtual void Fly()
        {
            Console.WriteLine("hammisi ucsun");
        }
    }
}
