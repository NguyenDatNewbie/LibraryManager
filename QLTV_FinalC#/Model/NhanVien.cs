namespace BanTest.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Spatial;
    using System.Linq;
    [Table("NhanVien")]
    public partial class NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanVien()
        {
            Muons = new HashSet<Muon>();
            TaiKhoans = new HashSet<TaiKhoan>();
            Tras = new HashSet<Tra>();
        }

        [Key]
        [StringLength(10)]
        public string maNV { get; set; }

        [StringLength(32)]
        public string tenNV { get; set; }

        [StringLength(10)]
        public string sdt { get; set; }

        public int? quyen { get; set; }

        [StringLength(32)]
        public string pathImg { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Muon> Muons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaiKhoan> TaiKhoans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tra> Tras { get; set; }
    }

    public partial class NhanVien
    {
        #region Đạt
        public static NhanVien GetNhanVien(string id)
        {
            QLTVModel context = new QLTVModel();
            return context.NhanViens.Where(p => p.maNV == id).FirstOrDefault();
        }
        #endregion

        #region Đăng
        public static List<NhanVien> GetAll()
        {
            QLTVModel context = new QLTVModel();
            return context.NhanViens.ToList();
        }
        public void Insert()
        {
            QLTVModel context = new QLTVModel();
            context.NhanViens.Add(this);
            context.SaveChanges();
        }
        public void UpdateNV()
        {
            QLTVModel context = new QLTVModel();
            context.NhanViens.AddOrUpdate(this);
            context.SaveChanges();
        }
        public static NhanVien GetNV(string maNV)
        {
            QLTVModel context = new QLTVModel();
            return context.NhanViens.Where(p => p.maNV == maNV).FirstOrDefault();
        }
        public void Delete()
        {
            QLTVModel context = new QLTVModel();
            context.NhanViens.Remove(this);
            context.SaveChanges();
        }
        public static void Delete(string maNV)
        {
            QLTVModel context = new QLTVModel();
            NhanVien nv = context.NhanViens.Where(p => p.maNV == maNV).FirstOrDefault();

            if (nv == null)
                throw new Exception("Không tồn tại mã nhân viên này");
            else
            {
                context.NhanViens.Remove(nv);
                context.SaveChanges();
            }
        }
        #endregion
    }

}
