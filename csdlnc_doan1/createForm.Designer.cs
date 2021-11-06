
namespace csdlnc_doan1
{
    partial class createForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaSP_column = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tensp_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giagiam_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 22);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "mã hóa đơn mới";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(779, 406);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 32);
            this.buttonInsert.TabIndex = 2;
            this.buttonInsert.Text = "insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP_column,
            this.tensp_column,
            this.soluong_column,
            this.dongia_column,
            this.giagiam_column,
            this.thanhtien_column});
            this.dataGridView1.Location = new System.Drawing.Point(12, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1145, 303);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellValidated);
            this.dataGridView1.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_DefaultValuesNeeded);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            // 
            // MaSP_column
            // 
            this.MaSP_column.HeaderText = "mã sản phẩm";
            this.MaSP_column.MinimumWidth = 6;
            this.MaSP_column.Name = "MaSP_column";
            this.MaSP_column.Width = 125;
            // 
            // tensp_column
            // 
            this.tensp_column.HeaderText = "tên sản phẩm";
            this.tensp_column.MinimumWidth = 6;
            this.tensp_column.Name = "tensp_column";
            this.tensp_column.ReadOnly = true;
            this.tensp_column.Width = 180;
            // 
            // soluong_column
            // 
            this.soluong_column.HeaderText = "số lượng";
            this.soluong_column.MinimumWidth = 6;
            this.soluong_column.Name = "soluong_column";
            this.soluong_column.Width = 125;
            // 
            // dongia_column
            // 
            this.dongia_column.HeaderText = "đơn giá";
            this.dongia_column.MinimumWidth = 6;
            this.dongia_column.Name = "dongia_column";
            this.dongia_column.ReadOnly = true;
            this.dongia_column.Width = 125;
            // 
            // giagiam_column
            // 
            this.giagiam_column.HeaderText = "giá giảm";
            this.giagiam_column.MinimumWidth = 6;
            this.giagiam_column.Name = "giagiam_column";
            this.giagiam_column.Width = 125;
            // 
            // thanhtien_column
            // 
            this.thanhtien_column.HeaderText = "thành tiền";
            this.thanhtien_column.MinimumWidth = 6;
            this.thanhtien_column.Name = "thanhtien_column";
            this.thanhtien_column.ReadOnly = true;
            this.thanhtien_column.Width = 125;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(317, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(202, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(636, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "ngày lập";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(639, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // createForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 453);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "createForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.createForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaSP_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensp_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn giagiam_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien_column;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}