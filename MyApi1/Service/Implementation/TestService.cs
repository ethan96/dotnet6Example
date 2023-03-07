using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApi1.Service
{
    public class TestService : ITestService
    {
        public string HelloWord()
        {
            return "Hello Word";
        }

        public int[] ThrowRandom3(int max, int min)
        {
            Random r = new Random();
            int n1 = r.Next(min, max);
            int n2 = r.Next(min, max);
            int n3 = r.Next(min, max);

            return new int[] { n1, n2, n3 };
        }
    }
}