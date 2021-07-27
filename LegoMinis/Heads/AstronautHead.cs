using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinis.Heads
{
    class AstronautHead : HeadBase
    {
        public bool WearingHelmet { get; set; }
        public FacialHair FacialHair { get; set; }
        
        public override void SayHi()
        {
            base.SayHi(); //this includes the base method
            Console.WriteLine("This is major tom to ground controllllll");
        }

        public override void Spin()
        {
            Console.WriteLine("The astronaut head spins to take in the beauty of the cosmos.");
        }

        public void Shave()
        {
            Console.WriteLine($"The Astronaut head shaves its {FacialHair}");
            FacialHair = FacialHair.None;
        }
    }
}
