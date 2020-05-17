using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDiemSVV2
{
    public partial class FormSinhVien : Form
    {
        public FormSinhVien()
        {
            InitializeComponent();
        }
        QLDDataContext dt = new QLDDataContext();

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FormSinhVien_Load(object sender, EventArgs e)
        {
            //xử lý Lớp
            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "MaLop";
         
            cboLop.DataSource = dt.Lop_SelectAll();
            //In Mã lơp
            txtMaLop.DataBindings.Clear();
            txtMaLop.DataBindings.Add("Text", cboLop.DataSource, "MaLop");
            txtTenLop.DataBindings.Clear();
            txtTenLop.DataBindings.Add("Text", cboLop.DataSource, "TenLop");
            // TODO: This line of code loads data into the 'qLDiemSvV2DataSet3.SinhVien' table. You can move, or remove it, as needed.
            this.sinhVienTableAdapter.Fill(this.qLDiemSvV2DataSet3.SinhVien);

        }
        Boolean adLop = false;
        private void btnThemL_Click(object sender, EventArgs e)
        {
            txtMaLop.Text = "";
            txtTenLop.Text = "";
            txtMaLop.Enabled = true;
            txtMaLop.Focus();
            adLop = true; 

        }
        private void btnLuuL_Click(object sender, EventArgs e)
        {
            if (adLop)
            {
                dt.Lop_Insert(txtMaLop.Text, txtTenLop.Text);
                txtMaLop.Enabled = false;
                adLop = false;
            }
            else
            {
                dt.Lop_Update(txtMaLop.Text, txtTenLop.Text);
            }
            FormSinhVien_Load(sender, e);

        }
        private void btnXoaL_Click(object sender, EventArgs e)
        {
            dt.Lop_Delete(cboLop.SelectedValue.ToString());
            FormSinhVien_Load(sender, e);
        }
        

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtgSV.DataSource = dt.Sinhvien_SelectMaLop(txtMaLop.Text);
            txtMaSV.DataBindings.Clear();
            txtMaSV.DataBindings.Add("Text", dtgSV.DataSource, "MaSV");
            txtTenSV.DataBindings.Clear();
            txtTenSV.DataBindings.Add("Text", dtgSV.DataSource, "TenSV");
            txtNgaySinh.DataBindings.Clear();
            txtNgaySinh.DataBindings.Add("Text", dtgSV.DataSource, "NgaySinh");
            txtGioiTinh.DataBindings.Clear();
            txtGioiTinh.DataBindings.Add("Text", dtgSV.DataSource, "GioiTinh");
            txtQueQuan.DataBindings.Clear();
            txtQueQuan.DataBindings.Add("Text", dtgSV.DataSource, "QueQuan");
        }
        Boolean adSV = false;
        private void btnThemSV_Click(object sender, EventArgs e)
        {
            txtMaSV.Text = "";
            txtTenSV.Text= "";
            txtNgaySinh.Text = "";
            txtGioiTinh.Text = "";
            txtQueQuan.Text = "";
            txtMaSV.Enabled = true;
            txtMaSV.Focus();
            adSV = true; 

        }

        private void btnLuuSV_Click(object sender, EventArgs e)
        {
            if (adSV)
            {
                dt.Sinhvien_Insert(txtMaSV.Text, txtTenLop.Text, txtNgaySinh.Text, txtGioiTinh.Text, txtQueQuan.Text, txtMaLop.Text);
                adSV = false;
                txtMaSV.Enabled = false;
                cboLop_SelectedIndexChanged(sender, e);


            }
            else
            {
                dt.Sinhvien_Update(txtMaSV.Text, txtTenLop.Text, txtNgaySinh.Text, txtGioiTinh.Text, txtQueQuan.Text);
                cboLop_SelectedIndexChanged(sender, e);
            }
        }

        private void btnXoaSV_Click(object sender, EventArgs e)
        {
            dt.Sinhvien_Delete(txtMaSV.Text);
            cboLop_SelectedIndexChanged(sender, e);
        }

        private void txtSearchSV_TextChanged(object sender, EventArgs e)
        {
            dtgSV.DataSource = dt.SinhViens.Where(x => x.TenSV.Contains(txtSearchSV.Text)).ToList();
            txtMaSV.DataBindings.Clear();
            txtMaSV.DataBindings.Add("Text", dtgSV.DataSource, "MaSV");
            txtTenSV.DataBindings.Clear();
            txtTenSV.DataBindings.Add("Text", dtgSV.DataSource, "TenSV");
            txtNgaySinh.DataBindings.Clear();
            txtNgaySinh.DataBindings.Add("Text", dtgSV.DataSource, "NgaySinh");
            txtGioiTinh.DataBindings.Clear();
            txtGioiTinh.DataBindings.Add("Text", dtgSV.DataSource, "GioiTinh");
            txtQueQuan.DataBindings.Clear();
            txtQueQuan.DataBindings.Add("Text", dtgSV.DataSource, "QueQuan");
        }

        private void btnThoatSV_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
