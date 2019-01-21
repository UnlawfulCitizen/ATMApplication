using System;
using System.Collections.Generic;
using System.Text;

namespace ATMApplication
{
    interface ICash
    {
        int Value { get; set; }
        int Count { get; set; }
    }
}
