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
    public partial class FormGame : MetroForm
    {
        private DAL dal;
        private UserAction action;
        public FormGame(User user)
        {
            InitializeComponent();
            dal = DAL.GetInstance();
            this.action = new UserAction();
            this.action.id_user = user.id;
            this.action.id_action = 1;
            
        }

        private void tileQueries_Click(object sender, EventArgs e)
        {

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
    }
}
