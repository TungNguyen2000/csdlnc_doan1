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
    public partial class createForm : Form
    {
        protected string newMaHoaDon;
        protected string newMakh;
        protected List<string> masp;
        protected List<string> tensp;
        protected List<int> slton;
        protected List<float> giatien;
        protected List<float> thanhtien;
        protected List<int> soluong;
        protected List<float> giagiam;
        public void loaddata()
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker1.Value = DateTime.Now;

            textBox1.ReadOnly = true;
            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
            using (SqlConnection conn = DBUtils.GetDBConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select 'HD' + cast ((max(cast(substring(mahd,3,len(mahd) - 2) as int)) + 1) as varchar) as newhd from hoadon", conn);
                SqlDataReader sdr = cmd.ExecuteReader();

                newMaHoaDon = "";
                newMakh = "";
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        if (sdr["newhd"] != DBNull.Value)
                        {
                            newMaHoaDon = sdr.GetString(0);
                        }
                        else newMaHoaDon = "HD0";
                    }
                }
                else newMaHoaDon = "HD0";
                textBox1.Text = newMaHoaDon;

                conn.Close();
            }

            using(SqlConnection conn = DBUtils.GetDBConnection())
            {
                conn.Open();
                SqlCommand sqlcmd = new SqlCommand("select masp from sanpham", conn);
                SqlDataAdapter oda = new SqlDataAdapter(sqlcmd);
                DataTable ds = new DataTable();
                oda.Fill(ds);
                MaSP_column.ValueMember = "masp";
                MaSP_column.DisplayMember = "masp";
                MaSP_column.DataSource = ds;
                conn.Close();
            }

            using (SqlConnection conn = DBUtils.GetDBConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT MAkh, HO + ' ' + TEN AS HOTEN FROM khachhang", conn);
                SqlDataAdapter oda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                oda.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = ds.Tables[0].Rows[i][1].ToString();
                    item.Value = ds.Tables[0].Rows[i][0].ToString();
                    comboBox1.Items.Add(item);
                }
                conn.Close();
            }
        }

        public void data_process()
        {
            using (SqlConnection conn = DBUtils.GetDBConnection())
            {
                conn.Open();
               
                conn.Close();
            }
        }
        public createForm()
        {
            InitializeComponent();
            data_process();
            loaddata();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void createForm_Load(object sender, EventArgs e)
        {

        }

        private void comboboxBoxmasp_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
           using (SqlConnection conn = DBUtils.GetDBConnection())
            {
                conn.Open();
                
                conn.Close();
            }
        }

        private void textBoxfloat_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxdecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void setGiaTienComboSelectionChanged(object sender, EventArgs e)
        {
            var currentcell = dataGridView1.CurrentCellAddress;
            var sendingCB = sender as DataGridViewComboBoxEditingControl;
            DataGridViewTextBoxCell cel_ten = (DataGridViewTextBoxCell)dataGridView1.Rows[currentcell.Y].Cells[1];
            DataGridViewTextBoxCell cel_gia = (DataGridViewTextBoxCell)dataGridView1.Rows[currentcell.Y].Cells[3];
            string getmasp = sendingCB.EditingControlFormattedValue.ToString();
            using (SqlConnection conn = DBUtils.GetDBConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select tensp, gia from sanpham where masp = '" + getmasp + "'", conn);
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        if (sdr["tensp"] != DBNull.Value)
                        {
                            cel_ten.Value = sdr.GetString(0);
                            cel_gia.Value = sdr.GetDouble(1).ToString();
                        }
                        
                    }
                }
                conn.Close();
            }
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(textBoxdecimal_KeyPress);
            if (dataGridView1.CurrentCell.ColumnIndex == 2) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(textBoxdecimal_KeyPress);
                }
            }
            else if (dataGridView1.CurrentCell.ColumnIndex == 0)
            { 
                ComboBox comboBox = e.Control as ComboBox;
                comboBox.SelectedIndexChanged -= setGiaTienComboSelectionChanged;
                comboBox.SelectedIndexChanged += setGiaTienComboSelectionChanged;
            }
            else if (dataGridView1.CurrentCell.ColumnIndex == 4 || dataGridView1.CurrentCell.ColumnIndex == 3) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(textBoxfloat_KeyPress);
                }
            }

            if (dataGridView1.CurrentCell.ColumnIndex == 2 || dataGridView1.CurrentCell.ColumnIndex == 4 || dataGridView1.CurrentCell.ColumnIndex == 0)
            {
                ComboBox comboBox = e.Control as ComboBox;
                


            }
        }

        private void setThanhTienComboSelectionChanged(object sender, EventArgs e)
        {
            var currentcell = dataGridView1.CurrentCellAddress;
            var sendingCB = sender as DataGridViewComboBoxEditingControl;
            DataGridViewTextBoxCell cel_ten = (DataGridViewTextBoxCell)dataGridView1.Rows[currentcell.Y].Cells[5];
            string getmasp = sendingCB.EditingControlFormattedValue.ToString();
            using (SqlConnection conn = DBUtils.GetDBConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select tensp, gia from sanpham where masp = '" + getmasp + "'", conn);
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        if (sdr["tensp"] != DBNull.Value)
                        {
                            cel_ten.Value = sdr.GetDouble(1).ToString();
                        }

                    }
                }
                conn.Close();
            }
        }

        private void dataGridView_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && dataGridView1.Rows[e.RowIndex].Cells[0] != null)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                try
                {
                    string sl = "0";
                    if (row.Cells[2].Value.ToString() != null)
                        sl = row.Cells[2].Value.ToString(); ;

                    string dg = "0";
                    if (row.Cells[3].Value.ToString() != null)
                        dg = row.Cells[3].Value.ToString();
                    string gg = "0";
                    if (row.Cells[4].Value.ToString() != null)
                        gg = row.Cells[4].Value.ToString();
                    int result;
                    float result1;
                    if (Int32.TryParse(sl, out result)
                        && float.TryParse(dg, out result1) && float.TryParse(gg, out result1))
                    {
                        row.Cells[5].Value = ((int.Parse(sl) * float.Parse(dg)) - float.Parse(gg)).ToString();
                    }
                } catch(Exception ex) { };
            }
        }

        private void dataGridView1_DefaultValuesNeeded(object sender, System.Windows.Forms.DataGridViewRowEventArgs e)
        {
            e.Row.Cells["dongia_column"].Value = 0;
            e.Row.Cells["soluong_column"].Value = 0;
            e.Row.Cells["thanhtien_column"].Value = 0;
            e.Row.Cells["giagiam_column"].Value = 0;
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a value");
                return;
            }
            newMaHoaDon = textBox1.Text.ToString();
            newMakh = (comboBox1.SelectedItem as ComboboxItem).Value.ToString();
            masp = new List<string>();
            giatien = new List<float>();
            thanhtien = new List<float>();
            soluong = new List<int>();
            giagiam = new List<float>();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            { 
                if (dataGridView1.Rows[i].Cells[0].Value != null) 
                {
                    masp.Add(dataGridView1.Rows[i].Cells["MaSP_column"].Value.ToString());
                    giatien.Add(float.Parse(dataGridView1.Rows[i].Cells["dongia_column"].Value.ToString()));
                    thanhtien.Add(float.Parse(dataGridView1.Rows[i].Cells["thanhtien_column"].Value.ToString()));
                    soluong.Add(int.Parse(dataGridView1.Rows[i].Cells["soluong_column"].Value.ToString()));
                    giagiam.Add(float.Parse(dataGridView1.Rows[i].Cells["giagiam_column"].Value.ToString()));
                } 
            }
            using(SqlConnection conn = DBUtils.GetDBConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into hoadon(mahd, makh, ngaylap) values ('" + newMaHoaDon + "', '" + newMakh + "', '" + dateTimePicker1.Value.ToString() + "'" + ")", conn);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                conn.Close();
            }

            using (SqlConnection conn = DBUtils.GetDBConnection())
            {
                conn.Open();
                for (int i = 0; i < masp.Count; i++)
                {
                    SqlCommand cmd = new SqlCommand("insert into ct_hoadon(mahd, masp, soluong, giaban, giagiam, thanhtien) values ('" + newMaHoaDon + "', '" + masp[i] + "', " + soluong[i] + ", " + giatien[i] + ", " + giagiam[i] + ", " + thanhtien[i] + ")", conn);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                }
                conn.Close();
            }

            using (SqlConnection conn = DBUtils.GetDBConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("update hoadon set tongtien = (select sum(cthd.ThanhTien) from ct_hoadon cthd where cthd.MaHD = hoadon.MaHD)", conn);
                cmd.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                conn.Close();
            }

            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
