namespace BanTest.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;
    [Table("NXB")]
    public partial class NXB
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NXB()
        {
            Saches = new HashSet<Sach>();
        }

        [Key]
        [StringLength(10)]
        public string maNXB { get; set; }

        [StringLength(32)]
        public string tenNXB { get; set; }

        [StringLength(50)]
        public string diachi { get; set; }

        [StringLength(10)]
        public string sdt { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sach> Saches { get; set; }
    }
    public partial class NXB
    {
        static QLTVModel db = new QLTVModel();
        public static List<NXB> GetAll()
        {
            db = new QLTVModel();
            return db.NXBs.ToList();
        }

        public static NXB GetNXB(string id)
        {
            return db.NXBs.Where(p => p.maNXB == id).FirstOrDefault();
        }

        public void Insert()
        {
            db.NXBs.Add(this);
            db.SaveChanges();
        }
        public void Update()
        {
            db.SaveChanges();
        }

        public static void Delete(string id)
        {
            NXB nxb = NXB.GetNXB(id);
            if (nxb == null)
            {

                throw new Exception("Không tìm thấy mã nxb ");
            }
            else
            {
                db.NXBs.Remove(nxb);
                db.SaveChanges();
            }
        }
    }

}
