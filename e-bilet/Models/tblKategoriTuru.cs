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
    
    public partial class tblKategoriTuru
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblKategoriTuru()
        {
            this.tblKategori = new HashSet<tblKategori>();
        }
    
        public string KategoriTuru { get; set; }
        public string KonserAdi { get; set; }
        public string TiyatroAdi { get; set; }
        public string SinemaAdi { get; set; }
        public string BalerinAdi { get; set; }
        public int id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblKategori> tblKategori { get; set; }
    }
}
