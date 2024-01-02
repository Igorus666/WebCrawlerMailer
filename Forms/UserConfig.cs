using Igorus_Email_Bot.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Igorus_Email_Bot.Forms
{
    public partial class UserConfig : Form
    {
        private string errorSMTP;
        private string errorAPI;
        private SMTP_operations smtpOperations;

        public UserConfig()
        {       
            InitializeComponent();

            Country.Items.Add("US");
            Country.Items.Add("BR");
            Country.Items.Add("CA");

            FillSMTP();
            FillAPI();
            smtpOperations = new SMTP_operations();
        }


        public void SaveSMTP()
        {
            Properties.Settings.Default.host = SMTPhost.Text;
            Properties.Settings.Default.user = User.Text;
            Properties.Settings.Default.password = Password.Text;
            Properties.Settings.Default.port = int.Parse(Port.Text);
            Properties.Settings.Default.ssl = SSL.Checked;

            Properties.Settings.Default.Save();
        }
        public void SaveAPI()
        {
            Properties.Settings.Default.APIkey = APIkey.Text;
            Properties.Settings.Default.CXid = CXid.Text;
            Properties.Settings.Default.Country = Country.SelectedItem.ToString();
            Properties.Settings.Default.Pages = int.Parse(Pages.Text);
            Properties.Settings.Default.ResultPerPages = int.Parse(ResultPerPages.Text);

            Properties.Settings.Default.Save();
        }
        private void FillSMTP()
        {
            SMTPhost.Text = Properties.Settings.Default.host;
            User.Text = Properties.Settings.Default.user;
            Password.Text = Properties.Settings.Default.password;
            Port.Text = Properties.Settings.Default.port.ToString();
            SSL.Checked = Properties.Settings.Default.ssl;
        }
        private void FillAPI()
        {
            APIkey.Text = Properties.Settings.Default.APIkey;
            CXid.Text = Properties.Settings.Default.CXid;
            Country.SelectedIndex = Country.FindStringExact(Properties.Settings.Default.Country);
            Pages.Text = Properties.Settings.Default.Pages.ToString();
            ResultPerPages.Text = Properties.Settings.Default.ResultPerPages.ToString();
        }
        private bool ValidateSMTP()
        {
            bool output = true;

            errorSMTP = null;

            if (SMTPhost.Text.Length == 0) { output = false; errorSMTP += "SMTP Host\n"; }
            if (User.Text.Length == 0) { output = false; errorSMTP += "User\n"; }
            if (Password.Text.Length == 0) { output = false; errorSMTP += "Password\n"; }
            if (Port.Text.Length == 0 || !int.TryParse(Port.Text, out _)) { output = false; errorSMTP += "Port\n"; }

            return output;
        }

        private bool ValidateAPI()
        {
            bool output = true;

            errorAPI = null;

            if (APIkey.Text.Length == 0) { output = false; errorAPI += "API Key must be provided\n"; }
            if (CXid.Text.Length == 0) { output = false; errorAPI += "Custom Search ID must be provided\n"; }
            if (Pages.Text == "0") { output = false; errorAPI += "Pages cannot be 0\n"; }
            if (ResultPerPages.Text == "0") { output = false; errorAPI += "Results cannot be 0\n"; }
            if (Country.SelectedItem == null) { output = false; errorAPI += "Country must be selected\n"; }

            return output;
        }

        private void TestSMTP_Click_1(object sender, EventArgs e)
        {
            if (ValidateSMTP())
            {
                smtpOperations.TestSMTP(SMTPhost.Text, User.Text, Password.Text, int.Parse(Port.Text), SSL.Checked);
            }
            else
            {
                MessageBox.Show("invalid name for: \n\n" + errorSMTP, "ATENTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errorSMTP = null;
            }
        }
        private void SavePF_Click_1(object sender, EventArgs e)
        {
            if (ValidateSMTP()) { SaveSMTP(); MessageBox.Show("SMTP Profile Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else
            {
                MessageBox.Show("invalid name for: \n\n" + errorSMTP, "ATENTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errorSMTP = null;
            }
        }

        private void SaveAPIButton_Click(object sender, EventArgs e)
        {
            if (ValidateAPI()) { SaveAPI(); MessageBox.Show("Google API Profile Saved" , "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);}
            else
            {
                MessageBox.Show("invalid values for: \n\n" + errorAPI, "ATENTION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errorAPI = null;
            }
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchPath_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select a File";
                openFileDialog.Filter = "Executable files (*.exe)|*.exe|All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.ChromePath = openFileDialog.FileName;
                    MessageBox.Show("Chrome Path Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Properties.Settings.Default.Save();
                }
            }
        }
    }
}
