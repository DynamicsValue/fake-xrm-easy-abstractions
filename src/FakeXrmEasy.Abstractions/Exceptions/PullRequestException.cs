using System;
using System.Runtime.Serialization;

namespace FakeXrmEasy.Abstractions.Exceptions
{
    /// <summary>
    /// Exception thrown for missing functionalities
    /// </summary>
    [Serializable]
    public class PullRequestException : Exception
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="sMessage"></param>
        public PullRequestException(string sMessage) :
            base(string.Format("Exception: {0}. This functionality is not available yet. Please consider contributing to the following Git project https://github.com/DynamicsValue/fake-xrm-easy by cloning the repository and issuing a pull request and/or raising an issue.", sMessage))
        {
        }

        /// <summary>
        /// Protected Constructor
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        protected PullRequestException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        /// <summary>
        /// Organization Request not implemented
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static PullRequestException NotImplementedOrganizationRequest(Type t)
        {
            return new PullRequestException(string.Format("The organization request type '{0}' is not yet supported... but we DO love pull requests so please feel free to submit one! :)", t.ToString()));
        }

        /// <summary>
        /// Organization Request partially not implemented
        /// </summary>
        /// <param name="t"></param>
        /// <param name="missingImplementation"></param>
        /// <returns></returns>
        public static PullRequestException PartiallyNotImplementedOrganizationRequest(Type t, string missingImplementation)
        {
            return new PullRequestException(string.Format("The organization request type '{0}' is not yet fully supported... {1}... but we DO love pull requests so please feel free to submit one! :)", t.ToString(), missingImplementation));
        }

        /// <summary>
        /// FetchXml Operator not implemented
        /// </summary>
        /// <param name="op"></param>
        /// <returns></returns>
        public static PullRequestException FetchXmlOperatorNotImplemented(string op)
        {
            return new PullRequestException(string.Format("The fetchxml operator '{0}' is not yet supported... but we DO love pull requests so please feel free to submit one! :)", op));
        }
    }
}