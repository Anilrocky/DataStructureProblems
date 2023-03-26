using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems.BankingCashCounterProblem
{
    public class BankingCashCounter
    {
        LinkedListQueue<string> queue = new LinkedListQueue<string>();
        int amount = 10000;
        public BankingCashCounter()
        {
            queue.Enqueue("a");
            queue.Enqueue("b");
            queue.Enqueue("c");
            queue.Display();
        }
        public void Operation()
        {
            int count = queue.Size();
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("\nEnter option to operate \n1.Withdraw \n2.Deposit \n3.Check balance");
                int option = Convert.ToInt32(Console.ReadLine());   
                switch (option)
                {
                    case 1:
                        Withdraw();                       
                        break;
                    case 2:
                        Deposit();                        
                        break;
                    case 3:
                        CheckBalance();
                        break;
                }              
            }
            queue.Dequeue();
        }
        public void CheckBalance()
        {
            Console.WriteLine("Balance--> "+amount);
        }
        public void Withdraw()
        {
            Console.WriteLine("Enter an amount to withdraw");
            int withdrawAmount = Convert.ToInt32(Console.ReadLine());
            if (amount >= withdrawAmount)
                amount -= withdrawAmount;
            else
                Console.WriteLine("Insufficient balance, please try after sometime");
        }
        public void Deposit()
        {
            Console.WriteLine("Enter an amount to Deposit");
            int depositAmount = Convert.ToInt32(Console.ReadLine());
            amount += depositAmount;
        }
    }
}
