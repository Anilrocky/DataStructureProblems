using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.AnagramProblem
{
    public class Anagram
    {
        public void CheckAnagram()
        {
            Console.WriteLine("Enter first word");
            string word1 = Console.ReadLine();
            Console.WriteLine("Enter second word");
            string word2 = Console.ReadLine();
            if (word1.Length != word2.Length)
            {
                Console.WriteLine("Given words are not anagram");
            }
            else
            {
                char[] chars1 = word1.ToCharArray();
                Array.Sort(chars1);
                word1 = new string(chars1 );
                char[] chars2 = word2.ToCharArray();
                Array.Sort(chars2);
                word2 = new string(chars2);
                if (word1 == word2)
                {
                    Console.WriteLine("Given words are anagram");
                }
                else
                {
                    Console.WriteLine("Given words are not anagram");
                }
            }
        }
    }
}
