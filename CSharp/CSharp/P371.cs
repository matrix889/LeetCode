using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P371
{
    class Solution
    {
        public int GetSum(int a, int b)
        {
            int result = a ^ b;
            int carry = (a & b) << 1;

            return (carry == 0) ? result : GetSum(result, carry);
        }
    }

}
