using Lib;
using Lib.Service;
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
    public partial class GroupsPopup : Form
    {
        
        public GroupModel selectedGroup {get;set;}
        IGroupService _groupService;
        public GroupsPopup()
        {
            InitializeComponent();
            selectedGroup = new GroupModel();
            _groupService = new GroupRepository();
            addEditBtn.Text = "Add";
            deleteBtn.Text = "Clear";
           

        }
        public GroupsPopup(GroupModel model)
        {
            InitializeComponent();
            selectedGroup = model;
            nameBox.Text = model.GroupName;
            descripionBox.Text = model.GroupDescription;
            addEditBtn.Text = "Edit";
            deleteBtn.Text = "Delete";
        }

        private void addEditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(nameBox.Text == string.Empty)
                {
                    Helper.ShowInfo("Name cannot be empty");
                    return;
                }
                GroupModel model = new GroupModel()
                {
                    GroupName = nameBox.Text,
                    GroupDescription = descripionBox.Text
                };
                bool isAdded = _groupService.AddGroup(model);
                if (isAdded == true) this.DialogResult = DialogResult.OK;
                else DialogResult = DialogResult.No;
            }
            catch(Exception ex)
            {
                Helper.ShowInfo(ex.Message);
            }
        }

        private void nameBox_Enter(object sender, EventArgs e)
        {
            panel6 = Helper.HandleFocusEnter(panel6);
        }

        private void nameBox_Leave(object sender, EventArgs e)
        {
            panel6 = Helper.HandleFocusLeave(panel6);
        }

        private void descripionBox_Enter(object sender, EventArgs e)
        {
            panel4 = Helper.HandleFocusEnter(panel4);
        }

        private void descripionBox_Leave(object sender, EventArgs e)
        {
            panel4 = Helper.HandleFocusLeave(panel4);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (deleteBtn.Text == "Clear")
                {
                    nameBox.Text = "";
                    descripionBox.Text = "";
                }
                else
                {
                   _groupService.DeleteGroup(Convert.ToInt32(selectedGroup.GroupId));
                    this.DialogResult = DialogResult.No;
                }
            }
            catch (Exception ex)
            {
                Logger.Log("GROUP", "ERROR", ex.Message, ex.StackTrace);
            }
        }
    }
}
