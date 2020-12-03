using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie
{
    class TransferToBankAccount : Send
    {
        private string Name;
        private string _Type;
        private string Number;
        private string _Name;
        private string _Number;
        public TransferToBankAccount() { }
        public TransferToBankAccount(string name, string  number,string _type, string _name, string  _number)
        {
            Name = name;
            Number = number;
            _Name = _name;
            _Number = _number;
            _Type = _type;
        }
        public override void SendTo()
        {
            Console.WriteLine("Money from: " + Name + " " + "(" + Number + ")" + " successfully sent to: " + _Name + " " + "(" + _Number + ")" + " by: " + _Type + "\n");
        }
    }
}
