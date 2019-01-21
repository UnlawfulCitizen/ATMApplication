using System;
using System.Collections.Generic;
using System.Text;

namespace ATMApplication
{
    class Cash : ICash
    {
        public int Value { get; set; } 
        public int Count { get; set; }

        public Cash(int value, int count)
        {
            Value = value;
            Count = count;
        }

    }
}
