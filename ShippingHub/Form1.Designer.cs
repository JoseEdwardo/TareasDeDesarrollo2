namespace ShippingHub
{
    partial class Form1
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
            label1 = new Label();
            labelArrivedAt = new Label();
            groupBox1 = new GroupBox();
            comboBoxState = new ComboBox();
            txtZip = new TextBox();
            label9 = new Label();
            label8 = new Label();
            txtCity = new TextBox();
            txtAddress = new TextBox();
            labelPackageID = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnBack = new Button();
            btnScanNew = new Button();
            btnAdd = new Button();
            btnRemove = new Button();
            btnEdit = new Button();
            btnNext = new Button();
            groupBox2 = new GroupBox();
            listBoxPackages = new ListBox();
            comboBoxFilterByState = new ComboBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 43);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 1;
            label1.Text = "Arrived at:";
            // 
            // labelArrivedAt
            // 
            labelArrivedAt.AutoSize = true;
            labelArrivedAt.BorderStyle = BorderStyle.FixedSingle;
            labelArrivedAt.Location = new Point(167, 43);
            labelArrivedAt.Name = "labelArrivedAt";
            labelArrivedAt.Size = new Size(215, 22);
            labelArrivedAt.TabIndex = 8;
            labelArrivedAt.Text = "                                                   ";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonFace;
            groupBox1.Controls.Add(comboBoxState);
            groupBox1.Controls.Add(txtZip);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtCity);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(labelPackageID);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(34, 110);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(594, 249);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Package Information";
            // 
            // comboBoxState
            // 
            comboBoxState.FormattingEnabled = true;
            comboBoxState.Location = new Point(300, 189);
            comboBoxState.Name = "comboBoxState";
            comboBoxState.Size = new Size(94, 28);
            comboBoxState.TabIndex = 16;
            // 
            // txtZip
            // 
            txtZip.Location = new Point(477, 190);
            txtZip.Name = "txtZip";
            txtZip.Size = new Size(91, 27);
            txtZip.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(425, 197);
            label9.Name = "label9";
            label9.Size = new Size(34, 20);
            label9.TabIndex = 14;
            label9.Text = "Zip:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(248, 197);
            label8.Name = "label8";
            label8.Size = new Size(46, 20);
            label8.TabIndex = 12;
            label8.Text = "State:";
            label8.Click += label8_Click;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(121, 194);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(104, 27);
            txtCity.TabIndex = 11;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(133, 125);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(435, 27);
            txtAddress.TabIndex = 10;
            // 
            // labelPackageID
            // 
            labelPackageID.AutoSize = true;
            labelPackageID.BorderStyle = BorderStyle.FixedSingle;
            labelPackageID.Location = new Point(133, 60);
            labelPackageID.Name = "labelPackageID";
            labelPackageID.Size = new Size(435, 22);
            labelPackageID.TabIndex = 9;
            labelPackageID.Text = "                                                                                                          ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 197);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 4;
            label4.Text = "City:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 60);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 3;
            label3.Text = "Package ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 125);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 2;
            label2.Text = "Address:";
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(34, 399);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 10;
            btnBack.Text = "<B̲ACK";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnScanNew
            // 
            btnScanNew.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnScanNew.Location = new Point(134, 399);
            btnScanNew.Name = "btnScanNew";
            btnScanNew.Size = new Size(94, 29);
            btnScanNew.TabIndex = 11;
            btnScanNew.Text = "S̲can";
            btnScanNew.UseVisualStyleBackColor = true;
            btnScanNew.Click += btnScanNew_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(234, 399);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "A̲dd";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemove.Location = new Point(334, 399);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 29);
            btnRemove.TabIndex = 13;
            btnRemove.Text = "R̲emove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(434, 399);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 14;
            btnEdit.Text = "E̲dit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNext.Location = new Point(534, 399);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 29);
            btnNext.TabIndex = 15;
            btnNext.Text = "N̲ext>";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ButtonFace;
            groupBox2.Controls.Add(listBoxPackages);
            groupBox2.Controls.Add(comboBoxFilterByState);
            groupBox2.Location = new Point(676, 110);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(281, 249);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Packages by State:";
            // 
            // listBoxPackages
            // 
            listBoxPackages.FormattingEnabled = true;
            listBoxPackages.Location = new Point(15, 91);
            listBoxPackages.Name = "listBoxPackages";
            listBoxPackages.Size = new Size(235, 144);
            listBoxPackages.TabIndex = 1;
            listBoxPackages.SelectedIndexChanged += listBoxPackages_SelectedIndexChanged;
            listBoxPackages.DoubleClick += listBoxPackages_DoubleClick;
            // 
            // comboBoxFilterByState
            // 
            comboBoxFilterByState.FormattingEnabled = true;
            comboBoxFilterByState.Location = new Point(15, 41);
            comboBoxFilterByState.Name = "comboBoxFilterByState";
            comboBoxFilterByState.Size = new Size(213, 28);
            comboBoxFilterByState.TabIndex = 0;
            comboBoxFilterByState.SelectedIndexChanged += comboBoxFilterByState_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(971, 450);
            Controls.Add(groupBox2);
            Controls.Add(btnNext);
            Controls.Add(btnEdit);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(btnScanNew);
            Controls.Add(btnBack);
            Controls.Add(groupBox1);
            Controls.Add(labelArrivedAt);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label labelArrivedAt;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtCity;
        private TextBox txtAddress;
        private Label labelPackageID;
        private TextBox txtZip;
        private Label label9;
        private Label label8;
        private Button btnBack;
        private ComboBox comboBoxState;
        private Button btnScanNew;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnEdit;
        private Button btnNext;
        private GroupBox groupBox2;
        private ListBox listBoxPackages;
        private ComboBox comboBoxFilterByState;
    }
}
