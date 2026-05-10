using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalAutomation
{
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }

        private void AnaMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnCarOp_Click(object sender, EventArgs e)
        {
            AracForm frm = new AracForm();
            frm.Show();
        }

        private void btnRentalOp_Click(object sender, EventArgs e)
        {
            KiralamaForm frm = new KiralamaForm();
            frm.Show();
        }

        private void btnCustomerOp_Click(object sender, EventArgs e)
        {
            MusteriForm frm = new MusteriForm();
            frm.Show();
        }

        private void btnMarkaYonetimi_Click(object sender, EventArgs e)
        {
            MarkaForm frm = new MarkaForm();
            frm.Show();
        }
    }
}
