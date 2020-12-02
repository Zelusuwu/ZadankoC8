using Zadanie_C8;
using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie_C8
{
    class KettleFillState
    {
        protected double fill;

        public KettleFillState(double f)
        {
            fill = f;
        }
        public void Fill()
        {    
            Console.WriteLine("Now kettle is filled with: " + fill + "L water");          
        }
    }
}
