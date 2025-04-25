namespace StudentGradeApp
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
            groupBox1 = new GroupBox();
            btnAddGrade = new Button();
            txtTest3 = new TextBox();
            txtTest2 = new TextBox();
            txtTest1 = new TextBox();
            txtStudentName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            rbnLetter = new RadioButton();
            rbnNumeric = new RadioButton();
            lstResults = new ListBox();
            label5 = new Label();
            lblClassAverage = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAddGrade);
            groupBox1.Controls.Add(txtTest3);
            groupBox1.Controls.Add(txtTest2);
            groupBox1.Controls.Add(txtTest1);
            groupBox1.Controls.Add(txtStudentName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(15, 15);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(409, 258);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Input Grades";
            // 
            // btnAddGrade
            // 
            btnAddGrade.Location = new Point(258, 214);
            btnAddGrade.Name = "btnAddGrade";
            btnAddGrade.Size = new Size(122, 27);
            btnAddGrade.TabIndex = 8;
            btnAddGrade.Text = "Add Grade";
            btnAddGrade.UseVisualStyleBackColor = true;
            btnAddGrade.Click += btnAddGrade_Click;
            // 
            // txtTest3
            // 
            txtTest3.Location = new Point(258, 170);
            txtTest3.Name = "txtTest3";
            txtTest3.Size = new Size(122, 30);
            txtTest3.TabIndex = 7;
            // 
            // txtTest2
            // 
            txtTest2.Location = new Point(258, 131);
            txtTest2.Name = "txtTest2";
            txtTest2.Size = new Size(122, 30);
            txtTest2.TabIndex = 6;
            // 
            // txtTest1
            // 
            txtTest1.Location = new Point(258, 90);
            txtTest1.Name = "txtTest1";
            txtTest1.Size = new Size(122, 30);
            txtTest1.TabIndex = 5;
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(162, 43);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(218, 30);
            txtStudentName.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 178);
            label4.Name = "label4";
            label4.Size = new Size(69, 23);
            label4.TabIndex = 3;
            label4.Text = "Text 3:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 98);
            label3.Name = "label3";
            label3.Size = new Size(68, 23);
            label3.TabIndex = 2;
            label3.Text = "Test 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 139);
            label2.Name = "label2";
            label2.Size = new Size(68, 23);
            label2.TabIndex = 1;
            label2.Text = "Test 2:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 43);
            label1.Name = "label1";
            label1.Size = new Size(150, 23);
            label1.TabIndex = 0;
            label1.Text = "Student's Name:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbnLetter);
            groupBox2.Controls.Add(rbnNumeric);
            groupBox2.Location = new Point(15, 292);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(409, 57);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "View";
            // 
            // rbnLetter
            // 
            rbnLetter.AutoSize = true;
            rbnLetter.Checked = true;
            rbnLetter.Location = new Point(57, 17);
            rbnLetter.Name = "rbnLetter";
            rbnLetter.Size = new Size(84, 28);
            rbnLetter.TabIndex = 10;
            rbnLetter.TabStop = true;
            rbnLetter.Text = "Letter";
            rbnLetter.UseVisualStyleBackColor = true;
            rbnLetter.CheckedChanged += rbnLetter_CheckedChanged;
            // 
            // rbnNumeric
            // 
            rbnNumeric.AutoSize = true;
            rbnNumeric.Location = new Point(240, 17);
            rbnNumeric.Name = "rbnNumeric";
            rbnNumeric.Size = new Size(104, 28);
            rbnNumeric.TabIndex = 11;
            rbnNumeric.Text = "Numeric";
            rbnNumeric.UseVisualStyleBackColor = true;
            rbnNumeric.CheckedChanged += rbnNumeric_CheckedChanged;
            // 
            // lstResults
            // 
            lstResults.FormattingEnabled = true;
            lstResults.Location = new Point(454, 24);
            lstResults.Name = "lstResults";
            lstResults.Size = new Size(250, 316);
            lstResults.TabIndex = 12;
            lstResults.SelectedIndexChanged += lstResults_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(454, 377);
            label5.Name = "label5";
            label5.Size = new Size(142, 24);
            label5.TabIndex = 13;
            label5.Text = "Class Average:";
            // 
            // lblClassAverage
            // 
            lblClassAverage.BorderStyle = BorderStyle.FixedSingle;
            lblClassAverage.Location = new Point(582, 372);
            lblClassAverage.Name = "lblClassAverage";
            lblClassAverage.Size = new Size(119, 30);
            lblClassAverage.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 460);
            Controls.Add(lblClassAverage);
            Controls.Add(label5);
            Controls.Add(lstResults);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnAddGrade;
        private TextBox txtTest3;
        private TextBox txtTest2;
        private TextBox txtTest1;
        private TextBox txtStudentName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private RadioButton rbnLetter;
        private RadioButton rbnNumeric;
        private ListBox lstResults;
        private Label label5;
        private Label lblClassAverage;
    }
}
