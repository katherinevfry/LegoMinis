using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinis.Heads
{
    class BatmanHead : HeadBase
    {
        public bool IsWearingMask { get; set; }
        public string Version { get; set; }
        public string FacialExpression { get; set; } = "Stoic";

        public BatmanHead()
        {
            Color = LegoColor.Black;
        }

        public override void Spin()
        {
            Console.WriteLine("Where's the Joker?");
        }
        // override overrides the base class SayHi method. You can only override within this class
        public override void SayHi()
        {
            Console.WriteLine("I'm Batman!");
        }


    }
}
