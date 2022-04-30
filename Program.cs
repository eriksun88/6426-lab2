//zhiyuan sun 1459462 lab2
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_lab_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            Test test = new Test(stack);
            test.DoPush();
            test.DoPush();
            test.DoPush();
            test.DoPush();
            test.DoPeek();
            test.DoPop();     
            test.DoClear();
            Console.ReadLine();
        }       
    }
}
