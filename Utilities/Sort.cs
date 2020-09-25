using System;

namespace Utilities
{
    public class Sort
    {
        public static void SelectionSort(ref int[] list)
        {
            int comparisons;
            int swaps; 
            SelectionSort(ref list, out comparisons, out swaps);
        }
        public static void SelectionSort(ref int[] list, out int _comparisons, out int _swaps)
        {
            int comparisons = 0;
            int swaps = 0;   

            for (int i =0; i < list.Length; i++)
            {
                int smallestIdx = i;
                for( int j=i; j < list.Length; j++)
                {
                    comparisons++;
                    if(list[j] < list[i])
                        smallestIdx = j;
                }

                Swap(list, i, smallestIdx);
                swaps++;
            }

            _swaps = swaps;
            _comparisons = comparisons;
        }

        private static void Swap(int[] list, int i, int j)
        {
            int tmp = list[i];
            list[i] = list[j];
            list[j] = tmp;
        }

        public static void BubbleSort(ref int[] list)
        {
            int comarisons;
            int swaps; 
            BubbleSort(ref list, out comarisons, out swaps);
        }
        public static void BubbleSort(ref int[] list, out int _comparisons, out int _swaps)
        {
            int comparisons = 0;
            int swaps = 0;
            for (int i =0; i < list.Length; i++)
            {
                for( int j=1; j < list.Length; j++)
                {
                    comparisons++;
                    if(list[j] < list[j-1])
                    {
                        Swap(list, j, j-1);
                        swaps++;
                    }    
                }
            }

             _swaps = swaps;
            _comparisons = comparisons;
        }

        public static void BubbleSort2(ref int[] list)
        {
            int comarisons;
            int swaps; 
            BubbleSort2(ref list, out comarisons, out swaps);
        }
        public static void BubbleSort2(ref int[] list, out int _comparisons, out int _swaps)
        {
            int comparisons = 0;
            int swaps = 0;
            for (int i =0; i < list.Length; i++)
            {
                for( int j=1; j < list.Length-i; j++)
                {
                    comparisons++;
                    if(list[j] < list[j-1])
                    {
                        Swap(list, j, j-1);
                        swaps++;
                    }    
                }
            }

             _swaps = swaps;
            _comparisons = comparisons;
        }
    }
}
