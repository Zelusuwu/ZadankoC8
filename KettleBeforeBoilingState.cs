using Zadanie_C8;
using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie_C8
{
    class KettleBeforeBoilingState : KettleState
    {
        protected Kettle _kettle;
        protected KettleFillState fill;

        public KettleBeforeBoilingState(Kettle kettle) : base(kettle)
        {
            _kettle = kettle;
        }
        public override void Empty()
        {
            Console.WriteLine("Kettle is empty");
        }
        public override double Fill()
        {
            if (Fill > 1.7)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You can't fill water above 1.7L");
            }
            else if (f < 0.5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You have to fill water above 0.5L");
            }
            else if (f > 0.5 || f < 1.7)
                Console.ForegroundColor = ConsoleColor.Green;
            fill.Fill();
            Console.ResetColor();
            return Fill();
        }
        public override void Full()
        {
            Console.WriteLine("Kettle is filled above 0.5L, you can now boil the water");;
        }
        public override void Boil()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Water is boiling");
            Console.ResetColor();
        }
    }
}
