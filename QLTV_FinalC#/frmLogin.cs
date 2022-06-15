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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Chắc không?(Y/N)", "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
                Application.Exit();
        }

        private void txttaiKhoan_Enter(object sender, EventArgs e)
        {
            if (txttaiKhoan.Text == "Tên đăng nhập")
            {
                txttaiKhoan.Text = "";
                txttaiKhoan.ForeColor = Color.Black;
            }
        }

        private void txttaiKhoan_Leave(object sender, EventArgs e)
        {
            if (txttaiKhoan.Text == "")
            {
                txttaiKhoan.Text = "Tên đăng nhập";
                txttaiKhoan.ForeColor = Color.Silver;
            }
        }

        private void txtmatKhau_Leave(object sender, EventArgs e)
        {
            if (txtmatKhau.Text == "")
            {
                txtmatKhau.UseSystemPasswordChar = false;
                txtmatKhau.Text = "Mật khẩu";
                txtmatKhau.ForeColor = Color.Silver;
            }
        }

        private void txtmatKhau_Enter(object sender, EventArgs e)
        {
            if (txtmatKhau.Text == "Mật khẩu")
            {
                txtmatKhau.UseSystemPasswordChar = true;
                txtmatKhau.Text = "";
                txtmatKhau.ForeColor = Color.Black;
            }
        }

        private void btnHienPass_Click(object sender, EventArgs e)
        {

        }

        private void btnHienPass_MouseDown(object sender, MouseEventArgs e)
        {
            txtmatKhau.UseSystemPasswordChar = false;
        }
            
        private void btnHienPass_MouseUp(object sender, MouseEventArgs e)
        {
            txtmatKhau.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = new TaiKhoan();
            List<TaiKhoan> lstTaiKhoan = tk.GetAll();
            var check = lstTaiKhoan.Where(p =>p.taiKhoan.Equals(txttaiKhoan.Text)).ToList();
            
            if(check.Count > 0)
            {
                if (check[0].matKhau.Equals(txtmatKhau.Text))
                {
                    MessageBox.Show("Đăng nhập thành công!!!!", "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    frmManHinhChinh frm = new frmManHinhChinh();
                    TaiKhoan.idCrurrent = check[0].maNV;
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Mật khẩu sai!!!!!", "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    txtmatKhau.ResetText();
                }
                 
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại", "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }    
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
