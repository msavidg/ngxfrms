//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ngxFrmsWebApi.DataModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class trn_FilingRequestReplaceFormXref
    {
        public int Id { get; set; }
        public int FilingRequestId { get; set; }
        public string BaseFormIdString { get; set; }
        public string FormEditionId { get; set; }
        public Nullable<System.DateTime> EditionDate { get; set; }
        public System.DateTime AuditLastModified { get; set; }
        public string AuditLastModifiedBy { get; set; }
    
        public virtual trn_FilingRequest trn_FilingRequest { get; set; }
    }
}