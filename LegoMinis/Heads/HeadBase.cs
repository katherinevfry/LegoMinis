using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinis.Heads
{
    abstract class HeadBase // abstract means a class cannot be instantiated. you cannot create a new instance. it can only be inherited from. e.g. BatmanHead : HeadBase
    {
        public LegoColor Color { get; set; }

        //virtual means this method's behavior can be changed by a class that inherits
        public virtual void SayHi()
        {
            Console.WriteLine("Hi");
        }

        public abstract void Spin(); //this means every head must have a method called Spin... there is just no default behavior. 
    }
}
