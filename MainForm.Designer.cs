
namespace POSSystem
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.posMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeCashMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تقريرالعملاءToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchItemsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferItemsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receiveItemsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesReportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.salesMenuItem,
            this.itemsMenuItem,
            this.reportsMenuItem});
            resources.ApplyResources(this.mainMenu, "mainMenu");
            this.mainMenu.Name = "mainMenu";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsMenuItem,
            this.toolStripSeparator1,
            this.exitMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            resources.ApplyResources(this.fileMenuItem, "fileMenuItem");
            // 
            // settingsMenuItem
            // 
            this.settingsMenuItem.Name = "settingsMenuItem";
            resources.ApplyResources(this.settingsMenuItem, "settingsMenuItem");
            this.settingsMenuItem.Click += new System.EventHandler(this.settingsMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            resources.ApplyResources(this.exitMenuItem, "exitMenuItem");
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // salesMenuItem
            // 
            this.salesMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.posMenuItem,
            this.closeCashMenuItem,
            this.تقريرالعملاءToolStripMenuItem});
            this.salesMenuItem.Name = "salesMenuItem";
            resources.ApplyResources(this.salesMenuItem, "salesMenuItem");
            // 
            // posMenuItem
            // 
            this.posMenuItem.Name = "posMenuItem";
            resources.ApplyResources(this.posMenuItem, "posMenuItem");
            this.posMenuItem.Click += new System.EventHandler(this.posMenuItem_Click);
            // 
            // closeCashMenuItem
            // 
            this.closeCashMenuItem.Name = "closeCashMenuItem";
            resources.ApplyResources(this.closeCashMenuItem, "closeCashMenuItem");
            // 
            // تقريرالعملاءToolStripMenuItem
            // 
            this.تقريرالعملاءToolStripMenuItem.Name = "تقريرالعملاءToolStripMenuItem";
            resources.ApplyResources(this.تقريرالعملاءToolStripMenuItem, "تقريرالعملاءToolStripMenuItem");
            this.تقريرالعملاءToolStripMenuItem.Click += new System.EventHandler(this.تقريرالعملاءToolStripMenuItem_Click);
            // 
            // itemsMenuItem
            // 
            this.itemsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchItemsMenuItem,
            this.transferItemsMenuItem,
            this.receiveItemsMenuItem});
            this.itemsMenuItem.Name = "itemsMenuItem";
            resources.ApplyResources(this.itemsMenuItem, "itemsMenuItem");
            // 
            // searchItemsMenuItem
            // 
            this.searchItemsMenuItem.Name = "searchItemsMenuItem";
            resources.ApplyResources(this.searchItemsMenuItem, "searchItemsMenuItem");
            this.searchItemsMenuItem.Click += new System.EventHandler(this.searchItemsMenuItem_Click);
            // 
            // transferItemsMenuItem
            // 
            this.transferItemsMenuItem.Name = "transferItemsMenuItem";
            resources.ApplyResources(this.transferItemsMenuItem, "transferItemsMenuItem");
            this.transferItemsMenuItem.Click += new System.EventHandler(this.transferItemsMenuItem_Click);
            // 
            // receiveItemsMenuItem
            // 
            this.receiveItemsMenuItem.Name = "receiveItemsMenuItem";
            resources.ApplyResources(this.receiveItemsMenuItem, "receiveItemsMenuItem");
            this.receiveItemsMenuItem.Click += new System.EventHandler(this.receiveItemsMenuItem_Click);
            // 
            // reportsMenuItem
            // 
            this.reportsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesReportMenuItem});
            this.reportsMenuItem.Name = "reportsMenuItem";
            resources.ApplyResources(this.reportsMenuItem, "reportsMenuItem");
            // 
            // salesReportMenuItem
            // 
            this.salesReportMenuItem.Name = "salesReportMenuItem";
            resources.ApplyResources(this.salesReportMenuItem, "salesReportMenuItem");
            this.salesReportMenuItem.Click += new System.EventHandler(this.salesReportMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Name = "toolStrip1";
            // 
            // mainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.mainMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "mainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem posMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeCashMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchItemsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferItemsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receiveItemsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesReportMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem تقريرالعملاءToolStripMenuItem;
    }
}

