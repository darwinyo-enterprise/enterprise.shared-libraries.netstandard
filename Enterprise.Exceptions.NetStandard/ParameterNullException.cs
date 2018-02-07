using Enterprise.Constants.NetStandard;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Enterprise.Exceptions.NetStandard
{
    /// <summary>
    /// Parameter Null Exception.
    /// </summary>
    public class ParameterNullException : Exception
    {
        public ParameterNullException():base(ExceptionMessage.PARAMETER_MUST_CONTAIN_VALUE)
        {
        }

        public ParameterNullException(string message) : base(message)
        {
        }

        public ParameterNullException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ParameterNullException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
