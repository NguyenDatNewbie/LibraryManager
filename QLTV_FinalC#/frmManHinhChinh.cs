using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanTest.Model;
using System.IO;
namespace BanTest
{
    public partial class frmManHinhChinh : Form
    {


        public frmManHinhChinh()
        {
            InitializeComponent();
        }
        public void BindGrid(List<Sach> listSach)
        {
            
            dgvDSSach.Rows.Clear();
            int stt = 1;
            foreach (var i in listSach)
            {
                int index = dgvDSSach.Rows.Add();
                dgvDSSach.Rows[index].Cells[0].Value = stt++;
                dgvDSSach.Rows[index].Cells[1].Value = i.maSach;
                dgvDSSach.Rows[index].Cells[2].Value = i.tenSach;
                dgvDSSach.Rows[index].Cells[3].Value = i.sl;
                dgvDSSach.Rows[index].Cells[4].Value = i.TheLoai.tenTL;
                dgvDSSach.Rows[index].Cells[5].Value = i.tenTG;
                dgvDSSach.Rows[index].Cells[6].Value = i.TheLoai.vitri;
            }
        }
        private void ResetTxt()
        {
            txtMaSach.ResetText();
            txtMSSV.ResetText();
            lbSV.Text = "........................";
            lbSoNo.Text = "........................";
        }


        public void ShowTaiKhoan(NhanVien nv)
        {
            string capdo = "Nhân viên"; //Default
            if (nv.quyen == 0)
            {
                listBox.Items.Insert(0, "Thêm Tài Khoản");
                listBox.ColumnWidth = 42;
                capdo = "Quản lý";
                picUpdate.Enabled = true;
            }
            else
            {
                picUpdate.Enabled = false;
                listBox.Size = new Size(133, 23);
            }
            string pathImgDefault = Path.GetDirectoryName(Application.ExecutablePath) + @"\Image\";
            Console.WriteLine(pathImgDefault);
            string pathImgFull = pathImgDefault + nv.pathImg;

            if (File.Exists(pathImgFull))
                picNV.Image = Image.FromFile(pathImgFull);
            else
                picNV.Image = Image.FromFile(pathImgDefault + "userDefault.jpg");
            lbTenNV.Text = nv.tenNV;
            lbLevelNV.Text = capdo;

        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            listBox.Visible = false;
            BindGrid(Sach.GetAll());
            ShowTaiKhoan(NhanVien.GetNhanVien(TaiKhoan.idCrurrent));
        }

        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex != -1) // -1 Là dòng title của dgv
            {
                DataGridViewRow row = dgvDSSach.Rows[e.RowIndex];
                txtMaSach.Text = Convert.ToString(row.Cells[1].Value);
            }
            
        }

        private Muon GetMuon()
        {
            Muon TTMuon = new Muon();
            TTMuon.maSV = txtMSSV.Text;
            TTMuon.maSach = txtMaSach.Text;
            TTMuon.maNV = TaiKhoan.idCrurrent;
            TTMuon.ngayMuon = DateTime.Now;
            return TTMuon;
        }
        private void btnMuon_Click(object sender, EventArgs e)
        {
            try
            {
                SinhVien sv = SinhVien.GetSV(txtMSSV.Text);
                if (sv == null)
                    throw new Exception("Tài khoản sinh viên không tồn tại");
                Sach.UpdateSL(txtMaSach.Text, true);
                lbSV.Text = sv.tenSV;
                if (Muon.GetMuon(txtMaSach.Text, txtMSSV.Text) != null)
                    throw new Exception("Sách này sinh viên đã mượn");
                Muon TTMuon = GetMuon();
                TTMuon.Insert();
                MessageBox.Show("Mượn thành công!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ResetTxt();
            BindGrid(Sach.GetAll());
        }

        private Tra GetTra(Muon muon)
        {
            Tra TTtra = new Tra();
            TTtra.maSV = muon.maSV;
            TTtra.maSach = muon.maSach;
            TTtra.maNV = muon.maNV;
            TTtra.ngayMuon = muon.ngayMuon;
            TTtra.ngayTra = DateTime.Now;

            return TTtra;
        }
        private void btnTra_Click(object sender, EventArgs e)
        {
            try
            {
                Muon sachSeTra = Muon.GetMuon(txtMaSach.Text, txtMSSV.Text); // Lấy ra thông tin sách chuẩn bị trả
                Sach.UpdateSL(txtMaSach.Text, false);
                if (sachSeTra != null)
                    lbSV.Text = sachSeTra.SinhVien.tenSV;
                else
                    throw new Exception("Không tồn tại trong bảng mượn");

                Tra TTtra = GetTra(sachSeTra);
                TTtra.Insert();
                MessageBox.Show("Trả thành công!");
                sachSeTra.Delete(); 
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ResetTxt();
            BindGrid(Sach.GetAll());
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetTxt();
            BindGrid(Sach.GetAll());
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Sach> KQTK = Sach.GetAll();

            // Trả về các dữ liệu mà tên sách có trong txtSearch
            var listKQS = KQTK.Where(p => p.tenSach.ToLower().Contains(txtSearch.Text.ToLower())).ToList(); 

            if(listKQS.Count > 0)
            {
                BindGrid(listKQS);
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm");
                txtSearch.ResetText();
            }
        }

        private void btnSearchSV_Click(object sender, EventArgs e)
        {
            try
            {
                List<Muon> muons = Muon.GetMuon(txtMSSV.Text);

                if (muons.Count() > 0)
                    lbSV.Text = muons[0].SinhVien.tenSV;

                lbSoNo.Text = muons.Count().ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
      
        private void pnlThongTin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUpdateSach_Click(object sender, EventArgs e)
        {
            CapNhatSach frm = new CapNhatSach();
            frm.Show();
            this.Hide();
            
        }

        private void btnLichSu_Click(object sender, EventArgs e)
        {
            frmDanhSach frm = new frmDanhSach();
            frm.Show();
            this.Hide();
        }

        private void picNV_Click(object sender, EventArgs e)
        {
            listBox.Visible = !listBox.Visible;
            
        }

        private void listBox_Click(object sender, EventArgs e)
        {
            if(listBox.Items.Count>1)
            {
                int index = listBox.SelectedIndex;
                if (index == 0)
                {
                    CapNhatTTNhanVien frm = new CapNhatTTNhanVien();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    frmLogin frm = new frmLogin();
                    frm.Show();
                    this.Hide();
                }
            }
            else
            {
                frmLogin frm = new frmLogin();
                frm.Show();
                this.Hide();
            }
        }

        
    }
}
