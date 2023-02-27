
namespace POSSystem
{
    partial class SearchItemForm
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
            this.itemsGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.filterButton = new System.Windows.Forms.Button();
            this.sizeCheckBox = new System.Windows.Forms.CheckBox();
            this.sizeComboBox = new System.Windows.Forms.ComboBox();
            this.colorCheckBox = new System.Windows.Forms.CheckBox();
            this.colorComboBox = new System.Windows.Forms.ComboBox();
            this.filterBranchCheckBox = new System.Windows.Forms.CheckBox();
            this.branchComboBox = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.branchColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.computerNoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.itemsGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemsGridView
            // 
            this.itemsGridView.AllowUserToDeleteRows = false;
            this.itemsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.branchColumn,
            this.barcodeColumn,
            this.computerNoColumn,
            this.colorColumn,
            this.sizeColumn,
            this.qtyColumn});
            this.itemsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsGridView.Location = new System.Drawing.Point(0, 102);
            this.itemsGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.itemsGridView.MultiSelect = false;
            this.itemsGridView.Name = "itemsGridView";
            this.itemsGridView.ReadOnly = true;
            this.itemsGridView.RowHeadersWidth = 51;
            this.itemsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemsGridView.Size = new System.Drawing.Size(1086, 418);
            this.itemsGridView.TabIndex = 6;
            this.itemsGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.itemsGridView_CellMouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.filterButton);
            this.panel1.Controls.Add(this.sizeCheckBox);
            this.panel1.Controls.Add(this.sizeComboBox);
            this.panel1.Controls.Add(this.colorCheckBox);
            this.panel1.Controls.Add(this.colorComboBox);
            this.panel1.Controls.Add(this.filterBranchCheckBox);
            this.panel1.Controls.Add(this.branchComboBox);
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.searchTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1086, 102);
            this.panel1.TabIndex = 5;
            // 
            // filterButton
            // 
            this.filterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filterButton.Location = new System.Drawing.Point(64, 53);
            this.filterButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(87, 28);
            this.filterButton.TabIndex = 18;
            this.filterButton.Text = "تصفية";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // sizeCheckBox
            // 
            this.sizeCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sizeCheckBox.AutoSize = true;
            this.sizeCheckBox.Location = new System.Drawing.Point(364, 58);
            this.sizeCheckBox.Name = "sizeCheckBox";
            this.sizeCheckBox.Size = new System.Drawing.Size(70, 21);
            this.sizeCheckBox.TabIndex = 17;
            this.sizeCheckBox.Text = "القياس";
            this.sizeCheckBox.UseVisualStyleBackColor = true;
            // 
            // sizeComboBox
            // 
            this.sizeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sizeComboBox.FormattingEnabled = true;
            this.sizeComboBox.Location = new System.Drawing.Point(157, 56);
            this.sizeComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sizeComboBox.Name = "sizeComboBox";
            this.sizeComboBox.Size = new System.Drawing.Size(202, 24);
            this.sizeComboBox.TabIndex = 16;
            // 
            // colorCheckBox
            // 
            this.colorCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorCheckBox.AutoSize = true;
            this.colorCheckBox.Location = new System.Drawing.Point(654, 58);
            this.colorCheckBox.Name = "colorCheckBox";
            this.colorCheckBox.Size = new System.Drawing.Size(57, 21);
            this.colorCheckBox.TabIndex = 15;
            this.colorCheckBox.Text = "اللون";
            this.colorCheckBox.UseVisualStyleBackColor = true;
            // 
            // colorComboBox
            // 
            this.colorComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorComboBox.FormattingEnabled = true;
            this.colorComboBox.Location = new System.Drawing.Point(447, 56);
            this.colorComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(202, 24);
            this.colorComboBox.TabIndex = 14;
            // 
            // filterBranchCheckBox
            // 
            this.filterBranchCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filterBranchCheckBox.AutoSize = true;
            this.filterBranchCheckBox.Location = new System.Drawing.Point(924, 60);
            this.filterBranchCheckBox.Name = "filterBranchCheckBox";
            this.filterBranchCheckBox.Size = new System.Drawing.Size(58, 21);
            this.filterBranchCheckBox.TabIndex = 13;
            this.filterBranchCheckBox.Text = "الفرع";
            this.filterBranchCheckBox.UseVisualStyleBackColor = true;
            // 
            // branchComboBox
            // 
            this.branchComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.branchComboBox.FormattingEnabled = true;
            this.branchComboBox.Location = new System.Drawing.Point(717, 58);
            this.branchComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.branchComboBox.Name = "branchComboBox";
            this.branchComboBox.Size = new System.Drawing.Size(202, 24);
            this.branchComboBox.TabIndex = 12;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Location = new System.Drawing.Point(537, 15);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(87, 28);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "بحث";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(925, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "رقم الكمبيوتر او الباركود";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.Location = new System.Drawing.Point(643, 19);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(276, 24);
            this.searchTextBox.TabIndex = 0;
            this.searchTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchTextBox_KeyUp);
            // 
            // branchColumn
            // 
            this.branchColumn.HeaderText = "الفرع";
            this.branchColumn.MinimumWidth = 6;
            this.branchColumn.Name = "branchColumn";
            this.branchColumn.ReadOnly = true;
            this.branchColumn.Width = 200;
            // 
            // barcodeColumn
            // 
            this.barcodeColumn.HeaderText = "الباركود";
            this.barcodeColumn.MinimumWidth = 6;
            this.barcodeColumn.Name = "barcodeColumn";
            this.barcodeColumn.ReadOnly = true;
            this.barcodeColumn.Width = 200;
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
            this.colorColumn.Width = 150;
            // 
            // sizeColumn
            // 
            this.sizeColumn.HeaderText = "القياس";
            this.sizeColumn.MinimumWidth = 6;
            this.sizeColumn.Name = "sizeColumn";
            this.sizeColumn.ReadOnly = true;
            this.sizeColumn.Width = 150;
            // 
            // qtyColumn
            // 
            this.qtyColumn.HeaderText = "الكمية";
            this.qtyColumn.MinimumWidth = 6;
            this.qtyColumn.Name = "qtyColumn";
            this.qtyColumn.ReadOnly = true;
            this.qtyColumn.Width = 125;
            // 
            // SearchItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 520);
            this.Controls.Add(this.itemsGridView);
            this.Controls.Add(this.panel1);
            this.Name = "SearchItemForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "بحث عن صنف";
            ((System.ComponentModel.ISupportInitialize)(this.itemsGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView itemsGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ComboBox branchComboBox;
        private System.Windows.Forms.CheckBox filterBranchCheckBox;
        private System.Windows.Forms.CheckBox sizeCheckBox;
        private System.Windows.Forms.ComboBox sizeComboBox;
        private System.Windows.Forms.CheckBox colorCheckBox;
        private System.Windows.Forms.ComboBox colorComboBox;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn computerNoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyColumn;
    }
}