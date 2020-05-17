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
    public partial class FormLop : Form
    {
        public FormLop()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FormLop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDiemSvV2DataSet1.Lop' table. You can move, or remove it, as needed.
            this.lopTableAdapter.Fill(this.qLDiemSvV2DataSet1.Lop);

        }
    }
}
