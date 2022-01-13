using System;
using System.Collections.Generic;

namespace Entropy
{
    class Program
    {
        static void Main(string[] args)
        {
            string uncompressedLetters = Console.ReadLine();

            int count = 1;
            string compressedLetters = uncompressedLetters[0].ToString();
            char lastLetter = compressedLetters[0];
            for (int i = 1; i < uncompressedLetters.Length; i++)
            {

                if (uncompressedLetters[i] == lastLetter)
                {
                    count++;
                }
                else
                {
                    compressedLetters += count;
                    count = 1;
                    lastLetter = uncompressedLetters[i];
                    compressedLetters += lastLetter;

                }
                if (i == uncompressedLetters.Length - 1)
                {
                    compressedLetters += count;
                }
            }



            Console.WriteLine(compressedLetters);
        }
    }
}
