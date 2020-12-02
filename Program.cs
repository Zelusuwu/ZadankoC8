using System;

namespace Zadanie_C8
{
    class Program
    {
        static void Main(string[] args)
        {

            Kettle k = new Kettle();
            KettleBeforeBoilingState kb = new KettleBeforeBoilingState(k);
            k.ChangeState(kb);
            kb.Empty();
            KettleFillState kf = new KettleFillState(1.4);
            kf.Fill();
            kb.Fill();
            kb.Full();
            kb.Boil();

            KettleBoilingWaterState kw = new KettleBoilingWaterState(k);
            k.ChangeState(kw);
            kw.Empty();
            kw.Fill();
            kw.Boil();
            kw.Full();

            KettleAfterBoilingState ka = new KettleAfterBoilingState(k);
            k.ChangeState(ka);
            ka.Empty();
            ka.Fill();
            ka.Boil();
            ka.Full();

        }
    }
}
