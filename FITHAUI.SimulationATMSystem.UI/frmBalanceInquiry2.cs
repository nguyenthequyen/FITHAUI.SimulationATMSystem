using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FITHAUI.SimulationATMSystem.UI
{
    public partial class frmBalanceInquiry2 : Form
    {
        public frmBalanceInquiry2()
        {
            InitializeComponent();
        }

        private void btnDisplayBalance_Click(object sender, EventArgs e)
        {
            var display = new frmBalanceInquiry3();
            this.Hide();
            display.Show();

        }
    }
}
