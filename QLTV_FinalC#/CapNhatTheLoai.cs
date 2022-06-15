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
    public partial class CapNhatTheLoai : Form
    {
        public CapNhatTheLoai()
        {
            InitializeComponent();
        }
        void ResetTxt()
        {
            txtMaTL.ResetText();
            txtTenTL.ResetText();
            txtViTri.ResetText();
        }
        private TheLoai GetTL()
        {
            TheLoai tl = new TheLoai();
            tl.maTL = txtMaTL.Text;
            tl.tenTL = txtTenTL.Text;
            tl.vitri = txtViTri.Text;

            return tl;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (TheLoai.GetTL(txtMaTL.Text) != null)
            {
                MessageBox.Show("Mã Thể loại đã tồn tại");
                txtMaTL.Focus();
            }
            else
            {
                TheLoai tl = GetTL();
                tl.Insert();
                MessageBox.Show("Thêm thành công");
                ResetTxt();
                CapNhatTheLoai_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                List<Sach> sach = Sach.GetSachByTL(txtMaTL.Text);
                if (sach.Count > 0)
                {
                    foreach (var i in sach)
                    {
                        i.maTL = "Default";
                        i.UpdateSach();
                    }

                }
                TheLoai.Delete(txtMaTL.Text);
                MessageBox.Show("Xóa thành công");
                ResetTxt();
                CapNhatTheLoai_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtMaTL.Focus();
            }
        }

        private void CapNhatTheLoai_Load(object sender, EventArgs e)
        {
            cbTL.DataSource = TheLoai.GetAll();
            cbTL.DisplayMember = "tenTL";
            cbTL.ValueMember = "maTL";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                TheLoai theLoai = TheLoai.GetTL(txtMaTL.Text);
                if (theLoai == null)
                    throw new Exception("Không tìm thấy thể loại này");
                else
                {
                    if (txtTenTL.Text != string.Empty)
                        theLoai.tenTL = txtTenTL.Text;
                    if (txtViTri.Text != string.Empty)
                        theLoai.vitri = txtViTri.Text;
                    theLoai.Update();
                    MessageBox.Show("Sửa thành công");
                    ResetTxt();
                    CapNhatTheLoai_Load(sender, e);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtMaTL.Focus();
            }
        }

        

        private void cbTL_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtMaTL.Text = cbTL.SelectedValue.ToString();
            TheLoai theloai = TheLoai.GetTL(txtMaTL.Text);
            txtTenTL.Text = theloai.tenTL;
            txtViTri.Text = theloai.vitri;
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
