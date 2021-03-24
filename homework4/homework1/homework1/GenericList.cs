using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1
{
    
    public class GenericList<T> where T : struct, IComparable<T>
    {

        private Node<T> head;
        private Node<T> tail;
        public GenericList()
        {
            tail = head = null;
        }
        public Node<T> Head
        {
            get => head;
        }
        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        } 
        public void ForEach(Action<Node<T>, double[]> action, ref double[]record)
        {
            if (head != null)
            {
                Node<T> temp = head;
                while (temp != null)
                {
                    action(temp,record);
                    temp = temp.Next;
                }
                
            }
            else
            {
                Console.WriteLine("链表为空");
            }
        }
        
    }
}
