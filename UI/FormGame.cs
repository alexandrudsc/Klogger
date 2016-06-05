using Klogger.Data;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klogger.UI
{
    public partial class FormGame : MetroForm
    {
        private DAL dal;
        private User user;
        private UserAction action;
        public FormGame(User user)
        {
            InitializeComponent();
            dal = DAL.GetInstance();

            this.user = user;
            
            this.action = new UserAction();
            this.action.id_user = user.id;
            this.action.id_action = 1;
            
        }

        private void tileQueries_Click(object sender, EventArgs e)
        {
            StringBuilder msg = new StringBuilder();
            UserAction action = this.dal.MostUsedAction(this.user);
            if (action != null)
                msg.Append("The most used action by " + this.user.username + " is: " + ((char)action.value) + "\n");
            action = this.dal.MostUsedActionCountry(this.user.id_country);
            Country c = this.dal.GetCountry(this.user.id_country);
            if (action != null)
                msg.Append("The most used action inW " + c.name + " is: " + ((char)action.value));
            MessageBox.Show(msg.ToString());
        }

        private void game_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.action.value = e.KeyChar;
            this.action.date = DateTime.Now;
            dal.AddUserAction(this.action);
        }

        private void FormGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tiles_Click(object sender, EventArgs e)
        {
            MetroTile tile = (MetroTile)sender;
            switch (tile.Name)
            {
                case "tileUsers":
                    if (!this.Name.Equals("FormUsers"))
                    {
                        FormUsers f = null;
                        if (Application.OpenForms["FormUsers"] == null)
                            f = new FormUsers();
                        else
                            f = (FormUsers)Application.OpenForms["FormUsers"];
                        f.Show();
                        this.Hide();
                    }
                    break;
                case "tileCountries":
                    if (!this.Name.Equals("FormCountries"))
                    {
                        FormCountries f = null;
                        if (Application.OpenForms["FormCountries"] == null)
                            f = new FormCountries();
                        else
                            f = (FormCountries)Application.OpenForms["FormCountries"];
                        f.Show();
                        this.Hide();
                    }
                    break;
                case "tileActions":
                    if (!this.Name.Equals("FormUserActions"))
                    {
                        FormUserActions f = null;
                        if (Application.OpenForms["FormUserActions"] == null)
                            f = new FormUserActions();
                        else
                            f = (FormUserActions)Application.OpenForms["FormUserActions"];
                        f.Show();
                        this.Hide();
                    }
                    break;

            }
        }

    }
}
