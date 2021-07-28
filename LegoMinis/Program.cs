using LegoMinis.Heads;
using LegoMinis.Legs;
using LegoMinis.Torsos;
using LegoMinis.MiniFigure;
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

            var batmanTorso = new BatSuitTorso();
            batmanTorso.BodyColor = LegoColor.Black;
            batmanTorso.HasBatBoomerang = true;
            batmanTorso.HasShirt = false;
            batmanTorso.Donates();

            var cowboyTorso = new CowboyTorso();

            var sumoTorso = new SumoTorso();

            var torsos = new List<TorsoBase>() { batmanTorso, cowboyTorso, sumoTorso };

            foreach (var torso in torsos)
            {
                torso.Greeting();
                torso.Wiggle();
            }

            var seaLegs = new SeaLeg();
            seaLegs.AreWobbly = true;
            seaLegs.Bottoms = BottomsType.MomJeans;
            seaLegs.NumberOfLegs = 3;
            seaLegs.Kicks = ShoesType.docMartens;

            var magicLegs = new MagicLeg();
            magicLegs.Bottoms = BottomsType.CargoShorts;
            magicLegs.HasInvisibleLegs = true;
            magicLegs.MeasuringLegs("small");
            Console.WriteLine($"Magic Legs have a length of {magicLegs.Length} inchs");

            var legs = new List<LegBase>() { seaLegs, magicLegs };

            foreach (var leg in legs)
            {
                leg.Dance();
                leg.Walk();
            }

            var bob = new MiniFigureBase(workerHead, cowboyTorso, magicLegs);
            bob.BuildIt();
            bob.Head.SayHi();
        }
    }
}
