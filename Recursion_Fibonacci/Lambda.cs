using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionFibonacci
{
    public static class Lambda
    {

        private static Func<int, int> MyFibFun = x => (x <= 1) ? x : MyFibFun(x - 1) + MyFibFun(x - 2);
        public static int GetFibonacci(int n) => MyFibFun(n);

    }
}
