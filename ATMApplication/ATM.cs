using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATMApplication
{
    public class ATM
    {

        
        private Dictionary<int, int> Bills = new Dictionary<int, int>();

        
        public ATM()
        {
            Stock();
        }
        /// <summary>
        /// Empties out the ATM, refills with default amount. 
        /// </summary>
        /// <returns></returns>
        public Dictionary<int,int> Stock()
        {
            Bills.Clear();
            Bills = new Dictionary<int, int>
            {
                { 100, 10 },
                { 50, 10 },
                { 20, 10 },
                { 10, 10 },
                { 5, 10 },
                { 1, 10 }
            };
            return Bills;
        }
        /// <summary>
        /// Gets Total value in ATM
        /// </summary>
        /// <returns></returns>
        public int GetTotal()
        {
            int total = 0;
            foreach (var bill in Bills)
            {
                total += bill.Key * bill.Value;
            }
            return total;
        }   
        /// <summary>
        /// Lists bills to Console.
        /// </summary>
        public void List()
        {
            Console.WriteLine("Machine balance: ");
            foreach (var bill in Bills)
            {
                Console.WriteLine($"${bill.Key} - {bill.Value}");
            }
        }


        public object List(int denomination)
        {
            if (Bills.TryGetValue(denomination, out int value))
                return $"${denomination} - {value}";
            return $"{denomination} - 0";
        }


        /// <summary>
        /// This function would assume that we have already verified that Bills > amount
        /// </summary>
        /// <param name="amount"></param>
        public object Withdrawl(int amount)
        {
            if (amount > 0 && amount <= GetTotal())
            {
                List<int> denominations = Bills.Keys.ToList();
                Dictionary<int, int> Transaction = new Dictionary<int, int>();

                foreach (int bill in denominations)
                {
                    
                    int count = amount / bill;
                    if (count >= Bills[bill])
                    {
                        amount -= Bills[bill] * bill;
                       //add key to transaction Transaction.Add(bill);

                        Bills.Remove(bill);

                    }
                    else if (count < Bills[bill] && count !=0)
                    {
                        amount -= count * bill;
                        Bills[bill] -= count;
                    }
                    

                }
                if (amount > 0)
                    return "Failure: insufficient funds";
                else
                    return $"Success: Dispensed ${amount}";
            }
            else {
                return "Failure: insufficient funds";
            }
        }
    
      

    }
}
