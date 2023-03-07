using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApi1.Service
{
    public interface ITestService
    {
        public string HelloWord();

        public int[] ThrowRandom3(int max, int min);
    }
}