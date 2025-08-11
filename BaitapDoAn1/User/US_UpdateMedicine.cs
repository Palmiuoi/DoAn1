using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaitapDoAn1.User
{
    public partial class US_UpdateMedicine : UserControl
    {
        function fn = new function();
        String query;


        public US_UpdateMedicine()
        {
            InitializeComponent();
        }

        private void clearAll()
        {
            txtMediId.Clear();
            txtMediName.Clear();
            txtMediNumber.Clear();
            txtMdate.ResetText();
            txtEDate.ResetText();
            txtAddQuatity.Clear();  
            txtAvailibleQuantity.Clear();
            txtPricePerUnint.Clear();

            if (txtAddQuatity.Text != "0")
            {
                txtAddQuatity.Text = "0";

            }
            else 
            {
                txtAvailibleQuantity.Text = "0";
            }
        }
        Int64 totalQuantity;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void US_UpdateMedicine_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String mname = txtMediId.Text;   
            String mnumber = txtMediNumber.Text;
            String mdate = txtMdate.Text;
            String edate = txtEDate.Text;
            Int64 quantity = Int64.Parse(txtAvailibleQuantity.Text);
            Int64 addQuantity = Int64.Parse(txtAddQuatity.Text);
            Int64 unitprice = Int64.Parse(txtPricePerUnint.Text);


            totalQuantity = quantity + addQuantity;

            query = "update medic set mname ='" + mname + "', mnumber ='" + mnumber + "', mDate ='" + mdate + "', eDate ='" + edate + "', quantity = " + totalQuantity + ",perUnit = " + unitprice + " where mid = '" + txtMediId.Text + "'";
            fn.setData(query, "Đã cập nhật chi tiết thuốc");


      }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtMediId.Text !=  "")
            {
                query = "select  *  from medic where mid = '" + txtMediId.Text + "'";
                DataSet ds = fn.getData(query);

                if(ds.Tables[0].Rows.Count != 0)
                {
                    txtMediName.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtMediNumber.Text = ds.Tables[0].Rows [0][3].ToString();
                    txtMdate.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtEDate.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtAvailibleQuantity.Text = ds.Tables[0].Rows[0][6].ToString();
                    txtPricePerUnint.Text = ds.Tables[0].Rows[0][7].ToString(); 

                }
                else
                {
                    MessageBox.Show("Không có thuốc giống ID này: " + txtMediId.Text + "Hiện hữu.", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }    
            }
            else
            {
                clearAll();
            }    
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
