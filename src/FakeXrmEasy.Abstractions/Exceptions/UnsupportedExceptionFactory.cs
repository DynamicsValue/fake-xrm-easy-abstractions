using FakeXrmEasy.Abstractions.Enums;
using System;

namespace FakeXrmEasy.Abstractions.Exceptions
{
    /// <summary>
    /// A factory class to raise unsupported exceptions based on the current license context
    /// </summary>
    public static class UnsupportedExceptionFactory
    {
        /// <summary>
        /// Returns a new general purpose exception based on the current license context
        /// </summary>
        /// <param name="currentLicense"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static Exception New(FakeXrmEasyLicense currentLicense, string message)
        {
            switch (currentLicense)
            {
                case FakeXrmEasyLicense.Commercial:
                    return new CommercialUnsupportedException(message);

                case FakeXrmEasyLicense.NonCommercial:
                    return new NonCommercialUnsupportedException(message);

                case FakeXrmEasyLicense.RPL_1_5:
                default:
                    return new OpenSourceUnsupportedException(message);
            }
        }

        /// <summary>
        /// Returns a not supported organization request exception
        /// </summary>
        /// <param name="currentLicense"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static Exception NotImplementedOrganizationRequest(FakeXrmEasyLicense currentLicense, Type t)
        {
            return New(currentLicense, $"The organization request type '{t}' is not yet supported... ");
        }

        /// <summary>
        /// Returns a partially not supported organization request exception
        /// </summary>
        /// <param name="currentLicense"></param>
        /// <param name="t"></param>
        /// <param name="missingImplementation"></param>
        /// <returns></returns>
        public static Exception PartiallyNotImplementedOrganizationRequest(FakeXrmEasyLicense currentLicense, Type t, string missingImplementation)
        {
            return New(currentLicense, $"The organization request type '{t}' is not yet fully supported... {missingImplementation}...");
        }

        /// <summary>
        /// Returns a fetchxml operator not supported exception
        /// </summary>
        /// <param name="currentLicense"></param>
        /// <param name="op"></param>
        /// <returns></returns>
        public static Exception FetchXmlOperatorNotImplemented(FakeXrmEasyLicense currentLicense, string op)
        {
            return New(currentLicense, $"The fetchxml operator '{op}' is not yet supported... ");
        }
    }
}
