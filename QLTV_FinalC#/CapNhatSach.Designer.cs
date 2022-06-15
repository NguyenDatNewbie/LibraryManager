
namespace BanTest
{
    partial class CapNhatSach
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
            this.dgvListSach = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picCheck = new System.Windows.Forms.PictureBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbNXB = new System.Windows.Forms.ComboBox();
            this.cbTL = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTenTG = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.picBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSach)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListSach
            // 
            this.dgvListSach.AllowUserToDeleteRows = false;
            this.dgvListSach.AllowUserToResizeColumns = false;
            this.dgvListSach.AllowUserToResizeRows = false;
            this.dgvListSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListSach.ColumnHeadersHeight = 27;
            this.dgvListSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.maSach,
            this.tenSach,
            this.sl,
            this.tenTG,
            this.tenTL,
            this.TenNXB});
            this.dgvListSach.Location = new System.Drawing.Point(60, 309);
            this.dgvListSach.Name = "dgvListSach";
            this.dgvListSach.ReadOnly = true;
            this.dgvListSach.RowHeadersVisible = false;
            this.dgvListSach.RowTemplate.Height = 30;
            this.dgvListSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListSach.Size = new System.Drawing.Size(749, 290);
            this.dgvListSach.TabIndex = 0;
            this.dgvListSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListSach_CellClick);
            // 
            // stt
            // 
            this.stt.FillWeight = 33.56165F;
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            // 
            // maSach
            // 
            this.maSach.FillWeight = 77.55723F;
            this.maSach.HeaderText = "Mã Sách";
            this.maSach.Name = "maSach";
            this.maSach.ReadOnly = true;
            this.maSach.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tenSach
            // 
            this.tenSach.FillWeight = 183.5786F;
            this.tenSach.HeaderText = "Tên sách";
            this.tenSach.Name = "tenSach";
            this.tenSach.ReadOnly = true;
            this.tenSach.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // sl
            // 
            this.sl.FillWeight = 32.15486F;
            this.sl.HeaderText = "SL";
            this.sl.Name = "sl";
            this.sl.ReadOnly = true;
            this.sl.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tenTG
            // 
            this.tenTG.FillWeight = 139.4161F;
            this.tenTG.HeaderText = "Tác giả";
            this.tenTG.Name = "tenTG";
            this.tenTG.ReadOnly = true;
            this.tenTG.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tenTL
            // 
            this.tenTL.FillWeight = 111.1219F;
            this.tenTL.HeaderText = "Thể loại";
            this.tenTL.Name = "tenTL";
            this.tenTL.ReadOnly = true;
            this.tenTL.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TenNXB
            // 
            this.TenNXB.FillWeight = 122.6096F;
            this.TenNXB.HeaderText = "NXB";
            this.TenNXB.Name = "TenNXB";
            this.TenNXB.ReadOnly = true;
            this.TenNXB.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(393, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Constantia", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(353, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cập Nhật Sách";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.picCheck);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnHuy);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.cbNXB);
            this.panel2.Controls.Add(this.cbTL);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtTenTG);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtSL);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txtTenSach);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txtMaSach);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(38, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(816, 217);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::BanTest.Properties.Resources.plus;
            this.pictureBox2.Location = new System.Drawing.Point(766, 111);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.button13_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::BanTest.Properties.Resources.plus;
            this.pictureBox1.Location = new System.Drawing.Point(766, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.btnTL_Click);
            // 
            // picCheck
            // 
            this.picCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCheck.Image = global::BanTest.Properties.Resources.search_alt;
            this.picCheck.Location = new System.Drawing.Point(299, 15);
            this.picCheck.Name = "picCheck";
            this.picCheck.Size = new System.Drawing.Size(25, 23);
            this.picCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCheck.TabIndex = 30;
            this.picCheck.TabStop = false;
            this.picCheck.Click += new System.EventHandler(this.btnCheckSach_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold);
            this.btnSua.Location = new System.Drawing.Point(417, 176);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(92, 28);
            this.btnSua.TabIndex = 28;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold);
            this.btnHuy.Location = new System.Drawing.Point(543, 176);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(92, 28);
            this.btnHuy.TabIndex = 27;
            this.btnHuy.Text = "Reset";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Location = new System.Drawing.Point(286, 176);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(92, 28);
            this.btnXoa.TabIndex = 25;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold);
            this.btnThem.Location = new System.Drawing.Point(157, 176);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(92, 28);
            this.btnThem.TabIndex = 24;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbNXB
            // 
            this.cbNXB.FormattingEnabled = true;
            this.cbNXB.Location = new System.Drawing.Point(634, 111);
            this.cbNXB.Name = "cbNXB";
            this.cbNXB.Size = new System.Drawing.Size(121, 23);
            this.cbNXB.TabIndex = 21;
            // 
            // cbTL
            // 
            this.cbTL.FormattingEnabled = true;
            this.cbTL.Location = new System.Drawing.Point(634, 61);
            this.cbTL.Name = "cbTL";
            this.cbTL.Size = new System.Drawing.Size(121, 23);
            this.cbTL.TabIndex = 20;
            this.cbTL.SelectedIndexChanged += new System.EventHandler(this.cbTL_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(486, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 19);
            this.label9.TabIndex = 19;
            this.label9.Text = "Nhà xuất bản";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(486, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 19);
            this.label10.TabIndex = 18;
            this.label10.Text = "Thể loại";
            // 
            // txtTenTG
            // 
            this.txtTenTG.Location = new System.Drawing.Point(634, 14);
            this.txtTenTG.Name = "txtTenTG";
            this.txtTenTG.Size = new System.Drawing.Size(121, 22);
            this.txtTenTG.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(486, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 19);
            this.label11.TabIndex = 16;
            this.label11.Text = "Tên tác giả";
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(143, 112);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(187, 22);
            this.txtSL.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(41, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 19);
            this.label12.TabIndex = 14;
            this.label12.Text = "Số lượng";
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(143, 63);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(187, 22);
            this.txtTenSach.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(41, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 19);
            this.label13.TabIndex = 12;
            this.label13.Text = "Tên sách";
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(143, 15);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(144, 22);
            this.txtMaSach.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(41, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 19);
            this.label14.TabIndex = 10;
            this.label14.Text = "Mã sách";
            // 
            // picBack
            // 
            this.picBack.BackColor = System.Drawing.Color.Transparent;
            this.picBack.BackgroundImage = global::BanTest.Properties.Resources.back_arrow;
            this.picBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBack.Location = new System.Drawing.Point(17, 10);
            this.picBack.Name = "picBack";
            this.picBack.Size = new System.Drawing.Size(61, 52);
            this.picBack.TabIndex = 4;
            this.picBack.TabStop = false;
            this.picBack.Click += new System.EventHandler(this.picBack_Click);
            // 
            // CapNhatSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BanTest.Properties.Resources.pexels_moose_photos_1037995;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 629);
            this.Controls.Add(this.picBack);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListSach);
            this.Name = "CapNhatSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CapNhatSach";
            this.Load += new System.EventHandler(this.CapNhatSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSach)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbNXB;
        private System.Windows.Forms.ComboBox cbTL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTenTG;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvListSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNXB;
        private System.Windows.Forms.PictureBox picBack;
        private System.Windows.Forms.PictureBox picCheck;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}