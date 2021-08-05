using SMS.Prompt;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SMS
{
    public class Helper
    {
        public static void ShowInfo(string message)
        {
            InfoForm form = new InfoForm(message);
            form.Show();
        }

        public static bool ShowPrompt(string message)
        {
            bool response =false;
            PromptForm form = new PromptForm(message);
            if(form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                response = true;
            }
            return response;
        }
       public static System.Windows.Forms.Panel HandleFocusEnter(System.Windows.Forms.Panel panel)
        {
            System.Windows.Forms.Panel returnPanel = panel;
            returnPanel.BackColor = Color.RoyalBlue;
            return returnPanel;
        }
        public static System.Windows.Forms.Panel HandleFocusLeave(System.Windows.Forms.Panel panel)
        {
            System.Windows.Forms.Panel returnPanel = panel;
            returnPanel.BackColor = Color.DarkGray;
            return returnPanel;
        }
    }

    public enum Mode
    {
        USER,
        SUPPLIER,
        CUSTOMER,
        UNIT,
        PRODUCT,
        GROUP
    }
}
