//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PI_Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class METADATA_LOOKUPS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public METADATA_LOOKUPS()
        {
            this.METADATA_LOOKUP_VALUES = new HashSet<METADATA_LOOKUP_VALUES>();
        }
    
        public string ORIGSTS { get; set; }
        public int ORIGREC { get; set; }
        public string NAME { get; set; }
        public string DATA_SOURCE { get; set; }
        public string USAGE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<METADATA_LOOKUP_VALUES> METADATA_LOOKUP_VALUES { get; set; }
    }
}