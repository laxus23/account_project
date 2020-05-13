using System;
using System.Collections.Generic;
using System.Text;

namespace projekt_zaliczeniowy
{
    interface IPrinter //interfejs dla drukarek
    {
        void Print(Account account); //wywołanie metody drukowanie
    }
}
