using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.BinarySearchProblem
{
    public class BinarySearch
    {
        public void ReadFile(string filePath)
        {
            string readData = File.ReadAllText(filePath);
            string[] words = readData.Split(' ');
            foreach (var data in words)
            {
                Console.Write(data+" ");
            }
            Console.WriteLine("\nEnter word to search");
            string search = Console.ReadLine();
            foreach (var data in words)
            {
                if (data.ToLower().Equals(search))
                {
                    Console.WriteLine("{0}--> word is found",data);
                    return;
                }
            }
            Console.WriteLine("Word is not found");
        }
    }
}
