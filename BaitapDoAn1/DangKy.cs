using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace BaitapDoAn1
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        public bool CheckAccount(string ac)
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");    
        }
        public bool CheckEmail(string em)
        {
            return Regex.IsMatch(em, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
        }
        Modify modify = new Modify();
        private void btn_dangki_Click(object sender, EventArgs e)
        {
                string tentk = txt_TenTaiKhoan.Text;
                string matkhau = txt_MatKhau.Text;
                string xnMatkhau = txt_XNmatkhau.Text;
                string email = txt_Email.Text;
            if(!CheckAccount(tentk))    { MessageBox.Show("Vui lòng nhập lại tài khoản dài 6 - 24 ký tự, với các ký tự chữ và số, chữ Hoa và chữ thường!"); return;}
            if (!CheckAccount(matkhau)) { MessageBox.Show("Vui lòng nhập lại mật khẩu dài 6 - 24 ký tự, với các ký tự chữ và số, chữ Hoa và chữ thường!"); return; }
            if(xnMatkhau != matkhau)    { MessageBox.Show("Vui lòng xác nhận mật khẩu chính xác!"); return; }
            if(!CheckEmail(email))      { MessageBox.Show("Vui lòng nhập đúng định dạng Email!");   return; }
            if(modify.TaiKhoans("Select * from TaiKhoan where Email = '"+email +"'").Count != 0) { MessageBox.Show("Email này đã được đăng kí, vui lòng đăng kí Email khác"); return ; }
            try
            {
                string query = "Insert into Taikhoan values ('" + tentk + "','" + matkhau + "','" + email + "')";
                modify.Command(query);
                if(MessageBox.Show("Đăng ký tài khoản thành công ! Bạn có muốn đăng nhập lại không?","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information)==DialogResult.Yes)
                {
           
                    this.Close();
                    
                }    
            }
            catch
            {
                MessageBox.Show("Tên tài khoản này đã được đăng ký, vui lòng đăng kí tên tài khoản khác!");
            }
        }

        private void DangKy_Load(object sender, EventArgs e)
        {

        }
    }
}
