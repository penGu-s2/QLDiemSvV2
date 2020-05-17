namespace QLDiemSVV2
{
    partial class FormLop
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnThoatL = new System.Windows.Forms.Button();
            this.btnXoaL = new System.Windows.Forms.Button();
            this.btnSuaL = new System.Windows.Forms.Button();
            this.btnThemL = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHĐT = new System.Windows.Forms.TextBox();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.txtMalop = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.qLDiemSvV2DataSet1 = new QLDiemSVV2.QLDiemSvV2DataSet1();
            this.lopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lopTableAdapter = new QLDiemSVV2.QLDiemSvV2DataSet1TableAdapters.LopTableAdapter();
            this.maLopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heDaoTaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLDiemSvV2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(249, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(441, 338);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maLopDataGridViewTextBoxColumn,
            this.tenLopDataGridViewTextBoxColumn,
            this.heDaoTaoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lopBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(429, 303);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnThoatL
            // 
            this.btnThoatL.Location = new System.Drawing.Point(696, 311);
            this.btnThoatL.Name = "btnThoatL";
            this.btnThoatL.Size = new System.Drawing.Size(75, 23);
            this.btnThoatL.TabIndex = 13;
            this.btnThoatL.Text = "Thoát";
            this.btnThoatL.UseVisualStyleBackColor = true;
            // 
            // btnXoaL
            // 
            this.btnXoaL.Location = new System.Drawing.Point(696, 259);
            this.btnXoaL.Name = "btnXoaL";
            this.btnXoaL.Size = new System.Drawing.Size(75, 23);
            this.btnXoaL.TabIndex = 12;
            this.btnXoaL.Text = "Xóa";
            this.btnXoaL.UseVisualStyleBackColor = true;
            // 
            // btnSuaL
            // 
            this.btnSuaL.Location = new System.Drawing.Point(696, 216);
            this.btnSuaL.Name = "btnSuaL";
            this.btnSuaL.Size = new System.Drawing.Size(75, 23);
            this.btnSuaL.TabIndex = 11;
            this.btnSuaL.Text = "Sửa";
            this.btnSuaL.UseVisualStyleBackColor = true;
            // 
            // btnThemL
            // 
            this.btnThemL.Location = new System.Drawing.Point(696, 165);
            this.btnThemL.Name = "btnThemL";
            this.btnThemL.Size = new System.Drawing.Size(75, 23);
            this.btnThemL.TabIndex = 10;
            this.btnThemL.Text = "Thêm";
            this.btnThemL.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(271, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "QUẢN LÝ LỚP ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtHĐT);
            this.groupBox1.Controls.Add(this.txtTenLop);
            this.groupBox1.Controls.Add(this.txtMalop);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 322);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txtHĐT
            // 
            this.txtHĐT.Location = new System.Drawing.Point(94, 178);
            this.txtHĐT.Name = "txtHĐT";
            this.txtHĐT.Size = new System.Drawing.Size(100, 24);
            this.txtHĐT.TabIndex = 5;
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(94, 117);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(100, 24);
            this.txtTenLop.TabIndex = 4;
            // 
            // txtMalop
            // 
            this.txtMalop.Location = new System.Drawing.Point(94, 53);
            this.txtMalop.Name = "txtMalop";
            this.txtMalop.Size = new System.Drawing.Size(100, 24);
            this.txtMalop.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-1, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Hệ Đào Tạo";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-3, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Lớp";
            // 
            // qLDiemSvV2DataSet1
            // 
            this.qLDiemSvV2DataSet1.DataSetName = "QLDiemSvV2DataSet1";
            this.qLDiemSvV2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lopBindingSource
            // 
            this.lopBindingSource.DataMember = "Lop";
            this.lopBindingSource.DataSource = this.qLDiemSvV2DataSet1;
            // 
            // lopTableAdapter
            // 
            this.lopTableAdapter.ClearBeforeFill = true;
            // 
            // maLopDataGridViewTextBoxColumn
            // 
            this.maLopDataGridViewTextBoxColumn.DataPropertyName = "MaLop";
            this.maLopDataGridViewTextBoxColumn.HeaderText = "MaLop";
            this.maLopDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maLopDataGridViewTextBoxColumn.Name = "maLopDataGridViewTextBoxColumn";
            this.maLopDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenLopDataGridViewTextBoxColumn
            // 
            this.tenLopDataGridViewTextBoxColumn.DataPropertyName = "TenLop";
            this.tenLopDataGridViewTextBoxColumn.HeaderText = "TenLop";
            this.tenLopDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenLopDataGridViewTextBoxColumn.Name = "tenLopDataGridViewTextBoxColumn";
            this.tenLopDataGridViewTextBoxColumn.Width = 125;
            // 
            // heDaoTaoDataGridViewTextBoxColumn
            // 
            this.heDaoTaoDataGridViewTextBoxColumn.DataPropertyName = "HeDaoTao";
            this.heDaoTaoDataGridViewTextBoxColumn.HeaderText = "HeDaoTao";
            this.heDaoTaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.heDaoTaoDataGridViewTextBoxColumn.Name = "heDaoTaoDataGridViewTextBoxColumn";
            this.heDaoTaoDataGridViewTextBoxColumn.Width = 125;
            // 
            // FormLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnThoatL);
            this.Controls.Add(this.btnXoaL);
            this.Controls.Add(this.btnSuaL);
            this.Controls.Add(this.btnThemL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormLop";
            this.Text = "FormLop";
            this.Load += new System.EventHandler(this.FormLop_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLDiemSvV2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnThoatL;
        private System.Windows.Forms.Button btnXoaL;
        private System.Windows.Forms.Button btnSuaL;
        private System.Windows.Forms.Button btnThemL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtHĐT;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.TextBox txtMalop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private QLDiemSvV2DataSet1 qLDiemSvV2DataSet1;
        private System.Windows.Forms.BindingSource lopBindingSource;
        private QLDiemSvV2DataSet1TableAdapters.LopTableAdapter lopTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heDaoTaoDataGridViewTextBoxColumn;
    }
}