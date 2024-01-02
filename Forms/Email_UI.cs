using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net.Mime;
using Igorus_Email_Bot.Library;
using System.Reflection.Emit;
using Igorus_Email_Bot.Forms;

namespace Igorus_Email_Bot
{
    public partial class BotUI : Form
    {
        private List<string> Elist = new List<string>();
        private Text_operations textOperations;
        private SMTP_operations smtpOperations;
        private string fullPath;
        public BotUI()
        {
            InitializeComponent();
            textOperations = new Text_operations();
            smtpOperations = new SMTP_operations();
            validateEngine();
        }
       
        private void validateEngine()
        {
            if (Properties.Settings.Default.host != null && Properties.Settings.Default.user != null && Properties.Settings.Default.password != null && Properties.Settings.Default.port != 0)
            {
                SMTPLabel.Text = "SMTP Server Online";
                SMTPLabel.ForeColor = Color.Green;
                SendButton.Enabled = true;
            }

            if (Properties.Settings.Default.APIkey != null && Properties.Settings.Default.CXid != null && Properties.Settings.Default.Country != null && Properties.Settings.Default.Pages != 0 && Properties.Settings.Default.ResultPerPages != 0 && Properties.Settings.Default.ChromePath != null)
            {
                APILabel.Text = "Google API Online";
                APILabel.ForeColor = Color.Green;
                SearchWeb.Enabled = true;
            }
        }
        
        private void AddRecipiant_Click(object sender, EventArgs e)
        {
            if (Recipiant.Text.Length != 0)
            {
                Elist.Add(Recipiant.Text);
                Populate();
                Recipiant.Text = null;
            }
            else { MessageBox.Show("No Email Adress Entered" , "ATENTION", MessageBoxButtons.OK, MessageBoxIcon.Warning); ; }
        }
        private void Populate()
        {
            EmailList.DataSource = null;
            EmailList.DataSource = Elist;
        }

        private void RemoveSelected_Click(object sender, EventArgs e)
        {
            if (EmailList.SelectedItem != null)
            {
                Elist.Remove((string)EmailList.SelectedItem);
                Populate();
            }
            else { MessageBox.Show("No Entry Selected", "ATENTION", MessageBoxButtons.OK, MessageBoxIcon.Warning); ; }
        }

        private void LoadList_Click(object sender, EventArgs e)
        {
            List<string> NewList = textOperations.LoadList();

            if (NewList != null)
            {
                Elist.AddRange(NewList);
                Populate();
            }
        }

        private void button1_Click(object sender, EventArgs e) 
        { 
            textOperations.SaveList(Elist); 
        }
                    

        private void SendButton_Click(object sender, EventArgs e)
        {
            if (Elist.Count > 0 && EmailSubject.Text.Length != 0 && EmailBody.Text.Length != 0)
            {
                smtpOperations.SendEmails(Properties.Settings.Default.host, Properties.Settings.Default.user, Properties.Settings.Default.password, Properties.Settings.Default.port, Properties.Settings.Default.ssl, fullPath, Elist, EmailSubject.Text, EmailBody.Text);
            }
            else if (Elist.Count == 0) { MessageBox.Show("No Emails added in the list");}
            else if (EmailSubject.Text.Length == 0 || EmailBody.Text.Length == 0) { MessageBox.Show("Email Body and Subject must be filled!"); }
        }

        private void AttatchBool_CheckedChanged(object sender, EventArgs e)
        {
            AttatchSearch.Enabled = !AttatchSearch.Enabled;
            if (!AttatchSearch.Enabled) { fullPath = null; AttatchName.Text = "\\\\"; }
        }

        private void AttatchSearch_Click(object sender, EventArgs e)
        {
            
            fullPath = textOperations.AttatchFile();

            if (fullPath != null)
            {
                int lastSlashIndex = fullPath.LastIndexOf('\\');
                string fileName = fullPath.Substring(lastSlashIndex + 1);
                AttatchName.Text = fileName;
            }

        }
        private void Config_Click(object sender, EventArgs e)
        {
            UserConfig config = new UserConfig();
            config.FormClosed += UserConfig_FormClosed;
            config.Show();
            this.Hide();
        }

        private void UserConfig_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            validateEngine();
        }

        private void SearchWeb_Click(object sender, EventArgs e)
        {
            APIsearch API = new APIsearch();
            API.FormClosed += API_FormClosed;
            API.Show();
        }

        private void API_FormClosed(object sender, FormClosedEventArgs e)
        {
            APIsearch API = (APIsearch)sender;
            List<string> emails = API.GetEmails();
            Elist.AddRange(emails);
            Populate();
        }
    }
}
