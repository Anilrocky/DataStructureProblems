using DataStructureProblems.AnagramProblem;
using DataStructureProblems.BankingCashCounterProblem;
using DataStructureProblems.BinarySearchProblem;
using DataStructureProblems.BubbleSortProblem;
using DataStructureProblems.CustomizeStringMessage;
using DataStructureProblems.InsertionSortProblem;
using DataStructureProblems.MergeSortProblem;
using DataStructureProblems.OrderedListProblem;
using DataStructureProblems.PrimeNumbersRange;
using DataStructureProblems.PrimePalindromeAnagram;
using DataStructureProblems.UnOrderedList;
using System;
namespace DataStructureProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structure Problems");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nChoose option to perform \n1.Binary search \n2.Insertion sort \n3.Bubble sort \n4.Anagram \n5.Prime numbers in range 0-1000 \n6.Customize string message \n7.Unordered list " +
                    "\n8.Ordered list \n9.Simple Banking Cash Counter \n10.Merge Sort \n11.Prime numbers that are palindrome,Anagram \n12.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        BinarySearch search = new BinarySearch();
                        search.ReadFile(@"D:\BridgeLabz\DataStructureProblems\DataStructureProblems\BinarySearchProblem\File.txt");
                        break;
                    case 2:
                        InsertionSort sort = new InsertionSort();
                        sort.ReadFile(@"D:\BridgeLabz\DataStructureProblems\DataStructureProblems\BinarySearchProblem\File.txt");
                        break;
                    case 3:
                        BubbleSort bubbleSort = new BubbleSort();
                        bubbleSort.ReadFile(@"D:\BridgeLabz\DataStructureProblems\DataStructureProblems\BubbleSortProblem\FileInteger.txt");
                        break;
                    case 4:
                        Anagram anagram = new Anagram();
                        anagram.CheckAnagram();
                        break;
                    case 5:
                        PrimeRange range = new PrimeRange();
                        range.PrimeNumbers();
                        break;
                    case 6:
                        CustomizeString customize = new CustomizeString();
                        customize.Customize();
                        break;
                    case 7:
                        LinkedListOperation linkedList = new LinkedListOperation();
                        linkedList.ReadFile(@"D:\BridgeLabz\DataStructureProblems\DataStructureProblems\UnOrderedList\File.txt");
                        break;
                    case 8:
                        OrderedList orderedList = new OrderedList();
                        orderedList.ReadFile(@"D:\BridgeLabz\DataStructureProblems\DataStructureProblems\OrderedListProblem\File.txt");
                        break;
                    case 9:
                        BankingCashCounter counter = new BankingCashCounter();
                        counter.Operation();
                        break;
                    case 10:
                        MergeSort mergeSort = new MergeSort();
                        mergeSort.ReadFile(@"D:\BridgeLabz\DataStructureProblems\DataStructureProblems\MergeSortProblem\File.txt");
                        break;
                    case 11:
                        PrimePalindrome palindrome = new PrimePalindrome();
                        palindrome.CheckPrime();
                        break;
                    case 12:
                        flag = false;
                        break;
                }
            }
        }
    }
}