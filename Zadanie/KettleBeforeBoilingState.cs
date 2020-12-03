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
        public override void Fill()
        {
            Console.WriteLine();
        }
        public override void Full()
        {
            Console.WriteLine("Kettle is filled above 0.5L, you can now boil the water");;
        }
        public override void Boil()
        {
            Console.WriteLine();
        }
    }
}
