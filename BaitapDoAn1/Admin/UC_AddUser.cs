using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaitapDoAn1.Admin
{
    public partial class UC_AddUser : UserControl
    {
        function fn = new function();
        String query;
        public UC_AddUser()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UC_AddUser_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            query = "select * from users where username = '" + txtUserName.Text + "'";
            DataSet ds =  fn.getData(query);

            if(ds.Tables[0].Rows.Count == 0)
            {
                pictrAddUser.ImageLocation = @"C:\\Users\\giaup\\Downloads\\Image\yes.jpg";
            }
            else
            {
                pictrAddUser.ImageLocation = @"C:\\Users\\giaup\\Downloads\\Image\no.jpg";
            }    
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            String role = txtRole.Text;
            String name = txtName.Text;
            String dob = txtDob.Text;
            Int64 mobile = Int64.Parse(txtPhoneNumber.Text);
            String email = txtEmail.Text;
            String username = txtUserName.Text;
            String pass = txtPassword.Text;


            try
            {

                query = "insert into users (userRole,name,dob,mobile,email,username,pass) values ('" + role + "','" + name + "','" + dob + "'," + mobile + ",'" + email + "', '" + username + "', '" + pass + "')";
                fn.setData(query, "Đăng kí thành công");
            }
            catch (Exception)
            {
                MessageBox.Show("Tên này đã được sử dụng rồi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        
        public  void clearAll()
        {
            txtName.Clear();
            txtDob.ResetText();
            txtPhoneNumber.Clear();
            txtEmail.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
            txtRole.SelectedIndex = -1;
        }
    }
}
