using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyProgrammer_254
{
    class Program
    {

        static void Main(string[] args)
        {

            string plain = " abcdefghijklmnopqrstuvwxyz/ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string cipher = " zyxwvutsrqponmlkjihgfedcba/ZYXWVUTSRQPONMLKJIHGFEDCBA";

            var plainChar = plain.ToCharArray();
            var cipherChar = cipher.ToCharArray();

            Console.Write("Please enter a word/sentance: ");
            string input = Console.ReadLine();
            var inputChar = input.ToCharArray();

            for (int h = 0; h < input.Length; h++)
            {
                for (int i = 0; i < plain.Length; i++)
                {
                    if (inputChar[h] == plainChar[i])
                    {
                        inputChar[h] = cipherChar[i];
                        Console.Write(inputChar[h]);
                        break;
                    }
                }
            }
            Console.Read();
        }
    }
}
