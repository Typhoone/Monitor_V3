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
            this.logBox = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.noteBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.clrNoteBtn = new System.Windows.Forms.Button();
            this.portSelect = new System.Windows.Forms.ComboBox();
            this.COMportRefresh = new System.Windows.Forms.Button();
            this.COMconnect = new System.Windows.Forms.Button();
            this.fileOpenBtn = new System.Windows.Forms.Button();
            this.fileSaveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logBox
            // 
            this.logBox.FormattingEnabled = true;
            this.logBox.Location = new System.Drawing.Point(12, 49);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(530, 550);
            this.logBox.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(548, 430);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(423, 140);
            this.textBox1.TabIndex = 1;
            // 
            // noteBtn
            // 
            this.noteBtn.Location = new System.Drawing.Point(815, 576);
            this.noteBtn.Name = "noteBtn";
            this.noteBtn.Size = new System.Drawing.Size(75, 23);
            this.noteBtn.TabIndex = 2;
            this.noteBtn.Text = "Add Note";
            this.noteBtn.UseVisualStyleBackColor = true;
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
            // clrNoteBtn
            // 
            this.clrNoteBtn.Location = new System.Drawing.Point(896, 576);
            this.clrNoteBtn.Name = "clrNoteBtn";
            this.clrNoteBtn.Size = new System.Drawing.Size(75, 23);
            this.clrNoteBtn.TabIndex = 4;
            this.clrNoteBtn.Text = "Cancel";
            this.clrNoteBtn.UseVisualStyleBackColor = true;
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
            // 
            // COMconnect
            // 
            this.COMconnect.Location = new System.Drawing.Point(808, 47);
            this.COMconnect.Name = "COMconnect";
            this.COMconnect.Size = new System.Drawing.Size(75, 23);
            this.COMconnect.TabIndex = 7;
            this.COMconnect.Text = "Connect";
            this.COMconnect.UseVisualStyleBackColor = true;
            // 
            // fileOpenBtn
            // 
            this.fileOpenBtn.Location = new System.Drawing.Point(727, 76);
            this.fileOpenBtn.Name = "fileOpenBtn";
            this.fileOpenBtn.Size = new System.Drawing.Size(75, 23);
            this.fileOpenBtn.TabIndex = 8;
            this.fileOpenBtn.Text = "Open";
            this.fileOpenBtn.UseVisualStyleBackColor = true;
            // 
            // fileSaveBtn
            // 
            this.fileSaveBtn.Location = new System.Drawing.Point(809, 75);
            this.fileSaveBtn.Name = "fileSaveBtn";
            this.fileSaveBtn.Size = new System.Drawing.Size(75, 23);
            this.fileSaveBtn.TabIndex = 9;
            this.fileSaveBtn.Text = "Save";
            this.fileSaveBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.fileSaveBtn);
            this.Controls.Add(this.fileOpenBtn);
            this.Controls.Add(this.COMconnect);
            this.Controls.Add(this.COMportRefresh);
            this.Controls.Add(this.portSelect);
            this.Controls.Add(this.clrNoteBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noteBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.logBox);
            this.Name = "Form1";
            this.Text = "Monitor v3.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox logBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button noteBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clrNoteBtn;
        private System.Windows.Forms.ComboBox portSelect;
        private System.Windows.Forms.Button COMportRefresh;
        private System.Windows.Forms.Button COMconnect;
        private System.Windows.Forms.Button fileOpenBtn;
        private System.Windows.Forms.Button fileSaveBtn;
    }
}

