using System;
using System.Collections.Generic;
using System.Text;

namespace projekt_zaliczeniowy
{
    class Printer : IPrinter//nowa klasa służąca do drukowania informacji o koncie, dziedziczy po interfejsie IPrinter
    {
        public void Print(Account account) //public - możliwość używania poza klasą Printer, void - typ danych, a więc funkcja nie zwraca niczego, SavingsAccount account - dane wejściowe
        {
            Console.WriteLine("\nDane konta: {0}", account.AccountNumber);
            Console.WriteLine("Typ: {0}", account.TypeName());
            Console.WriteLine("Saldo: {0}", account.GetBalance());
            Console.WriteLine();
        }

    }
}
