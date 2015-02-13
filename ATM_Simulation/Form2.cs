using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Simulation
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The balance for this account is " + GlobalVariables.balance);
            LogOut();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FastCashlbl.Visible = true;
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            btnProceed.Visible = true;
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            double amount = 0.0;
            var checkedRadiobutton = this.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(rb => rb.Checked);

            //check which radio button is checked
            if (checkedRadiobutton != null)
            {
                switch (checkedRadiobutton.Name)
                {
                    case "radioButton1":
                        amount = Convert.ToDouble(radioButton1.Text);
                        break;
                    case "radioButton2":
                        amount = Convert.ToDouble(radioButton2.Text);
                        break;
                    case "radioButton3":
                        amount = Convert.ToDouble(radioButton3.Text);
                        break;
                }
            }
            //update the balance
            GlobalVariables.balance = GlobalVariables.balance - amount;
            MessageBox.Show("The amount you withdrew is " + amount+ "\n The new balance is " + GlobalVariables.balance);
            LogOut();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Amountlbl.Visible = true;
            txtAmount.Visible = true;
            btnConfirm.Visible = true;
            FastCashlbl.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            btnProceed.Visible = false;
        }

        //go back to main page
        public void LogOut()
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                double withdraw = Convert.ToDouble(txtAmount.Text);
                if (withdraw > 0 && withdraw % 20 == 0)
                {
                    if (withdraw <= 1000)
                    {
                        GlobalVariables.balance = GlobalVariables.balance - withdraw;
                        MessageBox.Show("The amount you withdrew is " + withdraw + "\n The new balance is " + GlobalVariables.balance);
                        LogOut();
                    }
                    else if (withdraw > 1000)
                    {
                        HighAmoutErrorlbl.Visible = true;
                    }
                }
                else
                {
                    AmountErrorlbl.Visible = true;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("The amount entered was not in the correct format, enter numbers only!");
            }
        }
    }
}
