using System;
using System.Collections.Generic;
using System.Text;

namespace projekt_zaliczeniowy
{
    class BillingAccount : Account //klasa BillingAccount dziedziczy zmienne po Account
    {

        public BillingAccount(string accountNumber, int balance)
            : base(accountNumber, balance) // funkcja, która wypełnia dane konta wraz z argumentami
        {

        }

        public override string TypeName() //nadpisanie funkcji z klasy bazowej
        {
            return "ROZLICZENIOWE";
        }
    }

}



