using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();
            Random rnd = new Random();
            for (int i = 0; i < words.Length; i++)
            {

                int wordOne = rnd.Next(0, words.Length);
                int wordTwo = rnd.Next(0, words.Length);

                string temp = words[wordOne];
                words[wordOne] = words[wordTwo];
                words[wordTwo] = temp;

            }
            Console.WriteLine(string.Join("\n", words));
        }
    }
}
