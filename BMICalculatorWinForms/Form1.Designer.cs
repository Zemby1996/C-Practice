namespace BMICalculatorWinForms
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
            tbHeight = new TextBox();
            tbWeight = new TextBox();
            tbResult = new TextBox();
            cbHeight = new ComboBox();
            cbWeight = new ComboBox();
            label3 = new Label();
            btnCalculate = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(22, 82);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 0;
            label1.Text = "Height";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(19, 116);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 1;
            label2.Text = "Weight";
            // 
            // tbHeight
            // 
            tbHeight.Location = new Point(84, 79);
            tbHeight.Name = "tbHeight";
            tbHeight.Size = new Size(100, 23);
            tbHeight.TabIndex = 2;
            // 
            // tbWeight
            // 
            tbWeight.Location = new Point(85, 113);
            tbWeight.Name = "tbWeight";
            tbWeight.Size = new Size(100, 23);
            tbWeight.TabIndex = 3;
            // 
            // tbResult
            // 
            tbResult.Location = new Point(84, 200);
            tbResult.Name = "tbResult";
            tbResult.Size = new Size(153, 23);
            tbResult.TabIndex = 4;
            // 
            // cbHeight
            // 
            cbHeight.FormattingEnabled = true;
            cbHeight.Location = new Point(191, 79);
            cbHeight.Name = "cbHeight";
            cbHeight.Size = new Size(46, 23);
            cbHeight.TabIndex = 5;
            // 
            // cbWeight
            // 
            cbWeight.FormattingEnabled = true;
            cbWeight.Location = new Point(191, 113);
            cbWeight.Name = "cbWeight";
            cbWeight.Size = new Size(46, 23);
            cbWeight.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.Location = new Point(191, 51);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 7;
            label3.Text = "Unit";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(103, 149);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(72, 33);
            btnCalculate.TabIndex = 8;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label4.Location = new Point(25, 203);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 9;
            label4.Text = "Result";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 548);
            Controls.Add(label4);
            Controls.Add(btnCalculate);
            Controls.Add(label3);
            Controls.Add(cbWeight);
            Controls.Add(cbHeight);
            Controls.Add(tbResult);
            Controls.Add(tbWeight);
            Controls.Add(tbHeight);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbHeight;
        private TextBox tbWeight;
        private TextBox tbResult;
        private ComboBox cbHeight;
        private ComboBox cbWeight;
        private Label label3;
        private Button btnCalculate;
        private Label label4;
    }
}
