namespace AnimationStack
{
    partial class frmBase
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.lstFolders = new System.Windows.Forms.ListBox();
            this.btnDeleteFolder = new System.Windows.Forms.Button();
            this.btnSelectExportPath = new System.Windows.Forms.Button();
            this.btnStack = new System.Windows.Forms.Button();
            this.fdbImages = new System.Windows.Forms.FolderBrowserDialog();
            this.prgAnimationStack = new System.Windows.Forms.ProgressBar();
            this.lblMergeProgress = new System.Windows.Forms.Label();
            this.btnGroupBySelected = new System.Windows.Forms.Button();
            this.txtGroupByFolder = new System.Windows.Forms.TextBox();
            this.numStartIndex = new System.Windows.Forms.NumericUpDown();
            this.txtOutputPrefix = new System.Windows.Forms.TextBox();
            this.chkCreateFolders = new System.Windows.Forms.CheckBox();
            this.lblStartIndex = new System.Windows.Forms.Label();
            this.numIndexLength = new System.Windows.Forms.NumericUpDown();
            this.lblIndexLength = new System.Windows.Forms.Label();
            this.grpOutputIindex = new System.Windows.Forms.GroupBox();
            this.grpFolders = new System.Windows.Forms.GroupBox();
            this.lblExportPath = new System.Windows.Forms.Label();
            this.lblGroupByFolder = new System.Windows.Forms.Label();
            this.txtExportPath = new System.Windows.Forms.TextBox();
            this.lblOutputPrefix = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSampleOrder = new System.Windows.Forms.Label();
            this.grpExportOptions = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numStartIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIndexLength)).BeginInit();
            this.grpOutputIindex.SuspendLayout();
            this.grpFolders.SuspendLayout();
            this.grpExportOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(669, 373);
            this.btnSelectFolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(312, 38);
            this.btnSelectFolder.TabIndex = 0;
            this.btnSelectFolder.Text = "LOAD FOLDER";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // lstFolders
            // 
            this.lstFolders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstFolders.DisplayMember = "2";
            this.lstFolders.FormattingEnabled = true;
            this.lstFolders.HorizontalScrollbar = true;
            this.lstFolders.ItemHeight = 15;
            this.lstFolders.Location = new System.Drawing.Point(27, 42);
            this.lstFolders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstFolders.Name = "lstFolders";
            this.lstFolders.Size = new System.Drawing.Size(561, 199);
            this.lstFolders.TabIndex = 19;
            this.lstFolders.TabStop = false;
            this.lstFolders.ValueMember = "2";
            this.lstFolders.DoubleClick += new System.EventHandler(this.lstFolders_DoubleClick);
            // 
            // btnDeleteFolder
            // 
            this.btnDeleteFolder.Location = new System.Drawing.Point(413, 245);
            this.btnDeleteFolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteFolder.Name = "btnDeleteFolder";
            this.btnDeleteFolder.Size = new System.Drawing.Size(175, 33);
            this.btnDeleteFolder.TabIndex = 7;
            this.btnDeleteFolder.Text = "REMOVE SELECTED";
            this.btnDeleteFolder.UseVisualStyleBackColor = true;
            this.btnDeleteFolder.Click += new System.EventHandler(this.btnDeleteFolder_Click);
            // 
            // btnSelectExportPath
            // 
            this.btnSelectExportPath.Location = new System.Drawing.Point(669, 415);
            this.btnSelectExportPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectExportPath.Name = "btnSelectExportPath";
            this.btnSelectExportPath.Size = new System.Drawing.Size(312, 38);
            this.btnSelectExportPath.TabIndex = 1;
            this.btnSelectExportPath.Text = "SELECT EXPORT PATH";
            this.btnSelectExportPath.UseVisualStyleBackColor = true;
            this.btnSelectExportPath.Click += new System.EventHandler(this.btnSelectExportPath_Click);
            // 
            // btnStack
            // 
            this.btnStack.Location = new System.Drawing.Point(669, 457);
            this.btnStack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStack.Name = "btnStack";
            this.btnStack.Size = new System.Drawing.Size(312, 38);
            this.btnStack.TabIndex = 5;
            this.btnStack.Text = "STACK";
            this.btnStack.UseVisualStyleBackColor = true;
            this.btnStack.Click += new System.EventHandler(this.btnStack_Click);
            // 
            // prgAnimationStack
            // 
            this.prgAnimationStack.Location = new System.Drawing.Point(669, 283);
            this.prgAnimationStack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prgAnimationStack.Name = "prgAnimationStack";
            this.prgAnimationStack.Size = new System.Drawing.Size(312, 30);
            this.prgAnimationStack.Step = 0;
            this.prgAnimationStack.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgAnimationStack.TabIndex = 23;
            // 
            // lblMergeProgress
            // 
            this.lblMergeProgress.Location = new System.Drawing.Point(669, 265);
            this.lblMergeProgress.Name = "lblMergeProgress";
            this.lblMergeProgress.Size = new System.Drawing.Size(312, 16);
            this.lblMergeProgress.TabIndex = 24;
            this.lblMergeProgress.Text = "Animation Stack Progress";
            this.lblMergeProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGroupBySelected
            // 
            this.btnGroupBySelected.Location = new System.Drawing.Point(232, 244);
            this.btnGroupBySelected.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGroupBySelected.Name = "btnGroupBySelected";
            this.btnGroupBySelected.Size = new System.Drawing.Size(175, 33);
            this.btnGroupBySelected.TabIndex = 6;
            this.btnGroupBySelected.Text = "GROUP BY SELECTED";
            this.btnGroupBySelected.UseVisualStyleBackColor = true;
            this.btnGroupBySelected.Click += new System.EventHandler(this.btnGroupBySelected_Click);
            // 
            // txtGroupByFolder
            // 
            this.txtGroupByFolder.BackColor = System.Drawing.SystemColors.Control;
            this.txtGroupByFolder.Location = new System.Drawing.Point(21, 44);
            this.txtGroupByFolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 6);
            this.txtGroupByFolder.Name = "txtGroupByFolder";
            this.txtGroupByFolder.ReadOnly = true;
            this.txtGroupByFolder.Size = new System.Drawing.Size(519, 23);
            this.txtGroupByFolder.TabIndex = 27;
            this.txtGroupByFolder.TabStop = false;
            this.txtGroupByFolder.TextChanged += new System.EventHandler(this.FolderMainTextBox_TextChanged);
            // 
            // numStartIndex
            // 
            this.numStartIndex.Location = new System.Drawing.Point(23, 44);
            this.numStartIndex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numStartIndex.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.numStartIndex.Name = "numStartIndex";
            this.numStartIndex.Size = new System.Drawing.Size(116, 23);
            this.numStartIndex.TabIndex = 0;
            // 
            // txtOutputPrefix
            // 
            this.txtOutputPrefix.Location = new System.Drawing.Point(17, 49);
            this.txtOutputPrefix.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOutputPrefix.Name = "txtOutputPrefix";
            this.txtOutputPrefix.Size = new System.Drawing.Size(274, 23);
            this.txtOutputPrefix.TabIndex = 1;
            // 
            // chkCreateFolders
            // 
            this.chkCreateFolders.AutoSize = true;
            this.chkCreateFolders.Checked = true;
            this.chkCreateFolders.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCreateFolders.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkCreateFolders.Location = new System.Drawing.Point(802, 26);
            this.chkCreateFolders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 6);
            this.chkCreateFolders.Name = "chkCreateFolders";
            this.chkCreateFolders.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkCreateFolders.Size = new System.Drawing.Size(179, 19);
            this.chkCreateFolders.TabIndex = 2;
            this.chkCreateFolders.Text = "Create folder for each output";
            this.chkCreateFolders.UseVisualStyleBackColor = true;
            this.chkCreateFolders.CheckedChanged += new System.EventHandler(this.chkCreateFolders_CheckedChanged);
            // 
            // lblStartIndex
            // 
            this.lblStartIndex.Location = new System.Drawing.Point(21, 26);
            this.lblStartIndex.Name = "lblStartIndex";
            this.lblStartIndex.Size = new System.Drawing.Size(109, 16);
            this.lblStartIndex.TabIndex = 31;
            this.lblStartIndex.Text = "Base Value";
            this.lblStartIndex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numIndexLength
            // 
            this.numIndexLength.Location = new System.Drawing.Point(181, 44);
            this.numIndexLength.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numIndexLength.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numIndexLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numIndexLength.Name = "numIndexLength";
            this.numIndexLength.Size = new System.Drawing.Size(116, 23);
            this.numIndexLength.TabIndex = 1;
            this.numIndexLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblIndexLength
            // 
            this.lblIndexLength.Location = new System.Drawing.Point(181, 26);
            this.lblIndexLength.Name = "lblIndexLength";
            this.lblIndexLength.Size = new System.Drawing.Size(109, 16);
            this.lblIndexLength.TabIndex = 33;
            this.lblIndexLength.Text = "Minimum Length";
            this.lblIndexLength.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpOutputIindex
            // 
            this.grpOutputIindex.Controls.Add(this.numStartIndex);
            this.grpOutputIindex.Controls.Add(this.lblIndexLength);
            this.grpOutputIindex.Controls.Add(this.numIndexLength);
            this.grpOutputIindex.Controls.Add(this.lblStartIndex);
            this.grpOutputIindex.Location = new System.Drawing.Point(669, 127);
            this.grpOutputIindex.Name = "grpOutputIindex";
            this.grpOutputIindex.Padding = new System.Windows.Forms.Padding(18, 6, 12, 12);
            this.grpOutputIindex.Size = new System.Drawing.Size(312, 90);
            this.grpOutputIindex.TabIndex = 4;
            this.grpOutputIindex.TabStop = false;
            this.grpOutputIindex.Text = "Output Name ID";
            // 
            // grpFolders
            // 
            this.grpFolders.Controls.Add(this.lblExportPath);
            this.grpFolders.Controls.Add(this.lblGroupByFolder);
            this.grpFolders.Controls.Add(this.txtExportPath);
            this.grpFolders.Controls.Add(this.txtGroupByFolder);
            this.grpFolders.Location = new System.Drawing.Point(27, 362);
            this.grpFolders.Name = "grpFolders";
            this.grpFolders.Padding = new System.Windows.Forms.Padding(18, 10, 18, 12);
            this.grpFolders.Size = new System.Drawing.Size(561, 133);
            this.grpFolders.TabIndex = 35;
            this.grpFolders.TabStop = false;
            this.grpFolders.Text = "Selected Folders View (read-only)";
            // 
            // lblExportPath
            // 
            this.lblExportPath.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblExportPath.Location = new System.Drawing.Point(20, 75);
            this.lblExportPath.Name = "lblExportPath";
            this.lblExportPath.Size = new System.Drawing.Size(109, 16);
            this.lblExportPath.TabIndex = 38;
            this.lblExportPath.Text = "Export Path";
            this.lblExportPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGroupByFolder
            // 
            this.lblGroupByFolder.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblGroupByFolder.Location = new System.Drawing.Point(21, 26);
            this.lblGroupByFolder.Name = "lblGroupByFolder";
            this.lblGroupByFolder.Size = new System.Drawing.Size(109, 16);
            this.lblGroupByFolder.TabIndex = 36;
            this.lblGroupByFolder.Text = "Group By Folder";
            this.lblGroupByFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtExportPath
            // 
            this.txtExportPath.Location = new System.Drawing.Point(20, 93);
            this.txtExportPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtExportPath.Name = "txtExportPath";
            this.txtExportPath.ReadOnly = true;
            this.txtExportPath.Size = new System.Drawing.Size(519, 23);
            this.txtExportPath.TabIndex = 37;
            this.txtExportPath.TabStop = false;
            this.txtExportPath.TextChanged += new System.EventHandler(this.txtExportPath_TextChanged);
            // 
            // lblOutputPrefix
            // 
            this.lblOutputPrefix.Location = new System.Drawing.Point(17, 31);
            this.lblOutputPrefix.Name = "lblOutputPrefix";
            this.lblOutputPrefix.Size = new System.Drawing.Size(113, 16);
            this.lblOutputPrefix.TabIndex = 30;
            this.lblOutputPrefix.Text = "Output Prefix";
            this.lblOutputPrefix.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(27, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "Selected Folders";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSampleOrder
            // 
            this.lblSampleOrder.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSampleOrder.Location = new System.Drawing.Point(418, 24);
            this.lblSampleOrder.Name = "lblSampleOrder";
            this.lblSampleOrder.Size = new System.Drawing.Size(170, 16);
            this.lblSampleOrder.TabIndex = 38;
            this.lblSampleOrder.Text = "Sample: Order: Ascending ↑";
            this.lblSampleOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpExportOptions
            // 
            this.grpExportOptions.Controls.Add(this.txtOutputPrefix);
            this.grpExportOptions.Controls.Add(this.lblOutputPrefix);
            this.grpExportOptions.Location = new System.Drawing.Point(669, 27);
            this.grpExportOptions.Name = "grpExportOptions";
            this.grpExportOptions.Padding = new System.Windows.Forms.Padding(18, 6, 12, 12);
            this.grpExportOptions.Size = new System.Drawing.Size(312, 94);
            this.grpExportOptions.TabIndex = 3;
            this.grpExportOptions.TabStop = false;
            this.grpExportOptions.Text = "Export Options";
            // 
            // frmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 521);
            this.Controls.Add(this.chkCreateFolders);
            this.Controls.Add(this.grpExportOptions);
            this.Controls.Add(this.lblSampleOrder);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grpFolders);
            this.Controls.Add(this.grpOutputIindex);
            this.Controls.Add(this.btnGroupBySelected);
            this.Controls.Add(this.lblMergeProgress);
            this.Controls.Add(this.prgAnimationStack);
            this.Controls.Add(this.btnSelectExportPath);
            this.Controls.Add(this.btnStack);
            this.Controls.Add(this.btnDeleteFolder);
            this.Controls.Add(this.lstFolders);
            this.Controls.Add(this.btnSelectFolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmBase";
            this.Padding = new System.Windows.Forms.Padding(24);
            this.ShowIcon = false;
            this.Text = "AnimationStack";
            this.Load += new System.EventHandler(this.frmBase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numStartIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIndexLength)).EndInit();
            this.grpOutputIindex.ResumeLayout(false);
            this.grpFolders.ResumeLayout(false);
            this.grpFolders.PerformLayout();
            this.grpExportOptions.ResumeLayout(false);
            this.grpExportOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSelectFolder;
        private ListBox lstFolders;
        private Button btnDeleteFolder;
        private Button btnSelectExportPath;
        private Button btnStack;
        private FolderBrowserDialog fdbImages;
        private ProgressBar prgAnimationStack;
        private Label lblMergeProgress;
        private Button btnGroupBySelected;
        private TextBox txtGroupByFolder;
        private NumericUpDown numStartIndex;
        private TextBox txtOutputPrefix;
        private CheckBox chkCreateFolders;
        private Label lblStartIndex;
        private NumericUpDown numIndexLength;
        private Label lblIndexLength;
        private GroupBox grpOutputIindex;
        private GroupBox grpFolders;
        private Label lblGroupByFolder;
        private Label lblOutputPrefix;
        private Label label6;
        private Label lblSampleOrder;
        private Label lblExportPath;
        private TextBox txtExportPath;
        private GroupBox grpExportOptions;
    }
}