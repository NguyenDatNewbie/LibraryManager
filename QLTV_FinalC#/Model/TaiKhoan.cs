namespace BanTest.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Spatial;
    using System.Linq;
    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        [Key]
        [Column("taiKhoan", Order = 0)]
        [StringLength(20)]
        public string taiKhoan { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string matKhau { get; set; }

        [StringLength(10)]
        public string maNV { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }


    public partial class TaiKhoan
    {
        public static string idCrurrent = string.Empty;
        // Đăng
        public List<TaiKhoan> GetAll()
        {
            QLTVModel context = new QLTVModel();
            return context.TaiKhoans.ToList();
        }
        public void InsertUpdate()
        {
            QLTVModel context = new QLTVModel();
            context.TaiKhoans.AddOrUpdate(this);
            context.SaveChanges();
        }
        public static void Delete(string maNV)
        {
            QLTVModel context = new QLTVModel();
            TaiKhoan tk = context.TaiKhoans.Where(p => p.maNV == maNV).FirstOrDefault();

            if (tk == null)
                throw new Exception("Không t?n t?i mã nhân viên này");
            else
            {
                context.TaiKhoans.Remove(tk);
                context.SaveChanges();
            }
        }
    }
}
