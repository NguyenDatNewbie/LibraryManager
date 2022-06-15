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

namespace BanTest
{
    public partial class CapNhatTTNhanVien : Form
    {
        public static bool addInfo=false;
       
        public CapNhatTTNhanVien()
        {
            InitializeComponent();
            addInfo = false;
        }

        private void frmTaoTK_Load(object sender, EventArgs e)
        {
            
            try
            {
                BindGridNhanVien(NhanVien.GetAll());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void SetGridViewStyle(DataGridView dgview)
        {
            dgview.DefaultCellStyle.Font = new Font("Times New Roman", 10);
            dgview.ColumnHeadersDefaultCellStyle.Font = new Font("Constantia", 13, FontStyle.Bold);
            dgview.BorderStyle = BorderStyle.Fixed3D;
            dgview.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgview.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgview.BackgroundColor = Color.AliceBlue;
            dgview.EnableHeadersVisualStyles = false;
            dgview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgview.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 102, 255);
            dgview.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgview.AllowUserToOrderColumns = true;
            dgview.MultiSelect = false;
            dgview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void BindGridNhanVien(List<NhanVien> listdata)
        {
            SetGridViewStyle(dgvNhanVien);
            dgvNhanVien.Rows.Clear();

            foreach (var i in listdata)
            {
                int index = dgvNhanVien.Rows.Add();
                dgvNhanVien.Rows[index].Cells[0].Value = i.maNV;
                dgvNhanVien.Rows[index].Cells[1].Value = i.tenNV;
                dgvNhanVien.Rows[index].Cells[2].Value = i.sdt;
                if (i.quyen == 0)
                {
                    dgvNhanVien.Rows[index].Cells[3].Value = "Quản lý";
                }    
                if (i.quyen == 1)
                {
                    dgvNhanVien.Rows[index].Cells[3].Value = "Nhân viên";
                }    
            }    
        }
        private NhanVien GetTT()
        {
            NhanVien nv = new NhanVien();

            nv.maNV = txtMaNV.Text;
            nv.tenNV = txtHoTen.Text;
            nv.sdt = txtSodt.Text;
            if (txtQuyen.Text == "Quản lý")
            {
                nv.quyen = 0;
            }    
            else
            {
                nv.quyen = 1;
            }    
            return nv;

        }
        public void Reset()
        {
            txtMaNV.ResetText();
            txtHoTen.ResetText();
            txtSodt.ResetText();
            txtQuyen.ResetText();

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaNV.Text != string.Empty)
                {
                    NhanVien themNV = GetTT();
                    themNV.Insert();
                    //this.Hide();
                    CapNhatTK tk = new CapNhatTK();
                    tk.Message = txtMaNV.Text;
                    tk.ShowDialog();
                    if (addInfo == false)
                    {
                        NhanVien.Delete(themNV.maNV);
                        MessageBox.Show("Vui lòng tạo tài khoản");
                    }
                    else
                    {
                        Reset();
                        BindGridNhanVien(NhanVien.GetAll());
                    }                    

                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }    
            }
            catch
            {
                MessageBox.Show("Nhân viên này đã tồn tại", "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtMaNV.Focus();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaNV.Text != string.Empty)
                {
                    DialogResult tl = MessageBox.Show("Bạn có muốn xóa không", "Thông báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                    if (tl == DialogResult.Yes)
                    {
                        TaiKhoan.Delete(txtMaNV.Text);
                        NhanVien.Delete(txtMaNV.Text);
                        BindGridNhanVien(NhanVien.GetAll());
                        MessageBox.Show("Xóa nhân viên thành công", "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        Reset();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Xóa không thành công", "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) // -1 Là dòng title của dgv
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvNhanVien.Rows[e.RowIndex];
                txtMaNV.Text = Convert.ToString(row.Cells[0].Value);
                txtHoTen.Text = Convert.ToString(row.Cells[1].Value);
                txtSodt.Text = Convert.ToString(row.Cells[2].Value);
                txtQuyen.Text = Convert.ToString(row.Cells[3].Value);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaNV.Text != string.Empty)
                {
                    NhanVien suaNV = GetTT();

                    suaNV.UpdateNV();
                    BindGridNhanVien(NhanVien.GetAll());
                    MessageBox.Show("Sửa thành công");
                    Reset();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmManHinhChinh frm = new frmManHinhChinh();
            frm.Show();
            this.Hide();
        }
    }
}
