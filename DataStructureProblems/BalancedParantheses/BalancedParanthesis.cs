using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.BalancedParantheses
{
    public class BalancedParanthesis
    {
        public void ReadFile(string filePath)
        {
            LinkedListStack<string> listStack = new LinkedListStack<string>();
            string readData = File.ReadAllText(filePath);
            string[] words = readData.Split(" ");
            foreach (var data in words)
            {
                if (data.Equals("("))
                {
                    listStack.Push(data);
                }
                if (data.Equals(")"))
                {
                    listStack.Pop();
                }
            }
            listStack.Peek();
            listStack.Display();
        }
    }
}
