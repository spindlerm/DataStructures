using System;

namespace Utilities
{
    public class EmptyListException : Exception
    {
        public EmptyListException()
        {

        }

        public EmptyListException(string message) : base(message)
        {
        }
    }

    public class InvalidListIndexException : Exception
    {
        public InvalidListIndexException()
        {

        }

        public InvalidListIndexException(string message) : base(message)
        {
        }
    }

    public class EmptyHeapException : Exception
    {
        public EmptyHeapException()
        {

        }

        public EmptyHeapException(string message) : base(message)
        {
        }
    }

    public class InvalidHeapSizeException : Exception
    {
        public InvalidHeapSizeException()
        {

        }

        public InvalidHeapSizeException(string message) : base(message)
        {
        }
    }

     public class HeapSizeExceededException : Exception
    {
        public HeapSizeExceededException()
        {

        }

        public HeapSizeExceededException(string message) : base(message)
        {
        }
    }
}
