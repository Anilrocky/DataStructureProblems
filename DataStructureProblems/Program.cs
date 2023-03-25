using DataStructureProblems.AnagramProblem;
using DataStructureProblems.BinarySearchProblem;
using DataStructureProblems.BubbleSortProblem;
using DataStructureProblems.CustomizeStringMessage;
using DataStructureProblems.InsertionSortProblem;
using DataStructureProblems.PrimeNumbersRange;
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
                Console.WriteLine("\nChoose option to perform \n1.Binary search \n2.Insertion sort \n3.Bubble sort \n4.Anagram \n5.Prime numbers in range 0-1000 \n6.Customize string message \n7.Exit");
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
                        flag = false;
                        break;
                }
            }
        }
    }
}