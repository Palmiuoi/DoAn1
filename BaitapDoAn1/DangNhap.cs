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
    public partial class DangNhap : Form
    {
        function fn = new function();
        String query; 
        DataSet ds;





        public DangNhap()
        {
            InitializeComponent();
        }

        private void link_quenmatkhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QMK quenMatKhau = new QMK();
            quenMatKhau.ShowDialog();  
        }

        private void link_dangki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy dangky = new DangKy();   
            dangky.ShowDialog();
        }
        Modify modify = new Modify();



        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            string tentk   = txt_TenTaiKhoan.Text;
            string matkhau = txt_MatKhau.Text;
           if(tentk.Trim() == "") { MessageBox.Show("Vui lòng nhập lại tên tài khoản!");  }
            else if (matkhau.Trim() == "") { MessageBox.Show("Vui lòng nhập lại mật khẩu!"); }
            else
            {
                string query = "Select * from TaiKhoan where TenTaiKhoan = '" + tentk + "' and MatKhau = '" + matkhau + "' ";
                if(modify.TaiKhoans(query).Count != 0)
                {
                    MessageBox.Show("Đăng nhập thành công!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    //  Home home = new Home();
                    //   home.ShowDialog();
                    //   this.Close();
                    frmAdmin frmadmin = new frmAdmin();
                      frmadmin.ShowDialog();
                      this.Close();

                }
                //else
                //
                //    MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác!!!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //
            }

            query = "select * from users";
            ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count == 0) 
            {
                if(txt_TenTaiKhoan.Text == "root" && txt_MatKhau.Text == "root" )
                {
                    frmAdmin admin = new frmAdmin();
                    admin.Show();
                    this.Hide();
                }    
            }
            else
            {
              //  query = "SELECT * FROM users WHERE username = '"+ txt_TenTaiKhoan.Text + "' AND password = '"+ txt_MatKhau.Text + "'";
                query = "select * from users where username = '" + txt_TenTaiKhoan.Text + "' and pass = '" + txt_MatKhau.Text + "'";
                ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    String role = ds.Tables[0].Rows[0][1].ToString();
                    if(role == "Admin")
                    {
                        frmAdmin admin = new frmAdmin(txt_TenTaiKhoan.Text);
                        admin.Show();
                        this.Hide();
                    }
                    else if(role == "User")
                    {
                        frmUser user = new frmUser();
                        user.Show();
                        this.Hide();
                    }    
                }
                else
                {
                    MessageBox.Show("Tên người dùng hoặc mật khẩu sai","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }    
            }    


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
