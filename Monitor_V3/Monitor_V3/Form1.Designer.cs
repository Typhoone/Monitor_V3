namespace Monitor_V3
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.logBox = new System.Windows.Forms.ListBox();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.portSelect = new System.Windows.Forms.ComboBox();
            this.COMportRefresh = new System.Windows.Forms.Button();
            this.COMconnect = new System.Windows.Forms.Button();
            this.fileOpenBtn = new System.Windows.Forms.Button();
            this.fileSaveBtn = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.pulseTime = new System.Windows.Forms.NumericUpDown();
            this.pulseTimeBtn = new System.Windows.Forms.Button();
            this.autoScrollCheck = new System.Windows.Forms.CheckBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1_y = new System.Windows.Forms.ComboBox();
            this.chart1_x = new System.Windows.Forms.ComboBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chart2_x = new System.Windows.Forms.ComboBox();
            this.chart2_y = new System.Windows.Forms.ComboBox();
            this.chart1Size = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chart2Size = new System.Windows.Forms.NumericUpDown();
            this.graphUpdateBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pulseTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1Size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2Size)).BeginInit();
            this.SuspendLayout();
            // 
            // logBox
            // 
            this.logBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logBox.FormattingEnabled = true;
            this.logBox.Location = new System.Drawing.Point(12, 49);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(530, 277);
            this.logBox.TabIndex = 0;
            this.logBox.SelectedIndexChanged += new System.EventHandler(this.logBox_SelectedIndexChanged);
            // 
            // noteTextBox
            // 
            this.noteTextBox.Location = new System.Drawing.Point(549, 128);
            this.noteTextBox.Multiline = true;
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.noteTextBox.Size = new System.Drawing.Size(533, 198);
            this.noteTextBox.TabIndex = 1;
            this.noteTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.noteTextBox_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(529, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Time | RPM | Duty | Delay | Coil | Control | Trigger | Magnets";
            // 
            // portSelect
            // 
            this.portSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portSelect.FormattingEnabled = true;
            this.portSelect.Location = new System.Drawing.Point(548, 49);
            this.portSelect.Name = "portSelect";
            this.portSelect.Size = new System.Drawing.Size(173, 21);
            this.portSelect.TabIndex = 5;
            // 
            // COMportRefresh
            // 
            this.COMportRefresh.Location = new System.Drawing.Point(727, 47);
            this.COMportRefresh.Name = "COMportRefresh";
            this.COMportRefresh.Size = new System.Drawing.Size(75, 23);
            this.COMportRefresh.TabIndex = 6;
            this.COMportRefresh.Text = "Refresh";
            this.COMportRefresh.UseVisualStyleBackColor = true;
            this.COMportRefresh.Click += new System.EventHandler(this.COMportRefresh_Click);
            // 
            // COMconnect
            // 
            this.COMconnect.Location = new System.Drawing.Point(808, 47);
            this.COMconnect.Name = "COMconnect";
            this.COMconnect.Size = new System.Drawing.Size(75, 23);
            this.COMconnect.TabIndex = 7;
            this.COMconnect.Text = "Connect";
            this.COMconnect.UseVisualStyleBackColor = true;
            this.COMconnect.Click += new System.EventHandler(this.COMconnect_Click);
            // 
            // fileOpenBtn
            // 
            this.fileOpenBtn.Location = new System.Drawing.Point(926, 49);
            this.fileOpenBtn.Name = "fileOpenBtn";
            this.fileOpenBtn.Size = new System.Drawing.Size(75, 23);
            this.fileOpenBtn.TabIndex = 8;
            this.fileOpenBtn.Text = "Open";
            this.fileOpenBtn.UseVisualStyleBackColor = true;
            // 
            // fileSaveBtn
            // 
            this.fileSaveBtn.Location = new System.Drawing.Point(1007, 49);
            this.fileSaveBtn.Name = "fileSaveBtn";
            this.fileSaveBtn.Size = new System.Drawing.Size(75, 23);
            this.fileSaveBtn.TabIndex = 9;
            this.fileSaveBtn.Text = "Save";
            this.fileSaveBtn.UseVisualStyleBackColor = true;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(9, 659);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(154, 13);
            this.infoLabel.TabIndex = 11;
            this.infoLabel.Text = "Monitor v3.0 By Gordon Adams";
            // 
            // pulseTime
            // 
            this.pulseTime.Location = new System.Drawing.Point(548, 78);
            this.pulseTime.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.pulseTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pulseTime.Name = "pulseTime";
            this.pulseTime.Size = new System.Drawing.Size(50, 20);
            this.pulseTime.TabIndex = 13;
            this.pulseTime.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // pulseTimeBtn
            // 
            this.pulseTimeBtn.Location = new System.Drawing.Point(620, 75);
            this.pulseTimeBtn.Name = "pulseTimeBtn";
            this.pulseTimeBtn.Size = new System.Drawing.Size(100, 23);
            this.pulseTimeBtn.TabIndex = 14;
            this.pulseTimeBtn.Text = "Set Pulse Time";
            this.pulseTimeBtn.UseVisualStyleBackColor = true;
            this.pulseTimeBtn.Click += new System.EventHandler(this.pulseTimeBtn_Click);
            // 
            // autoScrollCheck
            // 
            this.autoScrollCheck.AutoSize = true;
            this.autoScrollCheck.Checked = true;
            this.autoScrollCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoScrollCheck.Location = new System.Drawing.Point(465, 332);
            this.autoScrollCheck.Name = "autoScrollCheck";
            this.autoScrollCheck.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.autoScrollCheck.Size = new System.Drawing.Size(77, 17);
            this.autoScrollCheck.TabIndex = 15;
            this.autoScrollCheck.Text = "Auto Scroll";
            this.autoScrollCheck.UseVisualStyleBackColor = true;
            this.autoScrollCheck.CheckedChanged += new System.EventHandler(this.autoScrollCheck_CheckedChanged);
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(12, 389);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(530, 267);
            this.chart1.TabIndex = 16;
            this.chart1.Text = "chart1";
            // 
            // chart1_y
            // 
            this.chart1_y.FormattingEnabled = true;
            this.chart1_y.Items.AddRange(new object[] {
            "Time",
            "RPM",
            "Duty",
            "Delay",
            "Coil Temp",
            "Control Box Temp",
            "Trigger RPM",
            "Magnets"});
            this.chart1_y.Location = new System.Drawing.Point(164, 362);
            this.chart1_y.Name = "chart1_y";
            this.chart1_y.Size = new System.Drawing.Size(121, 21);
            this.chart1_y.TabIndex = 17;
            // 
            // chart1_x
            // 
            this.chart1_x.FormattingEnabled = true;
            this.chart1_x.Items.AddRange(new object[] {
            "Time",
            "RPM",
            "Duty",
            "Delay",
            "Coil Temp",
            "Control Box Temp",
            "Trigger RPM",
            "Magnets"});
            this.chart1_x.Location = new System.Drawing.Point(12, 362);
            this.chart1_x.Name = "chart1_x";
            this.chart1_x.Size = new System.Drawing.Size(121, 21);
            this.chart1_x.TabIndex = 18;
            // 
            // chart2
            // 
            chartArea4.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart2.Legends.Add(legend4);
            this.chart2.Location = new System.Drawing.Point(548, 389);
            this.chart2.Name = "chart2";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(530, 267);
            this.chart2.TabIndex = 19;
            this.chart2.Text = "chart2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "vs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(677, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "vs";
            // 
            // chart2_x
            // 
            this.chart2_x.FormattingEnabled = true;
            this.chart2_x.Items.AddRange(new object[] {
            "Time",
            "RPM",
            "Duty",
            "Delay",
            "Coil Temp",
            "Control Box Temp",
            "Trigger RPM",
            "Magnets"});
            this.chart2_x.Location = new System.Drawing.Point(549, 362);
            this.chart2_x.Name = "chart2_x";
            this.chart2_x.Size = new System.Drawing.Size(121, 21);
            this.chart2_x.TabIndex = 22;
            // 
            // chart2_y
            // 
            this.chart2_y.FormattingEnabled = true;
            this.chart2_y.Items.AddRange(new object[] {
            "Time",
            "RPM",
            "Duty",
            "Delay",
            "Coil Temp",
            "Control Box Temp",
            "Trigger RPM",
            "Magnets"});
            this.chart2_y.Location = new System.Drawing.Point(701, 362);
            this.chart2_y.Name = "chart2_y";
            this.chart2_y.Size = new System.Drawing.Size(121, 21);
            this.chart2_y.TabIndex = 21;
            // 
            // chart1Size
            // 
            this.chart1Size.Location = new System.Drawing.Point(422, 363);
            this.chart1Size.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.chart1Size.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.chart1Size.Name = "chart1Size";
            this.chart1Size.Size = new System.Drawing.Size(120, 20);
            this.chart1Size.TabIndex = 24;
            this.chart1Size.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.chart1Size.ValueChanged += new System.EventHandler(this.chart1Size_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "values";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(917, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "values";
            // 
            // chart2Size
            // 
            this.chart2Size.Location = new System.Drawing.Point(962, 363);
            this.chart2Size.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.chart2Size.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.chart2Size.Name = "chart2Size";
            this.chart2Size.Size = new System.Drawing.Size(120, 20);
            this.chart2Size.TabIndex = 28;
            this.chart2Size.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.chart2Size.ValueChanged += new System.EventHandler(this.chart2Size_ValueChanged);
            // 
            // graphUpdateBtn
            // 
            this.graphUpdateBtn.Location = new System.Drawing.Point(992, 334);
            this.graphUpdateBtn.Name = "graphUpdateBtn";
            this.graphUpdateBtn.Size = new System.Drawing.Size(90, 23);
            this.graphUpdateBtn.TabIndex = 29;
            this.graphUpdateBtn.Text = "Update Graphs";
            this.graphUpdateBtn.UseVisualStyleBackColor = true;
            this.graphUpdateBtn.Click += new System.EventHandler(this.graphUpdateBtn_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 681);
            this.Controls.Add(this.graphUpdateBtn);
            this.Controls.Add(this.chart2Size);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chart1Size);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chart2_x);
            this.Controls.Add(this.chart2_y);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1_x);
            this.Controls.Add(this.chart1_y);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.autoScrollCheck);
            this.Controls.Add(this.pulseTimeBtn);
            this.Controls.Add(this.pulseTime);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.fileSaveBtn);
            this.Controls.Add(this.fileOpenBtn);
            this.Controls.Add(this.COMconnect);
            this.Controls.Add(this.COMportRefresh);
            this.Controls.Add(this.portSelect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noteTextBox);
            this.Controls.Add(this.logBox);
            this.Name = "Form1";
            this.Text = "Monitor v3.0";
            ((System.ComponentModel.ISupportInitialize)(this.pulseTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1Size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2Size)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox logBox;
        private System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox portSelect;
        private System.Windows.Forms.Button COMportRefresh;
        private System.Windows.Forms.Button COMconnect;
        private System.Windows.Forms.Button fileOpenBtn;
        private System.Windows.Forms.Button fileSaveBtn;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.NumericUpDown pulseTime;
        private System.Windows.Forms.Button pulseTimeBtn;
        private System.Windows.Forms.CheckBox autoScrollCheck;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox chart1_y;
        private System.Windows.Forms.ComboBox chart1_x;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox chart2_x;
        private System.Windows.Forms.ComboBox chart2_y;
        private System.Windows.Forms.NumericUpDown chart1Size;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown chart2Size;
        private System.Windows.Forms.Button graphUpdateBtn;
    }
}

