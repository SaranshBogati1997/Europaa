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
    public partial class PromptForm : Form
    {
        bool isYesNo = false;
        public PromptForm(string message, bool isYesNoPrompt)
        {
            InitializeComponent();
            isYesNo = true;
            this.mainLabel.Text = message;
            cancelBtn.Text = "No";
        }
        public PromptForm(string textToShow)
        {
            InitializeComponent();
            isYesNo = false;
            this.mainLabel.Text = textToShow;
        }
        private void YesBtn_Click(object sender, EventArgs e)
        {
            if (isYesNo == true) this.DialogResult = DialogResult.Yes;
            else this.DialogResult = DialogResult.OK;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            if (isYesNo == true) this.DialogResult = DialogResult.No;
            Close();
        }
    }
}
