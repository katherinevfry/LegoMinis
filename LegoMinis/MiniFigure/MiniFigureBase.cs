using LegoMinis.Heads;
using LegoMinis.Legs;
using LegoMinis.Torsos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinis.MiniFigure
{
   class MiniFigureBase
    {
        public HeadBase Head { get; }
        public TorsoBase Torso { get; }
        public LegBase Leg { get; }
  

        public MiniFigureBase(HeadBase head, TorsoBase torso, LegBase leg)
        {
            Head = head;
            Torso = torso;
            Leg = leg;
        }

        public void BuildIt()
        {
            Console.WriteLine("I love to build things");
        }

    }
}
