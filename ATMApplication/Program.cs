using System;
using System.Collections.Generic;

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
                for (int i = 1; i < matches.Length; i++)
                {
                    if (Parse(matches[i]) == 0)
                    {
                        matches[0] = "x";
                    }
                    
                }



                switch (matches[0].ToUpper())
                {
                    case "R":
                        atm.Stock();
                        break;
                    case "W":
                        for (int i = 1; i < matches.Length; i++)
                            Console.WriteLine(atm.Withdrawl(Parse(matches[i])));
                        break;
                    case "I":
                        for (int i = 1; i < matches.Length; i++)
                            Console.WriteLine(atm.List(Parse(matches[i])));
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
        public static int Parse(string s)
        {
            int x = 0;
            Int32.TryParse(s, out x);
            return x;

        }
    }
    
}
