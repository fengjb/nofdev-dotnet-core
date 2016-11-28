using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Nofdev.Data.Xml
{
    public class NofdevException : Exception
    {
        /// <summary>
        /// Creates a new <see cref="NofdevException"/> object.
        /// </summary>
        public NofdevException()
        {

        }

        /// <summary>
        /// Creates a new <see cref="NofdevException"/> object.
        /// </summary>
        public NofdevException(SerializationInfo serializationInfo, StreamingContext context)
        //: base(serializationInfo, context)   //core没支持
        {

        }

        /// <summary>
        /// Creates a new <see cref="NofdevException"/> object.
        /// </summary>
        /// <param name="message">Exception message</param>
        public NofdevException(string message)
            : base(message)
        {

        }

        /// <summary>
        /// Creates a new <see cref="NofdevException"/> object.
        /// </summary>
        /// <param name="message">Exception message</param>
        /// <param name="innerException">Inner exception</param>
        public NofdevException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}
