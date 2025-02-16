﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnDSAlgorithms
{
    class SumofNumbers
    {
        public int sumn(int n)
        {
            return n * (n + 1) / 2;
        }

        public int sumniteration(int n)
        {
            int total = 0;
            int i = 1;
            while (i <= n)
            {
                total = total + i;
                i = i + 1;
            }
            return total;
        }

        public int sumnrecursion(int n)
        {
            if (n == 0)
                return 0;
            return sumnrecursion(n - 1) + n;
        }

        static void Main(string[] args)
        {
            SumofNumbers s = new SumofNumbers();
            Console.WriteLine("Sum: " + s.sumn(5));
            Console.WriteLine("Sum: " + s.sumniteration(5));
            Console.WriteLine("Sum: " + s.sumnrecursion(5));
            Console.ReadKey();
        }
    }
}
