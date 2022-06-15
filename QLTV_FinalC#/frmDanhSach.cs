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
    public partial class frmDanhSach : Form
    {
        private bool check;
        public frmDanhSach()
        {
            InitializeComponent();
        }

        private void frmDanhSach_Load(object sender, EventArgs e)
        {
            try
            {
                SetGridViewStyle(dgvLSMuonTra);
                BindGridMuon(Muon.GetAll());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

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
        private void BindGridMuon(List<Muon> listdata)
        {
            dgvLSMuonTra.Rows.Clear();


            foreach (var i in listdata)
            {
                int index = dgvLSMuonTra.Rows.Add();
                dgvLSMuonTra.Rows[index].Cells[0].Value = i.maSV;
                dgvLSMuonTra.Rows[index].Cells[1].Value = i.SinhVien.tenSV;
                dgvLSMuonTra.Rows[index].Cells[2].Value = i.maSach;
                dgvLSMuonTra.Rows[index].Cells[3].Value = i.Sach.tenSach;
                dgvLSMuonTra.Rows[index].Cells[4].Value = i.ngayMuon;
                dgvLSMuonTra.Rows[index].Cells[5].Value = "..............";
            }
        }
        private void BindGridTra(List<Tra> listdata)
        {
            dgvLSMuonTra.Rows.Clear();

            foreach (var i in listdata)
            {
                int index = dgvLSMuonTra.Rows.Add();
                dgvLSMuonTra.Rows[index].Cells[0].Value = i.maSV;
                dgvLSMuonTra.Rows[index].Cells[1].Value = i.SinhVien.tenSV;
                dgvLSMuonTra.Rows[index].Cells[2].Value = i.maSach;
                dgvLSMuonTra.Rows[index].Cells[3].Value = i.Sach.tenSach;
                dgvLSMuonTra.Rows[index].Cells[4].Value = i.ngayMuon;
                dgvLSMuonTra.Rows[index].Cells[5].Value = i.ngayTra;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Nhập mã số sinh viên" || txtSearch.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã số sinh viên cần tìm", "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                if (check == true)
                {
                    List<Muon> listKQTKT = Muon.GetAll();
                    var lstMuon = listKQTKT.Where(p => p.maSV == txtSearch.Text).ToList();
                    if (lstMuon.Count > 0)
                    {
                        BindGridMuon(lstMuon);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy mã số sinh viên này!", "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
                if (check == false)
                {
                    List<Tra> listKQTKM = Tra.GetAll();
                    var lstTra = listKQTKM.Where(p => p.maSV == txtSearch.Text).ToList();
                    if (lstTra.Count > 0)
                    {
                        BindGridTra(lstTra);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy mã số sinh viên này!", "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void dgvLSMuonTra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMuon_Click_1(object sender, EventArgs e)
        {
            lb2.Text = "Danh sách các sinh viên mượn";
            check = true;
            try
            {
                BindGridMuon(Muon.GetAll());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTra_Click_1(object sender, EventArgs e)
        {
            lb2.Text = "Danh sách các sinh viên đã trả sách";
            check = false;
            try
            {
                BindGridTra(Tra.GetAll());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBackMain_Click(object sender, EventArgs e)
        {
            frmManHinhChinh frm = new frmManHinhChinh();
            frm.Show();
            this.Hide();
        }

        private void txtSearch_Click_1(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }

        private void btnFilter_Click_1(object sender, EventArgs e)
        {
            List<Muon> lstMuon = Muon.GetAll();
            List<Muon> lstKQTK = new List<Muon>();
            DateTime start = DateTime.Parse(dtpStart.Text);
            DateTime end = DateTime.Parse(dtpEnd.Text);
            if (check == true)
            {
                BindGridMuon(Muon.GetMuon(start, end));
            }
            else
            {
                BindGridTra(Tra.GetTra(start, end));
            }
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Nhập mã số sinh viên" || txtSearch.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã số sinh viên cần tìm", "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                Console.WriteLine(txtSearch.Text);
                if (check == true)
                {
                    List<Muon> listKQTKT = Muon.GetAll();
                    var lstMuon = listKQTKT.Where(p => p.maSV == txtSearch.Text).ToList();
                    if (lstMuon.Count > 0)
                    {
                        BindGridMuon(lstMuon);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy mã số sinh viên này!", "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
                if (check == false)
                {
                    List<Tra> listKQTKM = Tra.GetAll();
                    var lstTra = listKQTKM.Where(p => p.maSV == txtSearch.Text).ToList();
                    if (lstTra.Count > 0)
                    {
                        BindGridTra(lstTra);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy mã số sinh viên này!", "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
