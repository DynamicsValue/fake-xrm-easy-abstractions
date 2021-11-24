
using System;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;

namespace FakeXrmEasy.Abstractions.Settings
{
    /// <summary>
    /// Fiscal Year Settings
    /// </summary>
    [EntityLogicalName("organization")]
    public class FiscalYearSettings
    {
        /// <summary>
        /// Start Date
        /// </summary>
        [AttributeLogicalName("fiscalcalendarstart")]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Fiscal Period Template
        /// </summary>
        [AttributeLogicalName("fiscalperiodtype")]
        public Template FiscalPeriodTemplate { get; set; }

        /// <summary>
        /// Fiscal Period Template
        /// </summary>
        public enum Template
        {
            /// <summary>
            /// Annually
            /// </summary>
            Annually = 2000,
            /// <summary>
            /// SemiAnnually
            /// </summary>
            SemiAnnually = 2001,
            /// <summary>
            /// Quarterly
            /// </summary>
            Quarterly = 2002,
            /// <summary>
            /// Monthly
            /// </summary>
            Monthly = 2003,
            /// <summary>
            /// FourWeek
            /// </summary>
            FourWeek = 2004
        }

        /// <summary>
        /// Fiscal Year Settings
        /// </summary>
        public FiscalYearSettings()
        {
            FiscalPeriodTemplate = Template.Annually;
            StartDate = new DateTime(DateTime.UtcNow.Year, 1, 1);
        }
    }
}