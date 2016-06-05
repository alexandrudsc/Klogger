using Klogger.Data;
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
    public partial class FormLogin : MetroForm
    {
        public User user;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DAL dal = DAL.GetInstance();
            user = dal.Login(this.txtUsername.Text, this.txtPassword.Text);
            if ( user != null)
            {
                this.DialogResult = DialogResult.OK;
                
            }
            else
                MessageBox.Show("Try again");
        }
    }
}
