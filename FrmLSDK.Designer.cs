
namespace BTL
{
    partial class FrmLSDK
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogoutLSDK = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnTrangChuLSDK = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnHDDK = new System.Windows.Forms.Button();
            this.btnDKHP_LSDK = new System.Windows.Forms.Button();
            this.btnHPTD = new System.Windows.Forms.Button();
            this.btnTCHP_LSDK = new System.Windows.Forms.Button();
            this.btnLSDKHP = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grdLSDK = new System.Windows.Forms.DataGridView();
            this.MaLopHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HocKi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TietHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhongHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiangVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblLSDKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dKTCDataSet3 = new BTL.DKTCDataSet3();
            this.comNamHoc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comHocKy = new System.Windows.Forms.ComboBox();
            this.tblLSDKTableAdapter = new BTL.DKTCDataSet3TableAdapters.tblLSDKTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLSDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLSDKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dKTCDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(43)))), ((int)(((byte)(99)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnTrangChuLSDK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1201, 94);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLogoutLSDK);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(581, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(620, 94);
            this.panel2.TabIndex = 1;
            // 
            // btnLogoutLSDK
            // 
            this.btnLogoutLSDK.AutoSize = true;
            this.btnLogoutLSDK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(43)))), ((int)(((byte)(99)))));
            this.btnLogoutLSDK.FlatAppearance.BorderSize = 0;
            this.btnLogoutLSDK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogoutLSDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLogoutLSDK.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogoutLSDK.Location = new System.Drawing.Point(428, 49);
            this.btnLogoutLSDK.Name = "btnLogoutLSDK";
            this.btnLogoutLSDK.Size = new System.Drawing.Size(181, 40);
            this.btnLogoutLSDK.TabIndex = 0;
            this.btnLogoutLSDK.Text = "Đăng xuất";
            this.btnLogoutLSDK.UseVisualStyleBackColor = false;
            this.btnLogoutLSDK.Click += new System.EventHandler(this.btnLogoutLSDK_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(43)))), ((int)(((byte)(99)))));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button7.Location = new System.Drawing.Point(3, 50);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(365, 39);
            this.button7.TabIndex = 1;
            this.button7.Text = "11208055 | Lê Vũ Quỳnh Trang";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // btnTrangChuLSDK
            // 
            this.btnTrangChuLSDK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(43)))), ((int)(((byte)(99)))));
            this.btnTrangChuLSDK.FlatAppearance.BorderSize = 0;
            this.btnTrangChuLSDK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrangChuLSDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTrangChuLSDK.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTrangChuLSDK.Location = new System.Drawing.Point(29, 49);
            this.btnTrangChuLSDK.Name = "btnTrangChuLSDK";
            this.btnTrangChuLSDK.Size = new System.Drawing.Size(201, 40);
            this.btnTrangChuLSDK.TabIndex = 0;
            this.btnTrangChuLSDK.Text = "Trang chủ";
            this.btnTrangChuLSDK.UseVisualStyleBackColor = false;
            this.btnTrangChuLSDK.Click += new System.EventHandler(this.btnTrangChuLSDK_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(157)))), ((int)(((byte)(209)))));
            this.panel3.Controls.Add(this.btnHDDK);
            this.panel3.Controls.Add(this.btnDKHP_LSDK);
            this.panel3.Controls.Add(this.btnHPTD);
            this.panel3.Controls.Add(this.btnTCHP_LSDK);
            this.panel3.Controls.Add(this.btnLSDKHP);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 94);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(274, 513);
            this.panel3.TabIndex = 12;
            // 
            // btnHDDK
            // 
            this.btnHDDK.BackColor = System.Drawing.Color.White;
            this.btnHDDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHDDK.Location = new System.Drawing.Point(12, 16);
            this.btnHDDK.Name = "btnHDDK";
            this.btnHDDK.Size = new System.Drawing.Size(240, 60);
            this.btnHDDK.TabIndex = 2;
            this.btnHDDK.Text = "Hướng dẫn đăng ký ";
            this.btnHDDK.UseVisualStyleBackColor = false;
            // 
            // btnDKHP_LSDK
            // 
            this.btnDKHP_LSDK.BackColor = System.Drawing.Color.White;
            this.btnDKHP_LSDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDKHP_LSDK.Location = new System.Drawing.Point(12, 92);
            this.btnDKHP_LSDK.Name = "btnDKHP_LSDK";
            this.btnDKHP_LSDK.Size = new System.Drawing.Size(240, 60);
            this.btnDKHP_LSDK.TabIndex = 3;
            this.btnDKHP_LSDK.Text = "Đăng ký học phần ";
            this.btnDKHP_LSDK.UseVisualStyleBackColor = false;
            this.btnDKHP_LSDK.Click += new System.EventHandler(this.btnDKHP_LSDK_Click);
            // 
            // btnHPTD
            // 
            this.btnHPTD.BackColor = System.Drawing.Color.White;
            this.btnHPTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHPTD.Location = new System.Drawing.Point(12, 320);
            this.btnHPTD.Name = "btnHPTD";
            this.btnHPTD.Size = new System.Drawing.Size(240, 60);
            this.btnHPTD.TabIndex = 4;
            this.btnHPTD.Text = "Học phần tương đương";
            this.btnHPTD.UseVisualStyleBackColor = false;
            // 
            // btnTCHP_LSDK
            // 
            this.btnTCHP_LSDK.BackColor = System.Drawing.Color.White;
            this.btnTCHP_LSDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTCHP_LSDK.Location = new System.Drawing.Point(12, 244);
            this.btnTCHP_LSDK.Name = "btnTCHP_LSDK";
            this.btnTCHP_LSDK.Size = new System.Drawing.Size(240, 60);
            this.btnTCHP_LSDK.TabIndex = 5;
            this.btnTCHP_LSDK.Text = "Tra cứu học phần";
            this.btnTCHP_LSDK.UseVisualStyleBackColor = false;
            this.btnTCHP_LSDK.Click += new System.EventHandler(this.btnTCHP_LSDK_Click);
            // 
            // btnLSDKHP
            // 
            this.btnLSDKHP.BackColor = System.Drawing.Color.White;
            this.btnLSDKHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLSDKHP.Location = new System.Drawing.Point(12, 168);
            this.btnLSDKHP.Name = "btnLSDKHP";
            this.btnLSDKHP.Size = new System.Drawing.Size(240, 60);
            this.btnLSDKHP.TabIndex = 6;
            this.btnLSDKHP.Text = "Lịch sử đăng ký học phần ";
            this.btnLSDKHP.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(43)))), ((int)(((byte)(99)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(288, 110);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(869, 44);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "Lịch sử đăng ký học phần";
            // 
            // grdLSDK
            // 
            this.grdLSDK.AutoGenerateColumns = false;
            this.grdLSDK.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdLSDK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLSDK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLopHP,
            this.MaMon,
            this.MaSV,
            this.TenMon,
            this.SoTC,
            this.HocKi,
            this.NamHoc,
            this.TietHoc,
            this.PhongHoc,
            this.GiangVien});
            this.grdLSDK.DataSource = this.tblLSDKBindingSource;
            this.grdLSDK.Location = new System.Drawing.Point(288, 205);
            this.grdLSDK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdLSDK.Name = "grdLSDK";
            this.grdLSDK.RowHeadersWidth = 62;
            this.grdLSDK.RowTemplate.Height = 28;
            this.grdLSDK.Size = new System.Drawing.Size(869, 326);
            this.grdLSDK.TabIndex = 15;
            // 
            // MaLopHP
            // 
            this.MaLopHP.DataPropertyName = "MaLopHP";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaLopHP.DefaultCellStyle = dataGridViewCellStyle7;
            this.MaLopHP.HeaderText = "Mã lớp HP";
            this.MaLopHP.MinimumWidth = 6;
            this.MaLopHP.Name = "MaLopHP";
            this.MaLopHP.Width = 90;
            // 
            // MaMon
            // 
            this.MaMon.DataPropertyName = "MaMon";
            this.MaMon.HeaderText = "MaMon";
            this.MaMon.MinimumWidth = 6;
            this.MaMon.Name = "MaMon";
            this.MaMon.Width = 125;
            // 
            // MaSV
            // 
            this.MaSV.DataPropertyName = "MaSV";
            this.MaSV.HeaderText = "MaSV";
            this.MaSV.MinimumWidth = 6;
            this.MaSV.Name = "MaSV";
            this.MaSV.Width = 125;
            // 
            // TenMon
            // 
            this.TenMon.DataPropertyName = "TenMon";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenMon.DefaultCellStyle = dataGridViewCellStyle8;
            this.TenMon.HeaderText = "Tên môn học";
            this.TenMon.MinimumWidth = 6;
            this.TenMon.Name = "TenMon";
            this.TenMon.Width = 125;
            // 
            // SoTC
            // 
            this.SoTC.DataPropertyName = "SoTC";
            this.SoTC.HeaderText = "Số TC";
            this.SoTC.MinimumWidth = 6;
            this.SoTC.Name = "SoTC";
            this.SoTC.Width = 40;
            // 
            // HocKi
            // 
            this.HocKi.DataPropertyName = "HocKi";
            this.HocKi.HeaderText = "HocKi";
            this.HocKi.MinimumWidth = 6;
            this.HocKi.Name = "HocKi";
            this.HocKi.Width = 125;
            // 
            // NamHoc
            // 
            this.NamHoc.DataPropertyName = "NamHoc";
            this.NamHoc.HeaderText = "Năm học";
            this.NamHoc.MinimumWidth = 6;
            this.NamHoc.Name = "NamHoc";
            this.NamHoc.Width = 125;
            // 
            // TietHoc
            // 
            this.TietHoc.DataPropertyName = "TietHoc";
            this.TietHoc.HeaderText = "TietHoc";
            this.TietHoc.MinimumWidth = 6;
            this.TietHoc.Name = "TietHoc";
            this.TietHoc.Width = 125;
            // 
            // PhongHoc
            // 
            this.PhongHoc.DataPropertyName = "PhongHoc";
            this.PhongHoc.HeaderText = "PhongHoc";
            this.PhongHoc.MinimumWidth = 6;
            this.PhongHoc.Name = "PhongHoc";
            this.PhongHoc.Width = 125;
            // 
            // GiangVien
            // 
            this.GiangVien.DataPropertyName = "GiangVien";
            this.GiangVien.HeaderText = "GiangVien";
            this.GiangVien.MinimumWidth = 6;
            this.GiangVien.Name = "GiangVien";
            this.GiangVien.Width = 125;
            // 
            // tblLSDKBindingSource
            // 
            this.tblLSDKBindingSource.DataMember = "tblLSDK";
            this.tblLSDKBindingSource.DataSource = this.dKTCDataSet3;
            // 
            // dKTCDataSet3
            // 
            this.dKTCDataSet3.DataSetName = "DKTCDataSet3";
            this.dKTCDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comNamHoc
            // 
            this.comNamHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comNamHoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(43)))), ((int)(((byte)(99)))));
            this.comNamHoc.FormattingEnabled = true;
            this.comNamHoc.Items.AddRange(new object[] {
            "Tất cả",
            "2020-2021",
            "2021-2022",
            "2022-2023",
            "2023-2024"});
            this.comNamHoc.Location = new System.Drawing.Point(448, 163);
            this.comNamHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comNamHoc.Name = "comNamHoc";
            this.comNamHoc.Size = new System.Drawing.Size(180, 30);
            this.comNamHoc.TabIndex = 16;
            this.comNamHoc.Text = "  Chọn --";
            this.comNamHoc.SelectedIndexChanged += new System.EventHandler(this.comNamHoc_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(43)))), ((int)(((byte)(99)))));
            this.label1.Location = new System.Drawing.Point(332, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Năm học:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(43)))), ((int)(((byte)(99)))));
            this.label2.Location = new System.Drawing.Point(642, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Học kỳ:";
            // 
            // comHocKy
            // 
            this.comHocKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comHocKy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(43)))), ((int)(((byte)(99)))));
            this.comHocKy.FormattingEnabled = true;
            this.comHocKy.Items.AddRange(new object[] {
            "Tất cả",
            "Học kỳ 1",
            "Học kỳ 2"});
            this.comHocKy.Location = new System.Drawing.Point(728, 163);
            this.comHocKy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comHocKy.Name = "comHocKy";
            this.comHocKy.Size = new System.Drawing.Size(165, 30);
            this.comHocKy.TabIndex = 19;
            this.comHocKy.Text = "  Chọn --";
            this.comHocKy.SelectedIndexChanged += new System.EventHandler(this.comHocKy_SelectedIndexChanged);
            // 
            // tblLSDKTableAdapter
            // 
            this.tblLSDKTableAdapter.ClearBeforeFill = true;
            // 
            // FrmLSDK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(157)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(1201, 607);
            this.Controls.Add(this.comHocKy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comNamHoc);
            this.Controls.Add(this.grdLSDK);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmLSDK";
            this.Text = "FrmLSDK";
            this.Load += new System.EventHandler(this.FrmLSDK_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdLSDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLSDKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dKTCDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogoutLSDK;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnTrangChuLSDK;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView grdLSDK;
        private System.Windows.Forms.ComboBox comNamHoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comHocKy;
        private System.Windows.Forms.Button btnHDDK;
        private System.Windows.Forms.Button btnDKHP_LSDK;
        private System.Windows.Forms.Button btnHPTD;
        private System.Windows.Forms.Button btnTCHP_LSDK;
        private System.Windows.Forms.Button btnLSDKHP;
        private DKTCDataSet3 dKTCDataSet3;
        private System.Windows.Forms.BindingSource tblLSDKBindingSource;
        private DKTCDataSet3TableAdapters.tblLSDKTableAdapter tblLSDKTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLopHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn HocKi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TietHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhongHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiangVien;
    }
}