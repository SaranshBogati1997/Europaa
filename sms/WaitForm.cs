using Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS
{
    public partial class WaitForm : Form
    {
        public Action Worker { get; set; }
        public WaitForm(Action worker)
        {
            InitializeComponent();
            if (worker == null)
            {
                throw new ArgumentNullException();
            }
            Worker = worker;
        }
        
        protected override void OnLoad(EventArgs e)
        {
            try
            {
                base.OnLoad(e);
                Task.Factory.StartNew(Worker).ContinueWith(t =>
                {
                    this.Close();
                }, TaskScheduler.FromCurrentSynchronizationContext());
            }
            catch (Exception ex)
            {
                Logger.Log("WAITFORM", "ERROR", ex.Message, ex.StackTrace);
            }

        }
    }
}
