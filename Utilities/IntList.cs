using System;


namespace Utilities
{
    public class IntList
    {
        private Node head = null;
        private Node tail = null;
        
        public int Count { get; set;}

        private class Node
        {
            public int val  { get; set; }
            public Node next  { get; set; }
        
            public Node(int val, Node next)
            {
               this.val = val;
               this.next = next;
            }
            public Node(int val)
            {
               this.val = val;
               this.next = null;
            }
        }
        
        public  IntList()
        {
        }

        public int Pop()
        {
            // Returns the last elemet in the list - if there is one!
            return Pop(Count-1);
        }

        public int Pop(int index)
        {
            Node prev;
            Node target = _getAtIndex(index, out prev);


            if(target == head)
            {
                // If removing the head, update head
                head = target.next;
            }

            if(target == tail)
            {
                // If removing the tail, update tail
                tail = prev;
            }

            
            if(prev!=null)
                prev.next = target.next;
            
            // remove any references to other objects in the target node
            target.next = null;


            Count--;
            return target.val;
        }

        public int Get()
        {
            return Get(Count-1);
        }

        public int Get(int index)
        {
           
            Node prev;
            return _getAtIndex(index, out prev).val;
        }

        private Node _getAtIndex(int index, out Node prev)
        {
             if(head == null)
                throw new EmptyListException();

            if(index > Count-1)
                throw new InvalidListIndexException();

            // Find the node we want to return - target, also record the prev node
            int curInx = 0;
            Node target = head;
            Node _prev = null;
           
            while(curInx < index)
            {
                _prev = target; 
                target = target.next;
                curInx++;
            }

            prev = _prev;
            return target;
        }


        public void Add(int val)
        {
            Node n = new Node(val);  

            if (tail == null)
            {
                tail = n;
                head = n;
                Count = 1;
            }
            else
            {
                tail.next = n;
                tail = n;
                Count++;
            }  
        }
    }

}
