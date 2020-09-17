using System;
using Xunit;
using Utilities;

namespace myTests
{
    public class TestMaxHeap
    {
        [Fact]
        public void GivenEmptyMAxHeap_WhenInvaidSizeSet_ThrowInvalidHeapSizeException()
        {
            MaxHeap h = null;
            Assert.Throws<InvalidHeapSizeException>(() =>h = new MaxHeap(0));
        }

        [Fact]
        public void GivenEmptyMAxHeap_WhenCallCount_Return0()
        {
            MaxHeap h = new MaxHeap(3);
            Assert.Equal(0, h.Count);
        }

        [Fact]
        public void GivenEmptyMaxHeap_WhenCallGetMax_ThrowEmptyHeapException()
        {
            MaxHeap h = new MaxHeap(3);
            Assert.Throws<EmptyHeapException>(() => h.GetMax());
        }

        [Fact]
        public void GivenEmptyMaxHeap_WhenCallInsertMoreItemsThanSize_ThrowHeapSizeExceededException()
        {
            MaxHeap h = new MaxHeap(3);
            h.Insert(10);
            h.Insert(20);
            h.Insert(30);
            Assert.Throws<HeapSizeExceededException>(() => h.Insert(40));
        }

        [Fact]
        public void GivenEmptyMaxHeap_WhenCallInsertThenCount_Returns1()
        {
            MaxHeap h = new MaxHeap(3);
            h.Insert(10);
            Assert.Equal(1, h.Count);
        }

        [Fact]
        public void GivenEmptyMaxHeap_WhenCallInsertThenGetMax_ReturnsItemInserted()
        {
            MaxHeap h = new MaxHeap(3);
            h.Insert(10);
            Assert.Equal(10, h.GetMax());
        }

        [Fact]
        public void GivenEmptyMaxHeap_WhenCallInsertMultipleTimesThenGetMax_ReturnsItemMax()
        {
            MaxHeap h = new MaxHeap(3);
            h.Insert(10);
            h.Insert(20);
            h.Insert(30);
            Assert.Equal(30, h.GetMax());
        }
    }

    public class TestMinHeap
    {
        [Fact]
        public void GivenEmptyMinHeap_WhenInvaidSizeSet_ThrowInvalidHeapSizeException()
        {
            MinHeap h = null;
            Assert.Throws<InvalidHeapSizeException>(() =>h = new MinHeap(0));
        }

        [Fact]
        public void GivenEmptyMinHeap_WhenCallCount_Return0()
        {
            MinHeap h = new MinHeap(3);
            Assert.Equal(0, h.Count);
        }

        [Fact]
        public void GivenEmptyMineap_WhenCallGetMax_ThrowEmptyHeapException()
        {
            MinHeap h = new MinHeap(3);
            Assert.Throws<EmptyHeapException>(() => h.GetMin());
        }

        [Fact]
        public void GivenEmptyMinHeap_WhenCallInsertMoreItemsThanSize_ThrowHeapSizeExceededException()
        {
            MinHeap h = new MinHeap(3);
            h.Insert(10);
            h.Insert(20);
            h.Insert(30);
            Assert.Throws<HeapSizeExceededException>(() => h.Insert(40));
        }

        [Fact]
        public void GivenEmptyMinHeap_WhenCallInsertThenCount_Returns1()
        {
            MinHeap h = new MinHeap(3);
            h.Insert(10);
            Assert.Equal(1, h.Count);
        }

        [Fact]
        public void GivenEmptyMinHeap_WhenCallInsertThenGetMax_ReturnsItemInserted()
        {
            MinHeap h = new MinHeap(3);
            h.Insert(10);
            Assert.Equal(10, h.GetMin());
        }

        [Fact]
        public void GivenEmptyMinHeap_WhenCallInsertMultipleTimesThenGetMax_ReturnsItemMax()
        {
            MinHeap h = new MinHeap(4);
            h.Insert(30);
            h.Insert(20);
            h.Insert(1);
            h.Insert(10);
            Assert.Equal(1, h.GetMin());
        }
    }
}
