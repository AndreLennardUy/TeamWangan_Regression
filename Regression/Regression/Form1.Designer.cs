namespace Regression
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
            this.label1 = new System.Windows.Forms.Label();
            this.ageIn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.weightIn = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(56, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Regression Application";
            // 
            // ageIn
            // 
            this.ageIn.Location = new System.Drawing.Point(190, 154);
            this.ageIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ageIn.Name = "ageIn";
            this.ageIn.Size = new System.Drawing.Size(110, 23);
            this.ageIn.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Age:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(74, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Blood Pressure Predictor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(117, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Please enter age between 40 to 75.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(74, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(283, 39);
            this.label5.TabIndex = 6;
            this.label5.Text = "This is a convenient application for quickly estimating\r\nyour middle-aged/elderly" +
    " patient\'s blood pressure,\r\ngiven their age and weight in lbs.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(117, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Please enter weight in pounds (lbs).";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(100, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Enter Weight:";
            // 
            // weightIn
            // 
            this.weightIn.Location = new System.Drawing.Point(190, 200);
            this.weightIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.weightIn.Name = "weightIn";
            this.weightIn.Size = new System.Drawing.Size(110, 23);
            this.weightIn.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(139, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Result:";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(190, 281);
            this.result.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(110, 23);
            this.result.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 247);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 22);
            this.button1.TabIndex = 12;
            this.button1.Text = "Compute";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 328);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.weightIn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ageIn);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private TextBox ageIn;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox weightIn;
        private Label label8;
        private TextBox result;
        private Button button1;
    }
}