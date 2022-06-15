namespace BanTest.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;
    [Table("Tra")]
    public partial class Tra
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string maSV { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string maSach { get; set; }

        [StringLength(10)]
        public string maNV { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngayMuon { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngayTra { get; set; }

        public virtual NhanVien NhanVien { get; set; }

        public virtual Sach Sach { get; set; }

        public virtual SinhVien SinhVien { get; set; }
    }


    public partial class Tra
    {
        #region Đạt
        static QLTVModel db = new QLTVModel();
        public void Insert()
        {
            db.Tras.Add(this);
            db.SaveChanges();
        }

        public static void Delete(string idSach)
        {
            Tra tra = db.Tras.Where(p => p.maSach == idSach).FirstOrDefault();
            if (tra != null)
            {
                db.Tras.Remove(tra);
                db.SaveChanges();
            }
        }
        #endregion

        #region Đăng
        public static List<Tra> GetAll()
        {
            QLTVModel context = new QLTVModel();
            return context.Tras.ToList();
        }
        public static List<Tra> GetTra(string MSSV)
        {
            QLTVModel context = new QLTVModel();
            return context.Tras.Where(p => p.maSV == MSSV).ToList();
        }
        public static List<Tra> GetTra(DateTime start, DateTime end)
        {
            QLTVModel context = new QLTVModel();
            return context.Tras.Where(p => p.ngayTra >= start && p.ngayTra <= end).ToList();
        }
        #endregion

    }
}
