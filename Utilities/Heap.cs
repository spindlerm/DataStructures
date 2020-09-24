using System;

namespace Utilities
{
    public abstract class Heap
    {
        protected int Size {get; set;}
        public int Count {get; protected set; }

        protected int[] h;

        public Heap(int size)
        {
            if(size < 1)
                throw new InvalidHeapSizeException();

            Init(size);
        }

        private void Init(int size)
        {
                Size = size+1; // +1 to allow for first pos always being 0
                Count = 0;
                h = new int[Size];
        }

        public Heap(int [] list) 
        {
            Init(list.Length);

            for (int i = 0; i < list.Length; i++)
            {
                //Remember h start at pos 1
                h[i+1] = list[i];
            }

            Count = list.Length;

            Heapify();
        }


        public int GetRootElement()
        {
            if (Count != 0)
                return h[1];
            else
                throw new EmptyHeapException();
        }

        public void Insert(int item)
        {
            if(Count == Size-1)
                throw new HeapSizeExceededException(); 

            if(Count < Size-1)
            {
                h[Count+1] = item;
                Promote(Count+1);
                Count++;
            }
        }

        private void Promote(int pos)
        {
            while(pos  >1)
            {
                if(ItemCompare(h[pos], h[(int)(pos / 2)]))
                {
                    int tmp = h[(int)(pos / 2)];
                    h[(int)(pos / 2)] = h[pos];
                    h[pos] = tmp;
                }

                pos = (int)(pos /2);
            }
        }

        private void Demote(int pos)
        {
            while (pos*2 <= Count)
            {
                int scp = ChildPos(pos);
                if(ItemCompare(h[scp], h[pos]))
                {
                    int tmp = h[pos];
                    h[pos] = h[scp];
                    h[scp] = tmp;
                }
                pos = scp;
            }

        }

        private  int ChildPos(int pos)
        {
            int leftPos = pos*2;
            int rightPos = pos*2+1;

            int scp = leftPos; //default to the left child

            //Does the node at pos have a right child
            if(rightPos <= Count)
            {
                if(ItemCompare(h[rightPos], h[scp]))
                    scp = rightPos;
            }

            return scp;
        }


        protected void Heapify()
        {
            // Nodes = elements in a binary tree that have at least 1 child
            // Child item in a binary tree = element with no child
            // In a binary tree represented as an array (starting at pos 1) nodes occur in positions 1 - len/2


            //loop through lower nodes upto the root
            for (int i = Count/2 ; i > 0; i--)
            {
                Demote(i);
            }
        }

        protected  abstract bool ItemCompare(int itemA, int ItemB);
        
    }

    public class MaxHeap : Heap
    {
        public MaxHeap(int size) : base (size)
        {
           
        }

        public MaxHeap(int [] list) : base(list)
        {

        }

        public int GetMax()
        {
            return GetRootElement();
        }

        protected override bool ItemCompare(int itemA, int itemB)
        {
            // itemA is the item being added to the heap, itemB is an existing item being compared against
            return itemA > itemB ? true : false; 
        }
    }

    public class MinHeap : Heap
    {
        public MinHeap(int size) : base (size)
        {
           
        }

        public MinHeap(int [] list) : base(list)
        {
            
        }


        public int GetMin()
        {
            return GetRootElement();
        }

        protected override bool ItemCompare(int itemA, int itemB)
        {   
            // itemA is the item being added to the heap, itemB is an existing item being compared against          
            return itemA < itemB ? true : false; 
        }
    }
}
