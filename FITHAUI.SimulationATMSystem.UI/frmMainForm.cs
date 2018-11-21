using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FITHAUI.SimulationATMSystem.UI
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();

        }

        private void btnSuplusBalance_Click(object sender, EventArgs e)
        {
            var surplusPrintStatements = new frmBalanceInquiry1();
            surplusPrintStatements.Show();
            this.Hide();
        }

        private void btnChooseCashTransfer_Click(object sender, EventArgs e)
        {
            var frmChooseKindTransfer = new frmChooseKindTransfer();
            frmChooseKindTransfer.Show();
            this.Hide();
        }
    }
}
