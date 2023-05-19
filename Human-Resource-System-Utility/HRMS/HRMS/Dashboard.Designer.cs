namespace HRMS
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.btnAddPDS = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnShowPDS = new System.Windows.Forms.Button();
            this.btnShowSalary = new System.Windows.Forms.Button();
            this.btnShowLeave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPersonnelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePersonnelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.educationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workExperienceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payrollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leaveCreditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pDSResumeFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALNFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payrollFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEDU = new System.Windows.Forms.Button();
            this.btnWE = new System.Windows.Forms.Button();
            this.Select = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddPDS
            // 
            this.btnAddPDS.BackColor = System.Drawing.Color.YellowGreen;
            this.btnAddPDS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddPDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPDS.Location = new System.Drawing.Point(697, 38);
            this.btnAddPDS.Name = "btnAddPDS";
            this.btnAddPDS.Size = new System.Drawing.Size(189, 35);
            this.btnAddPDS.TabIndex = 1;
            this.btnAddPDS.Text = "🖆 ADD PERSONNEL";
            this.btnAddPDS.UseVisualStyleBackColor = false;
            this.btnAddPDS.Click += new System.EventHandler(this.btnAddPDS_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.textSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(921, 411);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personnel List";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Cornsilk;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(7, 19);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(139, 27);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "🗘 Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Cornsilk;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Location = new System.Drawing.Point(869, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(46, 29);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "🔍";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(695, 19);
            this.textSearch.MaxLength = 32;
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(168, 22);
            this.textSearch.TabIndex = 3;
            this.textSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(632, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Location = new System.Drawing.Point(7, 53);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(908, 352);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnShowPDS
            // 
            this.btnShowPDS.BackColor = System.Drawing.Color.Cornsilk;
            this.btnShowPDS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowPDS.Location = new System.Drawing.Point(101, 496);
            this.btnShowPDS.Name = "btnShowPDS";
            this.btnShowPDS.Size = new System.Drawing.Size(175, 29);
            this.btnShowPDS.TabIndex = 5;
            this.btnShowPDS.Text = "🖊 Personal Information";
            this.btnShowPDS.UseVisualStyleBackColor = false;
            this.btnShowPDS.Click += new System.EventHandler(this.btnShowPDS_Click);
            // 
            // btnShowSalary
            // 
            this.btnShowSalary.BackColor = System.Drawing.Color.Cornsilk;
            this.btnShowSalary.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowSalary.Location = new System.Drawing.Point(601, 496);
            this.btnShowSalary.Name = "btnShowSalary";
            this.btnShowSalary.Size = new System.Drawing.Size(100, 29);
            this.btnShowSalary.TabIndex = 8;
            this.btnShowSalary.Text = "💰 Payroll";
            this.btnShowSalary.UseVisualStyleBackColor = false;
            this.btnShowSalary.Click += new System.EventHandler(this.btnShowSalary_Click);
            // 
            // btnShowLeave
            // 
            this.btnShowLeave.BackColor = System.Drawing.Color.Cornsilk;
            this.btnShowLeave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowLeave.Location = new System.Drawing.Point(707, 496);
            this.btnShowLeave.Name = "btnShowLeave";
            this.btnShowLeave.Size = new System.Drawing.Size(130, 29);
            this.btnShowLeave.TabIndex = 9;
            this.btnShowLeave.Text = "✈ Leave Credits";
            this.btnShowLeave.UseVisualStyleBackColor = false;
            this.btnShowLeave.Click += new System.EventHandler(this.btnShowLeave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(892, 38);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(41, 35);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "🗑";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(945, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPersonnelToolStripMenuItem,
            this.deletePersonnelToolStripMenuItem,
            this.personalInformationToolStripMenuItem,
            this.educationToolStripMenuItem,
            this.workExperienceToolStripMenuItem,
            this.payrollToolStripMenuItem,
            this.leaveCreditsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Z)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.fileToolStripMenuItem.Text = "🛠 Options";
            // 
            // addPersonnelToolStripMenuItem
            // 
            this.addPersonnelToolStripMenuItem.Name = "addPersonnelToolStripMenuItem";
            this.addPersonnelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Oemplus)));
            this.addPersonnelToolStripMenuItem.Size = new System.Drawing.Size(304, 26);
            this.addPersonnelToolStripMenuItem.Text = "Add Personnel";
            this.addPersonnelToolStripMenuItem.Click += new System.EventHandler(this.addPersonnelToolStripMenuItem_Click);
            // 
            // deletePersonnelToolStripMenuItem
            // 
            this.deletePersonnelToolStripMenuItem.Name = "deletePersonnelToolStripMenuItem";
            this.deletePersonnelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.OemMinus)));
            this.deletePersonnelToolStripMenuItem.Size = new System.Drawing.Size(304, 26);
            this.deletePersonnelToolStripMenuItem.Text = "Delete Personnel";
            this.deletePersonnelToolStripMenuItem.Click += new System.EventHandler(this.deletePersonnelToolStripMenuItem_Click);
            // 
            // personalInformationToolStripMenuItem
            // 
            this.personalInformationToolStripMenuItem.Name = "personalInformationToolStripMenuItem";
            this.personalInformationToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Q)));
            this.personalInformationToolStripMenuItem.Size = new System.Drawing.Size(304, 26);
            this.personalInformationToolStripMenuItem.Text = "Personal Information";
            this.personalInformationToolStripMenuItem.Click += new System.EventHandler(this.personalInformationToolStripMenuItem_Click);
            // 
            // educationToolStripMenuItem
            // 
            this.educationToolStripMenuItem.Name = "educationToolStripMenuItem";
            this.educationToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.W)));
            this.educationToolStripMenuItem.Size = new System.Drawing.Size(304, 26);
            this.educationToolStripMenuItem.Text = "Education, LnD";
            this.educationToolStripMenuItem.Click += new System.EventHandler(this.educationToolStripMenuItem_Click);
            // 
            // workExperienceToolStripMenuItem
            // 
            this.workExperienceToolStripMenuItem.Name = "workExperienceToolStripMenuItem";
            this.workExperienceToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.workExperienceToolStripMenuItem.Size = new System.Drawing.Size(304, 26);
            this.workExperienceToolStripMenuItem.Text = "Work Experience";
            this.workExperienceToolStripMenuItem.Click += new System.EventHandler(this.workExperienceToolStripMenuItem_Click);
            // 
            // payrollToolStripMenuItem
            // 
            this.payrollToolStripMenuItem.Name = "payrollToolStripMenuItem";
            this.payrollToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.payrollToolStripMenuItem.Size = new System.Drawing.Size(304, 26);
            this.payrollToolStripMenuItem.Text = "Payroll";
            this.payrollToolStripMenuItem.Click += new System.EventHandler(this.payrollToolStripMenuItem_Click);
            // 
            // leaveCreditsToolStripMenuItem
            // 
            this.leaveCreditsToolStripMenuItem.Name = "leaveCreditsToolStripMenuItem";
            this.leaveCreditsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            this.leaveCreditsToolStripMenuItem.Size = new System.Drawing.Size(304, 26);
            this.leaveCreditsToolStripMenuItem.Text = "Leave Credits";
            this.leaveCreditsToolStripMenuItem.Click += new System.EventHandler(this.leaveCreditsToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pDSResumeFolderToolStripMenuItem,
            this.sALNFolderToolStripMenuItem,
            this.payrollFolderToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.viewToolStripMenuItem.Text = "🗁 View";
            // 
            // pDSResumeFolderToolStripMenuItem
            // 
            this.pDSResumeFolderToolStripMenuItem.Name = "pDSResumeFolderToolStripMenuItem";
            this.pDSResumeFolderToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.pDSResumeFolderToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.pDSResumeFolderToolStripMenuItem.Text = "PDS/Resume Folder";
            this.pDSResumeFolderToolStripMenuItem.Click += new System.EventHandler(this.pDSResumeFolderToolStripMenuItem_Click);
            // 
            // sALNFolderToolStripMenuItem
            // 
            this.sALNFolderToolStripMenuItem.Name = "sALNFolderToolStripMenuItem";
            this.sALNFolderToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.sALNFolderToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.sALNFolderToolStripMenuItem.Text = "SALN Folder";
            this.sALNFolderToolStripMenuItem.Click += new System.EventHandler(this.sALNFolderToolStripMenuItem_Click);
            // 
            // payrollFolderToolStripMenuItem
            // 
            this.payrollFolderToolStripMenuItem.Name = "payrollFolderToolStripMenuItem";
            this.payrollFolderToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.payrollFolderToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.payrollFolderToolStripMenuItem.Text = "Payroll Folder";
            this.payrollFolderToolStripMenuItem.Click += new System.EventHandler(this.payrollFolderToolStripMenuItem_Click);
            // 
            // btnEDU
            // 
            this.btnEDU.BackColor = System.Drawing.Color.Cornsilk;
            this.btnEDU.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEDU.Location = new System.Drawing.Point(282, 496);
            this.btnEDU.Name = "btnEDU";
            this.btnEDU.Size = new System.Drawing.Size(152, 29);
            this.btnEDU.TabIndex = 6;
            this.btnEDU.Text = "🎓 Education, LnD";
            this.btnEDU.UseVisualStyleBackColor = false;
            this.btnEDU.Click += new System.EventHandler(this.btnEDU_Click);
            // 
            // btnWE
            // 
            this.btnWE.BackColor = System.Drawing.Color.Cornsilk;
            this.btnWE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWE.Location = new System.Drawing.Point(440, 496);
            this.btnWE.Name = "btnWE";
            this.btnWE.Size = new System.Drawing.Size(155, 29);
            this.btnWE.TabIndex = 7;
            this.btnWE.Text = "💼 Work Experience";
            this.btnWE.UseVisualStyleBackColor = false;
            this.btnWE.Click += new System.EventHandler(this.btnWE_Click);
            // 
            // Select
            // 
            this.Select.HeaderText = "▼";
            this.Select.Name = "Select";
            this.Select.ReadOnly = true;
            this.Select.Width = 30;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(945, 534);
            this.Controls.Add(this.btnWE);
            this.Controls.Add(this.btnEDU);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnShowLeave);
            this.Controls.Add(this.btnShowSalary);
            this.Controls.Add(this.btnShowPDS);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddPDS);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddPDS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnShowPDS;
        private System.Windows.Forms.Button btnShowSalary;
        private System.Windows.Forms.Button btnShowLeave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payrollToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leaveCreditsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPersonnelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletePersonnelToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pDSResumeFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALNFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payrollFolderToolStripMenuItem;
        private System.Windows.Forms.Button btnEDU;
        private System.Windows.Forms.Button btnWE;
        private System.Windows.Forms.ToolStripMenuItem educationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workExperienceToolStripMenuItem;
        private System.Windows.Forms.DataGridViewButtonColumn Select;

    }
}