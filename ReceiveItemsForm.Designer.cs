
namespace POSSystem
{
    partial class receiveItemsForm
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
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.countLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.receiveBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkTextBox = new System.Windows.Forms.TextBox();
            this.itemsGridView = new System.Windows.Forms.DataGridView();
            this.barcodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.computerNoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receivedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromBranchColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsCountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.fromBranchColumn,
            this.itemsCountColumn,
            this.dateColumn});
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGrid.Location = new System.Drawing.Point(0, 0);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(1148, 249);
            this.dataGrid.TabIndex = 1;
            this.dataGrid.SelectionChanged += new System.EventHandler(this.dataGrid_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.countLbl);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.receiveBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 249);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1148, 59);
            this.panel1.TabIndex = 3;
            // 
            // countLbl
            // 
            this.countLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.countLbl.AutoSize = true;
            this.countLbl.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countLbl.Location = new System.Drawing.Point(306, 17);
            this.countLbl.Name = "countLbl";
            this.countLbl.Size = new System.Drawing.Size(22, 23);
            this.countLbl.TabIndex = 4;
            this.countLbl.Text = "0";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(343, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "العدد";
            // 
            // receiveBtn
            // 
            this.receiveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.receiveBtn.Location = new System.Drawing.Point(692, 14);
            this.receiveBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.receiveBtn.Name = "receiveBtn";
            this.receiveBtn.Size = new System.Drawing.Size(87, 28);
            this.receiveBtn.TabIndex = 2;
            this.receiveBtn.Text = "استلام";
            this.receiveBtn.UseVisualStyleBackColor = true;
            this.receiveBtn.Click += new System.EventHandler(this.receiveBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1081, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "مطابقة";
            // 
            // checkTextBox
            // 
            this.checkTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkTextBox.Location = new System.Drawing.Point(797, 17);
            this.checkTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkTextBox.Name = "checkTextBox";
            this.checkTextBox.Size = new System.Drawing.Size(276, 24);
            this.checkTextBox.TabIndex = 0;
            this.checkTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // itemsGridView
            // 
            this.itemsGridView.AllowUserToDeleteRows = false;
            this.itemsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barcodeColumn,
            this.computerNoColumn,
            this.colorColumn,
            this.sizeColumn,
            this.qtyColumn,
            this.receivedColumn});
            this.itemsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsGridView.Location = new System.Drawing.Point(0, 308);
            this.itemsGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.itemsGridView.MultiSelect = false;
            this.itemsGridView.Name = "itemsGridView";
            this.itemsGridView.ReadOnly = true;
            this.itemsGridView.RowHeadersWidth = 51;
            this.itemsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemsGridView.Size = new System.Drawing.Size(1148, 286);
            this.itemsGridView.TabIndex = 4;
            // 
            // barcodeColumn
            // 
            this.barcodeColumn.HeaderText = "الباركود";
            this.barcodeColumn.MinimumWidth = 6;
            this.barcodeColumn.Name = "barcodeColumn";
            this.barcodeColumn.ReadOnly = true;
            this.barcodeColumn.Width = 250;
            // 
            // computerNoColumn
            // 
            this.computerNoColumn.HeaderText = "رقم الكمبيوتر";
            this.computerNoColumn.MinimumWidth = 6;
            this.computerNoColumn.Name = "computerNoColumn";
            this.computerNoColumn.ReadOnly = true;
            this.computerNoColumn.Width = 150;
            // 
            // colorColumn
            // 
            this.colorColumn.HeaderText = "اللون";
            this.colorColumn.MinimumWidth = 6;
            this.colorColumn.Name = "colorColumn";
            this.colorColumn.ReadOnly = true;
            this.colorColumn.Width = 200;
            // 
            // sizeColumn
            // 
            this.sizeColumn.HeaderText = "القياس";
            this.sizeColumn.MinimumWidth = 6;
            this.sizeColumn.Name = "sizeColumn";
            this.sizeColumn.ReadOnly = true;
            this.sizeColumn.Width = 125;
            // 
            // qtyColumn
            // 
            this.qtyColumn.HeaderText = "الكمية";
            this.qtyColumn.MinimumWidth = 6;
            this.qtyColumn.Name = "qtyColumn";
            this.qtyColumn.ReadOnly = true;
            this.qtyColumn.Width = 125;
            // 
            // receivedColumn
            // 
            this.receivedColumn.HeaderText = "المستلم";
            this.receivedColumn.MinimumWidth = 6;
            this.receivedColumn.Name = "receivedColumn";
            this.receivedColumn.ReadOnly = true;
            this.receivedColumn.Width = 125;
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "رقم المناقلة";
            this.idColumn.MinimumWidth = 6;
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Width = 200;
            // 
            // fromBranchColumn
            // 
            this.fromBranchColumn.HeaderText = "من الفرع";
            this.fromBranchColumn.MinimumWidth = 6;
            this.fromBranchColumn.Name = "fromBranchColumn";
            this.fromBranchColumn.ReadOnly = true;
            this.fromBranchColumn.Width = 250;
            // 
            // itemsCountColumn
            // 
            this.itemsCountColumn.HeaderText = "عدد المواد";
            this.itemsCountColumn.MinimumWidth = 6;
            this.itemsCountColumn.Name = "itemsCountColumn";
            this.itemsCountColumn.ReadOnly = true;
            this.itemsCountColumn.Width = 125;
            // 
            // dateColumn
            // 
            this.dateColumn.HeaderText = "التاريخ";
            this.dateColumn.MinimumWidth = 6;
            this.dateColumn.Name = "dateColumn";
            this.dateColumn.ReadOnly = true;
            this.dateColumn.Width = 150;
            // 
            // receiveItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 594);
            this.Controls.Add(this.itemsGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGrid);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "receiveItemsForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "استلام مناقلات";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.receiveItemsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox checkTextBox;
        private System.Windows.Forms.DataGridView itemsGridView;
        private System.Windows.Forms.Button receiveBtn;
        private System.Windows.Forms.Label countLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromBranchColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemsCountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn computerNoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receivedColumn;
    }
}