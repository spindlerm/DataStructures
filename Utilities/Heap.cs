using System;

namespace Utilities
{
    public abstract class Heap
    {
        private int Size {get;}
        public int Count {get; private set; }

        protected int[] h;

        public Heap(int size)
        {
            if(size < 1)
                throw new InvalidHeapSizeException();

            this.Size = size+1; // +1 to allow for first pos always being 0
            Count = 0;
            h = new int[Size];
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

        protected  abstract bool ItemCompare(int itemA, int ItemB);
        
    }

    public class MaxHeap : Heap
    {
        public MaxHeap(int size) : base (size)
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
