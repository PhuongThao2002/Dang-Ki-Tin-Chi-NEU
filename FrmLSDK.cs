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

namespace BTL
{
    public partial class FrmLSDK : Form
    {
        public string maSV;
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();
        string sql, constr, s;
        int i;
        public FrmLSDK()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogoutLSDK_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Login f = new Login();
            f.ShowDialog();
        }

        private void btnTrangChuLSDK_Click(object sender, EventArgs e)
        {
            //frmSV f = new frmSV();
            //f.Show();
            //this.Close();
        }

        private void btnDKHP_LSDK_Click(object sender, EventArgs e)
        {
            //frmSV f = new frmSV();
            //f.Show();
           // this.Close();
        }

        private void comNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {

            /*if (comHocKy.Text == "Tất cả")
            {
                if (comNamHoc.Text == "Tất cả") sql = "Select * from tblLSDK where MaSV ='" + maSV + "'";
                else sql = "Select * from tblLSDK where MaSV ='" + maSV + "' and NamHoc='" + comNamHoc.Text + "'";
            }
            else
            {
                if (comNamHoc.Text == "Tất cả") sql = "Select * from tblLSDK where MaSV ='" + maSV + "' and HocKi = '" + comHocKy.Text + "'";
                else sql = "Select * from tblLSDK where MaSV ='" + maSV + "' and NamHoc = '" + comNamHoc.Text + "' and HocKi='" + comHocKy.Text + "'";
            }*/
            /*dt3.Clear();
            if (comNamHoc.Text == "Tất cả") sql = "Select * from tblLSDK where MaSV ='" + maSV + "'";
            else sql = "Select * from tblLSDK where MaSV ='" + maSV + "' and NamHoc='" + comNamHoc.Text + "'";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt3);
            grdLSDK.DataSource = dt3;*/

        }

        private void comHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (comNamHoc.Text=="Tất cả")
            {
                if (comHocKy.Text == "Tất cả") sql = "Select * from tblLSDK where MaSV ='" + maSV + "'";
                else sql = "Select * from tblLSDK where MaSV ='" + maSV + "' and HocKi='"+comHocKy.Text+"'";
            }
            else
            {
                if (comHocKy.Text == "Tất cả") sql = "Select * from tblLSDK where MaSV ='" + maSV + "' and NamHoc = '" + comNamHoc.Text + "'"; 
                else sql = "Select * from tblLSDK where MaSV ='" + maSV + "' and NamHoc = '" + comNamHoc.Text + "' and HocKi='" + comHocKy.Text + "'"; 
            }*/
            dt2.Clear();
            if(comHocKy.Text == "Tất cả") sql = "Select * from tblLSDK where MaSV ='" + maSV + "'";
                else sql = "Select * from tblLSDK where MaSV ='" + maSV + "' and HocKi='" + comHocKy.Text + "'";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt2);
            grdLSDK.DataSource = dt2;

        }

        private void btnTCHP_LSDK_Click(object sender, EventArgs e)
        {
            frmTCHP f = new frmTCHP();
            f.Show();
            this.Close();
        }

        private void FrmLSDK_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dKTCDataSet3.tblLSDK' table. You can move, or remove it, as needed.
            //this.tblLSDKTableAdapter.Fill(this.dKTCDataSet3.tblLSDK);
            constr = @"Data Source=LAPTOP-F0TSIU3S;Initial Catalog=DKTC;Integrated Security=True";
            conn.ConnectionString = constr;
            sql = "Select * from tblLSDK where MaSV ='"+maSV+"'";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            grdLSDK.DataSource = dt;

        }
    }
}
