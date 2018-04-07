using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            BigInteger factoriel = 1;
        
            for (int i = input; i > 0; i--)
            {
                factoriel *= i;
            }
            Console.WriteLine(factoriel);
        }
    }
}
