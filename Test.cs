using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_lab_2
{
    class Test
    {
        Stack<int> MyStack;
        Random Rdm;
        public Test(Stack<int> stack)
        {
            MyStack = stack;
            Rdm = new Random();
        }

        private int GenerateRandomNum()
        {
            int num =  Rdm.Next();
            Console.WriteLine("Generate Number is {0}",num);
            return num;
        }

        public void DoPush()
        {
            MyStack.Push(GenerateRandomNum());
        }
        public void DoPop()
        {
            int result = MyStack.Pop();
            Console.WriteLine("The result for Pop is {0}", result);
            Console.WriteLine("After Pop, total number of elements in the stack are {0}", MyStack.Count());
        }
        public void DoPeek()
        {
            int result = MyStack.Peek();
            Console.WriteLine("The result for Peek is {0}", result);
            Console.WriteLine("After Peek, total number of elements in the stack are {0}", MyStack.Count());
        }
        public void DoClear()
        {
            MyStack.Clear();
            Console.WriteLine("After Clear, total number of elements in the stack are {0}", MyStack.Count());
        }
    }
    
}
