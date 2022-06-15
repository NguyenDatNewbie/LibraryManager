
namespace BanTest
{
    partial class frmDanhSach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFilter = new System.Windows.Forms.Button();
            this.lblNgayDi = new System.Windows.Forms.Label();
            this.lblNgayDen = new System.Windows.Forms.Label();
            this.btnTra = new System.Windows.Forms.Button();
            this.btnMuon = new System.Windows.Forms.Button();
            this.lb2 = new System.Windows.Forms.Label();
            this.ngayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLSMuonTra = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBackMain = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLSMuonTra)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnFilter.BackgroundImage = global::BanTest.Properties.Resources.iconLoc;
            this.btnFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilter.Location = new System.Drawing.Point(963, 88);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(95, 51);
            this.btnFilter.TabIndex = 27;
            this.btnFilter.Text = "Lọc";
            this.btnFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click_1);
            // 
            // lblNgayDi
            // 
            this.lblNgayDi.AutoSize = true;
            this.lblNgayDi.BackColor = System.Drawing.Color.Transparent;
            this.lblNgayDi.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayDi.ForeColor = System.Drawing.Color.White;
            this.lblNgayDi.Location = new System.Drawing.Point(687, 100);
            this.lblNgayDi.Name = "lblNgayDi";
            this.lblNgayDi.Size = new System.Drawing.Size(103, 26);
            this.lblNgayDi.TabIndex = 25;
            this.lblNgayDi.Text = "Đến Ngày";
            // 
            // lblNgayDen
            // 
            this.lblNgayDen.AutoSize = true;
            this.lblNgayDen.BackColor = System.Drawing.Color.Transparent;
            this.lblNgayDen.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayDen.ForeColor = System.Drawing.Color.White;
            this.lblNgayDen.Location = new System.Drawing.Point(420, 100);
            this.lblNgayDen.Name = "lblNgayDen";
            this.lblNgayDen.Size = new System.Drawing.Size(91, 26);
            this.lblNgayDen.TabIndex = 23;
            this.lblNgayDen.Text = "Từ Ngày";
            // 
            // btnTra
            // 
            this.btnTra.BackColor = System.Drawing.Color.Cyan;
            this.btnTra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTra.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTra.ForeColor = System.Drawing.Color.White;
            this.btnTra.Location = new System.Drawing.Point(201, 144);
            this.btnTra.Name = "btnTra";
            this.btnTra.Size = new System.Drawing.Size(109, 40);
            this.btnTra.TabIndex = 22;
            this.btnTra.Text = "Trả";
            this.btnTra.UseVisualStyleBackColor = false;
            this.btnTra.Click += new System.EventHandler(this.btnTra_Click_1);
            // 
            // btnMuon
            // 
            this.btnMuon.BackColor = System.Drawing.Color.Cyan;
            this.btnMuon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMuon.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMuon.ForeColor = System.Drawing.Color.White;
            this.btnMuon.Location = new System.Drawing.Point(76, 144);
            this.btnMuon.Name = "btnMuon";
            this.btnMuon.Size = new System.Drawing.Size(105, 40);
            this.btnMuon.TabIndex = 21;
            this.btnMuon.Text = "Mượn";
            this.btnMuon.UseVisualStyleBackColor = false;
            this.btnMuon.Click += new System.EventHandler(this.btnMuon_Click_1);
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.BackColor = System.Drawing.Color.Transparent;
            this.lb2.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.ForeColor = System.Drawing.Color.White;
            this.lb2.Location = new System.Drawing.Point(419, 146);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(386, 32);
            this.lb2.TabIndex = 20;
            this.lb2.Text = "Danh sách các sinh viên mượn";
            // 
            // ngayTra
            // 
            this.ngayTra.FillWeight = 111.42F;
            this.ngayTra.HeaderText = "Ngày trả";
            this.ngayTra.Name = "ngayTra";
            // 
            // ngayMuon
            // 
            this.ngayMuon.FillWeight = 111.42F;
            this.ngayMuon.HeaderText = "Ngày mượn";
            this.ngayMuon.Name = "ngayMuon";
            // 
            // tenSach
            // 
            this.tenSach.FillWeight = 111.42F;
            this.tenSach.HeaderText = "Tên sách";
            this.tenSach.Name = "tenSach";
            // 
            // maSach
            // 
            this.maSach.FillWeight = 62.94916F;
            this.maSach.HeaderText = "Mã sách";
            this.maSach.Name = "maSach";
            // 
            // tenSV
            // 
            this.tenSV.FillWeight = 111.42F;
            this.tenSV.HeaderText = "Họ tên sinh viên";
            this.tenSV.Name = "tenSV";
            this.tenSV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // MaSV
            // 
            this.MaSV.FillWeight = 91.37053F;
            this.MaSV.HeaderText = "MSSV";
            this.MaSV.Name = "MaSV";
            // 
            // dgvLSMuonTra
            // 
            this.dgvLSMuonTra.AllowUserToAddRows = false;
            this.dgvLSMuonTra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLSMuonTra.ColumnHeadersHeight = 30;
            this.dgvLSMuonTra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.tenSV,
            this.maSach,
            this.tenSach,
            this.ngayMuon,
            this.ngayTra});
            this.dgvLSMuonTra.Location = new System.Drawing.Point(64, 190);
            this.dgvLSMuonTra.Name = "dgvLSMuonTra";
            this.dgvLSMuonTra.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvLSMuonTra.RowHeadersVisible = false;
            this.dgvLSMuonTra.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvLSMuonTra.RowTemplate.Height = 25;
            this.dgvLSMuonTra.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvLSMuonTra.Size = new System.Drawing.Size(1026, 476);
            this.dgvLSMuonTra.TabIndex = 19;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSearch.BackgroundImage = global::BanTest.Properties.Resources.iconSearch;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSearch.Location = new System.Drawing.Point(963, 31);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(155, 51);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(425, 50);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(515, 30);
            this.txtSearch.TabIndex = 17;
            this.txtSearch.Text = "Nhập mã số sinh viên";
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click_1);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::BanTest.Properties.Resources.rsz_books;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Location = new System.Drawing.Point(280, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(134, 100);
            this.panel1.TabIndex = 16;
            // 
            // btnBackMain
            // 
            this.btnBackMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBackMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackMain.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackMain.Image = global::BanTest.Properties.Resources.iconBack;
            this.btnBackMain.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBackMain.Location = new System.Drawing.Point(-5, 3);
            this.btnBackMain.Name = "btnBackMain";
            this.btnBackMain.Size = new System.Drawing.Size(142, 55);
            this.btnBackMain.TabIndex = 15;
            this.btnBackMain.Text = "Trở lại";
            this.btnBackMain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBackMain.UseVisualStyleBackColor = false;
            this.btnBackMain.Click += new System.EventHandler(this.btnBackMain_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(480, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(375, 40);
            this.lbTitle.TabIndex = 14;
            this.lbTitle.Text = "Lịch sử mượn - trả sách";
            // 
            // dtpStart
            // 
            this.dtpStart.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStart.Location = new System.Drawing.Point(518, 105);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(143, 20);
            this.dtpStart.TabIndex = 28;
            // 
            // dtpEnd
            // 
            this.dtpEnd.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnd.Location = new System.Drawing.Point(796, 105);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(147, 20);
            this.dtpEnd.TabIndex = 29;
            // 
            // frmDanhSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BanTest.Properties.Resources.backround1;
            this.ClientSize = new System.Drawing.Size(1136, 676);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.lblNgayDi);
            this.Controls.Add(this.lblNgayDen);
            this.Controls.Add(this.btnTra);
            this.Controls.Add(this.btnMuon);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.dgvLSMuonTra);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBackMain);
            this.Controls.Add(this.lbTitle);
            this.Name = "frmDanhSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách";
            this.Load += new System.EventHandler(this.frmDanhSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLSMuonTra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lblNgayDi;
        private System.Windows.Forms.Label lblNgayDen;
        private System.Windows.Forms.Button btnTra;
        private System.Windows.Forms.Button btnMuon;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridView dgvLSMuonTra;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBackMain;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
    }
}

