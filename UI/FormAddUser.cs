using Klogger.Data;
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
    public partial class FormAddUser : Form
    {
        public FormAddUser()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DAL dal = DAL.GetInstance();
            dal.addUser(CreateUser());
        }

        private User CreateUser()
        {
            User u = new User();
            u.username = this.txtUsername.Text;
            u.passwd = this.txtPassword.Text;
            u.id_country = this.cmbCountry.SelectedIndex;
            return u;
        }
    }
}
