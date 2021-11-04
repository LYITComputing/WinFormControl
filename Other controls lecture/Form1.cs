using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Other_controls_lecture
{
    
    public partial class frmPayment : Form
    {
        double amountDue = 0.0;

        List<String> ListCardTypes = new List<string>();

        public frmPayment()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Configure the controls
            //Set amount due to 
            txtAmountDue.Text = amountDue.ToString();
            cmbMonths.SelectedIndex = 0;
            //Add next five years to the years combo box
            int year = DateTime.Now.Year;
            for (int i = 0; i < 5; ++i)
            {
                //Get current year
                cmbYears.Items.Add(year);
                year++;  
            }
            cmbYears.SelectedIndex = 0;

            ////Initialise the list of card types by code
            //ListCardTypes.Add("Visa");
            //ListCardTypes.Add("Visa Debit");
            //ListCardTypes.Add("Mastercard");
            //ListCardTypes.Add("Americian Express");
            //lstCad=rds.Items.Clear();
            //foreach (String card in ListCardTypes)
            //{
            //    lstCards.Items.Add(card);
            //}
            
        }

        private void radCreditCard_CheckedChanged(object sender, EventArgs e)
        {
            grpCCInfo.Enabled = true;
            txtAmountDue_Validating(this, null);
            ClearCardInfo();
            //          lblPayMethod.Text = lstCards.SelectedItem.ToString();
        }

        private void ClearCardInfo()
        {
            lstCards.SelectedIndex = -1;
            cmbYears.SelectedIndex = -1;
            cmbMonths.SelectedIndex = -1;
            this.txtCreditCard.Text = "";
        }

        private void radBillCust_CheckedChanged(object sender, EventArgs e)
        {
            grpCCInfo.Enabled = false;
            txtAmountDue_Validating(this, null);
            lblPayMethod.Text = "Cash";
            lstCards.SelectedIndex = -1;
        }

        private void txtAmountDue_Validating(object sender, CancelEventArgs e)
        {
            //Check to see if the input is a number
            try
            {
                amountDue = double.Parse(txtAmountDue.Text);
                txtAmountDue.ForeColor = Color.Black;
                //Calculate cash discount
                if (rdoCash.Checked)
                {
                    double discount = amountDue * 0.1;
                    txtDiscount.Text = discount.ToString();
                    txtTotalDue.Text = (amountDue - discount).ToString();
                }
                else
                {
                    txtDiscount.Text = " ";
                    txtTotalDue.Text = amountDue.ToString();
                }
            }
            catch
            {
                txtDiscount.Text = " ";
                txtTotalDue.Text = " ";
                txtAmountDue.ForeColor = Color.Red;
                MessageBox.Show("Amount due must be a positive number");
            }


            //bool result;
            //if (result = double.TryParse(this.txtAmountDue.Text, out amountDue))
            //{
            //    txtAmountDue.ForeColor = Color.Black;
            //    if (rdoCash.Checked)
            //    {
            //        double discount = amountDue * 0.1;
            //        txtDiscount.Text = discount.ToString();
            //        txtTotalDue.Text = (amountDue - discount).ToString();
            //    }
            //    else
            //    {
            //        txtDiscount.Text = " ";
            //        txtTotalDue.Text = amountDue.ToString();
            //    }

            //}
            //else
            //{
            //    txtDiscount.Text = " ";
            //    txtTotalDue.Text = " ";
            //    txtAmountDue.ForeColor = Color.Red;
            //    MessageBox.Show("Amount due must be a positive number");
            //}


        }

        private void lstCards_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.rdoCreditCard.Checked == true)
            {
                lblPayMethod.Text = lstCards.SelectedItem.ToString();
            }
            
        }

        private void txtCreditCard_Validating(object sender, CancelEventArgs e)
        {
           bool validCardNumber = IsCreditCardInfoValid(this.txtCreditCard.Text, "05/2021", "332");
           if (!validCardNumber)
            {
                MessageBox.Show("We please enter valid card information");
                //The message should be more fine grained than this!
            }
        }

        public static bool IsCreditCardInfoValid(string cardNo, string expiryDate, string cvv)
        {
       
            //From : https://stackoverflow.com/questions/32959273/c-sharp-validating-user-input-like-a-credit-card-number
            //Define a regex specifying valid start numbers for the credit card
            var cardCheck = new Regex(@"^(1298|4319|4618|4567|8901|8933)([\-\s]?[0-9]{4}){3}$");
            var monthCheck = new Regex(@"^(0[1-9]|1[0-2])$");
            var yearCheck = new Regex(@"^20[0-9]{2}$");
            var cvvCheck = new Regex(@"^\d{3}$");

            if (!cardCheck.IsMatch(cardNo)) // <1>check card number is valid
                return false;
            if (!cvvCheck.IsMatch(cvv)) // <2>check cvv is valid as "999"
                return false;

            var dateParts = expiryDate.Split('/'); //expiry date in from MM/yyyy            
            if (!monthCheck.IsMatch(dateParts[0]) || !yearCheck.IsMatch(dateParts[1])) // <3 - 6>
                return false; // ^ check date format is valid as "MM/yyyy"

            var year = int.Parse(dateParts[1]);
            var month = int.Parse(dateParts[0]);
            var lastDateOfExpiryMonth = DateTime.DaysInMonth(year, month); //get actual expiry date
            var cardExpiry = new DateTime(year, month, lastDateOfExpiryMonth, 23, 59, 59);

            //check expiry greater than today & within next 6 years <7, 8>>
            return (cardExpiry > DateTime.Now && cardExpiry < DateTime.Now.AddYears(6));
        }

        private void txtAmountDue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtAmountDue_Validating(this, null);
            }
        }

        private void txtAmountDue_Leave(object sender, EventArgs e)
        {
            txtAmountDue_Validating(this, null);
        }
    }
}
