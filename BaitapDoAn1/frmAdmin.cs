using BaitapDoAn1.Admin;
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
    public partial class frmAdmin : Form
    {
        String user = ""; 
        public frmAdmin()
        {
            InitializeComponent();
        }

        public string ID
        {
            get { return user.ToString(); }
        }

        public frmAdmin(String userName)
        {
            InitializeComponent();
            lblUserName.Text = userName;
            user = userName;
            uC_ViewUser1.ID = ID;
            uC_Profile1.ID = ID;
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            uC_AddUser1.Visible = true;
            uC_AddUser1.BringToFront();
        }

       


        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            dn.Show();
            this.Hide();
        }

        private void btnDashbord_Click(object sender, EventArgs e)
        {
            // btnDashbord.BackColor = Color.LightBlue;
            uC_Dashbord1.Visible = true;
            uC_Dashbord1.BringToFront();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            uC_Dashbord1.Visible=false;
            uC_AddUser1.Visible=false;
            uC_ViewUser1.Visible=false;
            uC_Profile1.Visible = false;
            btnDashbord.PerformClick();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void btnViewUser_Click(object sender, EventArgs e)
        {
            uC_ViewUser1.Visible = true;
            uC_ViewUser1.BringToFront();

        }

        private void uC_ViewUser1_Load(object sender, EventArgs e)
        {

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
       
            uC_Profile1.Visible = true;
            uC_Profile1.BringToFront();
        }

        private void uC_Profile1_Load(object sender, EventArgs e)
        {

        }
    }
}
