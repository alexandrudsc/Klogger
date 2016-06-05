namespace Klogger.UI
{
    partial class FormGame
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
            this.game = new MetroFramework.Controls.MetroTextBox();
            this.tileQueries = new MetroFramework.Controls.MetroTile();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.tileActions = new MetroFramework.Controls.MetroTile();
            this.tileCountries = new MetroFramework.Controls.MetroTile();
            this.tileUsers = new MetroFramework.Controls.MetroTile();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // game
            // 
            // 
            // 
            // 
            this.game.CustomButton.Image = null;
            this.game.CustomButton.Location = new System.Drawing.Point(136, 1);
            this.game.CustomButton.Name = "";
            this.game.CustomButton.Size = new System.Drawing.Size(263, 263);
            this.game.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.game.CustomButton.TabIndex = 1;
            this.game.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.game.CustomButton.UseSelectable = true;
            this.game.CustomButton.Visible = false;
            this.game.Lines = new string[0];
            this.game.Location = new System.Drawing.Point(122, 66);
            this.game.MaxLength = 32767;
            this.game.Multiline = true;
            this.game.Name = "game";
            this.game.PasswordChar = '\0';
            this.game.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.game.SelectedText = "";
            this.game.SelectionLength = 0;
            this.game.SelectionStart = 0;
            this.game.Size = new System.Drawing.Size(400, 265);
            this.game.TabIndex = 0;
            this.game.UseSelectable = true;
            this.game.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.game.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.game.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.game_KeyPress);
            // 
            // tileQueries
            // 
            this.tileQueries.ActiveControl = null;
            this.tileQueries.Location = new System.Drawing.Point(3, 135);
            this.tileQueries.Name = "tileQueries";
            this.tileQueries.Size = new System.Drawing.Size(92, 24);
            this.tileQueries.TabIndex = 1;
            this.tileQueries.Text = "Queries";
            this.tileQueries.UseSelectable = true;
            this.tileQueries.Click += new System.EventHandler(this.tileQueries_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroPanel1.Controls.Add(this.tileQueries);
            this.metroPanel1.Controls.Add(this.tileActions);
            this.metroPanel1.Controls.Add(this.tileCountries);
            this.metroPanel1.Controls.Add(this.tileUsers);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(5, 66);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(111, 265);
            this.metroPanel1.TabIndex = 4;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // tileActions
            // 
            this.tileActions.ActiveControl = null;
            this.tileActions.Location = new System.Drawing.Point(3, 90);
            this.tileActions.Name = "tileActions";
            this.tileActions.Size = new System.Drawing.Size(92, 23);
            this.tileActions.TabIndex = 4;
            this.tileActions.Text = "User actions";
            this.tileActions.UseSelectable = true;
            this.tileActions.Click += new System.EventHandler(this.tiles_Click);
            // 
            // tileCountries
            // 
            this.tileCountries.ActiveControl = null;
            this.tileCountries.Location = new System.Drawing.Point(3, 49);
            this.tileCountries.Name = "tileCountries";
            this.tileCountries.Size = new System.Drawing.Size(92, 23);
            this.tileCountries.TabIndex = 3;
            this.tileCountries.Text = "Countries";
            this.tileCountries.UseSelectable = true;
            this.tileCountries.Click += new System.EventHandler(this.tiles_Click);
            // 
            // tileUsers
            // 
            this.tileUsers.ActiveControl = null;
            this.tileUsers.Location = new System.Drawing.Point(3, 3);
            this.tileUsers.Name = "tileUsers";
            this.tileUsers.Size = new System.Drawing.Size(92, 23);
            this.tileUsers.TabIndex = 2;
            this.tileUsers.Text = "Users";
            this.tileUsers.UseSelectable = true;
            this.tileUsers.Click += new System.EventHandler(this.tiles_Click);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 399);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.game);
            this.Name = "FormGame";
            this.Text = "Game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormGame_FormClosed);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox game;
        private MetroFramework.Controls.MetroTile tileQueries;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile tileActions;
        private MetroFramework.Controls.MetroTile tileCountries;
        private MetroFramework.Controls.MetroTile tileUsers;
    }
}