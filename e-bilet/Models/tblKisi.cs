//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace e_bilet.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblKisi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblKisi()
        {
            this.tblMusteri = new HashSet<tblMusteri>();
        }
    
        public int KisiNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string KisiTürü { get; set; }
        public string Sifre { get; set; }
    
        public virtual tblAdmin tblAdmin { get; set; }
        public virtual tblKisi tblKisi1 { get; set; }
        public virtual tblKisi tblKisi2 { get; set; }
        public virtual tblKisi tblKisi11 { get; set; }
        public virtual tblKisi tblKisi3 { get; set; }
        public virtual tblKisi tblKisi12 { get; set; }
        public virtual tblKisi tblKisi4 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblMusteri> tblMusteri { get; set; }
    }
}
