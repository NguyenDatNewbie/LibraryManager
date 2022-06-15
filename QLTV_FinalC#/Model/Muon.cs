namespace BanTest.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;
    [Table("Muon")]
    public partial class Muon
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

        public virtual NhanVien NhanVien { get; set; }

        public virtual Sach Sach { get; set; }

        public virtual SinhVien SinhVien { get; set; }
    }

    public partial class Muon
    {
        #region Đạt
        static QLTVModel db = new QLTVModel();
        public void Insert()
        {
            db.Muons.Add(this);
            db.SaveChanges();
        }
        public void Delete()
        {
            db.Muons.Remove(this);
            db.SaveChanges();
        }
        public static void Delete(string idSach)
        {
            Muon muon = db.Muons.Where(p => p.maSach == idSach).FirstOrDefault();
            if (muon != null)
            {
                db.Muons.Remove(muon);
                db.SaveChanges();
            }
        }

        public static Muon GetMuon(string idSach, string maSV)
        {
            return db.Muons.Where(p => p.maSV == maSV && p.maSach == idSach).FirstOrDefault();
        }

        public static List<Muon> GetMuon(string MSSV)
        {
            if (db.SinhViens.Where(p => p.maSV == MSSV).FirstOrDefault() == null)
            {
                throw new Exception("Mã sinh viên không tồn tại");
            }
            return db.Muons.Where(p => p.maSV == MSSV && p.SinhVien.maSV == MSSV).ToList();
        }
        #endregion
        #region Đăng

        public static List<Muon> GetAll()
        {
            QLTVModel context = new QLTVModel();
            return context.Muons.ToList();
        }
        //public static List<Muon> GetMuon(string MSSV)
        //{
        //    QLTVModel context = new QLTVModel();
        //    return context.Muons.Where(p => p.maSV == MSSV).ToList();
        //}
        public static List<Muon> GetMuon(DateTime start, DateTime end)
        {
            QLTVModel context = new QLTVModel();
            return context.Muons.Where(p => p.ngayMuon >= start && p.ngayMuon <= end).ToList();
        }
        #endregion
    }

}
