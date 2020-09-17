using System;
using System.Collections;
using System.Collections.Generic;


namespace Utilities
{
    public class GenDLList<T> : IEnumerable
    {
        private Node<T> head = null;
        private Node<T> tail = null;
        
        public int Count { get; set;}

        private class Node<_T>
        {
            public _T val  { get; set; }
            public Node<_T> next  { get; set; }
            public Node<_T> prev  { get; set; }
        
            public Node(_T val, Node<_T> prev, Node<_T> next)
            {
               this.val = val;
               this.prev = prev;
               this.next = next;
            }
            public Node(_T val)
            {
               this.val = val;
               this.prev = null;
               this.next = null;
            }
        }
        
        public  GenDLList()
        {
        }

        public T Pop()
        {
            // Returns the last elemet in the list - if there is one!
            return Pop(Count-1);
        }

        public T Pop(int index)
        {
            Node<T> target = _getAtIndex(index);

            if(target == head)
            {
                // If removing the head, update head
                head = target.next;
            }

            if(target == tail)
            {
                // If removing the tail, update tail
                tail = target.prev;
            }

            if(target.prev!=null)
                target.prev.next = target.next;
            
            // remove any references to other objects in the target node
            target.next = null;

            Count--;
            return target.val;
        }

        public T Get()
        {
            return Get(Count-1);
        }

        public T Get(int index)
        {
            return _getAtIndex(index).val;
        }

        private Node<T> _getAtIndex(int index)
        {
             if(head == null)
                throw new EmptyListException();

            if(index > Count-1)
                throw new InvalidListIndexException();

            // Find the node we want to return - target, also record the prev node
            int curInx = 0;
            Node<T> target = head;
           
            while(curInx < index)
            {
                target = target.next;
                curInx++;
            }

            return target;
        }


        public void Add(T val)
        {
            if (tail == null)
            {
                Node<T> n = new Node<T>(val);  
                tail = n;
                head = n;
                Count = 1;
            }
            else
            {
                Node<T> n = new Node<T>(val, tail, null);  
                tail.next = n;
                tail = n;
                Count++;
            }  
        }

        public IEnumerator<T> GetEnumerator()
        {
                Node<T> n = _getAtIndex(0);
                 yield return n.val;
        }
    
        IEnumerator  IEnumerable.GetEnumerator()
       {
          return this.GetEnumerator();
       }

        public IEnumerator<T> GedtEnumerator()
        {
            // Find the node we want to return - target, also record the prev node
                Node<T> target = head;
            
                while(target.next !=null)
                {
                    yield return target.val;
                    target = target.next;
                }
        }
    }
}
