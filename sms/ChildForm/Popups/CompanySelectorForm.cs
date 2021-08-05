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
    public partial class CompanySelectorForm : Form
    {
        List<CompanyModel> companyList;
        UserModel activeUser;
        ICompanyService _companyService;
        public CompanySelectorForm(UserModel user)
        {
            try
            {
                activeUser = user;
                InitializeComponent();
                _companyService = new CompanyRepository();
                companyList = _companyService.GetCompany();
                LoadData();
                AddSelectButton();
                //StyleGrid();          

            }
            catch (Exception ex)
            {
                Helper.ShowInfo(ex.Message);
            }

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
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
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
        void AddSelectButton()
        {
            DataGridViewButtonColumn button = new DataGridViewButtonColumn()
            {
                Name = "Select",
                HeaderText = "Actions",
                Text = "Select",
                FlatStyle = FlatStyle.Flat,
                UseColumnTextForButtonValue = true
            };
            button.DefaultCellStyle.BackColor = Color.FromArgb(55, 126, 161);
            button.DefaultCellStyle.ForeColor = Color.WhiteSmoke;
            this.dataGridView1.Columns.Add(button);
        }
        private void LoadData()
        {
            dataGridView1.DataSource = GetDataSource(companyList);
        }
        private DataTable GetDataSource(List<CompanyModel> companyList)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Sn", typeof(int));
            table.Columns.Add("Company", typeof(string));
            table.Columns.Add("PAN", typeof(double));
            int i = 1;
            foreach (CompanyModel company in companyList)
            {
                table.Rows.Add(i, company.CompanyName, company.PAN);
                i++;
            }
            return table;
        }

        private void CompanySelectorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            CompanyPopup popup = new CompanyPopup(activeUser);
            popup.Show();
            this.ShowInTaskbar = false;
            this.Hide();
        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dataGridView1.Columns["Select"].Index)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    var company = new CompanyModel();
                    foreach (var model in companyList)
                    {
                        if (model.PAN == Convert.ToDouble(row.Cells[3].Value))
                        {
                            company = model;
                        }
                    }
                    mainForm form = new mainForm(activeUser, company);
                    form.Show();
                    ShowInTaskbar = false;
                    this.Hide();
                }

            }
            catch (Exception ex)
            {
                Helper.ShowInfo(ex.Message);

            }
        }

        
    }
}
