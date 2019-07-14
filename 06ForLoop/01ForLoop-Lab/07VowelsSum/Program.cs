using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07VowelsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int charValue;
            int sum = 0;

            for (int i = 0; i < word.Length; i++)
            {
                switch (word[i])
                {
                    case 'a': charValue = 1; break;
                    case 'e': charValue = 2; break;
                    case 'i': charValue = 3; break;
                    case 'o': charValue = 4; break;
                    case 'u': charValue = 5; break;
                    default:
                        charValue = 0;
                        break;
                }

                sum += charValue;
            }

            Console.WriteLine(sum);
        }
    }
}
