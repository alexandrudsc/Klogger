﻿using Klogger.Data;
using MetroFramework.Controls;
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
    public partial class FormUsers : MetroFramework.Forms.MetroForm
    {
        public FormUsers()
        {
            InitializeComponent();
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            ShowUsers();
        }

        private void ShowUsers()
        {
            try
            {
                dataGridView.DataSource = null;
                DAL dal = DAL.GetInstance();
                DataTable dt = dal.GetUsersRaw();

                dataGridView.DataSource = dt;
                dataGridView.Columns[1].Visible = false;

            }
            catch 
            {
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            FormAddUser f = new FormAddUser();
            if (DialogResult.OK.Equals(f.ShowDialog()))
                ShowUsers();
        }

        private void btnAddCountry_Click(object sender, EventArgs e)
        {
            FormAddCountry f = new FormAddCountry();
            f.ShowDialog();
        }

        private void btnShowCountries_Click(object sender, EventArgs e)
        {
            FormCountries f = new FormCountries();
            f.ShowDialog();
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

        private void dataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        { 
            DataGridViewRow dr = this.dataGridView.Rows[e.RowIndex];
            FormAddUser f = new FormAddUser(dr);
            if (DialogResult.OK.Equals(f.ShowDialog()))
                ShowUsers();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            FormLogin f = new FormLogin();
            if (DialogResult.OK.Equals(f.ShowDialog()))
            {
                FormGame game = new FormGame(f.user);
                game.Show();
                this.Hide();
            }
        }
    }
}
