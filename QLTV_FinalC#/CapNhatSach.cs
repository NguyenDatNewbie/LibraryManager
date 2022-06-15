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
    public partial class CapNhatSach : Form
    {
        public CapNhatSach()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void Reset()
        {
            txtMaSach.ResetText();
            txtSL.ResetText();
            txtTenSach.ResetText();
            txtTenTG.ResetText();
            
        }
        public void BindGrid()
        {
            List<Sach> listSach = Sach.GetAll();
            List<TheLoai> listTL = TheLoai.GetAll();
            List<NXB> listNXB = NXB.GetAll();
            dgvListSach.Rows.Clear();
            int stt = 1;
            foreach (var i in listSach)
            {
                int index = dgvListSach.Rows.Add();
                dgvListSach.Rows[index].Cells[0].Value = stt++;
                dgvListSach.Rows[index].Cells[1].Value = i.maSach;
                dgvListSach.Rows[index].Cells[2].Value = i.tenSach;
                dgvListSach.Rows[index].Cells[3].Value = i.sl;
                dgvListSach.Rows[index].Cells[4].Value = i.tenTG;
                dgvListSach.Rows[index].Cells[5].Value = i.TheLoai.tenTL;
                dgvListSach.Rows[index].Cells[6].Value = i.NXB.tenNXB;
            }

            cbNXB.DataSource = listNXB;
            cbNXB.DisplayMember = "tenNXB";
            cbNXB.ValueMember = "maNXB";

            cbTL.DataSource = listTL;
            cbTL.DisplayMember = "tenTL";
            cbTL.ValueMember = "maTL";
        }
        private void CapNhatSach_Load(object sender, EventArgs e)
        {
            BindGrid();
        }


        private Sach GetSach()
        {
            Sach sach = new Sach();

            sach.maSach = txtMaSach.Text;
            if (txtTenSach != null)
                sach.tenSach = txtTenSach.Text;
            else
                sach.tenSach = "Chưa có tên sách";
            sach.sl = Convert.ToInt32(txtSL.Text);
            sach.tenTG = txtTenTG.Text;
            sach.maTL = cbTL.SelectedValue.ToString();
            sach.maNXB = cbNXB.SelectedValue.ToString();
            return sach;
        }

      
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                Sach themSach = GetSach();
                themSach.Insert();
                MessageBox.Show("Thêm thành công");
                Reset();
                CapNhatSach_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Mã sách này đã tồn tại");
                txtMaSach.Focus();
            }
        }

        private void btnCheckSach_Click(object sender, EventArgs e)
        {
            try 
            {
                Sach checkSach = Sach.GetSach(txtMaSach.Text);
                if (checkSach == null)
                    throw new Exception("Không tìm thấy sách này trong thư viện");
                else
                {
                    txtTenSach.Text = checkSach.tenSach;
                    txtSL.Text = checkSach.sl.ToString();
                    txtTenTG.Text = checkSach.tenTG;
                    cbNXB.SelectedValue = checkSach.maNXB;
                    cbTL.SelectedValue = checkSach.maTL;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                Muon.Delete(txtMaSach.Text);
                Tra.Delete(txtMaSach.Text);
                Sach.Delete(txtMaSach.Text);

                MessageBox.Show("Xóa thành công");
                Reset();
                BindGrid();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                Sach sach = Sach.GetSach(txtMaSach.Text);
                if (sach == null)
                    throw new Exception("Không tìm thấy sách này trong thư viện");

                if (txtTenSach.Text != string.Empty)
                    sach.tenSach = txtTenSach.Text;
                if (txtSL.Text != string.Empty)
                    sach.sl = Convert.ToInt32(txtSL.Text);
                if (txtTenTG.Text != string.Empty)
                    sach.tenTG = txtTenTG.Text;
                sach.maNXB = cbNXB.SelectedValue.ToString();
                sach.maTL = cbTL.SelectedValue.ToString();
                sach.UpdateSach();
                MessageBox.Show("Sửa thành công");
                Reset();
                BindGrid();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void cbTL_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void picBack_Click(object sender, EventArgs e)
        {
            frmManHinhChinh frm = new frmManHinhChinh();
            frm.Show();
            this.Hide();
        }

        private void btnTL_Click(object sender, EventArgs e)
        {
            CapNhatTheLoai frm = new CapNhatTheLoai();
            frm.ShowDialog();
            //BindGrid(Sach.GetAll(), NXB.GetAll(), TheLoai.GetAll());
            BindGrid();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            CapNhatNXB frm = new CapNhatNXB();
            frm.ShowDialog();
            //BindGrid(Sach.GetAll(), NXB.GetAll(), TheLoai.GetAll());
            BindGrid();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            BindGrid();
            Reset();
        }

        private void dgvListSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) // -1 Là dòng title của dgv
            {
                DataGridViewRow row = dgvListSach.Rows[e.RowIndex];

                txtMaSach.Text = Convert.ToString(row.Cells[1].Value);
                txtTenSach.Text = Convert.ToString(row.Cells[2].Value);
                txtSL.Text = Convert.ToString(row.Cells[3].Value);
                txtTenTG.Text = Convert.ToString(row.Cells[4].Value);
                cbTL.Text = row.Cells[5].Value.ToString();
                cbNXB.Text = row.Cells[6].Value.ToString();
            }
        }
    }
}
