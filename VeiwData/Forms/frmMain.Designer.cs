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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnMenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenuVeiw = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatusProcessor = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.wfgAllData = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.xyCursor1 = new NationalInstruments.UI.XYCursor();
            this.waveformPlot2 = new NationalInstruments.UI.WaveformPlot();
            this.xAxis2 = new NationalInstruments.UI.XAxis();
            this.yAxis2 = new NationalInstruments.UI.YAxis();
            this.wfgChart = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.waveformPlot1 = new NationalInstruments.UI.WaveformPlot();
            this.xAxis1 = new NationalInstruments.UI.XAxis();
            this.yAxis1 = new NationalInstruments.UI.YAxis();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdless = new System.Windows.Forms.RadioButton();
            this.rdHalf = new System.Windows.Forms.RadioButton();
            this.rdFull = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSizeData = new System.Windows.Forms.Label();
            this.lblNameFile = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnChoose = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wfgAllData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xyCursor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wfgChart)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1904, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnMenuFile
            // 
            this.btnMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuOpenFile});
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
            // 
            // btnMenuVeiw
            // 
            this.btnMenuVeiw.Name = "btnMenuVeiw";
            this.btnMenuVeiw.Size = new System.Drawing.Size(43, 20);
            this.btnMenuVeiw.Text = "Veiw";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusProcessor});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1019);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1904, 22);
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
            this.groupBox1.Size = new System.Drawing.Size(1879, 980);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.wfgAllData);
            this.groupBox3.Controls.Add(this.wfgChart);
            this.groupBox3.Location = new System.Drawing.Point(312, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1530, 948);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chart";
            // 
            // wfgAllData
            // 
            this.wfgAllData.Cursor = System.Windows.Forms.Cursors.Default;
            this.wfgAllData.Cursors.AddRange(new NationalInstruments.UI.XYCursor[] {
            this.xyCursor1});
            this.wfgAllData.Location = new System.Drawing.Point(23, 467);
            this.wfgAllData.Name = "wfgAllData";
            this.wfgAllData.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.waveformPlot2});
            this.wfgAllData.Size = new System.Drawing.Size(1453, 119);
            this.wfgAllData.TabIndex = 4;
            this.wfgAllData.UseColorGenerator = true;
            this.wfgAllData.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis2});
            this.wfgAllData.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis2});
            this.wfgAllData.CursorsChanged += new System.ComponentModel.CollectionChangeEventHandler(this.wfgAllData_CursorsChanged);
            this.wfgAllData.PlotAreaMouseUp += new System.Windows.Forms.MouseEventHandler(this.wfgAllData_PlotAreaMouseUp);
            this.wfgAllData.CursorChanged += new System.EventHandler(this.wfgAllData_CursorChanged);
            this.wfgAllData.MouseClick += new System.Windows.Forms.MouseEventHandler(this.wfgAllData_MouseClick);
            // 
            // xyCursor1
            // 
            this.xyCursor1.HorizontalCrosshairMode = NationalInstruments.UI.CursorCrosshairMode.None;
            this.xyCursor1.Plot = this.waveformPlot2;
            // 
            // waveformPlot2
            // 
            this.waveformPlot2.LineStep = NationalInstruments.UI.LineStep.CenteredXYStep;
            this.waveformPlot2.XAxis = this.xAxis2;
            this.waveformPlot2.YAxis = this.yAxis2;
            // 
            // wfgChart
            // 
            this.wfgChart.Location = new System.Drawing.Point(23, 39);
            this.wfgChart.Name = "wfgChart";
            this.wfgChart.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.waveformPlot1});
            this.wfgChart.Size = new System.Drawing.Size(1453, 409);
            this.wfgChart.TabIndex = 4;
            this.wfgChart.UseColorGenerator = true;
            this.wfgChart.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis1});
            this.wfgChart.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis1});
            // 
            // waveformPlot1
            // 
            this.waveformPlot1.XAxis = this.xAxis1;
            this.waveformPlot1.YAxis = this.yAxis1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblSizeData);
            this.groupBox2.Controls.Add(this.lblNameFile);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnChoose);
            this.groupBox2.Location = new System.Drawing.Point(7, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 948);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Open File";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdless);
            this.groupBox4.Controls.Add(this.rdHalf);
            this.groupBox4.Controls.Add(this.rdFull);
            this.groupBox4.Location = new System.Drawing.Point(6, 208);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(264, 60);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Display percentage";
            // 
            // rdless
            // 
            this.rdless.AutoSize = true;
            this.rdless.Location = new System.Drawing.Point(160, 24);
            this.rdless.Name = "rdless";
            this.rdless.Size = new System.Drawing.Size(51, 20);
            this.rdless.TabIndex = 1;
            this.rdless.Text = "10%";
            this.rdless.UseVisualStyleBackColor = true;
            this.rdless.CheckedChanged += new System.EventHandler(this.rdless_CheckedChanged);
            // 
            // rdHalf
            // 
            this.rdHalf.AutoSize = true;
            this.rdHalf.Checked = true;
            this.rdHalf.Location = new System.Drawing.Point(91, 24);
            this.rdHalf.Name = "rdHalf";
            this.rdHalf.Size = new System.Drawing.Size(51, 20);
            this.rdHalf.TabIndex = 1;
            this.rdHalf.TabStop = true;
            this.rdHalf.Text = "50%";
            this.rdHalf.UseVisualStyleBackColor = true;
            this.rdHalf.CheckedChanged += new System.EventHandler(this.rdHalf_CheckedChanged);
            // 
            // rdFull
            // 
            this.rdFull.AutoSize = true;
            this.rdFull.Location = new System.Drawing.Point(12, 24);
            this.rdFull.Name = "rdFull";
            this.rdFull.Size = new System.Drawing.Size(58, 20);
            this.rdFull.TabIndex = 1;
            this.rdFull.Text = "100%";
            this.rdFull.UseVisualStyleBackColor = true;
            this.rdFull.CheckedChanged += new System.EventHandler(this.rdFull_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Size :";
            // 
            // lblSizeData
            // 
            this.lblSizeData.AutoSize = true;
            this.lblSizeData.Location = new System.Drawing.Point(66, 173);
            this.lblSizeData.Name = "lblSizeData";
            this.lblSizeData.Size = new System.Drawing.Size(34, 16);
            this.lblSizeData.TabIndex = 1;
            this.lblSizeData.Text = "0MB";
            // 
            // lblNameFile
            // 
            this.lblNameFile.AutoSize = true;
            this.lblNameFile.Location = new System.Drawing.Point(23, 138);
            this.lblNameFile.Name = "lblNameFile";
            this.lblNameFile.Size = new System.Drawing.Size(64, 16);
            this.lblNameFile.TabIndex = 1;
            this.lblNameFile.Text = "Choosing";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name File :";
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Location = new System.Drawing.Point(26, 78);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(79, 33);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnChoose
            // 
            this.btnChoose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChoose.Location = new System.Drawing.Point(26, 39);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(79, 33);
            this.btnChoose.TabIndex = 0;
            this.btnChoose.Text = "Choose";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drawing";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wfgAllData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xyCursor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wfgChart)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.ToolStripMenuItem btnMenuOpenFile;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdless;
        private System.Windows.Forms.RadioButton rdHalf;
        private System.Windows.Forms.RadioButton rdFull;
        public System.Windows.Forms.Label lblSizeData;
        public System.Windows.Forms.Label lblNameFile;
        private NationalInstruments.UI.WaveformPlot waveformPlot1;
        private NationalInstruments.UI.XAxis xAxis1;
        private NationalInstruments.UI.YAxis yAxis1;
        public NationalInstruments.UI.WindowsForms.WaveformGraph wfgChart;
        public NationalInstruments.UI.WindowsForms.WaveformGraph wfgAllData;
        private NationalInstruments.UI.WaveformPlot waveformPlot2;
        private NationalInstruments.UI.XAxis xAxis2;
        private NationalInstruments.UI.YAxis yAxis2;
        private NationalInstruments.UI.XYCursor xyCursor1;
    }
}

