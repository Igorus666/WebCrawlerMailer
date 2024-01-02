using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Igorus_Email_Bot.Library
{
    internal class Text_operations
    {
        public List<string> Emails;
  
        public List<string> LoadList()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select a File";
            openFileDialog.Filter = "Text Files|*.txt|All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog.FileName;
                Emails = new List<string>(File.ReadAllLines(selectedFileName));
                return Emails;
            }
            else { MessageBox.Show("Failed to find the list", "ATENTION", MessageBoxButtons.OK, MessageBoxIcon.Warning); ; }
            return null;
        }
        public void SaveList(List<string> E)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save List to a File";
            saveFileDialog.Filter = "Text Files|*.txt|All Files|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = saveFileDialog.FileName;

                try
                {
                    File.WriteAllLines(selectedFileName, E);
                    MessageBox.Show("List saved successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving list: {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public string AttatchFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open File";
            openFileDialog.Filter = "All Files|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog.FileName;
            }
            else
            {
                MessageBox.Show($"Error selecting the file ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        
    }
}
