using System;
using System.Collections.Generic;
using System.Text;

namespace Workers
{
    class FixedPayment : Worker
    {
        public FixedPayment(string name) : base(name)
        {
            salary = 10000;
        }
    }
}
