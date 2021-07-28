using LegoMinis.Heads;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinis.Torsos
{
    class SumoTorso : TorsoBase
    {
        public bool AreTheyThicc { get; set; }
        public LegoColor Fundoshi { get; set; }

        public void FightPrep()
        {
            Console.WriteLine("Before the fight, our down some salt");
        }

        public override void Wiggle()
        {
            Console.WriteLine("Shiko");
        }
    }
}
