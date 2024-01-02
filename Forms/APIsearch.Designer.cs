namespace Igorus_Email_Bot.Forms
{
    partial class APIsearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(APIsearch));
            this.SearchText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.Lang = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.Log = new System.Windows.Forms.ListBox();
            this.Export = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SearchText
            // 
            this.SearchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchText.Location = new System.Drawing.Point(99, 92);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(837, 41);
            this.SearchText.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(322, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(345, 38);
            this.label7.TabIndex = 37;
            this.label7.Text = "Google Search Querry";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(23, 777);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(975, 44);
            this.progressBar.TabIndex = 39;
            // 
            // Lang
            // 
            this.Lang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Lang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lang.FormattingEnabled = true;
            this.Lang.Location = new System.Drawing.Point(283, 176);
            this.Lang.Name = "Lang";
            this.Lang.Size = new System.Drawing.Size(221, 44);
            this.Lang.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(95, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 38);
            this.label10.TabIndex = 44;
            this.label10.Text = "Language";
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.Transparent;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(590, 162);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(324, 63);
            this.SearchButton.TabIndex = 46;
            this.SearchButton.Text = "Begin Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // Log
            // 
            this.Log.BackColor = System.Drawing.SystemColors.WindowText;
            this.Log.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.Log.FormattingEnabled = true;
            this.Log.ItemHeight = 36;
            this.Log.Location = new System.Drawing.Point(60, 279);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(907, 472);
            this.Log.TabIndex = 47;
            // 
            // Export
            // 
            this.Export.BackColor = System.Drawing.Color.Transparent;
            this.Export.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Export.Location = new System.Drawing.Point(590, 667);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(377, 84);
            this.Export.TabIndex = 48;
            this.Export.Text = "Export Results";
            this.Export.UseVisualStyleBackColor = false;
            this.Export.Visible = false;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // APIsearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1022, 845);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.Lang);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.SearchText);
            this.Controls.Add(this.label7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "APIsearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  Web Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ComboBox Lang;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ListBox Log;
        private System.Windows.Forms.Button Export;
    }
}