using Enterprise.Constants.NetStandard;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Enterprise.Exceptions.NetStandard
{
    /// <summary>
    /// Attempt To Update But object are equal to target object.
    /// Probably User Not Changing Anything, but user attempt to update the record.
    /// </summary>
    public class NoChangesToUpdateException : Exception
    {
        public NoChangesToUpdateException():base(ExceptionMessage.NO_CHANGES_TO_UPDATE)
        {
        }

        public NoChangesToUpdateException(string message) : base(message)
        {
        }

        public NoChangesToUpdateException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NoChangesToUpdateException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
