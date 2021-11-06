using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace csdlnc_doan1
{
    public partial class MainForm : Form
    {
        public void loaddata()
        {
            using(SqlConnection conn = DBUtils.GetDBConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM HOADON", conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                conn.Close();
                DataSet ds = new DataSet();
                sda.Fill(ds);
                if (ds.Tables.Count > 0)
                {
                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                }
            }

            using (SqlConnection conn = DBUtils.GetDBConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select CAST(MONTH(ngaylap) AS VARCHAR(2)) + '-' + CAST(YEAR(ngaylap) AS VARCHAR(4)) as 'tháng-năm' , sum(tongtien) as 'tổng doanh thu' from hoadon \n" +
                  "group by CAST(MONTH(ngaylap) AS VARCHAR(2)) + '-' + CAST(YEAR(ngaylap) AS VARCHAR(4)) \n" + 
                  "order by CAST(MONTH(ngaylap) AS VARCHAR(2)) + '-' + CAST(YEAR(ngaylap) AS VARCHAR(4)) \n" , conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                conn.Close();
                DataSet ds = new DataSet();
                sda.Fill(ds);
                if (ds.Tables.Count > 0)
                {
                    dataGridView2.DataSource = ds.Tables[0].DefaultView;
                }
            }
        }

        public MainForm()
        {
            InitializeComponent();
            loaddata();
        }

        private void listHD_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            var frm = new createForm();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var frm = new updateForm();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }
    }
}
