using System;
using System.Runtime.Serialization;

namespace FakeXrmEasy.Abstractions.Exceptions
{
    [Serializable]
    public class LicenseException : Exception
    {
        public LicenseException(string message) : base(message)
        {

        }

        protected LicenseException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}
