using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Data;
using System.Windows.Forms;

namespace BaitapDoAn1
{
    internal class function
    {
        protected SqlConnection getConnection()
        {
            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = "data source = Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Đồ án 1 Làm chung\\BaitapDoAn1\\BaitapDoAn1\\Database1.mdf;Integrated Security=True";
            //return con;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Đồ án 1 Làm chung\BaitapDoAn1\BaitapDoAn1\Database1.mdf"";Integrated Security=True");
            return con;
        }

        public DataSet getData(String query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public void setData(String query,  String msg)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show(msg, "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
