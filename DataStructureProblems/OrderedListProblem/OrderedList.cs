using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.OrderedListProblem
{
    public class OrderedList
    {
        public void ReadFile(string filePath)
        {
            LinkedList<int> list = new LinkedList<int>();
            string readData = File.ReadAllText(filePath);
            string[] words = readData.Split(" ");
            foreach (var data in words)
            {
                int item = Convert.ToInt32(data);
                list.Add(item);
            }
            Console.WriteLine("Enter any number");
            int input = Convert.ToInt32(Console.ReadLine());
            int result = list.SearchElement(input);
            if (result != -1)
            {
                Console.WriteLine("Entered number found \nRemoving from linked list");
                list.DeleteElementAtParticularPosition(result);
            }
            else
            {
                list.Add(input);
            }
            list.Display();
        }
    }
}
