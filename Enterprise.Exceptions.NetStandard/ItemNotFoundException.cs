using Enterprise.Constants.NetStandard;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Enterprise.Exceptions.NetStandard
{
    /// <summary>
    /// Requested Item Not Found Exception.
    /// Could be Cause Item Null.
    /// </summary>
    public class ItemNotFoundException : Exception
    {
        public ItemNotFoundException():base(ExceptionMessage.ITEM_NOT_FOUND)
        {
        }

        public ItemNotFoundException(string message) : base(message)
        {
        }

        public ItemNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ItemNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
