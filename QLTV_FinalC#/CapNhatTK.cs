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
    public partial class CapNhatTK : Form
    {
        private string idNV;
        public CapNhatTK()
        {
            InitializeComponent();
        }

        private void frmTaoTK_Load(object sender, EventArgs e)
        {

        }
        public string Message
        {
            get { return idNV; }
            set { idNV = value; }
        }
        private TaiKhoan GetTK()
        {
            TaiKhoan tk = new TaiKhoan();

            tk.taiKhoan = txtTenDN.Text;
            tk.matKhau = txtNLPass.Text;
            tk.maNV = Message;
            return tk;

        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnDK_Click(object sender, EventArgs e)
        {
            try
            {
                CapNhatTTNhanVien.addInfo = false;
                if (txtTenDN.Text != string.Empty)
                {
                    if (txtPass.Text == txtNLPass.Text)
                    {
                        TaiKhoan dk = GetTK();
                        dk.InsertUpdate();
                        MessageBox.Show("Đăng kí thành công", "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        CapNhatTTNhanVien.addInfo = true;
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu không trùng khớp!!!!", "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        txtPass.ResetText();
                        txtNLPass.ResetText();
                    }    
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ", "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch
            {
                
                MessageBox.Show("Đăng kí không thành công", "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            }
        }
    }
}
