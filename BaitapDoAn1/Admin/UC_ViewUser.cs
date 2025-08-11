using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BaitapDoAn1.Admin
{
    public partial class UC_ViewUser : UserControl
    {
        function fn = new function();
        String query;
        //   DataSet ds;
        String currentUser = "";


        public UC_ViewUser()
        {
            InitializeComponent();
        }

        public string ID
        {
            set { currentUser = value; }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
            query = "select * from users where username like '" + txtSearch.Text + "%'";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0]; 
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
           
            if (MessageBox.Show("Bạn có chắc chắn?", "Xóa thông tin!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (currentUser != userName)
                {
                    query = "delete from users where username = '" + userName + "'";
                    fn.setData(query, "Bản ghi đã xóa");
                    UC_ViewUser_Load(this, null);
                }
                else
                {
                    MessageBox.Show("Bạn thử xóa lại \n Hồ sơ của bạn", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }    
            
        }

        private void UC_ViewUser_Load(object sender, EventArgs e)
        {
            query = "select * from users";
            DataSet ds =  fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        String userName;
   
        private void btnSyn_Click(object sender, EventArgs e)
        {
            UC_ViewUser_Load(this, null);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // không phải header
            {
               
                userName = dataGridView1.Rows[e.RowIndex].Cells["username"].Value.ToString();
              
            }
        }
    }
}
