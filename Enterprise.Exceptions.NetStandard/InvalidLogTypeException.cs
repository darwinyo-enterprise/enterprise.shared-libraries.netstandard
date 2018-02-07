using Enterprise.Constants.NetStandard.LoggingServer;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Enterprise.Exceptions.NetStandard
{
    /// <summary>
    /// Bad Log Type Exception.
    /// Make Sure You have define Log Model Correctly.
    /// </summary>
    public class InvalidLogTypeException : Exception
    {
        public InvalidLogTypeException():base(ExceptionMessage.LOG_TYPE_DOESNT_MATCH)
        {
        }

        public InvalidLogTypeException(string message) : base(message)
        {
        }

        public InvalidLogTypeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidLogTypeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
