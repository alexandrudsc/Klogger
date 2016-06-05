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
    public partial class FormCountries : MetroForm
    {
        public FormCountries()
        {
            InitializeComponent();
        }

        private void FormCountries_Load(object sender, EventArgs e)
        {
            ShowCountries();

        }

        private void ShowCountries()
        {
            dataGridView.DataSource = null;
            DAL dal = DAL.GetInstance();
            DataTable dt = dal.GetCountriesRaw();
            dataGridView.DataSource = dt;
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

        private void FormCountries_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dr = this.dataGridView.Rows[e.RowIndex];
            FormAddCountry f = new FormAddCountry(dr);
            if (DialogResult.OK.Equals(f.ShowDialog()))
                ShowCountries();
        }

    }
}
