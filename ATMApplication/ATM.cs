using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATMApplication
{
    public class ATM
    {
        private Dictionary<int, int> Drawer = new Dictionary<int, int>();

        public ATM()
        {
            Stock();
        }
        /// <summary>
        /// Empties out the ATM, refills with default amount. 
        /// </summary>
        /// <returns></returns>
        public void Stock()
        {
            Drawer.Clear();
            Drawer = new Dictionary<int, int>
            {
                { 100, 10 },
                { 50, 10 },
                { 20, 10 },
                { 10, 10 },
                { 5, 10 },
                { 1, 10 }
            };
        }

        /// <summary>
        /// Gets Total value in ATM
        /// </summary>
        /// <returns></returns>
        public int CurrentBalance()
        {
            int CurrentBalance = 0;
            foreach (var bill in Drawer)
            {
                CurrentBalance += bill.Key * bill.Value;
            }
            return CurrentBalance;
        }   

        /// <summary>
        /// Lists bills to Console.
        /// </summary>
        public string List()
        {
            String  output = "Machine balance: \n";
            
            foreach (int bill in Drawer.Keys)
            {
                output += List(bill) + "\n";
            }
            return output;
        }


        public object List(int denomination)
        {
            if (Drawer.TryGetValue(denomination, out int value))
                return $"${denomination} - {value}";
            return $"${denomination} - 0";
        }


        /// <summary>
        /// This function would assume that we have already verified that Bills > amount
        /// </summary>
        /// <param name="CashToWithdraw"></param>
        public object Withdrawl(int CashToWithdraw)
        {
            //Filters out situations where amount is greater than amount in ATM or 
            if (CashToWithdraw > 0 && CashToWithdraw <= CurrentBalance())
            {
                int Starting = CashToWithdraw;
                Dictionary<int, int> Transaction = new Dictionary<int, int>(Drawer);
                List<int> denominations = Drawer.Keys.ToList();


                foreach (int denomination in denominations)
                {
                    int BillsRequired = CashToWithdraw / denomination;

                    if (BillsRequired >= Drawer[denomination])
                    {
                        CashToWithdraw -= Drawer[denomination] * denomination;
                        Drawer.Remove(denomination);

                    }
                    else if (BillsRequired < Drawer[denomination] && BillsRequired != 0)
                    {
                        CashToWithdraw -= BillsRequired * denomination;
                        Drawer[denomination] -= BillsRequired;
                    }
                }
                if (CashToWithdraw > 0)
                {
                    //rollback
                    Drawer = Transaction;
                    return "Failure: insufficient funds";
                }
                else
                    return $"Success: Dispensed ${Starting} \n{List()}";
            }
            else
                return "Failure: insufficient funds";
        }
    }
}
