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
            Console.WriteLine("Kettle is filled with boiled water");
        }
        public override double Fill(double f)
        {
            Console.WriteLine();
            return f;
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
