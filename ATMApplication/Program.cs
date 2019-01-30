using System;

namespace ATMApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            ATM atm = new ATM();
            String Input;
            Boolean Exit = false;


            while (!Exit)
            {
                //todo fix this
                Input = Console.ReadLine();

                string[] str = Input.Split(' ');

                switch (str[0].ToUpper())
                {
                    case "R":
                        atm.Stock();
                        break;
                    case "W":
                        Console.WriteLine(atm.Withdrawl(Int32.Parse(str[1])));
                        atm.List();
                        break;
                    case "I":
                        for (int i = 1; i < str.Length; i++)
                        {
                            Console.WriteLine(atm.List(Int32.Parse(str[i])));
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
