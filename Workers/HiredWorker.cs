using System;
using System.Collections.Generic;
using System.Text;

namespace Workers
{
    class HiredWorker : Worker
    {
        int hourlyPayment;

        public HiredWorker(string name, int hourlyPayment) : base(name)
        {
            this.hourlyPayment = hourlyPayment;
            salary = 20.8 * 8 * hourlyPayment;
        }
    }
}
