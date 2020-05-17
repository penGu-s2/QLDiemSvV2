namespace QLDiemSVV2
{
    partial class FormSinhVien
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
            this.components = new System.ComponentModel.Container();
            this.box = new System.Windows.Forms.GroupBox();
            this.dtgSV = new System.Windows.Forms.DataGridView();
            this.maSVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.queQuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDiemSvV2DataSet3 = new QLDiemSVV2.QLDiemSvV2DataSet3();
            this.btnThoatSV = new System.Windows.Forms.Button();
            this.btnXoaSV = new System.Windows.Forms.Button();
            this.btnLuuSV = new System.Windows.Forms.Button();
            this.btnThemSV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cboKhoahoc = new System.Windows.Forms.ComboBox();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.sinhVienTableAdapter = new QLDiemSVV2.QLDiemSvV2DataSet3TableAdapters.SinhVienTableAdapter();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearchSV = new System.Windows.Forms.TextBox();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnThemL = new System.Windows.Forms.Button();
            this.btnLuuL = new System.Windows.Forms.Button();
            this.btnXoaL = new System.Windows.Forms.Button();
            this.box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDiemSvV2DataSet3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // box
            // 
            this.box.Controls.Add(this.dtgSV);
            this.box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box.Location = new System.Drawing.Point(249, 130);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(441, 308);
            this.box.TabIndex = 14;
            this.box.TabStop = false;
            this.box.Text = "Danh sách";
            // 
            // dtgSV
            // 
            this.dtgSV.AutoGenerateColumns = false;
            this.dtgSV.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSVDataGridViewTextBoxColumn,
            this.tenSVDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn,
            this.gioiTinhDataGridViewTextBoxColumn,
            this.queQuanDataGridViewTextBoxColumn,
            this.maLopDataGridViewTextBoxColumn});
            this.dtgSV.DataSource = this.sinhVienBindingSource;
            this.dtgSV.Location = new System.Drawing.Point(12, 19);
            this.dtgSV.Name = "dtgSV";
            this.dtgSV.RowHeadersWidth = 51;
            this.dtgSV.Size = new System.Drawing.Size(429, 283);
            this.dtgSV.TabIndex = 0;
            // 
            // maSVDataGridViewTextBoxColumn
            // 
            this.maSVDataGridViewTextBoxColumn.DataPropertyName = "MaSV";
            this.maSVDataGridViewTextBoxColumn.HeaderText = "MaSV";
            this.maSVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maSVDataGridViewTextBoxColumn.Name = "maSVDataGridViewTextBoxColumn";
            this.maSVDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenSVDataGridViewTextBoxColumn
            // 
            this.tenSVDataGridViewTextBoxColumn.DataPropertyName = "TenSV";
            this.tenSVDataGridViewTextBoxColumn.HeaderText = "TenSV";
            this.tenSVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenSVDataGridViewTextBoxColumn.Name = "tenSVDataGridViewTextBoxColumn";
            this.tenSVDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            this.ngaySinhDataGridViewTextBoxColumn.Width = 125;
            // 
            // gioiTinhDataGridViewTextBoxColumn
            // 
            this.gioiTinhDataGridViewTextBoxColumn.DataPropertyName = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.HeaderText = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gioiTinhDataGridViewTextBoxColumn.Name = "gioiTinhDataGridViewTextBoxColumn";
            this.gioiTinhDataGridViewTextBoxColumn.Width = 125;
            // 
            // queQuanDataGridViewTextBoxColumn
            // 
            this.queQuanDataGridViewTextBoxColumn.DataPropertyName = "QueQuan";
            this.queQuanDataGridViewTextBoxColumn.HeaderText = "QueQuan";
            this.queQuanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.queQuanDataGridViewTextBoxColumn.Name = "queQuanDataGridViewTextBoxColumn";
            this.queQuanDataGridViewTextBoxColumn.Width = 125;
            // 
            // maLopDataGridViewTextBoxColumn
            // 
            this.maLopDataGridViewTextBoxColumn.DataPropertyName = "MaLop";
            this.maLopDataGridViewTextBoxColumn.HeaderText = "MaLop";
            this.maLopDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maLopDataGridViewTextBoxColumn.Name = "maLopDataGridViewTextBoxColumn";
            this.maLopDataGridViewTextBoxColumn.Width = 125;
            // 
            // sinhVienBindingSource
            // 
            this.sinhVienBindingSource.DataMember = "SinhVien";
            this.sinhVienBindingSource.DataSource = this.qLDiemSvV2DataSet3;
            // 
            // qLDiemSvV2DataSet3
            // 
            this.qLDiemSvV2DataSet3.DataSetName = "QLDiemSvV2DataSet3";
            this.qLDiemSvV2DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnThoatSV
            // 
            this.btnThoatSV.Location = new System.Drawing.Point(696, 311);
            this.btnThoatSV.Name = "btnThoatSV";
            this.btnThoatSV.Size = new System.Drawing.Size(75, 23);
            this.btnThoatSV.TabIndex = 13;
            this.btnThoatSV.Text = "Thoát";
            this.btnThoatSV.UseVisualStyleBackColor = true;
            this.btnThoatSV.Click += new System.EventHandler(this.btnThoatSV_Click);
            // 
            // btnXoaSV
            // 
            this.btnXoaSV.Location = new System.Drawing.Point(696, 259);
            this.btnXoaSV.Name = "btnXoaSV";
            this.btnXoaSV.Size = new System.Drawing.Size(75, 23);
            this.btnXoaSV.TabIndex = 12;
            this.btnXoaSV.Text = "Xóa";
            this.btnXoaSV.UseVisualStyleBackColor = true;
            this.btnXoaSV.Click += new System.EventHandler(this.btnXoaSV_Click);
            // 
            // btnLuuSV
            // 
            this.btnLuuSV.Location = new System.Drawing.Point(696, 216);
            this.btnLuuSV.Name = "btnLuuSV";
            this.btnLuuSV.Size = new System.Drawing.Size(75, 23);
            this.btnLuuSV.TabIndex = 11;
            this.btnLuuSV.Text = "Lưu";
            this.btnLuuSV.UseVisualStyleBackColor = true;
            this.btnLuuSV.Click += new System.EventHandler(this.btnLuuSV_Click);
            // 
            // btnThemSV
            // 
            this.btnThemSV.Location = new System.Drawing.Point(696, 165);
            this.btnThemSV.Name = "btnThemSV";
            this.btnThemSV.Size = new System.Drawing.Size(75, 23);
            this.btnThemSV.TabIndex = 10;
            this.btnThemSV.Text = "Thêm";
            this.btnThemSV.UseVisualStyleBackColor = true;
            this.btnThemSV.Click += new System.EventHandler(this.btnThemSV_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(265, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "QUẢN LÝ THÔNG TIN SINH VIÊN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTenLop);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtGioiTinh);
            this.groupBox1.Controls.Add(this.txtNgaySinh);
            this.groupBox1.Controls.Add(this.txtMaLop);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtQueQuan);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTenSV);
            this.groupBox1.Controls.Add(this.txtMaSV);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 299);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Location = new System.Drawing.Point(94, 119);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(100, 24);
            this.txtNgaySinh.TabIndex = 17;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(94, 232);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(100, 24);
            this.txtMaLop.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(-3, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 18);
            this.label9.TabIndex = 15;
            this.label9.Text = "Mã lớp";
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Location = new System.Drawing.Point(94, 189);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(100, 24);
            this.txtQueQuan.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-3, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Quê quán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-3, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Giới tính";
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(94, 80);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(100, 24);
            this.txtTenSV.TabIndex = 4;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(94, 37);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(100, 24);
            this.txtMaSV.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-4, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên sinh viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sinh viên";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnXoaL);
            this.groupBox3.Controls.Add(this.btnLuuL);
            this.groupBox3.Controls.Add(this.btnThemL);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.cboKhoahoc);
            this.groupBox3.Controls.Add(this.cboLop);
            this.groupBox3.Location = new System.Drawing.Point(12, 40);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(781, 33);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(246, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 17);
            this.label10.TabIndex = 27;
            this.label10.Text = "DSLop";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(73, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 17);
            this.label11.TabIndex = 26;
            this.label11.Text = "Khoa";
            // 
            // cboKhoahoc
            // 
            this.cboKhoahoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboKhoahoc.FormattingEnabled = true;
            this.cboKhoahoc.Location = new System.Drawing.Point(122, 9);
            this.cboKhoahoc.Name = "cboKhoahoc";
            this.cboKhoahoc.Size = new System.Drawing.Size(120, 21);
            this.cboKhoahoc.TabIndex = 25;
            // 
            // cboLop
            // 
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(313, 12);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(122, 21);
            this.cboLop.TabIndex = 24;
            this.cboLop.SelectedIndexChanged += new System.EventHandler(this.cboLop_SelectedIndexChanged);
            // 
            // sinhVienTableAdapter
            // 
            this.sinhVienTableAdapter.ClearBeforeFill = true;
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Location = new System.Drawing.Point(94, 153);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(100, 24);
            this.txtGioiTinh.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(444, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Tìm kiếm :";
            // 
            // txtSearchSV
            // 
            this.txtSearchSV.Location = new System.Drawing.Point(530, 104);
            this.txtSearchSV.Name = "txtSearchSV";
            this.txtSearchSV.Size = new System.Drawing.Size(248, 20);
            this.txtSearchSV.TabIndex = 19;
            this.txtSearchSV.TextChanged += new System.EventHandler(this.txtSearchSV_TextChanged);
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(94, 269);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(100, 24);
            this.txtTenLop.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 18);
            this.label8.TabIndex = 19;
            this.label8.Text = "Tên lớp";
            // 
            // btnThemL
            // 
            this.btnThemL.Location = new System.Drawing.Point(441, 7);
            this.btnThemL.Name = "btnThemL";
            this.btnThemL.Size = new System.Drawing.Size(75, 23);
            this.btnThemL.TabIndex = 29;
            this.btnThemL.Text = "Thêm";
            this.btnThemL.UseVisualStyleBackColor = true;
            this.btnThemL.Click += new System.EventHandler(this.btnThemL_Click);
            // 
            // btnLuuL
            // 
            this.btnLuuL.Location = new System.Drawing.Point(522, 7);
            this.btnLuuL.Name = "btnLuuL";
            this.btnLuuL.Size = new System.Drawing.Size(75, 23);
            this.btnLuuL.TabIndex = 29;
            this.btnLuuL.Text = "Lưu";
            this.btnLuuL.UseVisualStyleBackColor = true;
            this.btnLuuL.Click += new System.EventHandler(this.btnLuuL_Click);
            // 
            // btnXoaL
            // 
            this.btnXoaL.Location = new System.Drawing.Point(603, 7);
            this.btnXoaL.Name = "btnXoaL";
            this.btnXoaL.Size = new System.Drawing.Size(75, 23);
            this.btnXoaL.TabIndex = 29;
            this.btnXoaL.Text = "Xóa";
            this.btnXoaL.UseVisualStyleBackColor = true;
            this.btnXoaL.Click += new System.EventHandler(this.btnXoaL_Click);
            // 
            // FormSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSearchSV);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.box);
            this.Controls.Add(this.btnThoatSV);
            this.Controls.Add(this.btnXoaSV);
            this.Controls.Add(this.btnLuuSV);
            this.Controls.Add(this.btnThemSV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormSinhVien";
            this.Text = "FormSinhVien";
            this.Load += new System.EventHandler(this.FormSinhVien_Load);
            this.box.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDiemSvV2DataSet3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox box;
        private System.Windows.Forms.DataGridView dtgSV;
        private System.Windows.Forms.Button btnThoatSV;
        private System.Windows.Forms.Button btnXoaSV;
        private System.Windows.Forms.Button btnLuuSV;
        private System.Windows.Forms.Button btnThemSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboKhoahoc;
        private System.Windows.Forms.ComboBox cboLop;
        private QLDiemSvV2DataSet3 qLDiemSvV2DataSet3;
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private QLDiemSvV2DataSet3TableAdapters.SinhVienTableAdapter sinhVienTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn queQuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker txtNgaySinh;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.TextBox txtSearchSV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnXoaL;
        private System.Windows.Forms.Button btnLuuL;
        private System.Windows.Forms.Button btnThemL;
    }
}