using BaitapDoAn1.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaitapDoAn1
{
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            dn.Show();
            this.Hide();
        }

        private void uS_Dashbord1_Load(object sender, EventArgs e)
        {

        }

        private void btnDashbord_Click(object sender, EventArgs e)
        {
            uS_Dashbord1.Visible = true;
            uS_Dashbord1.BringToFront();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            uS_Dashbord1.Visible=false;
            uS_AddMedicine1.Visible=false;
            uS_ViewMedicine1.Visible = false;
            uS_UpdateMedicine1.Visible = false;
            uS_CheckValidity1.Visible=false;
            uS_SellMedicine1.Visible = false;
            btnDashbord.PerformClick();
        }

        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            uS_AddMedicine1.Visible = true;
            uS_AddMedicine1.BringToFront();
        }

        private void frmUser_Load_1(object sender, EventArgs e)
        {

        }

        private void btnViewMedicine_Click(object sender, EventArgs e)
        {
            uS_ViewMedicine1.Visible = true;
            uS_ViewMedicine1.BringToFront();
        }

        private void btnUpdateMe_Click(object sender, EventArgs e)
        {
            uS_UpdateMedicine1.Visible = true;
            uS_UpdateMedicine1.BringToFront();
        }

        private void btnMeVaChk_Click(object sender, EventArgs e)
        {
            uS_CheckValidity1.Visible = true;
            uS_CheckValidity1.BringToFront();
        }

        private void btnSellMedicine_Click(object sender, EventArgs e)
        {
            uS_SellMedicine1.Visible = true;
            uS_SellMedicine1.BringToFront();
        }

        private void uS_SellMedicine1_Load(object sender, EventArgs e)
        {

        }
    }
}
