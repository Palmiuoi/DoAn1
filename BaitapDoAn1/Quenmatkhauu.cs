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
    public partial class QMK : Form
    {
        public QMK()
        {
            InitializeComponent();
            label2.Text = "";
        }
        Modify modify = new Modify();

        private void btn_dangki_Click(object sender, EventArgs e)
        {
            string email = txt_taikhoan.Text;
            if(email.Trim() == "") { MessageBox.Show("Vui lòng nhập Email đã đăng kí!"); }
            else
            {
                string query = "Select * from TaiKhoan where Email = '" + email + "'";
                if(modify.TaiKhoans(query).Count!=0)
                {
                    label5.ForeColor = Color.Blue;
                    label2.Text = "Mật khẩu: " + modify.TaiKhoans(query)[0].MatKhau; 
                }
                else
                {
                    label5.ForeColor = Color.Red;
                    label2.ForeColor = Color.Red;
                    label2.Text = "Email này chưa được đăng kí!";

                }    
            }    

        }
    }
}
