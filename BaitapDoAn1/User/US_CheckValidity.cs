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
    public partial class US_CheckValidity : UserControl
    {
        function fn = new function();
        String query;


        public US_CheckValidity()
        {
            InitializeComponent();
        }

        private void setDataGridView(String query, String lblName, Color col)
        {
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
            lblSet.Text = lblName;
            lblSet.ForeColor = col;
        }
        private void US_CheckValidity_Load(object sender, EventArgs e)
        {
            lblSet.Text = "";
        }

        private void txtCheck_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtCheck.SelectedIndex == 0)
            {
                query = "select *  from medic where TRY_CONVERT(date, eDate, 103) >= CAST(GETDATE() as date )";
                setDataGridView(query, "Valid Medicine", Color.Black);
            }
            else if (txtCheck.SelectedIndex == 1)
            {
                query = "select *  from medic where TRY_CONVERT(date, eDate, 103) < CAST(GETDATE() as date)";
                setDataGridView(query, "Expried Madicine", Color.Red);
            }
            else if (txtCheck.SelectedIndex == 2)
            {
                query = "select * from medic ";
                setDataGridView(query, "", Color.Black);
            }
               
        }
    }
}

