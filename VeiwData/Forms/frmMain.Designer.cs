namespace VeiwData
{
    partial class frmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnMenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuVeiw = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuTreeView = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatusProcessor = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.sgIntendedData = new NationalInstruments.UI.WindowsForms.ScatterGraph();
            this.scatterPlot2 = new NationalInstruments.UI.ScatterPlot();
            this.xAxis2 = new NationalInstruments.UI.XAxis();
            this.yAxis2 = new NationalInstruments.UI.YAxis();
            this.sgAllData = new NationalInstruments.UI.WindowsForms.ScatterGraph();
            this.scatterPlot1 = new NationalInstruments.UI.ScatterPlot();
            this.xAxis3 = new NationalInstruments.UI.XAxis();
            this.yAxis3 = new NationalInstruments.UI.YAxis();
            this.sbChart = new System.Windows.Forms.HScrollBar();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblIndex = new System.Windows.Forms.Label();
            this.lblRangeData = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLengthData = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCurser = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbZoom = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tvFileName = new System.Windows.Forms.TreeView();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnChoose = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sgIntendedData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sgAllData)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuFile,
            this.btnMenuEdit,
            this.btnMenuVeiw});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1820, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnMenuFile
            // 
            this.btnMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuOpenFile,
            this.toolStripSeparator1,
            this.btnMenuExit});
            this.btnMenuFile.Name = "btnMenuFile";
            this.btnMenuFile.Size = new System.Drawing.Size(37, 20);
            this.btnMenuFile.Text = "File";
            // 
            // btnMenuOpenFile
            // 
            this.btnMenuOpenFile.Name = "btnMenuOpenFile";
            this.btnMenuOpenFile.Size = new System.Drawing.Size(121, 22);
            this.btnMenuOpenFile.Text = "OpenFile";
            this.btnMenuOpenFile.Click += new System.EventHandler(this.btnMenuOpenFile_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(118, 6);
            // 
            // btnMenuExit
            // 
            this.btnMenuExit.Name = "btnMenuExit";
            this.btnMenuExit.Size = new System.Drawing.Size(121, 22);
            this.btnMenuExit.Text = "Exit";
            this.btnMenuExit.Click += new System.EventHandler(this.btnMenuExit_Click);
            // 
            // btnMenuEdit
            // 
            this.btnMenuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem});
            this.btnMenuEdit.Name = "btnMenuEdit";
            this.btnMenuEdit.Size = new System.Drawing.Size(39, 20);
            this.btnMenuEdit.Text = "Edit";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // btnMenuVeiw
            // 
            this.btnMenuVeiw.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuTreeView});
            this.btnMenuVeiw.Name = "btnMenuVeiw";
            this.btnMenuVeiw.Size = new System.Drawing.Size(43, 20);
            this.btnMenuVeiw.Text = "Veiw";
            // 
            // btnMenuTreeView
            // 
            this.btnMenuTreeView.Name = "btnMenuTreeView";
            this.btnMenuTreeView.Size = new System.Drawing.Size(120, 22);
            this.btnMenuTreeView.Text = "TreeView";
            this.btnMenuTreeView.Click += new System.EventHandler(this.btnMenuTreeView_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusProcessor});
            this.statusStrip1.Location = new System.Drawing.Point(0, 687);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1820, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatusProcessor
            // 
            this.lblStatusProcessor.Name = "lblStatusProcessor";
            this.lblStatusProcessor.Size = new System.Drawing.Size(91, 17);
            this.lblStatusProcessor.Text = "Processing Data";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1810, 657);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.sgIntendedData);
            this.groupBox3.Controls.Add(this.sgAllData);
            this.groupBox3.Controls.Add(this.sbChart);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(290, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1500, 633);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chart";
            // 
            // sgIntendedData
            // 
            this.sgIntendedData.Location = new System.Drawing.Point(23, 102);
            this.sgIntendedData.Name = "sgIntendedData";
            this.sgIntendedData.Plots.AddRange(new NationalInstruments.UI.ScatterPlot[] {
            this.scatterPlot2});
            this.sgIntendedData.Size = new System.Drawing.Size(1453, 391);
            this.sgIntendedData.TabIndex = 8;
            this.sgIntendedData.UseColorGenerator = true;
            this.sgIntendedData.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis2});
            this.sgIntendedData.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis2});
            // 
            // scatterPlot2
            // 
            this.scatterPlot2.XAxis = this.xAxis2;
            this.scatterPlot2.YAxis = this.yAxis2;
            // 
            // xAxis2
            // 
            this.xAxis2.Mode = NationalInstruments.UI.AxisMode.Fixed;
            // 
            // sgAllData
            // 
            this.sgAllData.Location = new System.Drawing.Point(23, 492);
            this.sgAllData.Name = "sgAllData";
            this.sgAllData.Plots.AddRange(new NationalInstruments.UI.ScatterPlot[] {
            this.scatterPlot1});
            this.sgAllData.Size = new System.Drawing.Size(1453, 135);
            this.sgAllData.TabIndex = 7;
            this.sgAllData.UseColorGenerator = true;
            this.sgAllData.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis3});
            this.sgAllData.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis3});
            this.sgAllData.PlotAreaMouseUp += new System.Windows.Forms.MouseEventHandler(this.sgAllData_PlotAreaMouseUp);
            // 
            // scatterPlot1
            // 
            this.scatterPlot1.XAxis = this.xAxis3;
            this.scatterPlot1.YAxis = this.yAxis3;
            // 
            // xAxis3
            // 
            this.xAxis3.Mode = NationalInstruments.UI.AxisMode.Fixed;
            // 
            // sbChart
            // 
            this.sbChart.Location = new System.Drawing.Point(37, 78);
            this.sbChart.Name = "sbChart";
            this.sbChart.Size = new System.Drawing.Size(1425, 25);
            this.sbChart.TabIndex = 6;
            this.sbChart.Visible = false;
            this.sbChart.ValueChanged += new System.EventHandler(this.sbChart_ValueChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblIndex);
            this.groupBox5.Controls.Add(this.lblRangeData);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.lblLengthData);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.lblCurser);
            this.groupBox5.Location = new System.Drawing.Point(248, 15);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(930, 60);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Data";
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Location = new System.Drawing.Point(719, 26);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(14, 16);
            this.lblIndex.TabIndex = 2;
            this.lblIndex.Text = "0";
            // 
            // lblRangeData
            // 
            this.lblRangeData.AutoSize = true;
            this.lblRangeData.Location = new System.Drawing.Point(468, 26);
            this.lblRangeData.Name = "lblRangeData";
            this.lblRangeData.Size = new System.Drawing.Size(31, 16);
            this.lblRangeData.TabIndex = 2;
            this.lblRangeData.Text = "0 - 0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(663, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Index :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Range View Data :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "LengthData :";
            // 
            // lblLengthData
            // 
            this.lblLengthData.AutoSize = true;
            this.lblLengthData.Location = new System.Drawing.Point(236, 26);
            this.lblLengthData.Name = "lblLengthData";
            this.lblLengthData.Size = new System.Drawing.Size(14, 16);
            this.lblLengthData.TabIndex = 1;
            this.lblLengthData.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "XCurser : ";
            // 
            // lblCurser
            // 
            this.lblCurser.AutoSize = true;
            this.lblCurser.Location = new System.Drawing.Point(74, 26);
            this.lblCurser.Name = "lblCurser";
            this.lblCurser.Size = new System.Drawing.Size(14, 16);
            this.lblCurser.TabIndex = 0;
            this.lblCurser.Text = "0";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbZoom);
            this.groupBox4.Location = new System.Drawing.Point(51, 15);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(191, 60);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Display percentage";
            // 
            // cbZoom
            // 
            this.cbZoom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbZoom.FormattingEnabled = true;
            this.cbZoom.Items.AddRange(new object[] {
            "2.5%",
            "5%",
            "7.5%",
            "10%",
            "20%",
            "30%",
            "50%",
            "70%",
            "FIT"});
            this.cbZoom.Location = new System.Drawing.Point(17, 26);
            this.cbZoom.Name = "cbZoom";
            this.cbZoom.Size = new System.Drawing.Size(155, 24);
            this.cbZoom.TabIndex = 7;
            this.cbZoom.SelectedIndexChanged += new System.EventHandler(this.cbZoom_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tvFileName);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnChoose);
            this.groupBox2.Location = new System.Drawing.Point(6, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 633);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Open File";
            // 
            // tvFileName
            // 
            this.tvFileName.AllowDrop = true;
            this.tvFileName.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tvFileName.Location = new System.Drawing.Point(8, 86);
            this.tvFileName.Name = "tvFileName";
            this.tvFileName.ShowNodeToolTips = true;
            this.tvFileName.Size = new System.Drawing.Size(264, 541);
            this.tvFileName.TabIndex = 3;
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Location = new System.Drawing.Point(144, 33);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(123, 33);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnChoose
            // 
            this.btnChoose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChoose.Location = new System.Drawing.Point(15, 33);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(123, 33);
            this.btnChoose.TabIndex = 0;
            this.btnChoose.Text = "Choose";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1820, 709);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graph";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sgIntendedData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sgAllData)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnMenuFile;
        private System.Windows.Forms.ToolStripMenuItem btnMenuEdit;
        private System.Windows.Forms.ToolStripMenuItem btnMenuVeiw;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusProcessor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.ToolStripMenuItem btnMenuOpenFile;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TreeView tvFileName;
        private System.Windows.Forms.ToolStripMenuItem btnMenuTreeView;
        private System.Windows.Forms.GroupBox groupBox5;
        public System.Windows.Forms.Label lblCurser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLengthData;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblRangeData;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem btnMenuExit;
        public System.Windows.Forms.HScrollBar sbChart;
        public System.Windows.Forms.ComboBox cbZoom;
        public System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.Label label4;
        private NationalInstruments.UI.ScatterPlot scatterPlot1;
        private NationalInstruments.UI.XAxis xAxis3;
        private NationalInstruments.UI.YAxis yAxis3;
        public NationalInstruments.UI.WindowsForms.ScatterGraph sgAllData;
        private NationalInstruments.UI.ScatterPlot scatterPlot2;
        private NationalInstruments.UI.XAxis xAxis2;
        private NationalInstruments.UI.YAxis yAxis2;
        public NationalInstruments.UI.WindowsForms.ScatterGraph sgIntendedData;
    }
}

