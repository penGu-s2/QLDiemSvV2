namespace QLDiemSVV2
{
    partial class FormHocKy
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
            this.btnThoatHK = new System.Windows.Forms.Button();
            this.btnXoaHK = new System.Windows.Forms.Button();
            this.btnSuaHK = new System.Windows.Forms.Button();
            this.btnThemHK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.txtMalop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.qLDiemSvV2DataSet2 = new QLDiemSVV2.QLDiemSvV2DataSet2();
            this.hocKyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hocKyTableAdapter = new QLDiemSVV2.QLDiemSvV2DataSet2TableAdapters.HocKyTableAdapter();
            this.maHKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hocKyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLDiemSvV2DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocKyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(249, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(441, 338);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHKDataGridViewTextBoxColumn,
            this.hocKyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hocKyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(429, 303);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnThoatHK
            // 
            this.btnThoatHK.Location = new System.Drawing.Point(696, 311);
            this.btnThoatHK.Name = "btnThoatHK";
            this.btnThoatHK.Size = new System.Drawing.Size(75, 23);
            this.btnThoatHK.TabIndex = 20;
            this.btnThoatHK.Text = "Thoát";
            this.btnThoatHK.UseVisualStyleBackColor = true;
            // 
            // btnXoaHK
            // 
            this.btnXoaHK.Location = new System.Drawing.Point(696, 259);
            this.btnXoaHK.Name = "btnXoaHK";
            this.btnXoaHK.Size = new System.Drawing.Size(75, 23);
            this.btnXoaHK.TabIndex = 19;
            this.btnXoaHK.Text = "Xóa";
            this.btnXoaHK.UseVisualStyleBackColor = true;
            // 
            // btnSuaHK
            // 
            this.btnSuaHK.Location = new System.Drawing.Point(696, 216);
            this.btnSuaHK.Name = "btnSuaHK";
            this.btnSuaHK.Size = new System.Drawing.Size(75, 23);
            this.btnSuaHK.TabIndex = 18;
            this.btnSuaHK.Text = "Sửa";
            this.btnSuaHK.UseVisualStyleBackColor = true;
            // 
            // btnThemHK
            // 
            this.btnThemHK.Location = new System.Drawing.Point(696, 165);
            this.btnThemHK.Name = "btnThemHK";
            this.btnThemHK.Size = new System.Drawing.Size(75, 23);
            this.btnThemHK.TabIndex = 17;
            this.btnThemHK.Text = "Thêm";
            this.btnThemHK.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(271, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "QUẢN LÝ KỲ HỌC";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTenLop);
            this.groupBox1.Controls.Add(this.txtMalop);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 322);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-3, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Học Kỳ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Kỳ Học";
            // 
            // qLDiemSvV2DataSet2
            // 
            this.qLDiemSvV2DataSet2.DataSetName = "QLDiemSvV2DataSet2";
            this.qLDiemSvV2DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hocKyBindingSource
            // 
            this.hocKyBindingSource.DataMember = "HocKy";
            this.hocKyBindingSource.DataSource = this.qLDiemSvV2DataSet2;
            // 
            // hocKyTableAdapter
            // 
            this.hocKyTableAdapter.ClearBeforeFill = true;
            // 
            // maHKDataGridViewTextBoxColumn
            // 
            this.maHKDataGridViewTextBoxColumn.DataPropertyName = "MaHK";
            this.maHKDataGridViewTextBoxColumn.HeaderText = "MaHK";
            this.maHKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maHKDataGridViewTextBoxColumn.Name = "maHKDataGridViewTextBoxColumn";
            this.maHKDataGridViewTextBoxColumn.Width = 125;
            // 
            // hocKyDataGridViewTextBoxColumn
            // 
            this.hocKyDataGridViewTextBoxColumn.DataPropertyName = "HocKy";
            this.hocKyDataGridViewTextBoxColumn.HeaderText = "HocKy";
            this.hocKyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hocKyDataGridViewTextBoxColumn.Name = "hocKyDataGridViewTextBoxColumn";
            this.hocKyDataGridViewTextBoxColumn.Width = 125;
            // 
            // FormHocKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnThoatHK);
            this.Controls.Add(this.btnXoaHK);
            this.Controls.Add(this.btnSuaHK);
            this.Controls.Add(this.btnThemHK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormHocKy";
            this.Text = "Học kỳ";
            this.Load += new System.EventHandler(this.FormHocKy_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLDiemSvV2DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocKyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnThoatHK;
        private System.Windows.Forms.Button btnXoaHK;
        private System.Windows.Forms.Button btnSuaHK;
        private System.Windows.Forms.Button btnThemHK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.TextBox txtMalop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private QLDiemSvV2DataSet2 qLDiemSvV2DataSet2;
        private System.Windows.Forms.BindingSource hocKyBindingSource;
        private QLDiemSvV2DataSet2TableAdapters.HocKyTableAdapter hocKyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hocKyDataGridViewTextBoxColumn;
    }
}