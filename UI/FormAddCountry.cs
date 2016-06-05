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
    public partial class FormAddCountry : MetroForm
    {
        private Country country;
        private DataGridViewRow row;

        public FormAddCountry()
        {
            InitializeComponent();
        }

        public FormAddCountry(DataGridViewRow countryRow)
        {
            InitializeComponent();
            row = countryRow;
            if (countryRow != null)
                this.btnDelete.Visible = true;
        }

        private void FormAddCountry_Load(object sender, EventArgs e)
        {
            InitData();
            FillScreen();
        }

        private void InitData()
        {
            if (this.row == null)
                return;
            this.country = new Country();
            this.country.name = row.Cells[DB.COUNTRY_NAME].Value.ToString();
            this.country.idx = int.Parse(row.Cells[DB.COUNTRY_ID].Value.ToString());
            this.country.language = row.Cells[DB.COUNTRY_LANGUAGE].Value.ToString();
        }

        private void FillScreen()
        {
            if (this.country == null)
                return;
            this.txtLanguage.Text = country.language;
            this.txtName.Text = country.name;
        }
            
        private void txtName_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DAL dal = DAL.GetInstance();
            if (dal.AddCountry(createCountry()) != null)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
            this.Close();
            
        }

        private Country createCountry()
        {
            if (this.country == null)
                country = new Country();
            country.name = this.txtName.Text;
            country.language = this.txtLanguage.Text;
            return country;  
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.country == null)
                return;
            DAL dal = DAL.GetInstance();
            if (dal.DeleteCountry(this.country))
                this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
