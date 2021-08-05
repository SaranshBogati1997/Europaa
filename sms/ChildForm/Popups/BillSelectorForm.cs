using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS.ChildForm.Popups
{
    public partial class BillSelectorForm : Form
    {
        public BillSelectorForm()
        {
            InitializeComponent();
        }

        private void loadBillBtn_Click(object sender, EventArgs e)
        {
            SalesForm form = new SalesForm();
            form.Show();
            this.Hide();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            PurchaseForm form = new PurchaseForm();
            form.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
