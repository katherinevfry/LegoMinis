using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinis.Legs
{
    class MagicLeg : LegBase
    {
        public bool HasInvisibleLegs { get; set; }
        public int Length { get; set; } // in inches

        public void MeasuringLegs(string size)
        {
            if (size == "small")
            {
                Length = 2;
            }
            else if (size == "medium")
            {
                Length = 5;
            }
            else if (size == "large")
            {
                Length = 24;
            } else
            {
                Length = 1;
            }
        }
        public override void Walk()
        {
            Console.WriteLine("magic carpet ride");
        }
    }
}
