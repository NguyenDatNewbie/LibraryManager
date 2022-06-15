namespace BanTest.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;
    [Table("Sach")]
    public partial class Sach
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sach()
        {
            Muons = new HashSet<Muon>();
            Tras = new HashSet<Tra>();
        }

        [Key]
        [StringLength(10)]
        public string maSach { get; set; }

        [StringLength(32)]
        public string tenSach { get; set; }

        public int? sl { get; set; }

        [StringLength(32)]
        public string tenTG { get; set; }

        [StringLength(10)]
        public string maTL { get; set; }

        [StringLength(10)]
        public string maNXB { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Muon> Muons { get; set; }

        public virtual NXB NXB { get; set; }

        public virtual TheLoai TheLoai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tra> Tras { get; set; }
    }

    public partial class Sach
    {
        static QLTVModel db = new QLTVModel();
        public static List<Sach> GetAll()
        {
            db = new QLTVModel();
            return db.Saches.ToList();
        }

        public static Sach GetSach(string id)
        {
            return db.Saches.Where(p => p.maSach == id).FirstOrDefault();
        }

        public static List<Sach> GetSachByTL(string idTL)
        {

            return db.Saches.Where(p => p.maTL == idTL).ToList();
        }

        public static List<Sach> GetSachByNXB(string idNXB)
        {
            return db.Saches.Where(p => p.maNXB == idNXB).ToList();
        }

        public static void UpdateSL(string id, bool Muon)
        {
            Sach sachSua = GetSach(id);
            if (sachSua != null)
            {
                if (sachSua.sl == 0 && Muon == true)
                    throw new Exception("Sách đã hết trong thư viện");

                if (Muon == true)
                    sachSua.sl -= 1;
                else
                    sachSua.sl += 1;
                db.SaveChanges();
            }
            else
                throw new Exception("Không tìm thấy mã sách này");
        }

        public void Insert()
        {
            db.Saches.Add(this);
            db.SaveChanges();
        }

        public void UpdateSach()
        {
            db.SaveChanges();
        }

        public static void Delete(string idSach)
        {
            Sach sach = db.Saches.Where(p => p.maSach == idSach).FirstOrDefault();

            if (sach == null)
                throw new Exception("Sách không có trong thư viện");
            else
            {
                db.Saches.Remove(sach);
                db.SaveChanges();
            }
        }
    }

}
