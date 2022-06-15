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
    public partial class CapNhatNXB : Form
    {
        public CapNhatNXB()
        {
            InitializeComponent();
        }
        void ResetTxt()
        {
            txtID.ResetText();
            txtDiaChi.ResetText();
            txtSDT.ResetText();
            txtTen.ResetText();
        }
        private NXB GetNXB()
        {
            NXB nxb = new NXB();

            nxb.maNXB = txtID.Text;
            nxb.tenNXB = txtTen.Text;
            nxb.sdt = txtSDT.Text;
            nxb.diachi = txtDiaChi.Text;
            return nxb;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtID.Text == string.Empty)
            {
                txtID.Focus();
                throw new Exception("Vui lòng nhập mã nhà sản xuất");
            }

            NXB nxbLinq = NXB.GetNXB(txtID.Text);
            try
            {

                if (nxbLinq == null) // Thêm
                {
                    NXB nxb = GetNXB();
                    nxb.Insert();
                    MessageBox.Show("Thêm nhà xuất bản thành công");
                }
                else // Sửa
                {
                    if (txtDiaChi.Text != string.Empty)
                        nxbLinq.diachi = txtDiaChi.Text;
                    if (txtSDT.Text != string.Empty)
                        nxbLinq.sdt = txtSDT.Text;
                    if (txtTen.Text != string.Empty)
                        nxbLinq.tenNXB = txtTen.Text;
                    nxbLinq.Update();
                    MessageBox.Show("Cập nhật thông tin NXB thành công");
                }
                CapNhatNXB_Load(sender, e);
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                List<Sach> saches = Sach.GetSachByNXB(txtID.Text);
                foreach (var i in saches)
                {
                    i.maNXB = "Default";
                    i.UpdateSach();
                }

                NXB.Delete(txtID.Text);
                MessageBox.Show("Xóa NXB thành công");
                ResetTxt();
                CapNhatNXB_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void picBack_Click(object sender, EventArgs e)
        {
            //CapNhatSach frm = new CapNhatSach();
            //frm.Show();
            this.Hide();
        }

        private void CapNhatNXB_Load(object sender, EventArgs e)
        {
            ResetTxt();
            cbNXB.DataSource = NXB.GetAll();
            cbNXB.DisplayMember = "tenNXB";
            cbNXB.ValueMember = "maNXB";
        }

        private void cbNXB_Click(object sender, EventArgs e)
        {
            txtID.Text = cbNXB.SelectedValue.ToString();
            NXB nxb = NXB.GetNXB(txtID.Text);
            txtTen.Text = nxb.tenNXB;
            txtDiaChi.Text = nxb.diachi;
            txtSDT.Text = nxb.sdt;
        }
    }
}
