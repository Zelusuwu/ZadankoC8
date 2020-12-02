using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie_C8
{
    abstract class KettleState
    {
        protected Kettle parentKettle;
        public KettleState(Kettle kettle)
        {
            parentKettle = kettle;
        }
        public abstract double Fill();
        public abstract void Boil();
        public abstract void Full();
        public abstract void Empty();

    }
}
