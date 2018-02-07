using System;
using System.Collections.Generic;
using System.Text;

namespace Enterprise.Comparer.NetStandard
{
    /// <summary>
    /// Used For Comparing Exception
    /// </summary>
    public class ExceptionComparer
    {
        /// <summary>
        /// Compare Exception
        /// </summary>
        /// <param name="t1">
        /// Exception 1
        /// </param>
        /// <param name="t2">
        /// Exception 2
        /// </param>
        /// <returns>
        /// return true if Exceptions Equals.
        /// </returns>
        public static bool Compare(Exception t1, Exception t2)
        {
            return t1.HelpLink == t2.HelpLink
                && t1.HResult == t2.HResult
                && t1.Message == t2.Message
                && t1.Source == t2.Source
                && t1.StackTrace == t2.StackTrace;
        }
    }
}
