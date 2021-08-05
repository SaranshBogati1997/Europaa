using Lib;
using Lib.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS.ChildForm
{
    public partial class SupplierForm : Form
    {      
        string moduleName = "SUPPLIERFORM";
        ISupplierService _supplierService;
        public SupplierForm()
        {
            try
            {
                InitializeComponent();             
                InitializeGridOnly();
                textBox1.GotFocus += TextBox1_GotFocus;
                _supplierService = new SupplierRepository();
            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
                Helper.ShowInfo(ex.Message);
            }
        }


        private void TextBox1_GotFocus(object sender, EventArgs e)
        {
            if (textBox1.Text == "Type here to search..")
            {
                textBox1.Text = "";
            }
        }

        private void InitializeGridOnly()
        {
            //StyleGrid();
            this.dataGridView1.DataSource = _supplierService.GetData();
            DataGridViewButtonColumn button = new DataGridViewButtonColumn()
            {
                Name = "Edit",
                HeaderText = "Actions",
                Text = "Action",
                FlatStyle = FlatStyle.Flat,
                UseColumnTextForButtonValue = true
            };
            //button.DefaultCellStyle.BackColor = Color.FromArgb(55, 126, 161);
            //button.DefaultCellStyle.ForeColor = Color.WhiteSmoke;
            this.dataGridView1.Columns.Add(button);
            dataGridView1.CellClick += dataGridView1_CellClick;

            this.dataGridView1.AllowUserToAddRows = false;
        }

        private void StyleGrid()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;

            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(54, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(909, 440);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.ForeColor = Color.Black;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.DefaultCellStyle.SelectionBackColor = this.dataGridView1.DefaultCellStyle.BackColor;
            this.dataGridView1.DefaultCellStyle.SelectionForeColor = this.dataGridView1.DefaultCellStyle.ForeColor;
        }



        private void addSupplierBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SupplierModel supplier = new SupplierModel();
                SupplierPopup popup = new SupplierPopup();
                if (popup.ShowDialog() == DialogResult.OK)
                {
                    supplier = popup.selectedSupplier;
                    bool supplierAdded = _supplierService.AddSupplier(supplier);
                    if (supplierAdded == true) Helper.ShowInfo("Supplier added successfully");
                    else Helper.ShowInfo("Failed to add Supplier");

                    RefreshData();
                }
            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
                Helper.ShowInfo(ex.Message);
            }

        }
        //edit supplier button
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dataGridView1.Columns["Edit"].Index)
                {
                    //Edit
                    if (e.RowIndex == -1) return;
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    SupplierModel supplier = new SupplierModel()
                    {
                        SupplierId = Convert.ToInt32(row.Cells[1].Value),
                        SupplierName = row.Cells[2].Value.ToString(),
                        SupplierAddress= row.Cells[3].Value.ToString(),
                        SupplierMobileNo= Convert.ToInt64(row.Cells[4].Value),
                        SupplierVatNo= Convert.ToInt64(row.Cells[5].Value)
                    };
                    SupplierPopup editPopup = new SupplierPopup(supplier);
                    DialogResult dr = new DialogResult();
                    dr = editPopup.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        SupplierModel editedsupplier = editPopup.selectedSupplier;
                        editedsupplier.SupplierId = supplier.SupplierId;
                        bool isUpdateComplete = _supplierService.UpdateSupplier(editedsupplier);
                        if (isUpdateComplete == true) Helper.ShowInfo("Supplier update complete");
                        else Helper.ShowInfo("Failed to update supplier");
                    }
                    else if (dr == DialogResult.No)
                    {
                        bool result = Helper.ShowPrompt("Are you sure you want to delete " + supplier.SupplierName + "?");

                        if (result == true)
                        {
                            bool isDeleted = _supplierService.DeleteSupplier(supplier.SupplierId);
                            if (isDeleted == true) Helper.ShowInfo(supplier.SupplierName + " deleted successfully");
                            else Helper.ShowInfo("Failed to delete supplier");
                        }
                    }
                }

                RefreshData();
            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
                Helper.ShowInfo(ex.Message);
            }

        }

        private void RefreshData()
        {
            try
            {
                this.dataGridView1.DataSource = _supplierService.GetData();
            }
            catch (Exception ex)
            {
                Helper.ShowInfo("Error encounetered. Error details: " + ex.Message);
            }


        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = dataGridView1.DataSource;
                string query1 = "";
                string query2 = "Name LIKE '%" + textBox1.Text + "%'";
                string query3 = "";
                if (textBox1.Text == string.Empty)
                {
                    query1 = "";
                    query3 = "";
                }
                else
                {
                    bool isId = int.TryParse(textBox1.Text, out _);
                    bool isNumber = long.TryParse(textBox1.Text, out _);
                    if (isId == true) query1 = " OR Id = " + Convert.ToInt32(textBox1.Text);
                    //if(isNumeric == true) query3 = " OR  MobileNo lIKE '%" + textBox1.Text + "%'";
                    if (isNumber == true) query3 = string.Format("OR CONVERT(MobileNo, 'System.String') like '%{0}%'",
                                      textBox1.Text);
                }
                bs.Filter = query2 + query1 + query3;
                //"Id LIKE '%" + textBox1.Text + "%'";


                dataGridView1.DataSource = bs;
            }
            catch (Exception ex)
            {
                Logger.Log(moduleName, "ERROR", ex.Message, ex.StackTrace);
                Helper.ShowInfo(ex.Message);
            }

        }
    }
}
