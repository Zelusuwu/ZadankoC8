using Zadanie_C8;
using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie_C8
{
    class KettleAfterBoilingState : KettleState
    {
        protected Kettle _kettle;

        public KettleAfterBoilingState(Kettle kettle) : base(kettle)
        {
            _kettle = kettle;
        }
        public override void Empty()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(". . .");
            Console.ResetColor();
        }
        public override void Fill()
        {
            Console.WriteLine();
        }
        public override void Full()
        {
            Console.WriteLine();
        }
        public override void Boil()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Water is boiled");
            Console.ResetColor();
        }
    }
}
