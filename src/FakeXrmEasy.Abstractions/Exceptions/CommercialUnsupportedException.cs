using System;

namespace FakeXrmEasy.Abstractions.Exceptions
{
    /// <summary>
    /// Unsupported Exception thrown in a commercial license context
    /// </summary>
    public class CommercialUnsupportedException: Exception
    { 
        /// <summary>
        /// Default constructor
        /// </summary>
        public CommercialUnsupportedException(string message)
           : base ($"Exception occurred: {message}. If you are using FakeXrmEasy under a commercial context and have an appropiate commercial license for this use, please raise an issue via our GitHub issue tracker at https://github.com/DynamicsValue/fake-xrm-easy or, else, please reach out via support@dynamicsvalue.com so we can prioritise it. If you are unsure about our licensing, please have a look at our licensing FAQ here: https://dynamicsvalue.github.io/fake-xrm-easy-docs/licensing/faq/")
        {

        }
    }
}
