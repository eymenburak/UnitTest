using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest.App
{
    public class CalculatorService : ICalculatorService
    {
        public int Add(int a, int b)
        {
            return 0;
        }

        public int Multip(int a, int b)
        {

            if (a==0)
            {
                throw new Exception("a = 0 !!!");

            }
            return a * b;
        }
    }
}
