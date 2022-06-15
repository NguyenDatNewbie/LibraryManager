namespace BanTest.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;
    [Table("TheLoai")]
    public partial class TheLoai
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TheLoai()
        {
            Saches = new HashSet<Sach>();
        }

        [Key]
        [StringLength(10)]
        public string maTL { get; set; }

        [StringLength(32)]
        public string tenTL { get; set; }

        [StringLength(50)]
        public string vitri { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sach> Saches { get; set; }
    }

    public partial class TheLoai
    {
        static QLTVModel db = new QLTVModel();
        public static List<TheLoai> GetAll()
        {
            db = new QLTVModel();
            return db.TheLoais.ToList();
        }

        public static TheLoai GetTL(string id)
        {
            return db.TheLoais.Where(p => p.maTL == id).FirstOrDefault();
        }

        public void Insert()
        {
            db.TheLoais.Add(this);
            db.SaveChanges();
        }

        public void Update()
        {
            db.SaveChanges();
        }

        public static void Delete(string id)
        {
            TheLoai theLoai = GetTL(id);
            if (theLoai == null)
                throw new Exception("Không tồn tại thể loại này");
            else
            {
                db.TheLoais.Remove(theLoai);
                db.SaveChanges();
            }
        }
    }


}
