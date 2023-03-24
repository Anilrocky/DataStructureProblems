using DataStructureProblems.BinarySearchProblem;
using DataStructureProblems.BubbleSortProblem;
using DataStructureProblems.InsertionSortProblem;
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
                Console.WriteLine("\nChoose option to perform \n1.Binary search \n2.Insertion sort \n3.Bubble sort \n4.Exit");
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
                        flag = false;
                        break;
                }
            }
        }
    }
}