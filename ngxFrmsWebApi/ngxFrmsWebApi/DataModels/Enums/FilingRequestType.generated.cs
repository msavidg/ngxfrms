using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
 
namespace ngxFrmsWebApi.DataModels.Enums
{
    /// <summary>
    /// ref_FilingRequestType auto generated enumeration
    /// taken in part from http://erraticdev.blogspot.com/2011/01/generate-enum-of-database-lookup-table.html
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
    public enum EnumFilingRequestType
    {
        /// <summary>
        /// FFR configuration setting.
        /// </summary>
        [Description("Form")]
        FFR = 1,

        /// <summary>
        /// AFR configuration setting.
        /// </summary>
        [Description("Assessment")]
        AFR = 2,

        /// <summary>
        /// RFR configuration setting.
        /// </summary>
        [Description("Rate")]
        RFR = 3,

        /// <summary>
        /// STATEAPR configuration setting.
        /// </summary>
        [Description("State Approval")]
        STATEAPR = 4,

        /// <summary>
        /// ADMIN configuration setting.
        /// </summary>
        [Description("Security Admin")]
        ADMIN = 5,

        /// <summary>
        /// FFR-BR configuration setting.
        /// </summary>
        [Description("BindRisk Form")]
        FFRBR = 6,

        /// <summary>
        /// FFR-PD configuration setting.
        /// </summary>
        [Description("Policy Decision Form")]
        FFRPD = 7,

        /// <summary>
        /// FFR-PROG configuration setting.
        /// </summary>
        [Description("Programs")]
        FFRPROG = 8
  }
}
 
