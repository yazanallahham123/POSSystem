
namespace POSSystem
{
    partial class settingsForm
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
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.connectionGroupBox = new System.Windows.Forms.GroupBox();
            this.loadDatabasesButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.databaseComboBox = new System.Windows.Forms.ComboBox();
            this.testConnectionButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.sqlPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sqlUserTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sqlServerTextBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.posGroup = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.printersComboBox = new System.Windows.Forms.ComboBox();
            this.priceTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.specialRadioButton = new System.Windows.Forms.RadioButton();
            this.clearanceRadioButton = new System.Windows.Forms.RadioButton();
            this.saleRadioButton = new System.Windows.Forms.RadioButton();
            this.endUserRadioButton = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.additionallPricesComboBox = new System.Windows.Forms.ComboBox();
            this.additionallPricesCheckBox = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.currencyComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.salesManComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.userComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtiComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bliComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.branchComboBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonsPanel.SuspendLayout();
            this.connectionGroupBox.SuspendLayout();
            this.posGroup.SuspendLayout();
            this.priceTypeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Controls.Add(this.cancelButton);
            this.buttonsPanel.Controls.Add(this.applyButton);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonsPanel.Location = new System.Drawing.Point(0, 515);
            this.buttonsPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(968, 84);
            this.buttonsPanel.TabIndex = 0;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(749, 27);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(87, 28);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "الغاء الأمر";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(855, 27);
            this.applyButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(87, 28);
            this.applyButton.TabIndex = 0;
            this.applyButton.Text = "تطبيق";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // connectionGroupBox
            // 
            this.connectionGroupBox.Controls.Add(this.button2);
            this.connectionGroupBox.Controls.Add(this.loadDatabasesButton);
            this.connectionGroupBox.Controls.Add(this.label4);
            this.connectionGroupBox.Controls.Add(this.databaseComboBox);
            this.connectionGroupBox.Controls.Add(this.testConnectionButton);
            this.connectionGroupBox.Controls.Add(this.label3);
            this.connectionGroupBox.Controls.Add(this.sqlPasswordTextBox);
            this.connectionGroupBox.Controls.Add(this.label2);
            this.connectionGroupBox.Controls.Add(this.sqlUserTextBox);
            this.connectionGroupBox.Controls.Add(this.label1);
            this.connectionGroupBox.Controls.Add(this.sqlServerTextBox);
            this.connectionGroupBox.Location = new System.Drawing.Point(14, 27);
            this.connectionGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.connectionGroupBox.Name = "connectionGroupBox";
            this.connectionGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.connectionGroupBox.Size = new System.Drawing.Size(479, 247);
            this.connectionGroupBox.TabIndex = 1;
            this.connectionGroupBox.TabStop = false;
            this.connectionGroupBox.Text = "اعدادات الإتصال";
            // 
            // loadDatabasesButton
            // 
            this.loadDatabasesButton.Location = new System.Drawing.Point(13, 164);
            this.loadDatabasesButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loadDatabasesButton.Name = "loadDatabasesButton";
            this.loadDatabasesButton.Size = new System.Drawing.Size(135, 28);
            this.loadDatabasesButton.TabIndex = 11;
            this.loadDatabasesButton.Text = "جلب قواعد البيانات";
            this.loadDatabasesButton.UseVisualStyleBackColor = true;
            this.loadDatabasesButton.Click += new System.EventHandler(this.loadDatabasesButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(369, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "قاعدة البيانات";
            // 
            // databaseComboBox
            // 
            this.databaseComboBox.FormattingEnabled = true;
            this.databaseComboBox.Location = new System.Drawing.Point(159, 166);
            this.databaseComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.databaseComboBox.Name = "databaseComboBox";
            this.databaseComboBox.Size = new System.Drawing.Size(202, 24);
            this.databaseComboBox.TabIndex = 7;
            // 
            // testConnectionButton
            // 
            this.testConnectionButton.Location = new System.Drawing.Point(13, 130);
            this.testConnectionButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.testConnectionButton.Name = "testConnectionButton";
            this.testConnectionButton.Size = new System.Drawing.Size(135, 28);
            this.testConnectionButton.TabIndex = 6;
            this.testConnectionButton.Text = "إختبار";
            this.testConnectionButton.UseVisualStyleBackColor = true;
            this.testConnectionButton.Click += new System.EventHandler(this.testConnectionButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "كلمة المرور";
            // 
            // sqlPasswordTextBox
            // 
            this.sqlPasswordTextBox.Location = new System.Drawing.Point(15, 98);
            this.sqlPasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sqlPasswordTextBox.Name = "sqlPasswordTextBox";
            this.sqlPasswordTextBox.PasswordChar = '*';
            this.sqlPasswordTextBox.Size = new System.Drawing.Size(342, 24);
            this.sqlPasswordTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "اسم المستخدم";
            // 
            // sqlUserTextBox
            // 
            this.sqlUserTextBox.Location = new System.Drawing.Point(15, 66);
            this.sqlUserTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sqlUserTextBox.Name = "sqlUserTextBox";
            this.sqlUserTextBox.Size = new System.Drawing.Size(342, 24);
            this.sqlUserTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "المخدم";
            // 
            // sqlServerTextBox
            // 
            this.sqlServerTextBox.Location = new System.Drawing.Point(15, 34);
            this.sqlServerTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sqlServerTextBox.Name = "sqlServerTextBox";
            this.sqlServerTextBox.Size = new System.Drawing.Size(342, 24);
            this.sqlServerTextBox.TabIndex = 0;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // posGroup
            // 
            this.posGroup.Controls.Add(this.label12);
            this.posGroup.Controls.Add(this.printersComboBox);
            this.posGroup.Controls.Add(this.priceTypeGroupBox);
            this.posGroup.Controls.Add(this.label11);
            this.posGroup.Controls.Add(this.additionallPricesComboBox);
            this.posGroup.Controls.Add(this.additionallPricesCheckBox);
            this.posGroup.Controls.Add(this.label10);
            this.posGroup.Controls.Add(this.currencyComboBox);
            this.posGroup.Controls.Add(this.label9);
            this.posGroup.Controls.Add(this.salesManComboBox);
            this.posGroup.Controls.Add(this.label8);
            this.posGroup.Controls.Add(this.userComboBox);
            this.posGroup.Controls.Add(this.label7);
            this.posGroup.Controls.Add(this.dtiComboBox);
            this.posGroup.Controls.Add(this.label6);
            this.posGroup.Controls.Add(this.bliComboBox);
            this.posGroup.Controls.Add(this.label5);
            this.posGroup.Controls.Add(this.branchComboBox);
            this.posGroup.Location = new System.Drawing.Point(500, 27);
            this.posGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.posGroup.Name = "posGroup";
            this.posGroup.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.posGroup.Size = new System.Drawing.Size(456, 467);
            this.posGroup.TabIndex = 2;
            this.posGroup.TabStop = false;
            this.posGroup.Text = "إعدادات نقطة البيع";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(323, 250);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 17);
            this.label12.TabIndex = 27;
            this.label12.Text = "الطابعة";
            // 
            // printersComboBox
            // 
            this.printersComboBox.FormattingEnabled = true;
            this.printersComboBox.Location = new System.Drawing.Point(113, 245);
            this.printersComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.printersComboBox.Name = "printersComboBox";
            this.printersComboBox.Size = new System.Drawing.Size(202, 24);
            this.printersComboBox.TabIndex = 26;
            // 
            // priceTypeGroupBox
            // 
            this.priceTypeGroupBox.Controls.Add(this.specialRadioButton);
            this.priceTypeGroupBox.Controls.Add(this.clearanceRadioButton);
            this.priceTypeGroupBox.Controls.Add(this.saleRadioButton);
            this.priceTypeGroupBox.Controls.Add(this.endUserRadioButton);
            this.priceTypeGroupBox.Location = new System.Drawing.Point(17, 354);
            this.priceTypeGroupBox.Name = "priceTypeGroupBox";
            this.priceTypeGroupBox.Size = new System.Drawing.Size(396, 77);
            this.priceTypeGroupBox.TabIndex = 25;
            this.priceTypeGroupBox.TabStop = false;
            this.priceTypeGroupBox.Text = "نوع السعر";
            // 
            // specialRadioButton
            // 
            this.specialRadioButton.AutoSize = true;
            this.specialRadioButton.Location = new System.Drawing.Point(21, 37);
            this.specialRadioButton.Name = "specialRadioButton";
            this.specialRadioButton.Size = new System.Drawing.Size(105, 21);
            this.specialRadioButton.TabIndex = 3;
            this.specialRadioButton.TabStop = true;
            this.specialRadioButton.Text = "السعر الخاص";
            this.specialRadioButton.UseVisualStyleBackColor = true;
            // 
            // clearanceRadioButton
            // 
            this.clearanceRadioButton.AutoSize = true;
            this.clearanceRadioButton.Location = new System.Drawing.Point(132, 37);
            this.clearanceRadioButton.Name = "clearanceRadioButton";
            this.clearanceRadioButton.Size = new System.Drawing.Size(72, 21);
            this.clearanceRadioButton.TabIndex = 2;
            this.clearanceRadioButton.TabStop = true;
            this.clearanceRadioButton.Text = "التصفية";
            this.clearanceRadioButton.UseVisualStyleBackColor = true;
            // 
            // saleRadioButton
            // 
            this.saleRadioButton.AutoSize = true;
            this.saleRadioButton.Location = new System.Drawing.Point(210, 37);
            this.saleRadioButton.Name = "saleRadioButton";
            this.saleRadioButton.Size = new System.Drawing.Size(77, 21);
            this.saleRadioButton.TabIndex = 1;
            this.saleRadioButton.TabStop = true;
            this.saleRadioButton.Text = "التنزيلات";
            this.saleRadioButton.UseVisualStyleBackColor = true;
            // 
            // endUserRadioButton
            // 
            this.endUserRadioButton.AutoSize = true;
            this.endUserRadioButton.Location = new System.Drawing.Point(293, 37);
            this.endUserRadioButton.Name = "endUserRadioButton";
            this.endUserRadioButton.Size = new System.Drawing.Size(85, 21);
            this.endUserRadioButton.TabIndex = 0;
            this.endUserRadioButton.TabStop = true;
            this.endUserRadioButton.Text = "سعر البيع";
            this.endUserRadioButton.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(323, 318);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "السعر الإضافي";
            // 
            // additionallPricesComboBox
            // 
            this.additionallPricesComboBox.FormattingEnabled = true;
            this.additionallPricesComboBox.Location = new System.Drawing.Point(113, 313);
            this.additionallPricesComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.additionallPricesComboBox.Name = "additionallPricesComboBox";
            this.additionallPricesComboBox.Size = new System.Drawing.Size(202, 24);
            this.additionallPricesComboBox.TabIndex = 23;
            // 
            // additionallPricesCheckBox
            // 
            this.additionallPricesCheckBox.AutoSize = true;
            this.additionallPricesCheckBox.Location = new System.Drawing.Point(206, 285);
            this.additionallPricesCheckBox.Name = "additionallPricesCheckBox";
            this.additionallPricesCheckBox.Size = new System.Drawing.Size(193, 21);
            this.additionallPricesCheckBox.TabIndex = 22;
            this.additionallPricesCheckBox.Text = "التسعير من الأسعار الإضافية";
            this.additionallPricesCheckBox.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(323, 218);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "العملة";
            // 
            // currencyComboBox
            // 
            this.currencyComboBox.FormattingEnabled = true;
            this.currencyComboBox.Location = new System.Drawing.Point(113, 213);
            this.currencyComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.currencyComboBox.Name = "currencyComboBox";
            this.currencyComboBox.Size = new System.Drawing.Size(202, 24);
            this.currencyComboBox.TabIndex = 20;
            this.currencyComboBox.SelectedIndexChanged += new System.EventHandler(this.currencyComboBox_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(323, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "البائع";
            // 
            // salesManComboBox
            // 
            this.salesManComboBox.FormattingEnabled = true;
            this.salesManComboBox.Location = new System.Drawing.Point(113, 181);
            this.salesManComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.salesManComboBox.Name = "salesManComboBox";
            this.salesManComboBox.Size = new System.Drawing.Size(202, 24);
            this.salesManComboBox.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(323, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "المستخدم";
            // 
            // userComboBox
            // 
            this.userComboBox.FormattingEnabled = true;
            this.userComboBox.Location = new System.Drawing.Point(113, 149);
            this.userComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userComboBox.Name = "userComboBox";
            this.userComboBox.Size = new System.Drawing.Size(202, 24);
            this.userComboBox.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(323, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "نمط المناقلة";
            // 
            // dtiComboBox
            // 
            this.dtiComboBox.FormattingEnabled = true;
            this.dtiComboBox.Location = new System.Drawing.Point(113, 117);
            this.dtiComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtiComboBox.Name = "dtiComboBox";
            this.dtiComboBox.Size = new System.Drawing.Size(202, 24);
            this.dtiComboBox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(323, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "نمط فاتورة المبيعات";
            // 
            // bliComboBox
            // 
            this.bliComboBox.FormattingEnabled = true;
            this.bliComboBox.Location = new System.Drawing.Point(113, 85);
            this.bliComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bliComboBox.Name = "bliComboBox";
            this.bliComboBox.Size = new System.Drawing.Size(202, 24);
            this.bliComboBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(323, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "الفرع";
            // 
            // branchComboBox
            // 
            this.branchComboBox.FormattingEnabled = true;
            this.branchComboBox.Location = new System.Drawing.Point(113, 50);
            this.branchComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.branchComboBox.Name = "branchComboBox";
            this.branchComboBox.Size = new System.Drawing.Size(202, 24);
            this.branchComboBox.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 202);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(452, 28);
            this.button2.TabIndex = 29;
            this.button2.Text = "حفظ و جلب البيانات";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 599);
            this.Controls.Add(this.posGroup);
            this.Controls.Add(this.connectionGroupBox);
            this.Controls.Add(this.buttonsPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "settingsForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "الإعدادات";
            this.Load += new System.EventHandler(this.settingsForm_Load);
            this.buttonsPanel.ResumeLayout(false);
            this.connectionGroupBox.ResumeLayout(false);
            this.connectionGroupBox.PerformLayout();
            this.posGroup.ResumeLayout(false);
            this.posGroup.PerformLayout();
            this.priceTypeGroupBox.ResumeLayout(false);
            this.priceTypeGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.GroupBox connectionGroupBox;
        private System.Windows.Forms.Button testConnectionButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sqlPasswordTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sqlUserTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sqlServerTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox databaseComboBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button loadDatabasesButton;
        private System.Windows.Forms.GroupBox posGroup;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox dtiComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox bliComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox branchComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox salesManComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox userComboBox;
        private System.Windows.Forms.CheckBox additionallPricesCheckBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox currencyComboBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox additionallPricesComboBox;
        private System.Windows.Forms.GroupBox priceTypeGroupBox;
        private System.Windows.Forms.RadioButton clearanceRadioButton;
        private System.Windows.Forms.RadioButton saleRadioButton;
        private System.Windows.Forms.RadioButton endUserRadioButton;
        private System.Windows.Forms.RadioButton specialRadioButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox printersComboBox;
        private System.Windows.Forms.Button button2;
    }
}