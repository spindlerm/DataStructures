using System;
using Xunit;
using Utilities;

namespace myTests
{
    public class TestIntList
    {
        [Fact]
        public void GivenAnEmptyList_WhenCallCount_ThenReturnZero()
        {
            IntList l = new IntList();

            Assert.Equal(0, l.Count);
        }

         [Fact]
        public void GivenAnEmptyList_WhenCallPop_ThenThrowEmptyListException()
        {
            IntList l = new IntList();
            Assert.Throws<EmptyListException>(() => l.Pop());
            
        }

        [Fact]
        public void GivenAnEmptyList_WhenCallGet_ThenThrowEmptyListException()
        {
            IntList l = new IntList();
            Assert.Throws<EmptyListException>(() => l.Get());
            
        }

       

        [Fact]
        public void GivenAnEmptyList_WhenCallPopWithIndex_ThenThrowEmptyListException()
        {
            IntList l = new IntList();
            Assert.Throws<EmptyListException>(() => l.Pop(1));
            
        }

        [Fact]
        public void GivenAPopulatedList_WhenCallPopWithInvalidIndex_ThenThrowEmptyListException()
        {
            IntList l = new IntList();
            l.Add(1);
            l.Add(2);
            l.Add(3);
            Assert.Throws<InvalidListIndexException>(() => l.Pop(10));
            
        }
        
        [Fact]
        public void GivenAPopulatedList_WhenCallWithInvalidIndex_ThenThrowInvalidListIndexException()
        {
            IntList l = new IntList();
            l.Add(1);
            l.Add(2);
            l.Add(3);
            Assert.Throws<InvalidListIndexException>(() => l.Get(10));
        }

        [Fact]
        public void GivenAnEmptyList_WhenCallAppend_ThenCallPopReturnAppendedItem()
        {
            IntList l = new IntList();
            l.Add(5);
            Assert.Equal(5, l.Pop());

            
        }

        [Fact]
        public void GivenAnEmptyList_WhenCallAppendMultipleTimes_ThenCallPopReturnAppendedItemsInReverseOrder()
        {
            IntList l = new IntList();
            l.Add(1);
            l.Add(2);
            l.Add(3);
            l.Add(4);
            l.Add(5);
            Assert.Equal(5, l.Count);
            Assert.Equal(5, l.Pop());
            Assert.Equal(4, l.Count);
            Assert.Equal(4, l.Pop());
            Assert.Equal(3, l.Count);
            Assert.Equal(3, l.Pop());
            Assert.Equal(2, l.Count);
            Assert.Equal(2, l.Pop());
            Assert.Equal(1, l.Count);
            Assert.Equal(1, l.Pop());
            Assert.Equal(0, l.Count);
            Assert.Throws<EmptyListException>(() => l.Pop());

            
        }
    
        [Fact]
        public void GivenAnEmptyList_WhenCallAddMultipleTimes_ThenCallPopWithIndexReturnCorrectItem()
        {
            IntList l = new IntList();
            l.Add(1);
            l.Add(2);
            l.Add(3);
            l.Add(4);
            l.Add(5);
            Assert.Equal(5, l.Count);
            Assert.Equal(1, l.Pop(0));
            Assert.Equal(4, l.Count);
            Assert.Equal(2, l.Pop(0));
            Assert.Equal(3, l.Count);
        }

        [Fact]
        public void GivenAnEmptyList_WhenCallAddMultipleTimes_ThenCallGetWithIndexReturnCorrectItemAndMaintainOriginalCount()
        {
            IntList l = new IntList();
            l.Add(1);
            l.Add(2);
            l.Add(3);
            l.Add(4);
            l.Add(5);
            Assert.Equal(5, l.Count);
            Assert.Equal(1, l.Get(0));
            Assert.Equal(2, l.Get(1));
            Assert.Equal(3, l.Get(2));
            Assert.Equal(4, l.Get(3));
            Assert.Equal(5, l.Get(4));
            Assert.Equal(5, l.Count);
        }
    

        [Fact]
        public void GivenAnNonEmptyList_WhenCallCount_ThenReturnCountOfItems()
        {
            IntList l = new IntList();
            
            l.Add(1);
            l.Add(2);
            l.Add(3);
            l.Add(4);
            l.Add(5);

            Assert.Equal(5, l.Count);
        }
    }
}
