using System;

namespace FakeXrmEasy.Abstractions.Exceptions
{
    /// <summary>
    /// Exception thrown when the FakeXrmEasy License has not been configured
    /// </summary>
    public class LicenseException : Exception
    {
        /// <summary>
        /// Exception thrown when the FakeXrmEasy License has not been configured
        /// </summary>
        /// <param name="message">Message to show when the license has not been configured</param>
        public LicenseException(string message) : base(message) { }
    }
}
