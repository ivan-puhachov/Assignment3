namespace assignment3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.weightLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.weightText = new System.Windows.Forms.TextBox();
            this.heightText = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusText = new System.Windows.Forms.TextBox();
            this.bmiText = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(28, 35);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(88, 13);
            this.weightLabel.TabIndex = 0;
            this.weightLabel.Text = "Weight (pounds):";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(28, 61);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(81, 13);
            this.heightLabel.TabIndex = 1;
            this.heightLabel.Text = "Height (inches):";
            this.heightLabel.Click += new System.EventHandler(this.heightLabel_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calculateButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateButton.Location = new System.Drawing.Point(282, 61);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // weightText
            // 
            this.weightText.BackColor = System.Drawing.SystemColors.Window;
            this.weightText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weightText.Location = new System.Drawing.Point(151, 35);
            this.weightText.Name = "weightText";
            this.weightText.Size = new System.Drawing.Size(100, 20);
            this.weightText.TabIndex = 3;
            this.weightText.TextChanged += new System.EventHandler(this.weightText_TextChanged);
            // 
            // heightText
            // 
            this.heightText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.heightText.Location = new System.Drawing.Point(151, 61);
            this.heightText.Name = "heightText";
            this.heightText.Size = new System.Drawing.Size(100, 20);
            this.heightText.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.statusText);
            this.groupBox1.Controls.Add(this.bmiText);
            this.groupBox1.Location = new System.Drawing.Point(31, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 88);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // statusText
            // 
            this.statusText.BackColor = System.Drawing.SystemColors.Control;
            this.statusText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statusText.Location = new System.Drawing.Point(7, 39);
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(188, 13);
            this.statusText.TabIndex = 1;
            // 
            // bmiText
            // 
            this.bmiText.BackColor = System.Drawing.SystemColors.Control;
            this.bmiText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bmiText.Location = new System.Drawing.Point(7, 19);
            this.bmiText.Name = "bmiText";
            this.bmiText.Size = new System.Drawing.Size(188, 13);
            this.bmiText.TabIndex = 0;
            this.bmiText.TextChanged += new System.EventHandler(this.bmiText_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 225);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.heightText);
            this.Controls.Add(this.weightText);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.weightLabel);
            this.Name = "Form1";
            this.Text = "BMI Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox weightText;
        private System.Windows.Forms.TextBox heightText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox statusText;
        private System.Windows.Forms.TextBox bmiText;
    }
}

