using System;
using System.Collections.Generic;
using System.Text;

namespace Workers
{
    class FixedPaymentWorker : Worker
    {
        public FixedPaymentWorker(string name) : base(name)
        {
            salary = 10000;
        }
    }
}
