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
    public partial class FormUserActions : MetroForm
    {
        public FormUserActions()
        {
            InitializeComponent();
        }

        private void FormUserActions_Load(object sender, EventArgs e)
        {
            ShowUsersActions();
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


        private void ShowUsersActions()
        {
            dataGridView.Rows.Clear();
            DAL dal = DAL.GetInstance();
            dataGridView.DataSource = dal.GetUserActionsRaw();
        }


        private void FormUserActions_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
      
    }
}
