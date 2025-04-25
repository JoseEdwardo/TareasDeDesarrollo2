namespace Flags
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
            comboBoxCountries = new ComboBox();
            groupBox1 = new GroupBox();
            pictureBoxFlag = new PictureBox();
            label1 = new Label();
            buttonSubmit = new Button();
            buttonNext = new Button();
            labelResult = new Label();
            textBoxFinalResult = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFlag).BeginInit();
            SuspendLayout();
            // 
            // comboBoxCountries
            // 
            comboBoxCountries.FormattingEnabled = true;
            comboBoxCountries.Location = new Point(286, 83);
            comboBoxCountries.Name = "comboBoxCountries";
            comboBoxCountries.Size = new Size(160, 28);
            comboBoxCountries.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBoxFlag);
            groupBox1.Location = new Point(12, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 158);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Flag";
            // 
            // pictureBoxFlag
            // 
            pictureBoxFlag.Location = new Point(6, 26);
            pictureBoxFlag.Name = "pictureBoxFlag";
            pictureBoxFlag.Size = new Size(226, 114);
            pictureBoxFlag.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxFlag.TabIndex = 0;
            pictureBoxFlag.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(286, 42);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 2;
            label1.Text = "Select Country:";
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(480, 42);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(133, 29);
            buttonSubmit.TabIndex = 3;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += button1_Click;
            // 
            // buttonNext
            // 
            buttonNext.Location = new Point(480, 102);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(133, 29);
            buttonNext.TabIndex = 4;
            buttonNext.Text = "Next Flag";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += buttonNext_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.BorderStyle = BorderStyle.FixedSingle;
            labelResult.Location = new Point(277, 140);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(171, 42);
            labelResult.TabIndex = 5;
            labelResult.Text = "                                        \r\n\r\n";
            // 
            // textBoxFinalResult
            // 
            textBoxFinalResult.AutoSize = true;
            textBoxFinalResult.BorderStyle = BorderStyle.FixedSingle;
            textBoxFinalResult.Location = new Point(480, 160);
            textBoxFinalResult.Name = "textBoxFinalResult";
            textBoxFinalResult.Size = new Size(135, 22);
            textBoxFinalResult.TabIndex = 6;
            textBoxFinalResult.Text = "                               \r\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 196);
            Controls.Add(textBoxFinalResult);
            Controls.Add(labelResult);
            Controls.Add(buttonNext);
            Controls.Add(buttonSubmit);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(comboBoxCountries);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxFlag).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxCountries;
        private GroupBox groupBox1;
        private PictureBox pictureBoxFlag;
        private Label label1;
        private Button buttonSubmit;
        private Button buttonNext;
        private Label labelResult;
        private Label textBoxFinalResult;
    }
}
