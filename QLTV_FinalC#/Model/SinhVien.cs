namespace BanTest.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;
    [Table("SinhVien")]
    public partial class SinhVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SinhVien()
        {
            Muons = new HashSet<Muon>();
            Tras = new HashSet<Tra>();
        }

        [Key]
        [StringLength(10)]
        public string maSV { get; set; }

        [StringLength(32)]
        public string tenSV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Muon> Muons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tra> Tras { get; set; }
    }

    public partial class SinhVien
    {
        static QLTVModel db = new QLTVModel();
        public static SinhVien GetSV(string MSSV)
        {
            return db.SinhViens.Where(p => p.maSV == MSSV).FirstOrDefault();
        }
    }

}
