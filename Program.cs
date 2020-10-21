using System;
using System.Security.Cryptography.X509Certificates;

namespace Scrabble
{
    class Program
    {
        static int Scrabs(string passed)
        {
            int total = 0;
            string lowPass = passed.ToLower();
            char[] conPass = new char[passed.Length];
            conPass = lowPass.ToCharArray();
            for (int i = 0; i < conPass.Length; i++)
            {
                if (conPass[i] == 'a' || conPass[i] == 'i' || conPass[i] == 'e' || conPass[i] == 'o' || conPass[i] == 'l' || conPass[i] == 'n' || conPass[i] == 'r'
                    || conPass[i] == 'u' || conPass[i] == 's' || conPass[i] == 't')
                {
                    total += 1;
                }
                else if (conPass[i] == 'd' || conPass[i] == 'g')
                {
                    total += 2;
                }
                else if (conPass[i] == 'b' || conPass[i] == 'c' || conPass[i] == 'p' || conPass[i] == 'm')
                {
                    total += 3;
                }
                else if (conPass[i] == 'v' || conPass[i] == 'f' || conPass[i] == 'h' || conPass[i] == 'y' || conPass[i] == 'w')
                {
                    total += 4;
                }
                else if (conPass[i] == 'k')
                {
                    total += 5;
                }
                else if (conPass[i] == 'z' || conPass[i] == 'q')
                {
                    total += 10;
                }
                else if (conPass[i] == 'x' || conPass[i] == 'j')
                {
                    total += 8;
                }
                else
                    total += -300;
            }

            return total;
        }
        static void Main(string[] args)
        {
            bool isTrue = true;
            while (isTrue)
            {
                string word;
                Console.WriteLine("Lets Scrabble a word?");
                word = Console.ReadLine();
                int score = Scrabs(word);
                
                if (score > 0)
                {
                    Console.WriteLine($"Your Score is {score}.");   
                }
                else
                {
                    Console.WriteLine("Thats not how you play scrabble stupid!");
                }
            }

        }
    }
}