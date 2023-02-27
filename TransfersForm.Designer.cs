
namespace POSSystem
{
    partial class TransfersForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.branchComboBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.barcodeText = new System.Windows.Forms.TextBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.blnoLabel = new System.Windows.Forms.Label();
            this.cashButton = new System.Windows.Forms.Button();
            this.removeItemButton = new System.Windows.Forms.Button();
            this.totalQtyLabel = new System.Windows.Forms.Label();
            this.totalValueLabel = new System.Windows.Forms.Label();
            this.computerNoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.branchComboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 81);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1180, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "إلى الفرع";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // branchComboBox
            // 
            this.branchComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.branchComboBox.FormattingEnabled = true;
            this.branchComboBox.Location = new System.Drawing.Point(972, 28);
            this.branchComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.branchComboBox.Name = "branchComboBox";
            this.branchComboBox.Size = new System.Drawing.Size(202, 24);
            this.branchComboBox.TabIndex = 14;
            this.branchComboBox.SelectedIndexChanged += new System.EventHandler(this.branchComboBox_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.barcodeText);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1262, 51);
            this.panel2.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1178, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "الباركود";
            // 
            // barcodeText
            // 
            this.barcodeText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.barcodeText.Location = new System.Drawing.Point(896, 13);
            this.barcodeText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barcodeText.Name = "barcodeText";
            this.barcodeText.Size = new System.Drawing.Size(276, 24);
            this.barcodeText.TabIndex = 16;
            this.barcodeText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.barcodeText_KeyUp);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.computerNoColumn,
            this.colorColumn,
            this.sizeColumn,
            this.priceColumn,
            this.barcodeColumn,
            this.Code});
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.Location = new System.Drawing.Point(0, 132);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(1262, 661);
            this.dataGrid.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.pictureBox);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.blnoLabel);
            this.panel3.Controls.Add(this.cashButton);
            this.panel3.Controls.Add(this.removeItemButton);
            this.panel3.Controls.Add(this.totalQtyLabel);
            this.panel3.Controls.Add(this.totalValueLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(953, 132);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(309, 661);
            this.panel3.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(92, 605);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 45);
            this.button1.TabIndex = 34;
            this.button1.Text = "اعادة تحميل";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(74, 394);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(159, 199);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 33;
            this.pictureBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 21);
            this.label2.TabIndex = 30;
            this.label2.Text = "رقم المناقلة";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // blnoLabel
            // 
            this.blnoLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blnoLabel.Location = new System.Drawing.Point(22, 83);
            this.blnoLabel.Name = "blnoLabel";
            this.blnoLabel.Size = new System.Drawing.Size(259, 21);
            this.blnoLabel.TabIndex = 32;
            this.blnoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cashButton
            // 
            this.cashButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cashButton.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashButton.ForeColor = System.Drawing.Color.White;
            this.cashButton.Location = new System.Drawing.Point(111, 202);
            this.cashButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cashButton.Name = "cashButton";
            this.cashButton.Size = new System.Drawing.Size(87, 76);
            this.cashButton.TabIndex = 29;
            this.cashButton.Text = "حفظ";
            this.cashButton.UseVisualStyleBackColor = false;
            this.cashButton.Click += new System.EventHandler(this.cashButton_Click);
            // 
            // removeItemButton
            // 
            this.removeItemButton.BackColor = System.Drawing.Color.Gray;
            this.removeItemButton.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.removeItemButton.ForeColor = System.Drawing.Color.White;
            this.removeItemButton.Location = new System.Drawing.Point(111, 288);
            this.removeItemButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(87, 76);
            this.removeItemButton.TabIndex = 28;
            this.removeItemButton.Text = "إلغاء الصنف";
            this.removeItemButton.UseVisualStyleBackColor = false;
            this.removeItemButton.Click += new System.EventHandler(this.removeItemButton_Click);
            // 
            // totalQtyLabel
            // 
            this.totalQtyLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalQtyLabel.Location = new System.Drawing.Point(22, 166);
            this.totalQtyLabel.Name = "totalQtyLabel";
            this.totalQtyLabel.Size = new System.Drawing.Size(259, 24);
            this.totalQtyLabel.TabIndex = 5;
            this.totalQtyLabel.Text = "العدد : 0";
            this.totalQtyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalValueLabel
            // 
            this.totalValueLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalValueLabel.Location = new System.Drawing.Point(12, 123);
            this.totalValueLabel.Name = "totalValueLabel";
            this.totalValueLabel.Size = new System.Drawing.Size(273, 24);
            this.totalValueLabel.TabIndex = 4;
            this.totalValueLabel.Text = "الإجمالي : 0";
            this.totalValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // TransfersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 793);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TransfersForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "مناقلة من فرع";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox branchComboBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox barcodeText;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label totalQtyLabel;
        private System.Windows.Forms.Label totalValueLabel;
        private System.Windows.Forms.Button removeItemButton;
        private System.Windows.Forms.Button cashButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label blnoLabel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn computerNoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
    }
}