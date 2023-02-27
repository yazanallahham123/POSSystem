
namespace POSSystem
{
    partial class posForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.removeItemButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.customerButton = new System.Windows.Forms.Button();
            this.blnoLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.salesManComboBox = new System.Windows.Forms.ComboBox();
            this.posTextLabel = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.returnButton = new System.Windows.Forms.Button();
            this.posText = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.totalQtyLabel = new System.Windows.Forms.Label();
            this.cashButton = new System.Windows.Forms.Button();
            this.totalValueLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.branchNameLbl = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.stateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.computerNoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.removeItemButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.customerNameLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.customerButton);
            this.panel1.Controls.Add(this.blnoLabel);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.salesManComboBox);
            this.panel1.Controls.Add(this.posTextLabel);
            this.panel1.Controls.Add(this.pictureBox);
            this.panel1.Controls.Add(this.returnButton);
            this.panel1.Controls.Add(this.posText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 713);
            this.panel1.TabIndex = 0;
            // 
            // removeItemButton
            // 
            this.removeItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeItemButton.BackColor = System.Drawing.Color.Gray;
            this.removeItemButton.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.removeItemButton.ForeColor = System.Drawing.Color.White;
            this.removeItemButton.Location = new System.Drawing.Point(135, 243);
            this.removeItemButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(87, 76);
            this.removeItemButton.TabIndex = 27;
            this.removeItemButton.Text = "إلغاء الصنف F7";
            this.removeItemButton.UseVisualStyleBackColor = false;
            this.removeItemButton.Click += new System.EventHandler(this.removeItemButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 21);
            this.label2.TabIndex = 26;
            this.label2.Text = "رقم الفاتورة";
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customerNameLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameLabel.Location = new System.Drawing.Point(10, 471);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(212, 21);
            this.customerNameLabel.TabIndex = 25;
            this.customerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 440);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.TabIndex = 24;
            this.label1.Text = "اسم العميل";
            // 
            // customerButton
            // 
            this.customerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customerButton.BackColor = System.Drawing.Color.Gray;
            this.customerButton.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.customerButton.ForeColor = System.Drawing.Color.White;
            this.customerButton.Location = new System.Drawing.Point(135, 159);
            this.customerButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customerButton.Name = "customerButton";
            this.customerButton.Size = new System.Drawing.Size(87, 76);
            this.customerButton.TabIndex = 23;
            this.customerButton.Text = "تحديد العميل F6";
            this.customerButton.UseVisualStyleBackColor = false;
            this.customerButton.Click += new System.EventHandler(this.customerButton_Click);
            // 
            // blnoLabel
            // 
            this.blnoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.blnoLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blnoLabel.Location = new System.Drawing.Point(10, 411);
            this.blnoLabel.Name = "blnoLabel";
            this.blnoLabel.Size = new System.Drawing.Size(208, 21);
            this.blnoLabel.TabIndex = 22;
            this.blnoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(183, 336);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "البائع";
            // 
            // salesManComboBox
            // 
            this.salesManComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.salesManComboBox.FormattingEnabled = true;
            this.salesManComboBox.Location = new System.Drawing.Point(10, 357);
            this.salesManComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.salesManComboBox.Name = "salesManComboBox";
            this.salesManComboBox.Size = new System.Drawing.Size(212, 24);
            this.salesManComboBox.TabIndex = 20;
            this.salesManComboBox.SelectedIndexChanged += new System.EventHandler(this.salesManComboBox_SelectedIndexChanged);
            this.salesManComboBox.SelectedValueChanged += new System.EventHandler(this.salesManComboBox_SelectedValueChanged);
            // 
            // posTextLabel
            // 
            this.posTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.posTextLabel.Location = new System.Drawing.Point(10, 16);
            this.posTextLabel.Name = "posTextLabel";
            this.posTextLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.posTextLabel.Size = new System.Drawing.Size(211, 23);
            this.posTextLabel.TabIndex = 3;
            this.posTextLabel.Text = "أدخل الباركود";
            this.posTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.Location = new System.Drawing.Point(35, 501);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(159, 199);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // returnButton
            // 
            this.returnButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.returnButton.BackColor = System.Drawing.Color.Gray;
            this.returnButton.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.returnButton.ForeColor = System.Drawing.Color.White;
            this.returnButton.Location = new System.Drawing.Point(135, 75);
            this.returnButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(87, 76);
            this.returnButton.TabIndex = 1;
            this.returnButton.Text = "مرتجع F5";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // posText
            // 
            this.posText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.posText.Location = new System.Drawing.Point(10, 43);
            this.posText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.posText.Name = "posText";
            this.posText.Size = new System.Drawing.Size(212, 24);
            this.posText.TabIndex = 0;
            this.posText.TextChanged += new System.EventHandler(this.posText_TextChanged);
            this.posText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.posText_KeyPress);
            this.posText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.posText_KeyUp);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.totalQtyLabel);
            this.panel2.Controls.Add(this.cashButton);
            this.panel2.Controls.Add(this.totalValueLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(233, 554);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1086, 159);
            this.panel2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(755, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 45);
            this.button2.TabIndex = 21;
            this.button2.Text = "كشف المبيعات اليومية";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(944, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 45);
            this.button1.TabIndex = 20;
            this.button1.Text = "اعادة تحميل";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // totalQtyLabel
            // 
            this.totalQtyLabel.AutoSize = true;
            this.totalQtyLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalQtyLabel.Location = new System.Drawing.Point(170, 97);
            this.totalQtyLabel.Name = "totalQtyLabel";
            this.totalQtyLabel.Size = new System.Drawing.Size(90, 24);
            this.totalQtyLabel.TabIndex = 19;
            this.totalQtyLabel.Text = "العدد : 0";
            // 
            // cashButton
            // 
            this.cashButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cashButton.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashButton.ForeColor = System.Drawing.Color.White;
            this.cashButton.Location = new System.Drawing.Point(45, 51);
            this.cashButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cashButton.Name = "cashButton";
            this.cashButton.Size = new System.Drawing.Size(87, 76);
            this.cashButton.TabIndex = 18;
            this.cashButton.Text = "نقدي F10";
            this.cashButton.UseVisualStyleBackColor = false;
            this.cashButton.Click += new System.EventHandler(this.cashButton_Click);
            // 
            // totalValueLabel
            // 
            this.totalValueLabel.AutoSize = true;
            this.totalValueLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalValueLabel.Location = new System.Drawing.Point(170, 59);
            this.totalValueLabel.Name = "totalValueLabel";
            this.totalValueLabel.Size = new System.Drawing.Size(127, 24);
            this.totalValueLabel.TabIndex = 17;
            this.totalValueLabel.Text = "الإجمالي : 0";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.branchNameLbl);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(233, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1086, 67);
            this.panel3.TabIndex = 15;
            // 
            // branchNameLbl
            // 
            this.branchNameLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.branchNameLbl.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchNameLbl.Location = new System.Drawing.Point(459, 16);
            this.branchNameLbl.Name = "branchNameLbl";
            this.branchNameLbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.branchNameLbl.Size = new System.Drawing.Size(621, 36);
            this.branchNameLbl.TabIndex = 4;
            this.branchNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stateColumn,
            this.computerNoColumn,
            this.colorColumn,
            this.sizeColumn,
            this.priceColumn,
            this.barcodeColumn,
            this.Code});
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.Location = new System.Drawing.Point(233, 67);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(1086, 487);
            this.dataGrid.TabIndex = 16;
            // 
            // stateColumn
            // 
            this.stateColumn.HeaderText = "الحالة";
            this.stateColumn.MinimumWidth = 6;
            this.stateColumn.Name = "stateColumn";
            this.stateColumn.ReadOnly = true;
            this.stateColumn.Width = 125;
            // 
            // computerNoColumn
            // 
            this.computerNoColumn.HeaderText = "رقم الكمبيوتر";
            this.computerNoColumn.MinimumWidth = 6;
            this.computerNoColumn.Name = "computerNoColumn";
            this.computerNoColumn.ReadOnly = true;
            this.computerNoColumn.Width = 200;
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
            this.sizeColumn.Width = 125;
            // 
            // priceColumn
            // 
            this.priceColumn.HeaderText = "السعر";
            this.priceColumn.MinimumWidth = 6;
            this.priceColumn.Name = "priceColumn";
            this.priceColumn.ReadOnly = true;
            this.priceColumn.Width = 150;
            // 
            // barcodeColumn
            // 
            this.barcodeColumn.HeaderText = "باركود";
            this.barcodeColumn.MinimumWidth = 6;
            this.barcodeColumn.Name = "barcodeColumn";
            this.barcodeColumn.ReadOnly = true;
            this.barcodeColumn.Width = 250;
            // 
            // Code
            // 
            this.Code.HeaderText = "code";
            this.Code.MinimumWidth = 6;
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.Visible = false;
            this.Code.Width = 125;
            // 
            // posForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 713);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "posForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "نقطة البيع";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.posForm_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox posText;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label posTextLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox salesManComboBox;
        private System.Windows.Forms.Label blnoLabel;
        private System.Windows.Forms.Button customerButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button removeItemButton;
        private System.Windows.Forms.Label totalQtyLabel;
        private System.Windows.Forms.Button cashButton;
        private System.Windows.Forms.Label totalValueLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label branchNameLbl;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn computerNoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
    }
}