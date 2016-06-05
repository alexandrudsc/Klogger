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
            this.SuspendLayout();
            // 
            // game
            // 
            // 
            // 
            // 
            this.game.CustomButton.Image = null;
            this.game.CustomButton.Location = new System.Drawing.Point(244, 1);
            this.game.CustomButton.Name = "";
            this.game.CustomButton.Size = new System.Drawing.Size(263, 263);
            this.game.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.game.CustomButton.TabIndex = 1;
            this.game.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.game.CustomButton.UseSelectable = true;
            this.game.CustomButton.Visible = false;
            this.game.Lines = new string[0];
            this.game.Location = new System.Drawing.Point(14, 66);
            this.game.MaxLength = 32767;
            this.game.Multiline = true;
            this.game.Name = "game";
            this.game.PasswordChar = '\0';
            this.game.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.game.SelectedText = "";
            this.game.SelectionLength = 0;
            this.game.SelectionStart = 0;
            this.game.Size = new System.Drawing.Size(508, 265);
            this.game.TabIndex = 0;
            this.game.UseSelectable = true;
            this.game.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.game.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.game.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.game_KeyPress);
            // 
            // tileQueries
            // 
            this.tileQueries.ActiveControl = null;
            this.tileQueries.Location = new System.Drawing.Point(14, 337);
            this.tileQueries.Name = "tileQueries";
            this.tileQueries.Size = new System.Drawing.Size(75, 56);
            this.tileQueries.TabIndex = 1;
            this.tileQueries.Text = "Queries";
            this.tileQueries.UseSelectable = true;
            this.tileQueries.Click += new System.EventHandler(this.tileQueries_Click);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 399);
            this.Controls.Add(this.tileQueries);
            this.Controls.Add(this.game);
            this.Name = "FormGame";
            this.Text = "Game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormGame_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox game;
        private MetroFramework.Controls.MetroTile tileQueries;
    }
}