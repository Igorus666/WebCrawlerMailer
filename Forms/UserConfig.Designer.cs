namespace Igorus_Email_Bot.Forms
{
    partial class UserConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserConfig));
            this.SavePF = new System.Windows.Forms.Button();
            this.TestSMTP = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Port = new System.Windows.Forms.TextBox();
            this.SSL = new System.Windows.Forms.CheckBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.User = new System.Windows.Forms.TextBox();
            this.SMTPhost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.APIkey = new System.Windows.Forms.TextBox();
            this.CXid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Country = new System.Windows.Forms.ComboBox();
            this.Pages = new System.Windows.Forms.NumericUpDown();
            this.SaveAPIButton = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.ResultPerPages = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SearchPath = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultPerPages)).BeginInit();
            this.SuspendLayout();
            // 
            // SavePF
            // 
            this.SavePF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavePF.Location = new System.Drawing.Point(196, 939);
            this.SavePF.Name = "SavePF";
            this.SavePF.Size = new System.Drawing.Size(201, 52);
            this.SavePF.TabIndex = 32;
            this.SavePF.Text = "Save Profile";
            this.SavePF.UseVisualStyleBackColor = true;
            this.SavePF.Click += new System.EventHandler(this.SavePF_Click_1);
            // 
            // TestSMTP
            // 
            this.TestSMTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestSMTP.Location = new System.Drawing.Point(370, 811);
            this.TestSMTP.Name = "TestSMTP";
            this.TestSMTP.Size = new System.Drawing.Size(193, 52);
            this.TestSMTP.TabIndex = 31;
            this.TestSMTP.Text = "Test SMTP";
            this.TestSMTP.UseVisualStyleBackColor = true;
            this.TestSMTP.Click += new System.EventHandler(this.TestSMTP_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(53, 774);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 38);
            this.label4.TabIndex = 30;
            this.label4.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(53, 647);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 38);
            this.label3.TabIndex = 29;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(53, 521);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 38);
            this.label2.TabIndex = 28;
            this.label2.Text = "User";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(53, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 38);
            this.label1.TabIndex = 27;
            this.label1.Text = "SMTP Host";
            // 
            // Port
            // 
            this.Port.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Port.Location = new System.Drawing.Point(60, 818);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(162, 41);
            this.Port.TabIndex = 26;
            // 
            // SSL
            // 
            this.SSL.AutoSize = true;
            this.SSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SSL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SSL.Location = new System.Drawing.Point(243, 817);
            this.SSL.Name = "SSL";
            this.SSL.Size = new System.Drawing.Size(111, 42);
            this.SSL.TabIndex = 25;
            this.SSL.Text = "SSL";
            this.SSL.UseVisualStyleBackColor = true;
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(60, 688);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(483, 41);
            this.Password.TabIndex = 24;
            this.Password.UseSystemPasswordChar = true;
            // 
            // User
            // 
            this.User.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.Location = new System.Drawing.Point(60, 562);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(483, 41);
            this.User.TabIndex = 23;
            // 
            // SMTPhost
            // 
            this.SMTPhost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMTPhost.Location = new System.Drawing.Point(60, 441);
            this.SMTPhost.Name = "SMTPhost";
            this.SMTPhost.Size = new System.Drawing.Size(483, 41);
            this.SMTPhost.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(49, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(514, 63);
            this.label5.TabIndex = 33;
            this.label5.Text = "SMTP Configuration";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(699, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(640, 63);
            this.label6.TabIndex = 34;
            this.label6.Text = "Google API Configuration";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(703, 391);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(249, 38);
            this.label7.TabIndex = 35;
            this.label7.Text = "Google API Key";
            // 
            // APIkey
            // 
            this.APIkey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APIkey.Location = new System.Drawing.Point(710, 441);
            this.APIkey.Name = "APIkey";
            this.APIkey.Size = new System.Drawing.Size(646, 41);
            this.APIkey.TabIndex = 36;
            // 
            // CXid
            // 
            this.CXid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CXid.Location = new System.Drawing.Point(710, 562);
            this.CXid.Name = "CXid";
            this.CXid.Size = new System.Drawing.Size(646, 41);
            this.CXid.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(703, 512);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(394, 38);
            this.label8.TabIndex = 37;
            this.label8.Text = "Custom Search Engine ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(703, 636);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(227, 38);
            this.label9.TabIndex = 39;
            this.label9.Text = "Pages Loaded";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(703, 774);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 38);
            this.label10.TabIndex = 41;
            this.label10.Text = "Country";
            // 
            // Country
            // 
            this.Country.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Country.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Country.FormattingEnabled = true;
            this.Country.Location = new System.Drawing.Point(710, 815);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(162, 44);
            this.Country.TabIndex = 43;
            // 
            // Pages
            // 
            this.Pages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pages.Location = new System.Drawing.Point(715, 688);
            this.Pages.Name = "Pages";
            this.Pages.Size = new System.Drawing.Size(157, 41);
            this.Pages.TabIndex = 44;
            // 
            // SaveAPIButton
            // 
            this.SaveAPIButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveAPIButton.Location = new System.Drawing.Point(920, 939);
            this.SaveAPIButton.Name = "SaveAPIButton";
            this.SaveAPIButton.Size = new System.Drawing.Size(201, 52);
            this.SaveAPIButton.TabIndex = 45;
            this.SaveAPIButton.Text = "Save Profile";
            this.SaveAPIButton.UseVisualStyleBackColor = true;
            this.SaveAPIButton.Click += new System.EventHandler(this.SaveAPIButton_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnButton.Image = ((System.Drawing.Image)(resources.GetObject("ReturnButton.Image")));
            this.ReturnButton.Location = new System.Drawing.Point(24, 38);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(163, 126);
            this.ReturnButton.TabIndex = 46;
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // ResultPerPages
            // 
            this.ResultPerPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultPerPages.Location = new System.Drawing.Point(1064, 689);
            this.ResultPerPages.Name = "ResultPerPages";
            this.ResultPerPages.Size = new System.Drawing.Size(157, 41);
            this.ResultPerPages.TabIndex = 48;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(1052, 637);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(268, 38);
            this.label11.TabIndex = 47;
            this.label11.Text = "Results per Page";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(1057, 774);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(238, 38);
            this.label12.TabIndex = 49;
            this.label12.Text = "Path to chrome";
            // 
            // SearchPath
            // 
            this.SearchPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchPath.Location = new System.Drawing.Point(1064, 818);
            this.SearchPath.Name = "SearchPath";
            this.SearchPath.Size = new System.Drawing.Size(142, 52);
            this.SearchPath.TabIndex = 50;
            this.SearchPath.Text = "Search";
            this.SearchPath.UseVisualStyleBackColor = true;
            this.SearchPath.Click += new System.EventHandler(this.SearchPath_Click);
            // 
            // UserConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1396, 1078);
            this.Controls.Add(this.SearchPath);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ResultPerPages);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.SaveAPIButton);
            this.Controls.Add(this.Pages);
            this.Controls.Add(this.Country);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CXid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.APIkey);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SavePF);
            this.Controls.Add(this.TestSMTP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.SSL);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.User);
            this.Controls.Add(this.SMTPhost);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  Configurations";
            ((System.ComponentModel.ISupportInitialize)(this.Pages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultPerPages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SavePF;
        private System.Windows.Forms.Button TestSMTP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Port;
        private System.Windows.Forms.CheckBox SSL;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox User;
        private System.Windows.Forms.TextBox SMTPhost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox APIkey;
        private System.Windows.Forms.TextBox CXid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox Country;
        private System.Windows.Forms.NumericUpDown Pages;
        private System.Windows.Forms.Button SaveAPIButton;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.NumericUpDown ResultPerPages;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button SearchPath;
    }
}