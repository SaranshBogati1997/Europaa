using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS.ChildForm
{
    public partial class ManageForm : Form
    {
        public ManageForm()
        {
            InitializeComponent();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            UsersForm form = new UsersForm(Mode.USER);
            form.Show();
        }

        private void customerBtn_Click(object sender, EventArgs e)
        {
            UsersForm form = new UsersForm(Mode.CUSTOMER);
            form.Show();
        }

        private void supplierBtn_Click(object sender, EventArgs e)
        {
            UsersForm form = new UsersForm(Mode.SUPPLIER);
            form.Show();
        }

        private void productsBtn_Click(object sender, EventArgs e)
        {
            UsersForm form = new UsersForm(Mode.PRODUCT);
            form.Show();
        }

        private void groupsBtn_Click(object sender, EventArgs e)
        {
            UsersForm form = new UsersForm(Mode.GROUP);
            form.Show();
        }

        private void unitBtn_Click(object sender, EventArgs e)
        {
            UsersForm form = new UsersForm(Mode.UNIT);
            form.Show();
        }
    }
}
