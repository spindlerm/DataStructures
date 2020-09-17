using System;
using Xunit;
using Utilities;

namespace myTests
{
    public class Selection_Sort_tests
    {
        [Fact]
        public void GivenEmtyListOfInts_WhenSorted_ResultIsEmptyList()
        {
            int[] toSort = new int[]{};

            Sort.SelectionSort(ref toSort);

            Assert.Equal(toSort, new int[]{});
        }

        [Fact]
        public void GivenListOfOneInt_WhenSorted_ResultIsListOfOneInt()
        {
            int[] toSort = new int[]{1};

            Sort.SelectionSort(ref toSort);

            Assert.Equal(toSort, new int[]{1});
        }

         [Fact]
        public void GivenUnsortedListOfInts_WhenSorted_ResultSortedListOfInts()
        {
            int[] toSort = new int[]{9,8,7,6,5,4,3,2,1};

            Sort.SelectionSort(ref toSort);

            Assert.Equal(new int[]{1,2,3,4,5,6,7,8,9}, toSort);
        }
    }

    public class Bubble_Sort_tests
    {
        [Fact]
        public void GivenEmtyListOfInts_WhenSorted_ResultIsEmptyList()
        {
            int[] toSort = new int[]{};

            Sort.BubbleSort(ref toSort);

            Assert.Equal(toSort, new int[]{});
        }

        [Fact]
        public void GivenListOfOneInt_WhenSorted_ResultIsListOfOneInt()
        {
            int[] toSort = new int[]{1};

            int comparisons;
            int swaps;

            Sort.BubbleSort(ref toSort, out comparisons, out swaps);

            Assert.Equal(toSort, new int[]{1});
        }

         [Fact]
        public void GivenUnsortedListOfInts_WhenSorted_ResultSortedListOfInts()
        {
            int[] toSort = new int[]{9,8,7,6,5,4,3,2,1};

            int comparisons;
            int swaps;
            Sort.BubbleSort2(ref toSort, out comparisons, out swaps);

            Assert.Equal(new int[]{1,2,3,4,5,6,7,8,9}, toSort);
        }
    }
}
