namespace ATM_Simulation
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.btnProceed = new System.Windows.Forms.Button();
            this.FastCashlbl = new System.Windows.Forms.Label();
            this.Amountlbl = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.AmountErrorlbl = new System.Windows.Forms.Label();
            this.HighAmoutErrorlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 69);
            this.button1.TabIndex = 0;
            this.button1.Text = "Withdraw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(181, 122);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 69);
            this.button2.TabIndex = 1;
            this.button2.Text = "Fast Cash";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(338, 122);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 69);
            this.button3.TabIndex = 2;
            this.button3.Text = "Balance Inquiry";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(138, 256);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(45, 21);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "25";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Visible = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(200, 256);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(45, 21);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "60";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Visible = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(251, 256);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(53, 21);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "100";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Visible = false;
            // 
            // btnProceed
            // 
            this.btnProceed.Location = new System.Drawing.Point(310, 256);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(86, 31);
            this.btnProceed.TabIndex = 6;
            this.btnProceed.Text = "Proceed";
            this.btnProceed.UseVisualStyleBackColor = true;
            this.btnProceed.Visible = false;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // FastCashlbl
            // 
            this.FastCashlbl.AutoSize = true;
            this.FastCashlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FastCashlbl.Location = new System.Drawing.Point(117, 210);
            this.FastCashlbl.Name = "FastCashlbl";
            this.FastCashlbl.Size = new System.Drawing.Size(252, 25);
            this.FastCashlbl.TabIndex = 7;
            this.FastCashlbl.Text = "Select the fast cash amount";
            this.FastCashlbl.Visible = false;
            // 
            // Amountlbl
            // 
            this.Amountlbl.AutoSize = true;
            this.Amountlbl.Location = new System.Drawing.Point(23, 296);
            this.Amountlbl.Name = "Amountlbl";
            this.Amountlbl.Size = new System.Drawing.Size(235, 17);
            this.Amountlbl.TabIndex = 8;
            this.Amountlbl.Text = "Enter amount must be multiple of 20";
            this.Amountlbl.Visible = false;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(264, 296);
            this.txtAmount.MaxLength = 4;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 22);
            this.txtAmount.TabIndex = 9;
            this.txtAmount.Visible = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(370, 293);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 25);
            this.btnConfirm.TabIndex = 10;
            this.btnConfirm.Text = "confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Visible = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // AmountErrorlbl
            // 
            this.AmountErrorlbl.AutoSize = true;
            this.AmountErrorlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountErrorlbl.ForeColor = System.Drawing.Color.Red;
            this.AmountErrorlbl.Location = new System.Drawing.Point(133, 337);
            this.AmountErrorlbl.Name = "AmountErrorlbl";
            this.AmountErrorlbl.Size = new System.Drawing.Size(231, 20);
            this.AmountErrorlbl.TabIndex = 11;
            this.AmountErrorlbl.Text = "Amount is not a multiple of 20";
            this.AmountErrorlbl.Visible = false;
            // 
            // HighAmoutErrorlbl
            // 
            this.HighAmoutErrorlbl.AutoSize = true;
            this.HighAmoutErrorlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighAmoutErrorlbl.ForeColor = System.Drawing.Color.Red;
            this.HighAmoutErrorlbl.Location = new System.Drawing.Point(119, 370);
            this.HighAmoutErrorlbl.Name = "HighAmoutErrorlbl";
            this.HighAmoutErrorlbl.Size = new System.Drawing.Size(314, 20);
            this.HighAmoutErrorlbl.TabIndex = 12;
            this.HighAmoutErrorlbl.Text = "Only withdraw up to 1000 per transaction";
            this.HighAmoutErrorlbl.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 436);
            this.Controls.Add(this.HighAmoutErrorlbl);
            this.Controls.Add(this.AmountErrorlbl);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.Amountlbl);
            this.Controls.Add(this.FastCashlbl);
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.Label FastCashlbl;
        private System.Windows.Forms.Label Amountlbl;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label AmountErrorlbl;
        private System.Windows.Forms.Label HighAmoutErrorlbl;
    }
}