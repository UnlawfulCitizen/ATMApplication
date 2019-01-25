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
            atm.Stock();
            atm.Withdrawl(2700);
            atm.ListBills() ;
            Console.WriteLine(atm.GetTotal());
           /* atm.Clear();
            atm.List();
            Console.ReadLine();
            atm.Stock();
            atm.Withdrawl(4000);
            atm.List();*/
            Console.ReadLine();

        }
    }
}
