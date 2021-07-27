using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinis.Heads
{
    class ConstructionWorkerHead : HeadBase
    {
        public bool HasMullet { get; set; }
        public int NumberOfTeeth { get; set; }
        public bool WearingHardHat { get; set; }

        public bool ToggleWorking()
        {
            WearingHardHat = !WearingHardHat;

            Console.WriteLine($"The construction worker head " +
                $"{(WearingHardHat ? "is" : "is not")} wearing its hard hat");

            return WearingHardHat;
        }

        public override void Spin()
        {
            if (NumberOfTeeth > 0)
            {
                NumberOfTeeth -= 1;
            }
 
            Console.WriteLine($"The {Color} Construction Worker Head spins after being hit by a girder");
        }

    }

}
