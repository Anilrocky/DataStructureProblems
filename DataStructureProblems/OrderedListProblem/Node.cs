using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.OrderedListProblem
{
    public class Node<T>
    {
        public T data;
        public Node<T> next;
        public Node(T value)
        {
            this.data = value;
        }
    }
}
