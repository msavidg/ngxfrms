using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
 
namespace ngxFrmsWebApi.DataModels.Enums
{
    /// <summary>
    /// ref_FilingRequestStatus auto generated enumeration
    /// taken in part from http://erraticdev.blogspot.com/2011/01/generate-enum-of-database-lookup-table.html
    /// </summary>
    [GeneratedCode("TextTemplatingFileGenerator", "10")]
    public enum EnumFilingRequestStatus
    {
        /// <summary>
        /// PBUA configuration setting.
        /// </summary>
        [Description("Pending Business Unit Approval")]
        PBUA = 1,

        /// <summary>
        /// PCLA configuration setting.
        /// </summary>
        [Description("Pending Claims Approval")]
        PCLA = 2,

        /// <summary>
        /// RS configuration setting.
        /// </summary>
        [Description("Request in Progress")]
        RS = 4,

        /// <summary>
        /// PCOA configuration setting.
        /// </summary>
        [Description("Pending Compliance Approval")]
        PCOA = 6,

        /// <summary>
        /// PXDPC configuration setting.
        /// </summary>
        [Description("Pending IT XDP Creation")]
        PXDPC = 8,

        /// <summary>
        /// PXMLC configuration setting.
        /// </summary>
        [Description("Pending IT XML Creation")]
        PXMLC = 9,

        /// <summary>
        /// PTFSC configuration setting.
        /// </summary>
        [Description("Pending IT TFS Check-In")]
        PTFSC = 11,

        /// <summary>
        /// PUAT configuration setting.
        /// </summary>
        [Description("Pending UAT")]
        PUAT = 15,

        /// <summary>
        /// PITPU configuration setting.
        /// </summary>
        [Description("Pending IT Production Upload")]
        PITPU = 18,

        /// <summary>
        /// PFMC configuration setting.
        /// </summary>
        [Description("Pending IT Production Form Master Creation")]
        PFMC = 19,

        /// <summary>
        /// COMPLETE configuration setting.
        /// </summary>
        [Description("Complete")]
        COMPLETE = 20,

        /// <summary>
        /// VOID configuration setting.
        /// </summary>
        [Description("Void")]
        VOID = 21,

        /// <summary>
        /// PPXDPD configuration setting.
        /// </summary>
        [Description("Pending IT Production XDP Deployment")]
        PPXDPD = 22,

        /// <summary>
        /// FWFI configuration setting.
        /// </summary>
        [Description("Pending Forms Work Flow Initiation")]
        FWFI = 23,

        /// <summary>
        /// PXDPD configuration setting.
        /// </summary>
        [Description("Pending IT XDP Deployment")]
        PXDPD = 24,

        /// <summary>
        /// PITFMC configuration setting.
        /// </summary>
        [Description("Pending IT Form Master Creation")]
        PITFMC = 25,

        /// <summary>
        /// PITQAAPP configuration setting.
        /// </summary>
        [Description("Pending IT QA Approval")]
        PITQAAPP = 26,

        /// <summary>
        /// RFR_RP configuration setting.
        /// </summary>
        [Description("Request in Progress")]
        RFR_RP = 27,

        /// <summary>
        /// RWFI configuration setting.
        /// </summary>
        [Description("Pending Rate Work Flow Initiation")]
        RWFI = 28,

        /// <summary>
        /// RFR_PDA configuration setting.
        /// </summary>
        [Description("Pending Business Unit Approval")]
        RFR_PDA = 29,

        /// <summary>
        /// RFR_PAA configuration setting.
        /// </summary>
        [Description("Pending Actuarial Approval")]
        RFR_PAA = 30,

        /// <summary>
        /// RFR_PITA configuration setting.
        /// </summary>
        [Description("Pending IT Approval")]
        RFR_PITA = 31,

        /// <summary>
        /// RFR_PRE-IA configuration setting.
        /// </summary>
        [Description("Pending Reinsurance Approval")]
        RFR_PREIA = 32,

        /// <summary>
        /// RFR_PCA configuration setting.
        /// </summary>
        [Description("Pending Compliance Approval")]
        RFR_PCA = 33,

        /// <summary>
        /// RFR_PITR configuration setting.
        /// </summary>
        [Description("Pending IT Review")]
        RFR_PITR = 34,

        /// <summary>
        /// RFR_PITBAR configuration setting.
        /// </summary>
        [Description("Pending IT BA Review")]
        RFR_PITBAR = 35,

        /// <summary>
        /// RFR_PITQA configuration setting.
        /// </summary>
        [Description("Pending IT QA Approval")]
        RFR_PITQA = 36,

        /// <summary>
        /// RFR_PITUATU configuration setting.
        /// </summary>
        [Description("Pending IT UAT Upload")]
        RFR_PITUATU = 37,

        /// <summary>
        /// RFR_PBUUAT configuration setting.
        /// </summary>
        [Description("Pending Business Unit UAT")]
        RFR_PBUUAT = 38,

        /// <summary>
        /// RFR_PITRC configuration setting.
        /// </summary>
        [Description("Pending IT Rate Changes")]
        RFR_PITRC = 39,

        /// <summary>
        /// RFR_PITPRODU configuration setting.
        /// </summary>
        [Description("Pending IT Production Upload")]
        RFR_PITPRODU = 41,

        /// <summary>
        /// RFR_FIIP configuration setting.
        /// </summary>
        [Description("Filing Implementation in Progress")]
        RFR_FIIP = 42,

        /// <summary>
        /// AFR_RP configuration setting.
        /// </summary>
        [Description("Request in Progress")]
        AFR_RP = 43,

