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
    public partial class FormQLDiem : Form
    {
        public FormQLDiem()
        {
            InitializeComponent();
        }
        
        private void FormQLDiem_Load(object sender, EventArgs e)
        {
         
            // TODO: This line of code loads data into the 'qLDiemSvV2DataSet6.BangDiem' table. You can move, or remove it, as needed.
            this.bangDiemTableAdapter2.Fill(this.qLDiemSvV2DataSet6.BangDiem);
            // TODO: This line of code loads data into the 'qLDiemSvV2DataSet5.BangDiem' table. You can move, or remove it, as needed.
            this.bangDiemTableAdapter1.Fill(this.qLDiemSvV2DataSet5.BangDiem);
            // TODO: This line of code loads data into the 'qLDiemSvV2DataSet4.BangDiem' table. You can move, or remove it, as needed.
            this.bangDiemTableAdapter.Fill(this.qLDiemSvV2DataSet4.BangDiem);

        }

        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtDiemTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
