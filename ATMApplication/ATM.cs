using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATMApplication
{
    public class ATM
    {

        //initialize 
        private Dictionary<int, int> Bills = new Dictionary<int, int>();


    
        public Dictionary<int,int> Stock()
        {
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
            int total= new int();
            foreach (var bill in Bills)
            {
                total += bill.Key * bill.Value;
            }
            return total;
        }
        
        public void Clear(Dictionary<int, int> Bills)
        {
            Bills.Clear();
        }
        /// <summary>
        /// Lists bills to Console.WriteLine.
        /// </summary>
        public void ListBills()
        {
            Console.WriteLine("Machine balance: ");
            foreach (var bill in Bills)
            {
                Console.WriteLine($"${bill.Key} - {bill.Value}");
            }
        }
        
        /// <summary>
        /// This function would assume that we have already verified that Bills > amount
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="Bills"></param>
        public void Withdrawl(int amount)
        {
            if (amount > 0 && amount <= GetTotal())
            {
                List<int> denominations = Bills.Keys.ToList();

                foreach (int bill in denominations)
                {
                    int count = amount / bill;
                    if (count >= Bills[bill])
                    {
                        amount -= Bills[bill] * bill;
                        Bills.Remove(bill);
                    }
                    else if (count < Bills[bill] && count !=0)
                    {
                        amount -= count * bill;
                        Bills[bill] -= count;
                    }
                    
                }
            }
            else {
                //todo list errorss \
            }
        }
        private void calculate(int amount, int[] denominations, int position)
        {
            if (amount == 0)
                return;
        }

        /*private void Calculate(int amount)
        {
            int[] billKeys  = Bills.Keys.ToArray();

            
            foreach (int i in billKeys)
            {
                int Count =amount / i;
                if (Bills[i] >= Count)
                    Bills[i] -= Count;

            }
          
        }*/


    }
}
