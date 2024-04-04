using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SInif1
{
     class Parrot :Bird
    {
        public void Talk()
        {
            Console.WriteLine(" yeriyen qus");
        }
        public override void Eat()
        {
            Console.WriteLine(" kush yemek yedi");
        }

        public override void Fly()
        {
            Console.WriteLine(" ucan kush");
        }
    }
    }


