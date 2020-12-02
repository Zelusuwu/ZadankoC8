using Zadanie_C8;
using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie_C8
{
    class KettleBoilingWaterState : KettleState
    {
        protected Kettle _kettle;
        public KettleBoilingWaterState(Kettle kettle) : base(kettle)
        {
            _kettle = kettle;
        }
        public override void Empty()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Water in kettle is boiling ");
            Console.ResetColor();
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
            Console.WriteLine("Water is still boiling");
            Console.ResetColor();
        }
    }
}
