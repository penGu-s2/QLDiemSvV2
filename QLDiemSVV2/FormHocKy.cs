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
    public partial class FormHocKy : Form
    {
        public FormHocKy()
        {
            InitializeComponent();
        }

        private void FormHocKy_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDiemSvV2DataSet2.HocKy' table. You can move, or remove it, as needed.
            this.hocKyTableAdapter.Fill(this.qLDiemSvV2DataSet2.HocKy);

        }
    }
}
