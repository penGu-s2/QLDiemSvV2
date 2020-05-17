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
    public partial class FormMonHoc : Form
    {
        public FormMonHoc()
        {
            InitializeComponent();
        }

        private void Formdanhmuc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDiemSvV2DataSet.MonHoc' table. You can move, or remove it, as needed.
            this.monHocTableAdapter.Fill(this.qLDiemSvV2DataSet.MonHoc);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
