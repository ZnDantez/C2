﻿using System;
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

        public static List<Worker> workers = new List<Worker>();

        public Worker(string name)
        {
            this.name = name;
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
