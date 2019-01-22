using System;

namespace ATMApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //todo add input 
            //todo add responses
            
            ATM atm = new ATM();
            atm.Restock();
            atm.List();
            Console.WriteLine(atm.TotalValue());
            atm.Clear();
            atm.List();
            Console.ReadLine();
            atm.Restock();
            atm.Withdrawl(4000);
            atm.List();
            Console.ReadLine();

        }
    }
}
