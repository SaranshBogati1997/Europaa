using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS.Prompt
{
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            InitializeComponent();
        }
        public InfoForm(string textToShow)
        {

            InitializeComponent();
            this.mainLabel.Text = textToShow;
        }

        private void YesBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mainLabel_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
