using System;


namespace Utilities
{
    public class IntDLList
    {
        private Node head = null;
        private Node tail = null;
        
        public int Count { get; set;}

        private class Node
        {
            public int val  { get; set; }
            public Node next  { get; set; }
            public Node prev  { get; set; }
        
            public Node(int val, Node prev, Node next)
            {
               this.val = val;
               this.prev = prev;
               this.next = next;
            }
            public Node(int val)
            {
               this.val = val;
               this.prev = null;
               this.next = null;
            }
        }
        
        public  IntDLList()
        {
        }

        public int Pop()
        {
            // Returns the last elemet in the list - if there is one!
            return Pop(Count-1);
        }

        public int Pop(int index)
        {
            Node target = _getAtIndex(index);


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

        public int Get()
        {
            return Get(Count-1);
        }

        public int Get(int index)
        {

            return _getAtIndex(index).val;
        }

        private Node _getAtIndex(int index)
        {
             if(head == null)
                throw new EmptyListException();

            if(index > Count-1)
                throw new InvalidListIndexException();

            // Find the node we want to return - target, also record the prev node
            int curInx = 0;
            Node target = head;
           
            while(curInx < index)
            {
                target = target.next;
                curInx++;
            }

         
            return target;
        }


        public void Add(int val)
        {
            

            if (tail == null)
            {
                Node n = new Node(val);  
                tail = n;
                head = n;
                Count = 1;
            }
            else
            {
                Node n = new Node(val, tail, null);  
                tail.next = n;
                tail = n;
                Count++;
            }  
        }
    }

}
