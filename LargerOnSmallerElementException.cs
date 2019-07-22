using System;
using System.Runtime.Serialization;

namespace Hanoi
{
    [Serializable]
    internal class LargerOnSmallerElementException : Exception
    {
        public LargerOnSmallerElementException()
        {
        }

        public LargerOnSmallerElementException(string message) : base(message)
        {
        }

        public LargerOnSmallerElementException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected LargerOnSmallerElementException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}