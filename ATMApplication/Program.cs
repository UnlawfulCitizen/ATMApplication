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
                
                Input = Console.ReadLine();
              

                string[] matches = Input.Split(" $");

                switch (matches[0].ToUpper())
                {
                    case "R":
                        atm.Stock();
                        break;
                    case "W":
                        Console.WriteLine(atm.Withdrawl(Int32.Parse(matches[1])));
                        break;
                    case "I":
                        for (int i = 1; i < matches.Length; i++)
                            Console.WriteLine(atm.List(Int32.Parse(matches[i])));
                        break;
                    case "Q":
                        Exit = true;
                        break;
                    default:
                        Console.WriteLine("Failure: Invalid Command");
                        break;
                }
            }
        }
    }
}
