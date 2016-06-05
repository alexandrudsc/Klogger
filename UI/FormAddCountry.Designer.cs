namespace Klogger.UI
{
    partial class FormAddCountry
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
            this.btnSave = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.txtLanguage = new MetroFramework.Controls.MetroTextBox();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.Language = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnDelete = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Image = null;
            this.btnSave.Location = new System.Drawing.Point(9, 172);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtLanguage
            // 
            this.txtLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtLanguage.CustomButton.Image = null;
            this.txtLanguage.CustomButton.Location = new System.Drawing.Point(223, 1);
            this.txtLanguage.CustomButton.Name = "";
            this.txtLanguage.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLanguage.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLanguage.CustomButton.TabIndex = 1;
            this.txtLanguage.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLanguage.CustomButton.UseSelectable = true;
            this.txtLanguage.CustomButton.Visible = false;
            this.txtLanguage.Lines = new string[0];
            this.txtLanguage.Location = new System.Drawing.Point(104, 115);
            this.txtLanguage.MaxLength = 36;
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.PasswordChar = '\0';
            this.txtLanguage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLanguage.SelectedText = "";
            this.txtLanguage.SelectionLength = 0;
            this.txtLanguage.SelectionStart = 0;
            this.txtLanguage.Size = new System.Drawing.Size(245, 23);
            this.txtLanguage.TabIndex = 11;
            this.txtLanguage.UseSelectable = true;
            this.txtLanguage.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLanguage.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(223, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(104, 77);
            this.txtName.MaxLength = 36;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.Size = new System.Drawing.Size(245, 23);
            this.txtName.TabIndex = 12;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtName.Click += new System.EventHandler(this.txtName_Click);
            // 
            // Language
            // 
            this.Language.AutoSize = true;
            this.Language.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Language.Location = new System.Drawing.Point(9, 113);
            this.Language.Name = "Language";
            this.Language.Size = new System.Drawing.Size(87, 25);
            this.Language.TabIndex = 9;
            this.Language.Text = "Language";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(9, 75);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(58, 25);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "Name";
            // 
            // btnDelete
            // 
            this.btnDelete.Image = null;
            this.btnDelete.Location = new System.Drawing.Point(104, 172);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FormAddCountry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 230);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtLanguage);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.Language);
            this.Controls.Add(this.metroLabel1);
            this.Name = "FormAddCountry";
            this.Text = "New Country";
            this.Load += new System.EventHandler(this.FormAddCountry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnSave;
        private MetroFramework.Controls.MetroTextBox txtLanguage;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroLabel Language;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btnDelete;
    }
}