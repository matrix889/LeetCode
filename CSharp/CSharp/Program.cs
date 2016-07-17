using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            P371.Solution test = new P371.Solution();
            Console.WriteLine(test.GetSum(a, b));
            Console.WriteLine(a + b);

        }
    }
}
