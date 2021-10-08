using System;
using System.Collections.Generic;
using System.Text;

namespace Workers
{
    class HiredWorker : Worker
    {
        int hour;

        public HiredWorker(string name, int hour) : base(name)
        {
            this.hour = hour;
            salary = 20.8 * 8 * hour;
        }
    }
}
