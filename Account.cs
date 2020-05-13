using System;
using System.Collections.Generic;
using System.Text;

namespace projekt_zaliczeniowy
{
    abstract class Account //klasa abstrakcyjna, ponieważ nie tworzymy z niej kont, jedyne jej użycie to użycie w roli klasy bazowej dla innej klasy
    {
        public string AccountNumber;
        public decimal Balance;

        public Account(string accountNumber, int balance) // funkcja, która wypełnia dane konta wraz z argumentami
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }
        
        public abstract string TypeName(); // ABSTRAKCYJNA METODA - dzięki temu będziemy mogli zaaplikować w klasach dziedziczących funkcję zwracającą typ konta

        public string GetBalance() //zwraca saldo
        {

            return string.Format("{0} zł", Balance); //format zwraca tekst jako nowy string, return saldo
        }
    }

}
