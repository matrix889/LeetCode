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
            P345.Solution tmp = new P345.Solution();
            for (var index = 0; index < 5; ++index)
            {
                string s = Console.ReadLine();
                Console.WriteLine(tmp.ReverseVowels(s));
            }

        }
    }
}
