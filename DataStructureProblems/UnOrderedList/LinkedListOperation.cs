using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.UnOrderedList
{
    public class LinkedListOperation
    {
        public void ReadFile(string filePath)
        {
            LinkedList<string> list = new LinkedList<string>();
            string readData = File.ReadAllText(filePath);
            string[] words = readData.Split(" ");
            foreach (var data in words)
            {
                list.Add(data);
            }
            Console.WriteLine("\nEnter any word");
            string input = Console.ReadLine();
            int result= list.SearchElement(input);
            if (result != -1)
            {
                Console.WriteLine("Entered word found \nRemoving word from Linked list");               
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
