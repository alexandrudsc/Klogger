using Klogger.Data;
using MetroFramework.Forms;
using System;
using System.Collections;
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
    public partial class FormAddUser : MetroForm
    {

        private DataGridViewRow userRow;
        private User user;

        public FormAddUser()
        {
            InitializeComponent();
        }

        public FormAddUser(DataGridViewRow userRow)
        {
            InitializeComponent();
            this.userRow = userRow;
            if (userRow != null)
                this.btnDelete.Visible = true;
        }

        private void FormAddUser_Load(object sender, EventArgs e)
        {
            DAL dal = DAL.GetInstance();
            ArrayList countries = dal.GetCountries();
            foreach (Country c in countries)
                this.cmbCountry.Items.Add(c);
            InitializeData(this.userRow);
            FillScreen();
        }

        private void InitializeData(DataGridViewRow userRow)
        {
            if (userRow == null) return;
            this.user = new User();
            this.user.id = int.Parse(userRow.Cells[DB.USER_ID].Value.ToString());
            this.user.passwd = userRow.Cells[DB.USER_PASSWD].Value.ToString();
            this.user.username = userRow.Cells[DB.USER_USERNAME ].Value.ToString();
            this.user.id_country = int.Parse(userRow.Cells[DB.USER_ID_COUNTRY].Value.ToString());
           
        }

        private void FillScreen()
        {
            if (user == null) return;
            this.txtPassword.Text = this.user.passwd;
            this.txtUsername.Text = this.user.username;
            this.cmbCountry.SelectedIndex = this.user.id_country - 1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DAL dal = DAL.GetInstance();
            if (dal.addUser(CreateUser()) != null)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
            this.Close();
        }

        private User CreateUser()
        {
            if (this.user == null)
                user = new User();
            if (String.IsNullOrEmpty(this.txtUsername.Text))
            {
                MessageBox.Show("Type username");
                return null;
            }

            if (String.IsNullOrEmpty(this.txtPassword.Text))
            {
                MessageBox.Show("Type password");
                return null;
            }

            user.username = this.txtUsername.Text;
            user.passwd = this.txtPassword.Text;
            Country c = (Country)this.cmbCountry.SelectedItem;

            if (c == null) return null;
            user.id_country = c.idx;
            return user;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DAL dal = DAL.GetInstance();
            dal.DeleteUser(this.user);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
