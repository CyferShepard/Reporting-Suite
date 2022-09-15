namespace Productivity_Reporter
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.genProdRepMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aVMReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.credentialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panelReport = new System.Windows.Forms.Panel();
            this.dgvOutput = new System.Windows.Forms.DataGridView();
            this.Agents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SERVICEID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accounts_Loaded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Touched = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contacts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RPC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PTP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debit_Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Attempts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Touched_Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact_Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RPC_Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PTP_Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debit_Order_Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnReportCancel = new System.Windows.Forms.Button();
            this.btnExecute = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelGen = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelAVM = new System.Windows.Forms.Panel();
            this.cmbScriptSelector = new System.Windows.Forms.ComboBox();
            this.dgvAVM = new System.Windows.Forms.DataGridView();
            this.AVMBck_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AVMService_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AVMService_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AVMAcc_Loaded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avmTouched = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AVM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AVMAttempts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AVMTouchRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AVMavmRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AVMAttRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtDateAVM = new System.Windows.Forms.DateTimePicker();
            this.btnAVMExport = new System.Windows.Forms.Button();
            this.btnAVMCancel = new System.Windows.Forms.Button();
            this.btnAVMGen = new System.Windows.Forms.Button();
            this.pnlADL = new System.Windows.Forms.Panel();
            this.btnADLCancel = new System.Windows.Forms.Button();
            this.btnValAndSave = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panelReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).BeginInit();
            this.panelGen.SuspendLayout();
            this.panelAVM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAVM)).BeginInit();
            this.pnlADL.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genProdRepMenuItem,
            this.aVMReportToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // genProdRepMenuItem
            // 
            this.genProdRepMenuItem.Name = "genProdRepMenuItem";
            this.genProdRepMenuItem.Size = new System.Drawing.Size(171, 20);
            this.genProdRepMenuItem.Text = "Generate Productivity Report";
            this.genProdRepMenuItem.Click += new System.EventHandler(this.genProdRepMenuItem_Click);
            // 
            // aVMReportToolStripMenuItem
            // 
            this.aVMReportToolStripMenuItem.Name = "aVMReportToolStripMenuItem";
            this.aVMReportToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.aVMReportToolStripMenuItem.Text = "AVM Report";
            this.aVMReportToolStripMenuItem.Click += new System.EventHandler(this.aVMReportToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.credentialsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // credentialsToolStripMenuItem
            // 
            this.credentialsToolStripMenuItem.Name = "credentialsToolStripMenuItem";
            this.credentialsToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.credentialsToolStripMenuItem.Text = "Credentials";
            this.credentialsToolStripMenuItem.Click += new System.EventHandler(this.credentialsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // panelReport
            // 
            this.panelReport.AutoSize = true;
            this.panelReport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelReport.BackColor = System.Drawing.SystemColors.Control;
            this.panelReport.Controls.Add(this.dgvOutput);
            this.panelReport.Controls.Add(this.label2);
            this.panelReport.Controls.Add(this.dtDate);
            this.panelReport.Controls.Add(this.btnExport);
            this.panelReport.Controls.Add(this.btnReportCancel);
            this.panelReport.Controls.Add(this.btnExecute);
            this.panelReport.Controls.Add(this.label1);
            this.panelReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelReport.Location = new System.Drawing.Point(0, 729);
            this.panelReport.Name = "panelReport";
            this.panelReport.Size = new System.Drawing.Size(1008, 806);
            this.panelReport.TabIndex = 11;
            // 
            // dgvOutput
            // 
            this.dgvOutput.AllowUserToAddRows = false;
            this.dgvOutput.AllowUserToDeleteRows = false;
            this.dgvOutput.AllowUserToResizeColumns = false;
            this.dgvOutput.AllowUserToResizeRows = false;
            this.dgvOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOutput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Agents,
            this.SERVICEID,
            this.ServiceName,
            this.Accounts_Loaded,
            this.Touched,
            this.Contacts,
            this.RPC,
            this.PTP,
            this.Debit_Order,
            this.Attempts,
            this.Touched_Rate,
            this.Contact_Rate,
            this.RPC_Rate,
            this.PTP_Rate,
            this.Debit_Order_Rate});
            this.dgvOutput.Location = new System.Drawing.Point(3, 82);
            this.dgvOutput.Name = "dgvOutput";
            this.dgvOutput.ReadOnly = true;
            this.dgvOutput.RowHeadersVisible = false;
            this.dgvOutput.Size = new System.Drawing.Size(1002, 611);
            this.dgvOutput.TabIndex = 3;
            // 
            // Agents
            // 
            this.Agents.HeaderText = "Agents";
            this.Agents.Name = "Agents";
            this.Agents.ReadOnly = true;
            this.Agents.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SERVICEID
            // 
            this.SERVICEID.HeaderText = "SERVICEID";
            this.SERVICEID.Name = "SERVICEID";
            this.SERVICEID.ReadOnly = true;
            this.SERVICEID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ServiceName
            // 
            this.ServiceName.HeaderText = "Service Name";
            this.ServiceName.Name = "ServiceName";
            this.ServiceName.ReadOnly = true;
            this.ServiceName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Accounts_Loaded
            // 
            this.Accounts_Loaded.HeaderText = "Accounts Loaded";
            this.Accounts_Loaded.Name = "Accounts_Loaded";
            this.Accounts_Loaded.ReadOnly = true;
            this.Accounts_Loaded.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Touched
            // 
            this.Touched.HeaderText = "Touched";
            this.Touched.Name = "Touched";
            this.Touched.ReadOnly = true;
            this.Touched.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Contacts
            // 
            this.Contacts.HeaderText = "Contacts";
            this.Contacts.Name = "Contacts";
            this.Contacts.ReadOnly = true;
            this.Contacts.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // RPC
            // 
            this.RPC.HeaderText = "RPC";
            this.RPC.Name = "RPC";
            this.RPC.ReadOnly = true;
            this.RPC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PTP
            // 
            this.PTP.HeaderText = "PTP";
            this.PTP.Name = "PTP";
            this.PTP.ReadOnly = true;
            this.PTP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Debit_Order
            // 
            this.Debit_Order.HeaderText = "Debit Order";
            this.Debit_Order.Name = "Debit_Order";
            this.Debit_Order.ReadOnly = true;
            this.Debit_Order.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Attempts
            // 
            this.Attempts.HeaderText = "Attempts";
            this.Attempts.Name = "Attempts";
            this.Attempts.ReadOnly = true;
            this.Attempts.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Touched_Rate
            // 
            this.Touched_Rate.HeaderText = "Touched Rate";
            this.Touched_Rate.Name = "Touched_Rate";
            this.Touched_Rate.ReadOnly = true;
            this.Touched_Rate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Contact_Rate
            // 
            this.Contact_Rate.HeaderText = "Contact Rate";
            this.Contact_Rate.Name = "Contact_Rate";
            this.Contact_Rate.ReadOnly = true;
            this.Contact_Rate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // RPC_Rate
            // 
            this.RPC_Rate.HeaderText = "RPC Rate";
            this.RPC_Rate.Name = "RPC_Rate";
            this.RPC_Rate.ReadOnly = true;
            this.RPC_Rate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PTP_Rate
            // 
            this.PTP_Rate.HeaderText = "PTP Rate";
            this.PTP_Rate.Name = "PTP_Rate";
            this.PTP_Rate.ReadOnly = true;
            this.PTP_Rate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Debit_Order_Rate
            // 
            this.Debit_Order_Rate.HeaderText = "Debit Order Rate";
            this.Debit_Order_Rate.Name = "Debit_Order_Rate";
            this.Debit_Order_Rate.ReadOnly = true;
            this.Debit_Order_Rate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(756, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select Date";
            // 
            // dtDate
            // 
            this.dtDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtDate.Location = new System.Drawing.Point(759, 27);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(237, 20);
            this.dtDate.TabIndex = 6;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Location = new System.Drawing.Point(840, 53);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnReportCancel
            // 
            this.btnReportCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReportCancel.Location = new System.Drawing.Point(921, 53);
            this.btnReportCancel.Name = "btnReportCancel";
            this.btnReportCancel.Size = new System.Drawing.Size(75, 23);
            this.btnReportCancel.TabIndex = 4;
            this.btnReportCancel.Text = "Cancel";
            this.btnReportCancel.UseVisualStyleBackColor = true;
            this.btnReportCancel.Click += new System.EventHandler(this.btnReportCancel_Click);
            // 
            // btnExecute
            // 
            this.btnExecute.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExecute.Location = new System.Drawing.Point(759, 54);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 1;
            this.btnExecute.Text = "Generate";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agent Performance Report";
            // 
            // panelGen
            // 
            this.panelGen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelGen.Controls.Add(this.label3);
            this.panelGen.Location = new System.Drawing.Point(432, 346);
            this.panelGen.Name = "panelGen";
            this.panelGen.Size = new System.Drawing.Size(200, 100);
            this.panelGen.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Generating Report";
            // 
            // panelAVM
            // 
            this.panelAVM.AutoSize = true;
            this.panelAVM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelAVM.Controls.Add(this.cmbScriptSelector);
            this.panelAVM.Controls.Add(this.dgvAVM);
            this.panelAVM.Controls.Add(this.label5);
            this.panelAVM.Controls.Add(this.label4);
            this.panelAVM.Controls.Add(this.dtDateAVM);
            this.panelAVM.Controls.Add(this.btnAVMExport);
            this.panelAVM.Controls.Add(this.btnAVMCancel);
            this.panelAVM.Controls.Add(this.btnAVMGen);
            this.panelAVM.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAVM.Location = new System.Drawing.Point(0, 24);
            this.panelAVM.Name = "panelAVM";
            this.panelAVM.Size = new System.Drawing.Size(1008, 705);
            this.panelAVM.TabIndex = 9;
            this.panelAVM.Visible = false;
            // 
            // cmbScriptSelector
            // 
            this.cmbScriptSelector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbScriptSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbScriptSelector.FormattingEnabled = true;
            this.cmbScriptSelector.Location = new System.Drawing.Point(759, 54);
            this.cmbScriptSelector.Name = "cmbScriptSelector";
            this.cmbScriptSelector.Size = new System.Drawing.Size(237, 21);
            this.cmbScriptSelector.TabIndex = 15;
            // 
            // dgvAVM
            // 
            this.dgvAVM.AllowUserToAddRows = false;
            this.dgvAVM.AllowUserToDeleteRows = false;
            this.dgvAVM.AllowUserToResizeColumns = false;
            this.dgvAVM.AllowUserToResizeRows = false;
            this.dgvAVM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAVM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAVM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAVM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AVMBck_ID,
            this.AVMService_ID,
            this.AVMService_Name,
            this.AVMAcc_Loaded,
            this.avmTouched,
            this.AVM,
            this.AVMAttempts,
            this.AVMTouchRate,
            this.AVMavmRate,
            this.AVMAttRate});
            this.dgvAVM.Location = new System.Drawing.Point(3, 110);
            this.dgvAVM.Name = "dgvAVM";
            this.dgvAVM.ReadOnly = true;
            this.dgvAVM.RowHeadersVisible = false;
            this.dgvAVM.Size = new System.Drawing.Size(1002, 583);
            this.dgvAVM.TabIndex = 14;
            // 
            // AVMBck_ID
            // 
            this.AVMBck_ID.HeaderText = "Bck_ID";
            this.AVMBck_ID.Name = "AVMBck_ID";
            this.AVMBck_ID.ReadOnly = true;
            this.AVMBck_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AVMService_ID
            // 
            this.AVMService_ID.HeaderText = "ServiceID";
            this.AVMService_ID.Name = "AVMService_ID";
            this.AVMService_ID.ReadOnly = true;
            this.AVMService_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AVMService_Name
            // 
            this.AVMService_Name.HeaderText = "Service_Name";
            this.AVMService_Name.Name = "AVMService_Name";
            this.AVMService_Name.ReadOnly = true;
            this.AVMService_Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AVMAcc_Loaded
            // 
            this.AVMAcc_Loaded.HeaderText = "Accounts_Loaded";
            this.AVMAcc_Loaded.Name = "AVMAcc_Loaded";
            this.AVMAcc_Loaded.ReadOnly = true;
            this.AVMAcc_Loaded.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // avmTouched
            // 
            this.avmTouched.HeaderText = "Touched";
            this.avmTouched.Name = "avmTouched";
            this.avmTouched.ReadOnly = true;
            this.avmTouched.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AVM
            // 
            this.AVM.HeaderText = "AVM";
            this.AVM.Name = "AVM";
            this.AVM.ReadOnly = true;
            this.AVM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AVMAttempts
            // 
            this.AVMAttempts.HeaderText = "Attempts";
            this.AVMAttempts.Name = "AVMAttempts";
            this.AVMAttempts.ReadOnly = true;
            this.AVMAttempts.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AVMTouchRate
            // 
            this.AVMTouchRate.HeaderText = "Touch Rate";
            this.AVMTouchRate.Name = "AVMTouchRate";
            this.AVMTouchRate.ReadOnly = true;
            this.AVMTouchRate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AVMavmRate
            // 
            this.AVMavmRate.HeaderText = "AVMRate";
            this.AVMavmRate.Name = "AVMavmRate";
            this.AVMavmRate.ReadOnly = true;
            this.AVMavmRate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AVMAttRate
            // 
            this.AVMAttRate.HeaderText = "Attempt Rate";
            this.AVMAttRate.Name = "AVMAttRate";
            this.AVMAttRate.ReadOnly = true;
            this.AVMAttRate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(309, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(323, 31);
            this.label5.TabIndex = 13;
            this.label5.Text = "AVM Performance Report";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(756, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Select Date";
            // 
            // dtDateAVM
            // 
            this.dtDateAVM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtDateAVM.Location = new System.Drawing.Point(759, 27);
            this.dtDateAVM.Name = "dtDateAVM";
            this.dtDateAVM.Size = new System.Drawing.Size(237, 20);
            this.dtDateAVM.TabIndex = 11;
            // 
            // btnAVMExport
            // 
            this.btnAVMExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAVMExport.Location = new System.Drawing.Point(840, 80);
            this.btnAVMExport.Name = "btnAVMExport";
            this.btnAVMExport.Size = new System.Drawing.Size(75, 23);
            this.btnAVMExport.TabIndex = 10;
            this.btnAVMExport.Text = "Export";
            this.btnAVMExport.UseVisualStyleBackColor = true;
            this.btnAVMExport.Click += new System.EventHandler(this.btnAVMExport_Click);
            // 
            // btnAVMCancel
            // 
            this.btnAVMCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAVMCancel.Location = new System.Drawing.Point(921, 80);
            this.btnAVMCancel.Name = "btnAVMCancel";
            this.btnAVMCancel.Size = new System.Drawing.Size(75, 23);
            this.btnAVMCancel.TabIndex = 9;
            this.btnAVMCancel.Text = "Cancel";
            this.btnAVMCancel.UseVisualStyleBackColor = true;
            this.btnAVMCancel.Click += new System.EventHandler(this.btnAVMCancel_Click);
            // 
            // btnAVMGen
            // 
            this.btnAVMGen.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnAVMGen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAVMGen.Location = new System.Drawing.Point(759, 81);
            this.btnAVMGen.Name = "btnAVMGen";
            this.btnAVMGen.Size = new System.Drawing.Size(75, 23);
            this.btnAVMGen.TabIndex = 8;
            this.btnAVMGen.Text = "Generate";
            this.btnAVMGen.UseVisualStyleBackColor = true;
            this.btnAVMGen.Click += new System.EventHandler(this.btnAVMGen_Click);
            // 
            // pnlADL
            // 
            this.pnlADL.Controls.Add(this.btnADLCancel);
            this.pnlADL.Controls.Add(this.btnValAndSave);
            this.pnlADL.Controls.Add(this.txtPass);
            this.pnlADL.Controls.Add(this.txtUsername);
            this.pnlADL.Controls.Add(this.label7);
            this.pnlADL.Controls.Add(this.label6);
            this.pnlADL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlADL.Location = new System.Drawing.Point(0, 1535);
            this.pnlADL.Name = "pnlADL";
            this.pnlADL.Size = new System.Drawing.Size(1008, 0);
            this.pnlADL.TabIndex = 15;
            this.pnlADL.Visible = false;
            // 
            // btnADLCancel
            // 
            this.btnADLCancel.Location = new System.Drawing.Point(547, 444);
            this.btnADLCancel.Name = "btnADLCancel";
            this.btnADLCancel.Size = new System.Drawing.Size(145, 48);
            this.btnADLCancel.TabIndex = 5;
            this.btnADLCancel.Text = "Cancel";
            this.btnADLCancel.UseVisualStyleBackColor = true;
            this.btnADLCancel.Click += new System.EventHandler(this.btnADLCancel_Click);
            // 
            // btnValAndSave
            // 
            this.btnValAndSave.Location = new System.Drawing.Point(348, 444);
            this.btnValAndSave.Name = "btnValAndSave";
            this.btnValAndSave.Size = new System.Drawing.Size(127, 48);
            this.btnValAndSave.TabIndex = 4;
            this.btnValAndSave.Text = "Validate and Save";
            this.btnValAndSave.UseVisualStyleBackColor = true;
            this.btnValAndSave.Click += new System.EventHandler(this.btnValAndSave_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(348, 256);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(353, 20);
            this.txtPass.TabIndex = 3;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(348, 182);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(353, 20);
            this.txtUsername.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label7.Location = new System.Drawing.Point(207, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(207, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Username:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.panelGen);
            this.Controls.Add(this.pnlADL);
            this.Controls.Add(this.panelReport);
            this.Controls.Add(this.panelAVM);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Productivity Exporter";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelReport.ResumeLayout(false);
            this.panelReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).EndInit();
            this.panelGen.ResumeLayout(false);
            this.panelGen.PerformLayout();
            this.panelAVM.ResumeLayout(false);
            this.panelAVM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAVM)).EndInit();
            this.pnlADL.ResumeLayout(false);
            this.pnlADL.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem genProdRepMenuItem;
        private System.Windows.Forms.Panel panelReport;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnReportCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.DataGridView dgvOutput;
        private System.Windows.Forms.Panel panelGen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Agents;
        private System.Windows.Forms.DataGridViewTextBoxColumn SERVICEID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Accounts_Loaded;
        private System.Windows.Forms.DataGridViewTextBoxColumn Touched;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contacts;
        private System.Windows.Forms.DataGridViewTextBoxColumn RPC;
        private System.Windows.Forms.DataGridViewTextBoxColumn PTP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debit_Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn Attempts;
        private System.Windows.Forms.DataGridViewTextBoxColumn Touched_Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact_Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RPC_Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PTP_Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debit_Order_Rate;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aVMReportToolStripMenuItem;
        private System.Windows.Forms.Panel panelAVM;
        private System.Windows.Forms.DataGridView dgvAVM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtDateAVM;
        private System.Windows.Forms.Button btnAVMExport;
        private System.Windows.Forms.Button btnAVMCancel;
        private System.Windows.Forms.Button btnAVMGen;
        private System.Windows.Forms.DataGridViewTextBoxColumn AVMBck_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AVMService_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AVMService_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn AVMAcc_Loaded;
        private System.Windows.Forms.DataGridViewTextBoxColumn avmTouched;
        private System.Windows.Forms.DataGridViewTextBoxColumn AVM;
        private System.Windows.Forms.DataGridViewTextBoxColumn AVMAttempts;
        private System.Windows.Forms.DataGridViewTextBoxColumn AVMTouchRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn AVMavmRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn AVMAttRate;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem credentialsToolStripMenuItem;
        private System.Windows.Forms.Panel pnlADL;
        private System.Windows.Forms.Button btnValAndSave;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnADLCancel;
        private System.Windows.Forms.ComboBox cmbScriptSelector;
    }
}

