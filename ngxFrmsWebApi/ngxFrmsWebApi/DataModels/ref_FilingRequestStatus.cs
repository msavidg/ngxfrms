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
    
    public partial class ref_FilingRequestStatus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ref_FilingRequestStatus()
        {
            this.trn_FilingRequest = new HashSet<trn_FilingRequest>();
        }
    
        public int FilingRequestStatusId { get; set; }
        public int FilingRequestTypeId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int OrderInFlow { get; set; }
        public string Group { get; set; }
        public Nullable<bool> Active { get; set; }
    
        public virtual ref_FilingRequestType ref_FilingRequestType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trn_FilingRequest> trn_FilingRequest { get; set; }
    }
}
