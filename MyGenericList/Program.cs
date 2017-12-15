using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGenericList
{
    public class MyGenericList<T>
    {
        private class Node
        {

            private Node next;
            public T data;

            public Node(T t)
            {
                data = t;
                next = null;
            }

            public Node Next
            {
                get { return next; }
                set { next = value; }
            }
            public T Data
            {
                get { return data; }
                set { data = value; }
            }
        }
        Node head;
        public MyGenericList()
        {
            head = null;
        }

        public void addHead(T t)
        {
            Node n = new Node(t);
            n.Next = head;
            head = n;
            
        }
        public IEnumerator<T> GetEnumerator()
        {
            Node current = head;

            while (current != null)
            {
                yield return current.data;
                current = current.Next;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            // int is the type argument
            MyGenericList<int> list = new MyGenericList<int>();
            list.addHead(4);
            list.addHead(5);
            list.addHead(6);
            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }
    }
}
