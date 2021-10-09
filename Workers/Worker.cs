using System;
using System.Collections.Generic;
using System.Text;

namespace Workers
{
    abstract class Worker
    {
        protected string name;
        protected double salary;

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public static List<Worker> workers;

        public static void Init()
        {
            workers = new List<Worker>();
        }

        public Worker(string name)
        {
            this.name = name;
            workers.Add(this);
        }

        public static void ShowWorkers()
        {
            foreach (var worker in workers)
            {
                Console.WriteLine($"{worker.name} - {worker.salary}");
            }
        }
    }
}
