using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie_C8
{
    class Kettle
    {
        private KettleState currentState;
        public Kettle()
        {
            currentState = new KettleAfterBoilingState(this);
        }
        public void ChangeState(KettleState newState)
        {
            currentState = newState;
        }
        public void Fill()
        {
            currentState.Fill();
        }
        public void Boil()
        {
            currentState.Boil();
        }
        public void Full()
        {
            currentState.Full();
        }
        public void Empty()
        {
            currentState.Empty();
        }
    }
}
