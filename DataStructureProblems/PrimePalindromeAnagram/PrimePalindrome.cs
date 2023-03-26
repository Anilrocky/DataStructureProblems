using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.PrimePalindromeAnagram
{
    public class PrimePalindrome
    {
        public void CheckPrime()
        {
            int startRange = 0, endRange = 1000;
            Console.WriteLine("Prime numbers b/w {0} - {1} that are Anagram and Palindromes are: ", startRange, endRange);
            var primeNum = new List<int>();
            for (int i = startRange; i <= endRange; i++)
            {
                if (IsPrime(i))
                {
                    primeNum.Add(i);
                }
            }
            var results = new List<int>();
            for (int i = 0; i < primeNum.Count; i++)
            {
                for (int j = i + 1; j < primeNum.Count; j++)
                {
                    if (IsAnagram(primeNum[i], primeNum[j]) && IsPalindrome(primeNum[i]))
                    {
                        results.Add(primeNum[i]);
                        results.Add(primeNum[j]);
                    }
                }
            }
            results = results.Distinct().OrderBy(x => x).ToList();
            foreach (var data in results)
            {
                Console.Write(data + " ");
            }
        }
        public bool IsPrime(int n)
        {
            if (n < 2)
                return false;
            if (n == 2)
                return true;
            if (n % 2 == 0)
                return false;
            for (int i = 3; i <= n / 2; i += 2)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public bool IsPalindrome(int n)
        {
            var palindrome = n.ToString();
            return palindrome.SequenceEqual(palindrome.Reverse());
        }
        public bool IsAnagram(int a, int b)
        {
            var str1 = a.ToString().ToList();
            var str2 = b.ToString().ToList();
            str1.Sort();
            str2.Sort();
            return Enumerable.SequenceEqual(str1, str2);
        }
    }
}
