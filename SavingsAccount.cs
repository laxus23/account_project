using System;
using System.Collections.Generic;
using System.Text;

namespace projekt_zaliczeniowy
{
    class SavingsAccount : Account //klasa SavingsAccount dziedziczy zmienne po Account
    {
        public SavingsAccount(string accountNumber, int balance)
            : base(accountNumber, balance) //wykorzystuje konstruktor klasy bazowej
        {

        }
        public override string TypeName() //nadpisanie funkcji z klasy bazowej
        {
            return "OSZCZĘDNOŚCIOWE";
        }
    }
}
