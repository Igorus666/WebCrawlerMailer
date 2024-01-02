using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Igorus_Email_Bot;
using System.Threading.Tasks;

namespace Igorus_Email_Bot.Library
{
    internal class SMTP_operations
    {
        private int success = 0;
        private int failure = 0;

        public void TestSMTP(string host, string user, string password, int port, bool ssl)
        {
            MailMessage mail = new MailMessage(user, user);

            mail.Subject = "Hello from C# SMTP";
            mail.Body = "Test concluded successfully! \nIgorus Email Bot ready to go";

            SmtpClient smtpClient = new SmtpClient(host);
            smtpClient.Port = port;
            smtpClient.Credentials = new NetworkCredential(user, password);
            smtpClient.EnableSsl = ssl;

            try
            {
                smtpClient.Send(mail);
                MessageBox.Show("Email sent successfully! \nCheck your inbox");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sending email: {ex.Message}");
            }
            finally
            {
                if (mail.Attachments.Count > 0)
                {
                    mail.Attachments[0].Dispose();
                }
            }
        }
        public void SendEmails(string host, string user, string password, int port, bool ssl, string attachmentPath, List<string> recipientEmails, string Subject, string body)
        {
            MessageBox.Show($" Auto Send is running on the background\n this may take a while...", "Beginning SMTP Auto Send", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //await Task.Run(() => MessageBox.Show("Patience is a virtude", "Beginning SMTP Auto Send", MessageBoxButtons.OK, MessageBoxIcon.Information));

            foreach (string recipientEmail in recipientEmails)
            {
                MailMessage mail = new MailMessage(user, recipientEmail);

                mail.Subject = Subject;
                mail.Body = body;

                if (!string.IsNullOrEmpty(attachmentPath) && File.Exists(attachmentPath))
                {
                    Attachment attachment = new Attachment(attachmentPath);
                    mail.Attachments.Add(attachment);
                }

                SmtpClient smtpClient = new SmtpClient(host);
                smtpClient.Port = port;
                smtpClient.Credentials = new NetworkCredential(user, password);
                smtpClient.EnableSsl = ssl;

                try
                {
                    smtpClient.Send(mail);
                    success++;
                }
                catch (Exception ex)
                {
                    failure++;
                    MessageBox.Show($"Error sending email to: {recipientEmail} \n\n {ex.Message}");
                }
                finally
                {
                    if (mail.Attachments.Count > 0)
                    {
                        mail.Attachments[0].Dispose();
                    }
                }
            }

            MessageBox.Show($" Emails succesfully sent to {success} users\n\n Failed to delivery to {failure} users", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            success = 0;
            failure = 0;

        }

    }
}
