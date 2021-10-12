using System;

namespace FakeXrmEasy.Abstractions.Exceptions
{
    public class LicenseException : Exception
    {
        public LicenseException(string message) : base(message)
        {

        }
    }
}
