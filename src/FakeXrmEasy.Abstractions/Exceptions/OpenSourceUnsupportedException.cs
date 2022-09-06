using System;

namespace FakeXrmEasy.Abstractions.Exceptions
{
    /// <summary>
    /// Unsupported exception raised in the context of an open source use
    /// </summary>
    public class OpenSourceUnsupportedException : Exception
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public OpenSourceUnsupportedException(string message)
            : base($"Exception occurred: {message}. If you are using FakeXrmEasy in an Open Source project please raise an issue via our GitHub issue tracker at https://github.com/DynamicsValue/fake-xrm-easy. Also please do consider giving back to the OSS community by contributing back to our project via a pull request. The community will appreciate any kind contribution even if small: typos, comments, steps to reproduce a bug, documentation, or new ideas for new features. If you are unsure about our licensing, please have a look at our licensing FAQ here: https://dynamicsvalue.github.io/fake-xrm-easy-docs/licensing/faq/")

        {

        }
    }
}
