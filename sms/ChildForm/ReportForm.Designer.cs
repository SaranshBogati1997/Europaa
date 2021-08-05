namespace SMS.ChildForm
{
    partial class ReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.loadChartBtn = new FontAwesome.Sharp.IconButton();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.yearLabel = new System.Windows.Forms.Label();
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timeComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.reportComboBox = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.monthSelector = new System.Windows.Forms.ComboBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.exportBtn = new FontAwesome.Sharp.IconButton();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 1015);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(1295, 37);
            this.bottomPanel.TabIndex = 1;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(54, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1191, 58);
            this.topPanel.TabIndex = 2;
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(1245, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(50, 1015);
            this.rightPanel.TabIndex = 2;
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(54, 1015);
            this.leftPanel.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(54, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1191, 100);
            this.panel2.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.loadChartBtn);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(774, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(193, 100);
            this.panel6.TabIndex = 9;
            // 
            // loadChartBtn
            // 
            this.loadChartBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.loadChartBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadChartBtn.FlatAppearance.BorderSize = 0;
            this.loadChartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadChartBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.loadChartBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadChartBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.loadChartBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.loadChartBtn.IconColor = System.Drawing.Color.Black;
            this.loadChartBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.loadChartBtn.IconSize = 48;
            this.loadChartBtn.Location = new System.Drawing.Point(0, 28);
            this.loadChartBtn.Name = "loadChartBtn";
            this.loadChartBtn.Rotation = 0D;
            this.loadChartBtn.Size = new System.Drawing.Size(193, 46);
            this.loadChartBtn.TabIndex = 9;
            this.loadChartBtn.Text = "Load Chart";
            this.loadChartBtn.UseVisualStyleBackColor = false;
            this.loadChartBtn.Click += new System.EventHandler(this.loadChartBtn_Click);
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 74);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(193, 26);
            this.panel8.TabIndex = 8;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(193, 28);
            this.panel7.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.yearLabel);
            this.panel5.Controls.Add(this.yearComboBox);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.timeComboBox);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(222, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(552, 100);
            this.panel5.TabIndex = 8;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLabel.Location = new System.Drawing.Point(240, 3);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(106, 28);
            this.yearLabel.TabIndex = 5;
            this.yearLabel.Text = "Select year";
            // 
            // yearComboBox
            // 
            this.yearComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.yearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Location = new System.Drawing.Point(235, 38);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(178, 36);
            this.yearComboBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select time scale";
            // 
            // timeComboBox
            // 
            this.timeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeComboBox.FormattingEnabled = true;
            this.timeComboBox.Items.AddRange(new object[] {
            "Year ",
            "Month"});
            this.timeComboBox.Location = new System.Drawing.Point(11, 38);
            this.timeComboBox.Name = "timeComboBox";
            this.timeComboBox.Size = new System.Drawing.Size(178, 36);
            this.timeComboBox.TabIndex = 2;
            this.timeComboBox.SelectedIndexChanged += new System.EventHandler(this.timeComboBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.reportComboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 100);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Generate report for";
            // 
            // reportComboBox
            // 
            this.reportComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.reportComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.reportComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportComboBox.FormattingEnabled = true;
            this.reportComboBox.Items.AddRange(new object[] {
            "Purchase",
            "Sales",
            "Stock"});
            this.reportComboBox.Location = new System.Drawing.Point(11, 38);
            this.reportComboBox.Name = "reportComboBox";
            this.reportComboBox.Size = new System.Drawing.Size(176, 36);
            this.reportComboBox.TabIndex = 1;
            this.reportComboBox.SelectedIndexChanged += new System.EventHandler(this.reportComboBox_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.monthSelector);
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(54, 915);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1191, 100);
            this.panel3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(325, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Select month to generate report";
            // 
            // monthSelector
            // 
            this.monthSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthSelector.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthSelector.FormattingEnabled = true;
            this.monthSelector.Location = new System.Drawing.Point(330, 64);
            this.monthSelector.Name = "monthSelector";
            this.monthSelector.Size = new System.Drawing.Size(288, 36);
            this.monthSelector.TabIndex = 5;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.exportBtn);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(310, 100);
            this.panel9.TabIndex = 1;
            // 
            // exportBtn
            // 
            this.exportBtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.exportBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exportBtn.FlatAppearance.BorderSize = 0;
            this.exportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.exportBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.exportBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.exportBtn.IconColor = System.Drawing.Color.Black;
            this.exportBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.exportBtn.IconSize = 48;
            this.exportBtn.Location = new System.Drawing.Point(0, 43);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Rotation = 0D;
            this.exportBtn.Size = new System.Drawing.Size(310, 57);
            this.exportBtn.TabIndex = 0;
            this.exportBtn.Text = "Export Report";
            this.exportBtn.UseVisualStyleBackColor = false;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // panel10
            // 
            this.panel10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(310, 43);
            this.panel10.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.chart1);
            this.panel4.Controls.Add(this.chart2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(54, 158);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1191, 757);
            this.panel4.TabIndex = 7;
            // 
            // chart1
            // 
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.AxisY.MajorGrid.Interval = 0D;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.LightVertical;
            series1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series1.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.SystemColors.ActiveBorder;
            series1.CustomProperties = "LabelStyle=Top";
            series1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.LabelForeColor = System.Drawing.Color.DimGray;
            series1.Name = "Series1";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.YValuesPerPoint = 4;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(694, 757);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            this.chart1.Titles.Add(title1);
            this.chart1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseClick);
            this.chart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseMove);
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.Dock = System.Windows.Forms.DockStyle.Right;
            this.chart2.Location = new System.Drawing.Point(694, 0);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(497, 757);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1295, 1052);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.bottomPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportForm";
            this.Text = "Report";
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }


        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private FontAwesome.Sharp.IconButton loadChartBtn;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox timeComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox reportComboBox;
        private System.Windows.Forms.Panel panel9;
        private FontAwesome.Sharp.IconButton exportBtn;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.ComboBox yearComboBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox monthSelector;
    }
}