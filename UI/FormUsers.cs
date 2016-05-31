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
    public partial class FormUsers : MetroFramework.Forms.MetroForm
    {
        public FormUsers()
        {
            InitializeComponent();
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            DisplayUsers();
        }

        private void DisplayUsers()
        {
            try
            {
                DAL dal = DAL.GetInstance();
                DataTable dt = dal.GetUsersRaw();

                dataGridView.DataSource = dt;
                dataGridView.Columns[1].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            FormAddUser f = new FormAddUser();
            f.ShowDialog();
        }
    }
}
