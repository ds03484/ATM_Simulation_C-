namespace ATM_Simulation
{
    partial class Form1
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
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.CreditRbtn = new System.Windows.Forms.RadioButton();
            this.DebitRbtn = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.PINlbl = new System.Windows.Forms.Label();
            this.txtPIN = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Errorlbl = new System.Windows.Forms.Label();
            this.CardErrorlbl = new System.Windows.Forms.Label();
            this.PINErrorlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(21, 118);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(216, 22);
            this.txtCardNumber.TabIndex = 0;
            // 
            // CreditRbtn
            // 
            this.CreditRbtn.AutoSize = true;
            this.CreditRbtn.Location = new System.Drawing.Point(21, 78);
            this.CreditRbtn.Name = "CreditRbtn";
            this.CreditRbtn.Size = new System.Drawing.Size(98, 21);
            this.CreditRbtn.TabIndex = 1;
            this.CreditRbtn.TabStop = true;
            this.CreditRbtn.Text = "Credit card";
            this.CreditRbtn.UseVisualStyleBackColor = true;
            // 
            // DebitRbtn
            // 
            this.DebitRbtn.AutoSize = true;
            this.DebitRbtn.Location = new System.Drawing.Point(143, 78);
            this.DebitRbtn.Name = "DebitRbtn";
            this.DebitRbtn.Size = new System.Drawing.Size(94, 21);
            this.DebitRbtn.TabIndex = 2;
            this.DebitRbtn.TabStop = true;
            this.DebitRbtn.Text = "Debit card";
            this.DebitRbtn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Check card number";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PINlbl
            // 
            this.PINlbl.AutoSize = true;
            this.PINlbl.Location = new System.Drawing.Point(18, 290);
            this.PINlbl.Name = "PINlbl";
            this.PINlbl.Size = new System.Drawing.Size(102, 17);
            this.PINlbl.TabIndex = 4;
            this.PINlbl.Text = "Enter Your PIN";
            this.PINlbl.Visible = false;
            // 
            // txtPIN
            // 
            this.txtPIN.Location = new System.Drawing.Point(126, 285);
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.Size = new System.Drawing.Size(124, 22);
            this.txtPIN.TabIndex = 5;
            this.txtPIN.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(256, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(369, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select a card type and enter card number";
            // 
            // Errorlbl
            // 
            this.Errorlbl.AutoSize = true;
            this.Errorlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Errorlbl.ForeColor = System.Drawing.Color.Red;
            this.Errorlbl.Location = new System.Drawing.Point(75, 34);
            this.Errorlbl.Name = "Errorlbl";
            this.Errorlbl.Size = new System.Drawing.Size(239, 25);
            this.Errorlbl.TabIndex = 8;
            this.Errorlbl.Text = "Select Debit or Credit card";
            this.Errorlbl.Visible = false;
            // 
            // CardErrorlbl
            // 
            this.CardErrorlbl.AutoSize = true;
            this.CardErrorlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardErrorlbl.ForeColor = System.Drawing.Color.Red;
            this.CardErrorlbl.Location = new System.Drawing.Point(17, 170);
            this.CardErrorlbl.Name = "CardErrorlbl";
            this.CardErrorlbl.Size = new System.Drawing.Size(241, 20);
            this.CardErrorlbl.TabIndex = 9;
            this.CardErrorlbl.Text = "Enter 16 digits for card number";
            this.CardErrorlbl.Visible = false;
            // 
            // PINErrorlbl
            // 
            this.PINErrorlbl.AutoSize = true;
            this.PINErrorlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PINErrorlbl.ForeColor = System.Drawing.Color.Red;
            this.PINErrorlbl.Location = new System.Drawing.Point(77, 242);
            this.PINErrorlbl.Name = "PINErrorlbl";
            this.PINErrorlbl.Size = new System.Drawing.Size(245, 20);
            this.PINErrorlbl.TabIndex = 10;
            this.PINErrorlbl.Text = "PIN must be at least 4 numbers";
            this.PINErrorlbl.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 425);
            this.Controls.Add(this.PINErrorlbl);
            this.Controls.Add(this.CardErrorlbl);
            this.Controls.Add(this.Errorlbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtPIN);
            this.Controls.Add(this.PINlbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DebitRbtn);
            this.Controls.Add(this.CreditRbtn);
            this.Controls.Add(this.txtCardNumber);
            this.Name = "Form1";
            this.Text = "Welcome to the E ATM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.RadioButton CreditRbtn;
        private System.Windows.Forms.RadioButton DebitRbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label PINlbl;
        private System.Windows.Forms.TextBox txtPIN;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Errorlbl;
        private System.Windows.Forms.Label CardErrorlbl;
        private System.Windows.Forms.Label PINErrorlbl;
    }
}

