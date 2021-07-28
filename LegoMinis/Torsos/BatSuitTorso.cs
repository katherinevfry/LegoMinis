using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinis.Torsos
{
    class BatSuitTorso : TorsoBase
    {
        public bool HasBatBoomerang { get; set; }
        public override void Greeting()
        {
            base.Greeting();
            Console.WriteLine("Give a fist pump");
        }

        public override void Wiggle()
        {
            Console.WriteLine("flex on em!");
        }

        public void Donates()
        {
            Console.WriteLine("Donates a gajillion dollars");
        }
    }
}
