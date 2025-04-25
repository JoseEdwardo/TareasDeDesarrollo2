namespace Listas
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
            label2 = new Label();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            colorDialog1 = new ColorDialog();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(43, 37);
            label1.Name = "label1";
            label1.Size = new Size(140, 24);
            label1.TabIndex = 0;
            label1.Text = "Lista sin ordenar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(307, 37);
            label2.Name = "label2";
            label2.Size = new Size(125, 24);
            label2.TabIndex = 1;
            label2.Text = "Lista ordenada";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(43, 103);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(140, 224);
            listBox1.TabIndex = 2;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(307, 103);
            listBox2.Name = "listBox2";
            listBox2.SelectionMode = SelectionMode.MultiExtended;
            listBox2.Size = new Size(140, 224);
            listBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(43, 354);
            button1.Name = "button1";
            button1.Size = new Size(140, 29);
            button1.TabIndex = 4;
            button1.Text = "Añadir Elemento";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(43, 400);
            button2.Name = "button2";
            button2.Size = new Size(140, 29);
            button2.TabIndex = 5;
            button2.Text = "Borrar Elemento";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(43, 449);
            button3.Name = "button3";
            button3.Size = new Size(140, 29);
            button3.TabIndex = 6;
            button3.Text = "Borrar Lista ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(214, 156);
            button4.Name = "button4";
            button4.Size = new Size(53, 40);
            button4.TabIndex = 7;
            button4.Text = "<<";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(214, 235);
            button5.Name = "button5";
            button5.Size = new Size(53, 40);
            button5.TabIndex = 8;
            button5.Text = ">>";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(307, 449);
            button6.Name = "button6";
            button6.Size = new Size(140, 29);
            button6.TabIndex = 11;
            button6.Text = "Borrar Lista ";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(307, 400);
            button7.Name = "button7";
            button7.Size = new Size(140, 29);
            button7.TabIndex = 10;
            button7.Text = "Borrar Elementos";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(307, 354);
            button8.Name = "button8";
            button8.Size = new Size(140, 29);
            button8.TabIndex = 9;
            button8.Text = "Añadir Elemento";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 511);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Listas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox listBox1;
        private ListBox listBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private ColorDialog colorDialog1;
    }
}
