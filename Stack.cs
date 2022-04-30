using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_lab_2
{
    class Stack<T>
    {
        LinkedList<T> MyList;

        public Stack()
        {
            this.MyList = new LinkedList<T>();
        }
        public void Push(T obj)
        {
            MyList.AddFirst(obj);    
        }
        public T Peek()
        {
            if (MyList.Count >0)
            {
                return MyList.First();
            }
            else
            {
                throw new InvalidOperationException();
            }
              
        }
        public T Pop()
        {
            if (MyList.Count > 0)
            {
                T top = MyList.First();
                MyList.Remove(MyList.First());
                return top;               
            }
            else
            {
                throw new InvalidOperationException();
            }               
        }
        public void Clear()
        {
            MyList.Clear();
        }
        public int Count()
        {
            return MyList.Count();
        }
    }   
}
