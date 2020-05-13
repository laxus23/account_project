using System;
using System.Collections.Generic;
using System.Collections;


namespace projekt_zaliczeniowy
{
    class Program
    {
        static void Square(int x)
        {
            x += x;
            Console.WriteLine("\nCongratulations. As a lucky man, your balance has doubled: {0}. \nUps, that's only a joke.\n", x);
        }
        static void SquareRef(ref int x)
        {
            x *= 3;
            System.Console.WriteLine("\nThe second account will be created with balance: {0}.\n", x);
        }

        static void Main(string[] args) 
            /*Domyślnie w aplikacjach konsolowych jest to metoda wejściowa, od której zaczyna się wykonywanie naszego programu. 
            Jest ona statyczna i nie zwraca żadnych wartości, za to jako parametry przyjmuje tablicę zawierającą argumenty przekazane do naszego programu podczas uruchamiania.*/
        {
            var numbers = new List<int>();                          //tworzenie listy
            Queue<int> queuenumbers = new Queue<int>();             //tworzenie queue
            Stack stack = new Stack();                              //tworzenie stacka
            SortedList sortedList = new SortedList();              //tworzenie sortedlist
            IDictionary<int, string> dict = new Dictionary<int, string>();  //tworzenie dictionary

            string name = "Nazwa: Bank";
            string author = "Autor: RŁ";
            Console.WriteLine(name); 
            Console.WriteLine(author);
            Console.WriteLine("");
            string AccountNumber;
            int Balance;
            Console.WriteLine("Enter your account number: ");
            AccountNumber = Console.ReadLine();
            Console.WriteLine("Enter your balance: ");
            Balance = 0;
            {
                try
                {
                    Balance = Convert.ToInt32(Console.ReadLine());  //input konwertowany na inta

                }
                catch (Exception)
                {
                    Console.WriteLine("Balance is not integer");
                }

                finally
                {
                    Console.WriteLine("Your Balance is: {0}", Balance);
                }
            }
            if (Balance % 2 == 0)
            {
               Square(Balance);
                numbers.Add(Balance);      //dodawanie Balance do listy   
                queuenumbers.Enqueue(Balance); //dodawanie Balance do queue
                stack.Push(Balance);            //dodanie Balance do stacka
                sortedList.Add(Balance, AccountNumber); //dodanie Balance i AccountNumber do stacka
                dict.Add(Balance, AccountNumber);   //dodanie Balance i AccountNumber do dict

            }
            Console.WriteLine("The value outside the method: {0}", Balance);

            SavingsAccount savingsAccount = new SavingsAccount(AccountNumber, Balance); //tworzenie nowego konta
            
            SquareRef(ref Balance);
            numbers.Add(Balance); //dodawanie ref Balance do listy
            queuenumbers.Enqueue(Balance); //dodawanie ref Balance do queue
            stack.Push(Balance);            //dodanie ref Balance do stacka
            sortedList.Add(Balance, AccountNumber); //dodanie ref Balance i AccountNumber do stacka
            dict.Add(Balance, AccountNumber);   //dodanie ref Balance i AccountNumber do dict

            SavingsAccount savingsAccount01 = new SavingsAccount("940000000002", Balance); //tworzenie nowego konta

            Console.Write("Posortowane liczby dla listy: ");
            foreach (var item in numbers)     // pętla, która wypisze nam wszystkie elementy z listy
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nLiczba elementów w Queue: {0}", queuenumbers.Count); 

            while (queuenumbers.Count > 0)                  // pętla, która trwa dopóki Count większe od zera
                Console.WriteLine(queuenumbers.Dequeue());      //wypisuje elementy queue

            Console.WriteLine("\nLiczba elementów w Queue: {0}", queuenumbers.Count);

            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("Liczba elementów stacka " + stack.Count);
            Console.WriteLine("Elementy stacka: ");

            foreach (var item in stack)     // pętla, która wypisze nam wszystkie elementy ze stacka
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\nCzy w stacku znajduje się element 3 " + stack.Contains(3));    //sprawdzenie czy w stacku znajduje się 3
            int element;
            Console.WriteLine("Podaj liczbę, a program sprawdzi, czy zawiera się w stacku");   

            element = Convert.ToInt32(Console.ReadLine());          //input konwertowany na inta

            Console.WriteLine("{0}", stack.Contains(element));  //zwraca True lub False - w zależności od tego, czy element znajduje się w stacku
            
            BillingAccount billingAccount = new BillingAccount("940000000003", 50); //tworzenie nowego konta billingowego
            sortedList.Add(50, "940000000003"); //dodanie Balance i AccountNumber billingAccount do stacka
            dict.Add(50, "940000000003");   //dodanie Balance i AccountNumber billingAccount do dict
            
            IPrinter printer = new Printer(); //tworzenie nowego obiektu printer
            printer.Print(savingsAccount); //wywołanie funkcji print dla konta savingsAccount
            printer.Print(savingsAccount01); //wywołanie funkcji print dla konta savingsAccount01
            printer.Print(billingAccount);
            
   
            string balance = savingsAccount.GetBalance(); //nowy string, w którym zwrócony jest balance savingsAccount
            Console.WriteLine("Bilans konta wynosi: {0}", balance);
            string balancebilling = billingAccount.GetBalance(); //nowy string, w którym zwrócony jest balance billingAccount
            Console.WriteLine("Bilans konta wynosi: {0}", balancebilling);
            
            string typeaccount = savingsAccount.TypeName();
            Console.WriteLine("Konto jest {0}", typeaccount);
            string typeaccountbilling = billingAccount.TypeName();
            Console.WriteLine("Konto jest {0}", typeaccountbilling);
            Console.WriteLine("Sorted list: ");
            for (int i = 0; i < sortedList.Count; i++)  //pętla, która pozwoli na wypisanie kluczy i indeksów od najmniejszego do największego, i++ zwiększenie o 1
            {
                Console.WriteLine("key: {0}, value: {1}",
                    sortedList.GetKey(i), sortedList.GetByIndex(i));        //pobiera klucz i indeks
            }
            Console.WriteLine("Dict: ");
            foreach (KeyValuePair<int, string> item in dict)            //pętla, która zwraca key i value dla dicta
            {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            }

            Console.ReadKey();

        }
    }
}
