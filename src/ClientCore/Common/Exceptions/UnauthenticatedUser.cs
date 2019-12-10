using System;
using System.Collections.Generic;
using System.Text;

namespace GroupChat.ClientCore.Common.Exceptions
{

    [Serializable]
    public class UnauthenticatedUser : Exception
    {
        public UnauthenticatedUser(string message) : base(message) { }

        public UnauthenticatedUser(string message, Exception inner) : base(message, inner) { }

        protected UnauthenticatedUser(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
