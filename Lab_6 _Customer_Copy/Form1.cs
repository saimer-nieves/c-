using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab_6;
using Lab_5_Midterm;

namespace Lab_5_Midterm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_person_Click(object sender, EventArgs e) // this is the property that takes action once you click on something
        {
            //This is the label name
            

            Customer temp = new Customer();
            
            


            
            temp.First_name = txtfirst_name.Text;
            temp.Middle_name = txtmiddle_name.Text;
            temp.Last_name = txtlast_name.Text;
            temp.Street_1 = txtstreet_1.Text;
            temp.Street_2 = txtstreet_2.Text;
            temp.City = txtcity.Text;
            temp.State = txtstate.Text;
            temp.Zip_code = txtzip_code.Text;
            temp.Phone_number = txtphone.Text;
            temp.Cell_phone = txtCell_Phone.Text;
            temp.Email_address = txtemail.Text;
            temp.InstagramURL = txtInstagramURL.Text;
            
            bool discountMember = chkdiscount_member.Checked;
            //MessageBox.Show(discountMember.ToString());

            temp.CustomerSince = dtpcustomer_since.Value;

            //double dblTotal_purchases;
           // if (Double.TryParse(txttotal_purchases.Text, out dblTotal_purchases) == true)
            //{
              //  temp.TotalPurchases = dblTotal_purchases;
            //}
           // else 
           // {
             //  // temp.TotalPurchases = 0;
              //  temp.Feedback += "INVALID: ERROR: Total purchases price was not accepted please type in the right format";
            //
          //  }
           // temp.RewardsEarned = Convert.ToInt32(numlistRewards.Value);
            

            
           

          

            if (temp.Feedback.Contains("INVALID: "))
            {
                lblFeedBack.Text = temp.Feedback;

            }


            else
            {
                lblFeedBack.Text = temp.AddARecord();
               
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        
        private void numlist_totalpurchases_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void txttotal_purchases_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && e.KeyChar != '-' && ch != 8)//keys allow only digit backspace, delete and dash
            {
                e.Handled = true;
            }
        }

        private void txtCell_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && e.KeyChar != '-' && ch != 8)//keys allow only digit backspace, delete and dash
            {
                e.Handled = true;
            }
        }

        private void txttotal_purchases_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && e.KeyChar != '.')//keys allow only digit backspace, delete and dash
            {
                e.Handled = true;
            }
        }

        private void txtzip_code_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)//keys allow only digit backspace, delete and dash
            {
                e.Handled = true;
            }
        }

        private void txtstate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
