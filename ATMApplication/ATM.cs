using System;
using System.Collections.Generic;
using System.Text;

namespace ATMApplication
{
    public class ATM
    {
        Dictionary<int, int> Bills = new Dictionary<int, int>();
        public void Restock()
        {
            Bills.Add(100, 10);
            Bills.Add(50, 10);
            Bills.Add(20, 10);
            Bills.Add(10, 10);
            Bills.Add(5, 10);
            Bills.Add(1, 10);
        }
        public int TotalValue()
        {
            int total = 0;
            foreach (var bill in Bills)
            {
                total += bill.Key * bill.Value;
            }
            return total;
        }
        public void Clear()
        {
            Bills.Clear();
        }
        public void List()
        {
            Console.WriteLine("Machine balance: ");
            foreach (var bill in Bills)
            {
                Console.WriteLine($"${bill.Key} - {bill.Value}");
            }
        }
        private void Withdrawl(int bill, int amount)
        {
           // if(!Bills.TryGetValue(bill))
            Bills[bill] -= amount;
        }
        public void Withdrawl(int amount)
        {
            //lets check to see if amount > total
            if (amount > TotalValue())
                return;
            else
            {
              
            }

        }
        private void Calculate(int amount)
        {
            for (int i = 0; i > amount; i++)
            {

            }
        }


    }
}
