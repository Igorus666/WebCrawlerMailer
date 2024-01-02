namespace Igorus_Email_Bot
{
    partial class BotUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BotUI));
            this.EmailList = new System.Windows.Forms.ListBox();
            this.Recipiant = new System.Windows.Forms.TextBox();
            this.AddRecipiant = new System.Windows.Forms.Button();
            this.RemoveSelected = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SendButton = new System.Windows.Forms.Button();
            this.LoadList = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.AttatchBool = new System.Windows.Forms.CheckBox();
            this.AttatchSearch = new System.Windows.Forms.Button();
            this.AttatchName = new System.Windows.Forms.Label();
            this.EmailBody = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EmailSubject = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Config = new System.Windows.Forms.Button();
            this.SMTPLabel = new System.Windows.Forms.Label();
            this.APILabel = new System.Windows.Forms.Label();
            this.SearchWeb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmailList
            // 
            this.EmailList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailList.FormattingEnabled = true;
            this.EmailList.ItemHeight = 31;
            this.EmailList.Location = new System.Drawing.Point(1370, 200);
            this.EmailList.Name = "EmailList";
            this.EmailList.Size = new System.Drawing.Size(495, 903);
            this.EmailList.TabIndex = 5;
            // 
            // Recipiant
            // 
            this.Recipiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recipiant.Location = new System.Drawing.Point(1370, 66);
            this.Recipiant.Name = "Recipiant";
            this.Recipiant.Size = new System.Drawing.Size(495, 41);
            this.Recipiant.TabIndex = 6;
            // 
            // AddRecipiant
            // 
            this.AddRecipiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRecipiant.Location = new System.Drawing.Point(1370, 125);
            this.AddRecipiant.Name = "AddRecipiant";
            this.AddRecipiant.Size = new System.Drawing.Size(183, 47);
            this.AddRecipiant.TabIndex = 7;
            this.AddRecipiant.Text = "Add to List";
            this.AddRecipiant.UseVisualStyleBackColor = true;
            this.AddRecipiant.Click += new System.EventHandler(this.AddRecipiant_Click);
            // 
            // RemoveSelected
            // 
            this.RemoveSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveSelected.Location = new System.Drawing.Point(1370, 1115);
            this.RemoveSelected.Name = "RemoveSelected";
            this.RemoveSelected.Size = new System.Drawing.Size(298, 47);
            this.RemoveSelected.TabIndex = 8;
            this.RemoveSelected.Text = "Remove Selected";
            this.RemoveSelected.UseVisualStyleBackColor = true;
            this.RemoveSelected.Click += new System.EventHandler(this.RemoveSelected_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(1363, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(296, 38);
            this.label5.TabIndex = 13;
            this.label5.Text = "New Mail Recipiant";
            // 
            // SendButton
            // 
            this.SendButton.BackColor = System.Drawing.Color.Transparent;
            this.SendButton.Enabled = false;
            this.SendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendButton.Location = new System.Drawing.Point(1097, 1055);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(228, 112);
            this.SendButton.TabIndex = 14;
            this.SendButton.Text = "Send Emails";
            this.SendButton.UseVisualStyleBackColor = false;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // LoadList
            // 
            this.LoadList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadList.Location = new System.Drawing.Point(1682, 125);
            this.LoadList.Name = "LoadList";
            this.LoadList.Size = new System.Drawing.Size(183, 47);
            this.LoadList.TabIndex = 16;
            this.LoadList.Text = "Load List";
            this.LoadList.UseVisualStyleBackColor = true;
            this.LoadList.Click += new System.EventHandler(this.LoadList_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1683, 1115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 47);
            this.button1.TabIndex = 17;
            this.button1.Text = "Save List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AttatchBool
            // 
            this.AttatchBool.AutoSize = true;
            this.AttatchBool.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttatchBool.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AttatchBool.Location = new System.Drawing.Point(31, 1061);
            this.AttatchBool.Name = "AttatchBool";
            this.AttatchBool.Size = new System.Drawing.Size(299, 42);
            this.AttatchBool.TabIndex = 18;
            this.AttatchBool.Text = "Send Attachment";
            this.AttatchBool.UseVisualStyleBackColor = true;
            this.AttatchBool.CheckedChanged += new System.EventHandler(this.AttatchBool_CheckedChanged);
            // 
            // AttatchSearch
            // 
            this.AttatchSearch.BackColor = System.Drawing.Color.Transparent;
            this.AttatchSearch.Enabled = false;
            this.AttatchSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttatchSearch.Location = new System.Drawing.Point(22, 1120);
            this.AttatchSearch.Name = "AttatchSearch";
            this.AttatchSearch.Size = new System.Drawing.Size(187, 47);
            this.AttatchSearch.TabIndex = 19;
            this.AttatchSearch.Text = "Attach File";
            this.AttatchSearch.UseVisualStyleBackColor = false;
            this.AttatchSearch.Click += new System.EventHandler(this.AttatchSearch_Click);
            // 
            // AttatchName
            // 
            this.AttatchName.AutoSize = true;
            this.AttatchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttatchName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AttatchName.Location = new System.Drawing.Point(215, 1132);
            this.AttatchName.Name = "AttatchName";
            this.AttatchName.Size = new System.Drawing.Size(27, 29);
            this.AttatchName.TabIndex = 20;
            this.AttatchName.Text = "\\\\";
            // 
            // EmailBody
            // 
            this.EmailBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailBody.Location = new System.Drawing.Point(22, 349);
            this.EmailBody.Multiline = true;
            this.EmailBody.Name = "EmailBody";
            this.EmailBody.Size = new System.Drawing.Size(1303, 680);
            this.EmailBody.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(15, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 38);
            this.label1.TabIndex = 22;
            this.label1.Text = "Email Body";
            // 
            // EmailSubject
            // 
            this.EmailSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailSubject.Location = new System.Drawing.Point(22, 245);
            this.EmailSubject.Name = "EmailSubject";
            this.EmailSubject.Size = new System.Drawing.Size(696, 41);
            this.EmailSubject.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(15, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 38);
            this.label2.TabIndex = 24;
            this.label2.Text = "Email Subject";
            // 
            // Config
            // 
            this.Config.BackColor = System.Drawing.Color.Transparent;
            this.Config.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Config.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Config.Image = ((System.Drawing.Image)(resources.GetObject("Config.Image")));
            this.Config.Location = new System.Drawing.Point(22, 39);
            this.Config.Name = "Config";
            this.Config.Size = new System.Drawing.Size(115, 115);
            this.Config.TabIndex = 25;
            this.Config.UseVisualStyleBackColor = false;
            this.Config.Click += new System.EventHandler(this.Config_Click);
            // 
            // SMTPLabel
            // 
            this.SMTPLabel.AutoSize = true;
            this.SMTPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMTPLabel.ForeColor = System.Drawing.Color.Red;
            this.SMTPLabel.Location = new System.Drawing.Point(152, 56);
            this.SMTPLabel.Name = "SMTPLabel";
            this.SMTPLabel.Size = new System.Drawing.Size(453, 38);
            this.SMTPLabel.TabIndex = 26;
            this.SMTPLabel.Text = "Warning! no SMTP configured";
            // 
            // APILabel
            // 
            this.APILabel.AutoSize = true;
            this.APILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APILabel.ForeColor = System.Drawing.Color.Red;
            this.APILabel.Location = new System.Drawing.Point(152, 107);
            this.APILabel.Name = "APILabel";
            this.APILabel.Size = new System.Drawing.Size(535, 38);
            this.APILabel.TabIndex = 27;
            this.APILabel.Text = "Warning! no Google API Configured";
            // 
            // SearchWeb
            // 
            this.SearchWeb.BackColor = System.Drawing.Color.Transparent;
            this.SearchWeb.Enabled = false;
            this.SearchWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchWeb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SearchWeb.Location = new System.Drawing.Point(1031, 56);
            this.SearchWeb.Name = "SearchWeb";
            this.SearchWeb.Size = new System.Drawing.Size(294, 112);
            this.SearchWeb.TabIndex = 28;
            this.SearchWeb.Text = "Search Web Adresses";
            this.SearchWeb.UseVisualStyleBackColor = false;
            this.SearchWeb.Click += new System.EventHandler(this.SearchWeb_Click);
            // 
            // BotUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(216F, 216F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1881, 1194);
            this.Controls.Add(this.SearchWeb);
            this.Controls.Add(this.APILabel);
            this.Controls.Add(this.SMTPLabel);
            this.Controls.Add(this.Config);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EmailSubject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmailBody);
            this.Controls.Add(this.AttatchName);
            this.Controls.Add(this.AttatchSearch);
            this.Controls.Add(this.AttatchBool);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LoadList);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RemoveSelected);
            this.Controls.Add(this.AddRecipiant);
            this.Controls.Add(this.Recipiant);
            this.Controls.Add(this.EmailList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BotUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Email BOT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox EmailList;
        private System.Windows.Forms.TextBox Recipiant;
        private System.Windows.Forms.Button AddRecipiant;
        private System.Windows.Forms.Button RemoveSelected;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Button LoadList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox AttatchBool;
        private System.Windows.Forms.Button AttatchSearch;
        private System.Windows.Forms.Label AttatchName;
        private System.Windows.Forms.TextBox EmailBody;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmailSubject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Config;
        private System.Windows.Forms.Label SMTPLabel;
        private System.Windows.Forms.Label APILabel;
        private System.Windows.Forms.Button SearchWeb;
    }
}

