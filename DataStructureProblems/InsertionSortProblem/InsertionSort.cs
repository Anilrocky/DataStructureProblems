using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.InsertionSortProblem
{
    public class InsertionSort
    {
        public void ReadFile(string filePath)
        {
            string readData = File.ReadAllText(filePath);
            string[] words = readData.Split(" ");
            foreach (var data in words)
            {
                Console.Write(data+" ");
            }
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = i+1; j < words.Length; j++)
                {
                    string temp = words[i];
                    words[i] = words[j];
                    words[j] = temp;
                }
                Console.WriteLine(words[i]+" ");
            }           
        }       
    }
}
