using System;
using System.Runtime.Serialization;

namespace Hanoi
{
    [Serializable]
    internal class EmptyTowerException : Exception
    {
        public EmptyTowerException()
        {
        }

        public EmptyTowerException(string message) : base(message)
        {
        }

        public EmptyTowerException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected EmptyTowerException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}