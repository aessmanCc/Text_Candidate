
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Email_Canidates
{
    public partial class frmEmailCanidate : Form
    {
        public frmEmailCanidate()
        {
            InitializeComponent();
        }

        private Email email = null;

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                SmtpClient setup = new SmtpClient("YourSMTPService")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("YourEmail", "YourPassword"),
                    EnableSsl = true
                };
                
                email = new Email(txtcanidateName.Text, long.Parse(txtcanidateNumber.Text), txtuserMessage.Text, Convert.ToString(cboWirelessProvider.SelectedItem));

                MailMessage message = new MailMessage
                {
                    From = new MailAddress("YourEmail"),
                    Body = "Hello,  " + email.CanidateName + "." + "\n " + email.UserMessage + "\n" + "<<<DO NOT REPLY TO THIS MESSAGE>>>"
                };

                message.To.Add(Convert.ToString(email.CanidateNumber)+email.PhoneProvider);
                setup.Send(message);
            }
        }

        //All data validation.
        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";

            errorMessage += Validator.IsPresent(txtcanidateName.Text, txtcanidateName.Tag.ToString());
            errorMessage += Validator.IsPresent(txtuserMessage.Text, txtuserMessage.Tag.ToString());
            errorMessage += Validator.IsInt32(txtcanidateNumber.Text, txtcanidateNumber.Tag.ToString());
            errorMessage += Validator.IsWithinRange(txtcanidateNumber.Text, txtcanidateNumber.Text, 1000000000, 9999999999);
            errorMessage += Validator.PhoneProvider(cboWirelessProvider.SelectedIndex, cboWirelessProvider.Tag.ToString());


            //Display error messages.
            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
            }
            return success;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

        }
    }
}
