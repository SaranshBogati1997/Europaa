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
    public partial class UnitPopup : Form
    {
        
        public UnitModel selectedUnit { get; set; }
        IUnitService _unitService; 
        public UnitPopup()
        {
            selectedUnit = new UnitModel();
            InitializeComponent();
            addEditBtn.Text = "Add";
            deleteBtn.Text = "Clear";
            _unitService = new UnitRepository();
           
        }
        public UnitPopup(UnitModel model)
        {
            selectedUnit = model;
            InitializeComponent();
            nameBox.Text = model.UnitName;
            shortNameBox.Text = model.UnitShortName;
            addEditBtn.Text = "Edit";
        }

        private void addEditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (nameBox.Text == string.Empty)
                {
                    Helper.ShowInfo("Name cannot be empty");
                    return;
                }
                UnitModel model = new UnitModel()
                {
                    UnitName = nameBox.Text,
                    UnitShortName = shortNameBox.Text
                };
                bool isAdded = _unitService.AddUnit(model);
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

        private void shortNameBox_Enter(object sender, EventArgs e)
        {
            panel1 = Helper.HandleFocusEnter(panel1);
        }

        private void shortNameBox_Leave(object sender, EventArgs e)
        {
            panel1 = Helper.HandleFocusLeave(panel1);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (deleteBtn.Text == "Clear")
                {
                    nameBox.Text = "";
                    shortNameBox.Text = "";
                }
                else
                {
                    _unitService.DeleteUnit(Convert.ToInt32(selectedUnit.UnitId));
                    this.DialogResult = DialogResult.No;
                }
            }
            catch (Exception ex)
            {
                Logger.Log("UNIT", "ERROR", ex.Message, ex.StackTrace);
            }
        }
    }
}
