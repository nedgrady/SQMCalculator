namespace SQMCalculator
{
    partial class CalculatorVew
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.salaryText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.monthsText = new System.Windows.Forms.TextBox();
            this.bonusText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.AccessibleName = "Calculator Button";
            this.calculateButton.Location = new System.Drawing.Point(181, 33);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(92, 59);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculate Bonus";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // salaryText
            // 
            this.salaryText.AccessibleName = "Salary Input";
            this.salaryText.Location = new System.Drawing.Point(57, 35);
            this.salaryText.Name = "salaryText";
            this.salaryText.Size = new System.Drawing.Size(100, 20);
            this.salaryText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Salary:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Months:";
            // 
            // monthsText
            // 
            this.monthsText.AccessibleName = "Months Input";
            this.monthsText.Location = new System.Drawing.Point(57, 72);
            this.monthsText.Name = "monthsText";
            this.monthsText.Size = new System.Drawing.Size(100, 20);
            this.monthsText.TabIndex = 4;
            // 
            // bonusText
            // 
            this.bonusText.Location = new System.Drawing.Point(57, 132);
            this.bonusText.Name = "bonusText";
            this.bonusText.ReadOnly = true;
            this.bonusText.Size = new System.Drawing.Size(100, 20);
            this.bonusText.TabIndex = 5;
            // 
            // CalculatorVew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 223);
            this.Controls.Add(this.bonusText);
            this.Controls.Add(this.monthsText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salaryText);
            this.Controls.Add(this.calculateButton);
            this.Name = "CalculatorVew";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox salaryText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox monthsText;
        private System.Windows.Forms.TextBox bonusText;
    }
}

