namespace QLDiemSVV2
{
    partial class FormMonHoc
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThemMH = new System.Windows.Forms.Button();
            this.btnSuaMH = new System.Windows.Forms.Button();
            this.btnXoaMH = new System.Windows.Forms.Button();
            this.btnThoatMH = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.qLDiemSvV2DataSet = new QLDiemSVV2.QLDiemSvV2DataSet();
            this.monHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monHocTableAdapter = new QLDiemSVV2.QLDiemSvV2DataSetTableAdapters.MonHocTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMamon = new System.Windows.Forms.TextBox();
            this.txtTenmon = new System.Windows.Forms.TextBox();
            this.txtSTC = new System.Windows.Forms.TextBox();
            this.soTinChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMonHocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maMonHocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDiemSvV2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSTC);
            this.groupBox1.Controls.Add(this.txtTenmon);
            this.groupBox1.Controls.Add(this.txtMamon);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 322);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(273, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ MÔN HỌC";
            // 
            // btnThemMH
            // 
            this.btnThemMH.Location = new System.Drawing.Point(698, 160);
            this.btnThemMH.Name = "btnThemMH";
            this.btnThemMH.Size = new System.Drawing.Size(75, 23);
            this.btnThemMH.TabIndex = 3;
            this.btnThemMH.Text = "Thêm";
            this.btnThemMH.UseVisualStyleBackColor = true;
            // 
            // btnSuaMH
            // 
            this.btnSuaMH.Location = new System.Drawing.Point(698, 211);
            this.btnSuaMH.Name = "btnSuaMH";
            this.btnSuaMH.Size = new System.Drawing.Size(75, 23);
            this.btnSuaMH.TabIndex = 4;
            this.btnSuaMH.Text = "Sửa";
            this.btnSuaMH.UseVisualStyleBackColor = true;
            // 
            // btnXoaMH
            // 
            this.btnXoaMH.Location = new System.Drawing.Point(698, 254);
            this.btnXoaMH.Name = "btnXoaMH";
            this.btnXoaMH.Size = new System.Drawing.Size(75, 23);
            this.btnXoaMH.TabIndex = 5;
            this.btnXoaMH.Text = "Xóa";
            this.btnXoaMH.UseVisualStyleBackColor = true;
            // 
            // btnThoatMH
            // 
            this.btnThoatMH.Location = new System.Drawing.Point(698, 306);
            this.btnThoatMH.Name = "btnThoatMH";
            this.btnThoatMH.Size = new System.Drawing.Size(75, 23);
            this.btnThoatMH.TabIndex = 6;
            this.btnThoatMH.Text = "Thoát";
            this.btnThoatMH.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(251, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(441, 338);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maMonHocDataGridViewTextBoxColumn,
            this.tenMonHocDataGridViewTextBoxColumn,
            this.soTinChiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.monHocBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(429, 303);
            this.dataGridView1.TabIndex = 0;
            // 
            // qLDiemSvV2DataSet
            // 
            this.qLDiemSvV2DataSet.DataSetName = "QLDiemSvV2DataSet";
            this.qLDiemSvV2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // monHocBindingSource
            // 
            this.monHocBindingSource.DataMember = "MonHoc";
            this.monHocBindingSource.DataSource = this.qLDiemSvV2DataSet;
            // 
            // monHocTableAdapter
            // 
            this.monHocTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Môn Học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-3, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Môn Học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số tín chỉ";
            // 
            // txtMamon
            // 
            this.txtMamon.Location = new System.Drawing.Point(94, 53);
            this.txtMamon.Name = "txtMamon";
            this.txtMamon.Size = new System.Drawing.Size(100, 24);
            this.txtMamon.TabIndex = 3;
            // 
            // txtTenmon
            // 
            this.txtTenmon.Location = new System.Drawing.Point(94, 117);
            this.txtTenmon.Name = "txtTenmon";
            this.txtTenmon.Size = new System.Drawing.Size(100, 24);
            this.txtTenmon.TabIndex = 4;
            // 
            // txtSTC
            // 
            this.txtSTC.Location = new System.Drawing.Point(94, 178);
            this.txtSTC.Name = "txtSTC";
            this.txtSTC.Size = new System.Drawing.Size(100, 24);
            this.txtSTC.TabIndex = 5;
            // 
            // soTinChiDataGridViewTextBoxColumn
            // 
            this.soTinChiDataGridViewTextBoxColumn.DataPropertyName = "SoTinChi";
            this.soTinChiDataGridViewTextBoxColumn.HeaderText = "SoTinChi";
            this.soTinChiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soTinChiDataGridViewTextBoxColumn.Name = "soTinChiDataGridViewTextBoxColumn";
            this.soTinChiDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenMonHocDataGridViewTextBoxColumn
            // 
            this.tenMonHocDataGridViewTextBoxColumn.DataPropertyName = "TenMonHoc";
            this.tenMonHocDataGridViewTextBoxColumn.HeaderText = "TenMonHoc";
            this.tenMonHocDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenMonHocDataGridViewTextBoxColumn.Name = "tenMonHocDataGridViewTextBoxColumn";
            this.tenMonHocDataGridViewTextBoxColumn.Width = 125;
            // 
            // maMonHocDataGridViewTextBoxColumn
            // 
            this.maMonHocDataGridViewTextBoxColumn.DataPropertyName = "MaMonHoc";
            this.maMonHocDataGridViewTextBoxColumn.HeaderText = "MaMonHoc";
            this.maMonHocDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maMonHocDataGridViewTextBoxColumn.Name = "maMonHocDataGridViewTextBoxColumn";
            this.maMonHocDataGridViewTextBoxColumn.Width = 125;
            // 
            // Formdanhmuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnThoatMH);
            this.Controls.Add(this.btnXoaMH);
            this.Controls.Add(this.btnSuaMH);
            this.Controls.Add(this.btnThemMH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Formdanhmuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Môn Học";
            this.Load += new System.EventHandler(this.Formdanhmuc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDiemSvV2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemMH;
        private System.Windows.Forms.Button btnSuaMH;
        private System.Windows.Forms.Button btnXoaMH;
        private System.Windows.Forms.Button btnThoatMH;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QLDiemSvV2DataSet qLDiemSvV2DataSet;
        private System.Windows.Forms.BindingSource monHocBindingSource;
        private QLDiemSvV2DataSetTableAdapters.MonHocTableAdapter monHocTableAdapter;
        private System.Windows.Forms.TextBox txtSTC;
        private System.Windows.Forms.TextBox txtTenmon;
        private System.Windows.Forms.TextBox txtMamon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMonHocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMonHocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soTinChiDataGridViewTextBoxColumn;
    }
}