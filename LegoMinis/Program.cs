using LegoMinis.Heads;
using System;
using System.Collections.Generic;

namespace LegoMinis
{
    class Program
    {
        static void Main(string[] args)
        {
            var workerHead = new ConstructionWorkerHead();
            workerHead.Color = LegoColor.Yellow;

            var batmanHead = new BatmanHead();

            var astroHead = new AstronautHead();

            var heads = new List<HeadBase>() { astroHead, batmanHead, workerHead };

            foreach (var head in heads)
            {
                head.SayHi(); // i can do this for anything the heads have in common, ie the headbase. polymorphism is the concept
                head.Spin();
            }

        }
    }
}
