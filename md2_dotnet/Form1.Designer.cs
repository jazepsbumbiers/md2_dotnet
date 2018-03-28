namespace md2_dotnet
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
            this.mnuMainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileProductsBrowser = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInventory = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInventoryBrowse = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInventorySetNotif = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.dgdAccountingTable = new System.Windows.Forms.DataGridView();
            this.dtpFilterSalesDateFrom = new System.Windows.Forms.DateTimePicker();
            this.lblFilterSalesDateFrom = new System.Windows.Forms.Label();
            this.dtpFilterSalesDateTo = new System.Windows.Forms.DateTimePicker();
            this.lblFilterSalesDateTo = new System.Windows.Forms.Label();
            this.txtTotalDayRevenue = new System.Windows.Forms.TextBox();
            this.lblTotalDayRevenue = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.mnuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.dgdOrderNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgdItemNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgdItemTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgdDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgdQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgdPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgdPVNvalue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgdTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgdDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgdTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFilterAccounting = new System.Windows.Forms.Button();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.lblTotalPVN = new System.Windows.Forms.Label();
            this.txtTotalPVN = new System.Windows.Forms.TextBox();
            this.lblPriceOfItems = new System.Windows.Forms.Label();
            this.txtTotalPriceOfItems = new System.Windows.Forms.TextBox();
            this.mnuMainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdAccountingTable)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMainMenuStrip
            // 
            this.mnuMainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuInventory,
            this.mnuHelp});
            this.mnuMainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenuStrip.Name = "mnuMainMenuStrip";
            this.mnuMainMenuStrip.Size = new System.Drawing.Size(883, 24);
            this.mnuMainMenuStrip.TabIndex = 0;
            this.mnuMainMenuStrip.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileProductsBrowser,
            this.mnuFileSave,
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuFileProductsBrowser
            // 
            this.mnuFileProductsBrowser.Name = "mnuFileProductsBrowser";
            this.mnuFileProductsBrowser.Size = new System.Drawing.Size(180, 22);
            this.mnuFileProductsBrowser.Text = "Product browser";
            this.mnuFileProductsBrowser.Click += new System.EventHandler(this.mnuFileProductsBrowser_Click);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(180, 22);
            this.mnuFileExit.Text = "Exit";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // mnuInventory
            // 
            this.mnuInventory.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuInventoryBrowse,
            this.mnuInventorySetNotif});
            this.mnuInventory.Name = "mnuInventory";
            this.mnuInventory.Size = new System.Drawing.Size(69, 20);
            this.mnuInventory.Text = "Inventory";
            // 
            // mnuInventoryBrowse
            // 
            this.mnuInventoryBrowse.Name = "mnuInventoryBrowse";
            this.mnuInventoryBrowse.Size = new System.Drawing.Size(180, 22);
            this.mnuInventoryBrowse.Text = "Browse";
            this.mnuInventoryBrowse.Click += new System.EventHandler(this.mnuInventoryBrowse_Click);
            // 
            // mnuInventorySetNotif
            // 
            this.mnuInventorySetNotif.Name = "mnuInventorySetNotif";
            this.mnuInventorySetNotif.Size = new System.Drawing.Size(180, 22);
            this.mnuInventorySetNotif.Text = "Set notifications";
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelpAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "Help";
            // 
            // mnuHelpAbout
            // 
            this.mnuHelpAbout.Name = "mnuHelpAbout";
            this.mnuHelpAbout.Size = new System.Drawing.Size(180, 22);
            this.mnuHelpAbout.Text = "About";
            this.mnuHelpAbout.Click += new System.EventHandler(this.mnuHelpAbout_Click);
            // 
            // dgdAccountingTable
            // 
            this.dgdAccountingTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdAccountingTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgdOrderNo,
            this.dgdItemNr,
            this.dgdItemTitle,
            this.dgdDescription,
            this.dgdQuantity,
            this.dgdPrice,
            this.dgdPVNvalue,
            this.dgdTotalPrice,
            this.dgdDate,
            this.dgdTime});
            this.dgdAccountingTable.Location = new System.Drawing.Point(12, 70);
            this.dgdAccountingTable.Name = "dgdAccountingTable";
            this.dgdAccountingTable.Size = new System.Drawing.Size(855, 281);
            this.dgdAccountingTable.TabIndex = 1;
            // 
            // dtpFilterSalesDateFrom
            // 
            this.dtpFilterSalesDateFrom.Location = new System.Drawing.Point(12, 44);
            this.dtpFilterSalesDateFrom.Name = "dtpFilterSalesDateFrom";
            this.dtpFilterSalesDateFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpFilterSalesDateFrom.TabIndex = 2;
            // 
            // lblFilterSalesDateFrom
            // 
            this.lblFilterSalesDateFrom.AutoSize = true;
            this.lblFilterSalesDateFrom.Location = new System.Drawing.Point(13, 28);
            this.lblFilterSalesDateFrom.Name = "lblFilterSalesDateFrom";
            this.lblFilterSalesDateFrom.Size = new System.Drawing.Size(54, 13);
            this.lblFilterSalesDateFrom.TabIndex = 3;
            this.lblFilterSalesDateFrom.Text = "From date";
            // 
            // dtpFilterSalesDateTo
            // 
            this.dtpFilterSalesDateTo.Location = new System.Drawing.Point(258, 44);
            this.dtpFilterSalesDateTo.Name = "dtpFilterSalesDateTo";
            this.dtpFilterSalesDateTo.Size = new System.Drawing.Size(200, 20);
            this.dtpFilterSalesDateTo.TabIndex = 4;
            // 
            // lblFilterSalesDateTo
            // 
            this.lblFilterSalesDateTo.AutoSize = true;
            this.lblFilterSalesDateTo.Location = new System.Drawing.Point(255, 28);
            this.lblFilterSalesDateTo.Name = "lblFilterSalesDateTo";
            this.lblFilterSalesDateTo.Size = new System.Drawing.Size(44, 13);
            this.lblFilterSalesDateTo.TabIndex = 5;
            this.lblFilterSalesDateTo.Text = "To date";
            // 
            // txtTotalDayRevenue
            // 
            this.txtTotalDayRevenue.Location = new System.Drawing.Point(785, 368);
            this.txtTotalDayRevenue.Name = "txtTotalDayRevenue";
            this.txtTotalDayRevenue.ReadOnly = true;
            this.txtTotalDayRevenue.Size = new System.Drawing.Size(82, 20);
            this.txtTotalDayRevenue.TabIndex = 6;
            // 
            // lblTotalDayRevenue
            // 
            this.lblTotalDayRevenue.AutoSize = true;
            this.lblTotalDayRevenue.Location = new System.Drawing.Point(704, 371);
            this.lblTotalDayRevenue.Name = "lblTotalDayRevenue";
            this.lblTotalDayRevenue.Size = new System.Drawing.Size(75, 13);
            this.lblTotalDayRevenue.TabIndex = 7;
            this.lblTotalDayRevenue.Text = "Day\'s revenue";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(777, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 22);
            this.button1.TabIndex = 8;
            this.button1.Text = "Export to excel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // mnuFileSave
            // 
            this.mnuFileSave.Name = "mnuFileSave";
            this.mnuFileSave.Size = new System.Drawing.Size(180, 22);
            this.mnuFileSave.Text = "Save";
            // 
            // dgdOrderNo
            // 
            this.dgdOrderNo.HeaderText = "Order no.";
            this.dgdOrderNo.Name = "dgdOrderNo";
            // 
            // dgdItemNr
            // 
            this.dgdItemNr.HeaderText = "Item no.";
            this.dgdItemNr.Name = "dgdItemNr";
            this.dgdItemNr.Width = 75;
            // 
            // dgdItemTitle
            // 
            this.dgdItemTitle.HeaderText = "Title";
            this.dgdItemTitle.Name = "dgdItemTitle";
            // 
            // dgdDescription
            // 
            this.dgdDescription.HeaderText = "Description";
            this.dgdDescription.Name = "dgdDescription";
            this.dgdDescription.Width = 150;
            // 
            // dgdQuantity
            // 
            this.dgdQuantity.HeaderText = "Quantity";
            this.dgdQuantity.Name = "dgdQuantity";
            this.dgdQuantity.Width = 50;
            // 
            // dgdPrice
            // 
            this.dgdPrice.HeaderText = "Item price w/o PVN";
            this.dgdPrice.Name = "dgdPrice";
            this.dgdPrice.Width = 75;
            // 
            // dgdPVNvalue
            // 
            this.dgdPVNvalue.HeaderText = "PVN ";
            this.dgdPVNvalue.Name = "dgdPVNvalue";
            this.dgdPVNvalue.Width = 50;
            // 
            // dgdTotalPrice
            // 
            this.dgdTotalPrice.HeaderText = "Total price";
            this.dgdTotalPrice.Name = "dgdTotalPrice";
            this.dgdTotalPrice.Width = 60;
            // 
            // dgdDate
            // 
            this.dgdDate.HeaderText = "Date";
            this.dgdDate.Name = "dgdDate";
            this.dgdDate.Width = 75;
            // 
            // dgdTime
            // 
            this.dgdTime.HeaderText = "Time";
            this.dgdTime.Name = "dgdTime";
            this.dgdTime.Width = 75;
            // 
            // btnFilterAccounting
            // 
            this.btnFilterAccounting.Location = new System.Drawing.Point(493, 41);
            this.btnFilterAccounting.Name = "btnFilterAccounting";
            this.btnFilterAccounting.Size = new System.Drawing.Size(75, 23);
            this.btnFilterAccounting.TabIndex = 9;
            this.btnFilterAccounting.Text = "Filter";
            this.btnFilterAccounting.UseVisualStyleBackColor = true;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(483, 428);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(96, 13);
            this.lblTotalPrice.TabIndex = 28;
            this.lblTotalPrice.Text = "Total price of items";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(586, 425);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(90, 20);
            this.txtTotalPrice.TabIndex = 27;
            // 
            // lblTotalPVN
            // 
            this.lblTotalPVN.AutoSize = true;
            this.lblTotalPVN.Location = new System.Drawing.Point(483, 399);
            this.lblTotalPVN.Name = "lblTotalPVN";
            this.lblTotalPVN.Size = new System.Drawing.Size(85, 13);
            this.lblTotalPVN.TabIndex = 26;
            this.lblTotalPVN.Text = "Total PVN value";
            // 
            // txtTotalPVN
            // 
            this.txtTotalPVN.Location = new System.Drawing.Point(586, 396);
            this.txtTotalPVN.Name = "txtTotalPVN";
            this.txtTotalPVN.ReadOnly = true;
            this.txtTotalPVN.Size = new System.Drawing.Size(90, 20);
            this.txtTotalPVN.TabIndex = 25;
            // 
            // lblPriceOfItems
            // 
            this.lblPriceOfItems.AutoSize = true;
            this.lblPriceOfItems.Location = new System.Drawing.Point(462, 368);
            this.lblPriceOfItems.Name = "lblPriceOfItems";
            this.lblPriceOfItems.Size = new System.Drawing.Size(117, 13);
            this.lblPriceOfItems.TabIndex = 30;
            this.lblPriceOfItems.Text = "Price of items w/o PVN";
            // 
            // txtTotalPriceOfItems
            // 
            this.txtTotalPriceOfItems.Location = new System.Drawing.Point(586, 364);
            this.txtTotalPriceOfItems.Name = "txtTotalPriceOfItems";
            this.txtTotalPriceOfItems.ReadOnly = true;
            this.txtTotalPriceOfItems.Size = new System.Drawing.Size(90, 20);
            this.txtTotalPriceOfItems.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 461);
            this.Controls.Add(this.lblPriceOfItems);
            this.Controls.Add(this.txtTotalPriceOfItems);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.lblTotalPVN);
            this.Controls.Add(this.txtTotalPVN);
            this.Controls.Add(this.btnFilterAccounting);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTotalDayRevenue);
            this.Controls.Add(this.txtTotalDayRevenue);
            this.Controls.Add(this.lblFilterSalesDateTo);
            this.Controls.Add(this.dtpFilterSalesDateTo);
            this.Controls.Add(this.lblFilterSalesDateFrom);
            this.Controls.Add(this.dtpFilterSalesDateFrom);
            this.Controls.Add(this.dgdAccountingTable);
            this.Controls.Add(this.mnuMainMenuStrip);
            this.Name = "Form1";
            this.Text = "Accounting";
            this.mnuMainMenuStrip.ResumeLayout(false);
            this.mnuMainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdAccountingTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileProductsBrowser;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ToolStripMenuItem mnuInventory;
        private System.Windows.Forms.ToolStripMenuItem mnuInventoryBrowse;
        private System.Windows.Forms.ToolStripMenuItem mnuInventorySetNotif;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuHelpAbout;
        private System.Windows.Forms.DataGridView dgdAccountingTable;
        private System.Windows.Forms.DateTimePicker dtpFilterSalesDateFrom;
        private System.Windows.Forms.Label lblFilterSalesDateFrom;
        private System.Windows.Forms.DateTimePicker dtpFilterSalesDateTo;
        private System.Windows.Forms.Label lblFilterSalesDateTo;
        private System.Windows.Forms.TextBox txtTotalDayRevenue;
        private System.Windows.Forms.Label lblTotalDayRevenue;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgdOrderNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgdItemNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgdItemTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgdDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgdQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgdPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgdPVNvalue;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgdTotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgdDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgdTime;
        private System.Windows.Forms.Button btnFilterAccounting;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label lblTotalPVN;
        private System.Windows.Forms.TextBox txtTotalPVN;
        private System.Windows.Forms.Label lblPriceOfItems;
        private System.Windows.Forms.TextBox txtTotalPriceOfItems;
    }
}

