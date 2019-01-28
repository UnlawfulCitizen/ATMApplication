using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ATMApplication
{
    static class UserInput
    {
        public static int parseInput(String input)
        {
            /*valid commands 
       * W $N = Withdrawl amount
       * R = Restock
       * I = list denominations of that time 
       * Q = Quits app
       * 
       * 
       */


            string[] str = input.Split(' ');
            
                        
            if (str[0]==("R"))
            {
                Console.WriteLine("Restock");    
            }
            else if (input.StartsWith("W"))
            {
                Console.WriteLine("Withdraw");
            }
            else if (input.StartsWith("Q"))
            {
                Console.WriteLine("Quitting");
            }
            else if (input.StartsWith("L"))
            {
                Console.WriteLine("List");
                foreach (string s in str)
                {
                    Console.WriteLine("Value");
                }
                
            }
            return 0;


        }


        public static void Quit()
        {
            System.Environment.Exit(1);
        }
    }
}
