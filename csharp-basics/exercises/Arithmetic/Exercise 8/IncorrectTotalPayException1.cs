using System;
using System.Runtime.Serialization;

namespace Exercise_8
{
    public class IncorrectTotalPayException : System.Exception
    {
        public IncorrectTotalPayException()
        {
        }

        public IncorrectTotalPayException(string message) : base(message)
        {
        }

        public IncorrectTotalPayException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected IncorrectTotalPayException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}