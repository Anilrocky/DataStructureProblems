using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.MergeSortProblem
{
    public class MergeSort
    {
        public void ReadFile(string filePath)
        {
            string readData = File.ReadAllText(filePath);
            string[] words = readData.Split(" ");
            int[] arr = new int[words.Length];
            int count = 0;
            foreach (var data in words)
            {
                arr[count] = Convert.ToInt32(data);
                count++;
                Console.Write(data+" ");
            }
            int left = 0;
            int right = words.Length;
            MergeSortArr(arr, left, right - 1);
            Display(arr,left,right);
        }
        public void MergeSortArr(int[] arr, int left, int right)
        {
            if (left<right)
            {
                int mid = left + (right - left) / 2;
                MergeSortArr(arr, left, mid);
                MergeSortArr(arr, mid + 1, right);
                Merge(arr, left, right, mid);
            }
        }
        public void Merge(int[] arr,int left, int right,int mid)
        {
            int i, j, k;
            int h1 = mid - left + 1;
            int n1 = right - mid;
            int[] a = new int[h1];
            int[] b = new int[n1];
            for (i = 0; i < h1; i++)
            {
                a[i] = arr[left + i];
            }
            for (j = 0; j < n1; j++)
            {
                b[j] = arr[mid + 1 + j];
            }
            i = 0;
            j = 0;
            k = left;
            while (i<h1 && j<n1)
            {
                if (a[i] <= b[j])
                {
                    arr[k] = a[i];
                    i++;
                }
                else
                {
                    arr[k] = b[j];
                    j++;
                }
                k++;
            }
            while (i<h1)
            {
                arr[k] = a[i];
                i++;
                k++;
            }
            while (j < n1)
            {
                arr[k] = b[j];
                j++;
                k++;
            }
        }
        public void Display(int[] arr,int left,int right)
        {
            Console.WriteLine();
            for (int i = left; i<right; i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
    }
}
