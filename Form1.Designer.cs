namespace Calculator_Application
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
            txtBoxInput1 = new TextBox();
            txtBoxInput2 = new TextBox();
            cbOperator = new ComboBox();
            btnEqual = new Button();
            lblDisplayTotal = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            checkedListBox1 = new CheckedListBox();
            SuspendLayout();
            // 
            // txtBoxInput1
            // 
            txtBoxInput1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxInput1.Location = new Point(199, 15);
            txtBoxInput1.Margin = new Padding(2);
            txtBoxInput1.Name = "txtBoxInput1";
            txtBoxInput1.Size = new Size(123, 29);
            txtBoxInput1.TabIndex = 0;
            // 
            // txtBoxInput2
            // 
            txtBoxInput2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxInput2.Location = new Point(199, 93);
            txtBoxInput2.Margin = new Padding(2);
            txtBoxInput2.Name = "txtBoxInput2";
            txtBoxInput2.Size = new Size(123, 29);
            txtBoxInput2.TabIndex = 1;
            // 
            // cbOperator
            // 
            cbOperator.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbOperator.FormattingEnabled = true;
            cbOperator.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cbOperator.Location = new Point(235, 55);
            cbOperator.Margin = new Padding(2);
            cbOperator.Name = "cbOperator";
            cbOperator.Size = new Size(54, 27);
            cbOperator.TabIndex = 2;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = Color.DarkSalmon;
            btnEqual.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEqual.Location = new Point(215, 162);
            btnEqual.Margin = new Padding(2);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(94, 26);
            btnEqual.TabIndex = 3;
            btnEqual.Text = "Calculate";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += btnEqual_Click;
            // 
            // lblDisplayTotal
            // 
            lblDisplayTotal.AutoSize = true;
            lblDisplayTotal.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDisplayTotal.Location = new Point(199, 131);
            lblDisplayTotal.Margin = new Padding(2, 0, 2, 0);
            lblDisplayTotal.Name = "lblDisplayTotal";
            lblDisplayTotal.Size = new Size(18, 19);
            lblDisplayTotal.TabIndex = 4;
            lblDisplayTotal.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(26, 21);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(160, 18);
            label1.TabIndex = 5;
            label1.Text = "Enter First number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(18, 101);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(168, 18);
            label2.TabIndex = 6;
            label2.Text = "Enter Second number:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(114, 131);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(72, 19);
            label3.TabIndex = 7;
            label3.Text = "Answer:";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(74, 212);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(8, 4);
            checkedListBox1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(346, 209);
            Controls.Add(checkedListBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblDisplayTotal);
            Controls.Add(btnEqual);
            Controls.Add(cbOperator);
            Controls.Add(txtBoxInput2);
            Controls.Add(txtBoxInput1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(2);
            Name = "Form1";
            Text = "FrmCalculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxInput1;
        private TextBox txtBoxInput2;
        private ComboBox cbOperator;
        private Button btnEqual;
        private Label lblDisplayTotal;
        private Label label1;
        private Label label2;
        private Label label3;
        private CheckedListBox checkedListBox1;
    }
}