        /// <summary>
        /// AWFI configuration setting.
        /// </summary>
        [Description("Pending Assessment Work Flow Initiation")]
        AWFI = 44,

        /// <summary>
        /// AFR_PITR configuration setting.
        /// </summary>
        [Description("Pending IT Review")]
        AFR_PITR = 45,

        /// <summary>
        /// AFR_PITBAR configuration setting.
        /// </summary>
        [Description("Pending IT BA Review")]
        AFR_PITBAR = 46,

        /// <summary>
        /// AFR_PITUAT configuration setting.
        /// </summary>
        [Description("Pending IT UAT Upload")]
        AFR_PITUAT = 47,

        /// <summary>
        /// AFR_PITGUAT configuration setting.
        /// </summary>
        [Description("Pending IT Genius Review")]
        AFR_PITGUAT = 48,

        /// <summary>
        /// AFR_PBUUAT configuration setting.
        /// </summary>
        [Description("Pending Business Unit UAT")]
        AFR_PBUUAT = 50,

        /// <summary>
        /// AFR_PITPRODU configuration setting.
        /// </summary>
        [Description("Pending IT Production Upload")]
        AFR_PITPRODU = 51,

        /// <summary>
        /// AFR_COMPLETED configuration setting.
        /// </summary>
        [Description("Complete")]
        AFR_COMPLETED = 52,

        /// <summary>
        /// STATEAPR_RP configuration setting.
        /// </summary>
        [Description("Filing Implementation in Progress")]
        STATEAPR_RP = 53,

        /// <summary>
        /// STATEAPR_ITR configuration setting.
        /// </summary>
        [Description("Pending IT State Approval Review")]
        STATEAPR_ITR = 54,

        /// <summary>
        /// STATEAPR_ITQA configuration setting.
        /// </summary>
        [Description("Pending IT State Approval QA")]
        STATEAPR_ITQA = 55,

        /// <summary>
        /// ADMIN_SEC configuration setting.
        /// </summary>
        [Description("Security Admin")]
        ADMIN_SEC = 56,

        /// <summary>
        /// STATE_APR_ADMIN configuration setting.
        /// </summary>
        [Description("Compliance State Approval Admin")]
        STATE_APR_ADMIN = 57,

        /// <summary>
        /// BR-PBUA configuration setting.
        /// </summary>
        [Description("Pending Business Unit Approval")]
        BRPBUA = 58,

        /// <summary>
        /// BR-PCLA configuration setting.
        /// </summary>
        [Description("Pending Claims Approval")]
        BRPCLA = 59,

        /// <summary>
        /// BR-PCOA configuration setting.
        /// </summary>
        [Description("Pending Compliance Approval")]
        BRPCOA = 60,

        /// <summary>
        /// BR-PITR configuration setting.
        /// </summary>
        [Description("Pending IT Review")]
        BRPITR = 61,

        /// <summary>
        /// BR-PITQA configuration setting.
        /// </summary>
        [Description("Pending IT QA Approval")]
        BRPITQA = 62,

        /// <summary>
        /// BR-PUAT configuration setting.
        /// </summary>
        [Description("Pending UAT")]
        BRPUAT = 63,

        /// <summary>
        /// BR-PUATFC configuration setting.
        /// </summary>
        [Description("Pending UAT Form Changes")]
        BRPUATFC = 64,

        /// <summary>
        /// BR-PITPU configuration setting.
        /// </summary>
        [Description("Pending IT Production Upload")]
        BRPITPU = 65,

        /// <summary>
        /// PD-PBUA configuration setting.
        /// </summary>
        [Description("Pending Business Unit Approval")]
        PDPBUA = 66,

        /// <summary>
        /// PD-PCLA configuration setting.
        /// </summary>
        [Description("Pending Claims Approval")]
        PDPCLA = 67,

        /// <summary>
        /// PD-PCOA configuration setting.
        /// </summary>
        [Description("Pending Compliance Approval")]
        PDPCOA = 68,

        /// <summary>
        /// PD-PITR configuration setting.
        /// </summary>
        [Description("Pending IT Review")]
        PDPITR = 69,

        /// <summary>
        /// PD-PITQA configuration setting.
        /// </summary>
        [Description("Pending IT QA Approval")]
        PDPITQA = 70,

        /// <summary>
        /// PD-PUAT configuration setting.
        /// </summary>
        [Description("Pending UAT")]
        PDPUAT = 71,

        /// <summary>
        /// PD-PUATFC configuration setting.
        /// </summary>
        [Description("Pending UAT Form Changes")]
        PDPUATFC = 72,

        /// <summary>
        /// PD-PITPU configuration setting.
        /// </summary>
        [Description("Pending IT Production Upload")]
        PDPITPU = 73,

        /// <summary>
        /// AFR_PITQA configuration setting.
        /// </summary>
        [Description("Pending IT QA Approval")]
        AFR_PITQA = 75,

        /// <summary>
        /// PITR configuration setting.
        /// </summary>
        [Description("Pending IT Review")]
        PITR = 76,

        /// <summary>
        /// POPSR configuration setting.
        /// </summary>
        [Description("Pending OPS Review")]
        POPSR = 77,

        /// <summary>
        /// CR configuration setting.
        /// </summary>
        [Description("Change Request")]
        CR = 80,

        /// <summary>
        /// ADMIN_TAG configuration setting.
        /// </summary>
        [Description("Tags")]
        ADMIN_TAG = 81,

        /// <summary>
        /// WD configuration setting.
        /// </summary>
        [Description("Withdrawn")]
        WD = 82,

        /// <summary>
        /// NIMP configuration setting.
        /// </summary>
        [Description("Not Implemented")]
        NIMP = 83
  }
}
 
