namespace MortgageCalculator
{
    partial class mainWindow
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
            this.principal = new System.Windows.Forms.Label();
            this.interestRate = new System.Windows.Forms.Label();
            this.amortPd = new System.Windows.Forms.Label();
            this.principalBox = new System.Windows.Forms.TextBox();
            this.interestRateBox = new System.Windows.Forms.TextBox();
            this.paymentFreqBox = new System.Windows.Forms.TextBox();
            this.amortPdBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.percent = new System.Windows.Forms.Label();
            this.paymentFreq = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // principal
            // 
            this.principal.AutoSize = true;
            this.principal.Location = new System.Drawing.Point(27, 29);
            this.principal.Name = "principal";
            this.principal.Size = new System.Drawing.Size(68, 20);
            this.principal.TabIndex = 0;
            this.principal.Text = "Principal";
            // 
            // interestRate
            // 
            this.interestRate.AutoSize = true;
            this.interestRate.Location = new System.Drawing.Point(27, 109);
            this.interestRate.Name = "interestRate";
            this.interestRate.Size = new System.Drawing.Size(103, 20);
            this.interestRate.TabIndex = 2;
            this.interestRate.Text = "Interest Rate";
            // 
            // amortPd
            // 
            this.amortPd.AutoSize = true;
            this.amortPd.Location = new System.Drawing.Point(27, 149);
            this.amortPd.Name = "amortPd";
            this.amortPd.Size = new System.Drawing.Size(147, 20);
            this.amortPd.TabIndex = 3;
            this.amortPd.Text = "Amortization Period";
            // 
            // principalBox
            // 
            this.principalBox.Location = new System.Drawing.Point(219, 26);
            this.principalBox.Name = "principalBox";
            this.principalBox.Size = new System.Drawing.Size(170, 26);
            this.principalBox.TabIndex = 6;
            // 
            // interestRateBox
            // 
            this.interestRateBox.Location = new System.Drawing.Point(219, 106);
            this.interestRateBox.Name = "interestRateBox";
            this.interestRateBox.Size = new System.Drawing.Size(170, 26);
            this.interestRateBox.TabIndex = 7;
            // 
            // paymentFreqBox
            // 
            this.paymentFreqBox.Location = new System.Drawing.Point(219, 66);
            this.paymentFreqBox.Name = "paymentFreqBox";
            this.paymentFreqBox.Size = new System.Drawing.Size(170, 26);
            this.paymentFreqBox.TabIndex = 8;
            // 
            // amortPdBox
            // 
            this.amortPdBox.Location = new System.Drawing.Point(219, 146);
            this.amortPdBox.Name = "amortPdBox";
            this.amortPdBox.Size = new System.Drawing.Size(170, 26);
            this.amortPdBox.TabIndex = 9;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(283, 226);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(106, 42);
            this.calculateButton.TabIndex = 10;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // percent
            // 
            this.percent.AutoSize = true;
            this.percent.Location = new System.Drawing.Point(389, 109);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(23, 20);
            this.percent.TabIndex = 11;
            this.percent.Text = "%";
            // 
            // paymentFreq
            // 
            this.paymentFreq.AutoSize = true;
            this.paymentFreq.Location = new System.Drawing.Point(27, 69);
            this.paymentFreq.Name = "paymentFreq";
            this.paymentFreq.Size = new System.Drawing.Size(150, 20);
            this.paymentFreq.TabIndex = 1;
            this.paymentFreq.Text = "Payment Frequency";
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(219, 186);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(170, 26);
            this.output.TabIndex = 12;
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 304);
            this.Controls.Add(this.output);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.amortPdBox);
            this.Controls.Add(this.paymentFreqBox);
            this.Controls.Add(this.interestRateBox);
            this.Controls.Add(this.principalBox);
            this.Controls.Add(this.amortPd);
            this.Controls.Add(this.interestRate);
            this.Controls.Add(this.paymentFreq);
            this.Controls.Add(this.principal);
            this.Name = "mainWindow";
            this.Text = "Mortgage Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label principal;
        private System.Windows.Forms.Label interestRate;
        private System.Windows.Forms.Label amortPd;
        private System.Windows.Forms.TextBox principalBox;
        private System.Windows.Forms.TextBox interestRateBox;
        private System.Windows.Forms.TextBox paymentFreqBox;
        private System.Windows.Forms.TextBox amortPdBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label percent;
        private System.Windows.Forms.Label paymentFreq;
        private System.Windows.Forms.TextBox output;
    }
}

