using System;

namespace FakeXrmEasy.Abstractions.Exceptions
{
    public class LicenseException : Exception
    {
        internal LicenseException(string message) : base(message)
        {

        }
    }
}
