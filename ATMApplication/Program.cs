using System;

namespace ATMApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            ATM atm = new ATM();
            atm.Stock();
            String Input;
            Boolean Exit = false;


            while (!Exit)
            {

                Input = Console.ReadLine();

                string[] str = Input.Split(' ');

                switch (str[0])
                {
                    case "R":
                        atm.Restock();
                        break;
                    case "W":
                        atm.Withdrawl(Int32.Parse(str[1]));
                        break;
                    case "I":
                        foreach (string s in str)
                        {
                            atm.List(Int32.Parse(s));
                        }
                        break;
                    case "Q":
                        Exit = true;
                        break;
                    default:
                        Console.WriteLine("Failure: Invalid Command");
                        break;
                }


            }




            //todo add input 
            //todo add responses
            
           // UserInput.parseInput( Console.ReadLine());
            

            //ATM atm = new ATM();
         /*   atm.Stock();
            atm.Withdrawl(2700);
            atm.ListBills();
            Console.WriteLine(atm.GetTotal());
           
            Console.ReadLine();*/

        }
    }
}
