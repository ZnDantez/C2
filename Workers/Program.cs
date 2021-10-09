using System;

namespace Workers
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker.Init();
            Worker w2 = new FixedPaymentWorker("Коля");
            Worker w1 = new HiredWorker("Ваня", 100);
            Worker.ShowWorkers();
        }
    }
}
