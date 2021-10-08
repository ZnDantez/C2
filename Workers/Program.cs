using System;

namespace Workers
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker w2 = new FixedPaymentWorker("Коля");
            Worker.workers.Add(w2);
            Worker w1 = new HiredWorker("Ваня", 100);
            Worker.workers.Add(w1);
            Worker.ShowWorkers();
        }
    }
}
