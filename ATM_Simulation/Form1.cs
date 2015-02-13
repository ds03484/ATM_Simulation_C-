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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtCardNumber.MaxLength = 16;
            txtPIN.MaxLength = 10;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //checks if the card type is selected
            bool ValidCard = false;
            if (DebitRbtn.Checked || CreditRbtn.Checked == true)
            {
                Errorlbl.Visible = false;
                ValidCard = true;
            }
            else
            {
                Errorlbl.Visible = true;
                ValidCard = false;
            }

            //check card number
            bool ValidNumber = false;
            try
            {
                long cardNumber = 0;
                if (txtCardNumber.Text.Length == 16)
                {
                    CardErrorlbl.Visible = false;
                    cardNumber = Convert.ToInt64(txtCardNumber.Text);
                    ValidNumber = true;
                }
                else if (txtCardNumber.Text.Length < 16)
                {
                    CardErrorlbl.Visible = true;
                }
                else
                {
                    ValidNumber = false;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("The Card Number was not in the correct format, enter numbers only!");
            }

            bool cont = ValidCard && ValidNumber;
            if (cont == true)
            {
                PINlbl.Visible = true;
                txtPIN.Visible = true;
                button2.Visible = true;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool ValidPIN = false;
            try
            {
                int PIN = 0;
                if (txtPIN.Text.Length >= 4 && txtPIN.Text.Length <= 10)
                {
                    PINErrorlbl.Visible = false;
                    PIN = Convert.ToInt32(txtPIN.Text);
                    ValidPIN = true;
                }
                else if (txtPIN.Text.Length < 4)
                {
                    PINErrorlbl.Visible = true;
                }
                else
                {
                    ValidPIN = false;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("The PIN Number was not in the correct format, enter numbers only!");
            }

            if (ValidPIN == true)
            {
                this.Hide();
                Form2 form = new Form2();
                form.Show();
            }
        }
    }
}
