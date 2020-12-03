using System;
using Zadanie;

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

            TransferToBankAccount myBank;
            SetTransferType myType = new SetTransferType();
            myType.SetTransfer(myBank = new TransferToBankAccount("Jan Kowalski", "00 1111 2222 3333 4444 5555 6666", "Transfer to the bank account", "Anna Kowalska", "00 6666 5555 4444 3333 2222 1111"));
            myBank.SendTo();

            TransferToThePhoneNumber myPhone;
            myType.SetTransfer(myPhone = new TransferToThePhoneNumber("Jan Kowalski", "+48 123 456 789", "Transfer to the phone number", "Anna Kowalska", "+48 987 654 321"));
            myPhone.SendTo();
        }
    }
}
