namespace De1
{
    partial class Form1
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
            this.grThongTinVatLieu = new System.Windows.Forms.GroupBox();
            this.lbGhiChu = new System.Windows.Forms.Label();
            this.pbAnh = new System.Windows.Forms.PictureBox();
            this.tbGhiChu = new System.Windows.Forms.TextBox();
            this.btAnh = new System.Windows.Forms.Button();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.lbGiaBan = new System.Windows.Forms.Label();
            this.lbGiaNhap = new System.Windows.Forms.Label();
            this.lbDonViTinh = new System.Windows.Forms.Label();
            this.lbTenVatLieu = new System.Windows.Forms.Label();
            this.lbMaVatLieu = new System.Windows.Forms.Label();
            this.tbSoLuong = new System.Windows.Forms.TextBox();
            this.tbTenVatLieu = new System.Windows.Forms.TextBox();
            this.tbDonViTinh = new System.Windows.Forms.TextBox();
            this.tbGiaNhap = new System.Windows.Forms.TextBox();
            this.tbGiaBan = new System.Windows.Forms.TextBox();
            this.tbMaVatLieu = new System.Windows.Forms.TextBox();
            this.grButton = new System.Windows.Forms.GroupBox();
            this.btBoQua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.dtDuLieu = new System.Windows.Forms.DataGridView();
            this.grThongTinVatLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnh)).BeginInit();
            this.grButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDuLieu)).BeginInit();
            this.SuspendLayout();
            // 
            // grThongTinVatLieu
            // 
            this.grThongTinVatLieu.Controls.Add(this.lbGhiChu);
            this.grThongTinVatLieu.Controls.Add(this.pbAnh);
            this.grThongTinVatLieu.Controls.Add(this.tbGhiChu);
            this.grThongTinVatLieu.Controls.Add(this.btAnh);
            this.grThongTinVatLieu.Controls.Add(this.lbSoLuong);
            this.grThongTinVatLieu.Controls.Add(this.lbGiaBan);
            this.grThongTinVatLieu.Controls.Add(this.lbGiaNhap);
            this.grThongTinVatLieu.Controls.Add(this.lbDonViTinh);
            this.grThongTinVatLieu.Controls.Add(this.lbTenVatLieu);
            this.grThongTinVatLieu.Controls.Add(this.lbMaVatLieu);
            this.grThongTinVatLieu.Controls.Add(this.tbSoLuong);
            this.grThongTinVatLieu.Controls.Add(this.tbTenVatLieu);
            this.grThongTinVatLieu.Controls.Add(this.tbDonViTinh);
            this.grThongTinVatLieu.Controls.Add(this.tbGiaNhap);
            this.grThongTinVatLieu.Controls.Add(this.tbGiaBan);
            this.grThongTinVatLieu.Controls.Add(this.tbMaVatLieu);
            this.grThongTinVatLieu.Location = new System.Drawing.Point(49, 39);
            this.grThongTinVatLieu.Name = "grThongTinVatLieu";
            this.grThongTinVatLieu.Size = new System.Drawing.Size(859, 256);
            this.grThongTinVatLieu.TabIndex = 6;
            this.grThongTinVatLieu.TabStop = false;
            this.grThongTinVatLieu.Text = "Thông Tin Vật Liệu";
            // 
            // lbGhiChu
            // 
            this.lbGhiChu.AutoSize = true;
            this.lbGhiChu.Location = new System.Drawing.Point(471, 157);
            this.lbGhiChu.Name = "lbGhiChu";
            this.lbGhiChu.Size = new System.Drawing.Size(56, 16);
            this.lbGhiChu.TabIndex = 22;
            this.lbGhiChu.Text = "Ghi Chú:";
            // 
            // pbAnh
            // 
            this.pbAnh.Location = new System.Drawing.Point(572, 38);
            this.pbAnh.Name = "pbAnh";
            this.pbAnh.Size = new System.Drawing.Size(264, 110);
            this.pbAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAnh.TabIndex = 21;
            this.pbAnh.TabStop = false;
            // 
            // tbGhiChu
            // 
            this.tbGhiChu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbGhiChu.Location = new System.Drawing.Point(572, 157);
            this.tbGhiChu.Multiline = true;
            this.tbGhiChu.Name = "tbGhiChu";
            this.tbGhiChu.Size = new System.Drawing.Size(264, 79);
            this.tbGhiChu.TabIndex = 20;
            // 
            // btAnh
            // 
            this.btAnh.Location = new System.Drawing.Point(431, 38);
            this.btAnh.Name = "btAnh";
            this.btAnh.Size = new System.Drawing.Size(113, 54);
            this.btAnh.TabIndex = 19;
            this.btAnh.Text = "Ảnh";
            this.btAnh.UseVisualStyleBackColor = true;
            this.btAnh.Click += new System.EventHandler(this.btAnh_Click);
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.Location = new System.Drawing.Point(41, 188);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(64, 16);
            this.lbSoLuong.TabIndex = 18;
            this.lbSoLuong.Text = "Số Lượng";
            // 
            // lbGiaBan
            // 
            this.lbGiaBan.AutoSize = true;
            this.lbGiaBan.Location = new System.Drawing.Point(41, 157);
            this.lbGiaBan.Name = "lbGiaBan";
            this.lbGiaBan.Size = new System.Drawing.Size(55, 16);
            this.lbGiaBan.TabIndex = 17;
            this.lbGiaBan.Text = "Giá Bán";
            // 
            // lbGiaNhap
            // 
            this.lbGiaNhap.AutoSize = true;
            this.lbGiaNhap.Location = new System.Drawing.Point(41, 129);
            this.lbGiaNhap.Name = "lbGiaNhap";
            this.lbGiaNhap.Size = new System.Drawing.Size(64, 16);
            this.lbGiaNhap.TabIndex = 16;
            this.lbGiaNhap.Text = "Giá Nhập";
            // 
            // lbDonViTinh
            // 
            this.lbDonViTinh.AutoSize = true;
            this.lbDonViTinh.Location = new System.Drawing.Point(41, 101);
            this.lbDonViTinh.Name = "lbDonViTinh";
            this.lbDonViTinh.Size = new System.Drawing.Size(75, 16);
            this.lbDonViTinh.TabIndex = 15;
            this.lbDonViTinh.Text = "Đơn Vị Tính";
            // 
            // lbTenVatLieu
            // 
            this.lbTenVatLieu.AutoSize = true;
            this.lbTenVatLieu.Location = new System.Drawing.Point(41, 76);
            this.lbTenVatLieu.Name = "lbTenVatLieu";
            this.lbTenVatLieu.Size = new System.Drawing.Size(82, 16);
            this.lbTenVatLieu.TabIndex = 14;
            this.lbTenVatLieu.Text = "Tên Vật Liệu";
            // 
            // lbMaVatLieu
            // 
            this.lbMaVatLieu.AutoSize = true;
            this.lbMaVatLieu.Location = new System.Drawing.Point(41, 45);
            this.lbMaVatLieu.Name = "lbMaVatLieu";
            this.lbMaVatLieu.Size = new System.Drawing.Size(73, 16);
            this.lbMaVatLieu.TabIndex = 13;
            this.lbMaVatLieu.Text = "Mã Vật liệu";
            // 
            // tbSoLuong
            // 
            this.tbSoLuong.Location = new System.Drawing.Point(151, 182);
            this.tbSoLuong.Name = "tbSoLuong";
            this.tbSoLuong.Size = new System.Drawing.Size(126, 22);
            this.tbSoLuong.TabIndex = 12;
            this.tbSoLuong.TextChanged += new System.EventHandler(this.tbSoLuong_TextChanged);
            // 
            // tbTenVatLieu
            // 
            this.tbTenVatLieu.Location = new System.Drawing.Point(151, 70);
            this.tbTenVatLieu.Name = "tbTenVatLieu";
            this.tbTenVatLieu.Size = new System.Drawing.Size(126, 22);
            this.tbTenVatLieu.TabIndex = 11;
            // 
            // tbDonViTinh
            // 
            this.tbDonViTinh.Location = new System.Drawing.Point(151, 98);
            this.tbDonViTinh.Name = "tbDonViTinh";
            this.tbDonViTinh.Size = new System.Drawing.Size(126, 22);
            this.tbDonViTinh.TabIndex = 10;
            // 
            // tbGiaNhap
            // 
            this.tbGiaNhap.Location = new System.Drawing.Point(151, 126);
            this.tbGiaNhap.Name = "tbGiaNhap";
            this.tbGiaNhap.Size = new System.Drawing.Size(126, 22);
            this.tbGiaNhap.TabIndex = 9;
            this.tbGiaNhap.TextChanged += new System.EventHandler(this.tbGiaNhap_TextChanged);
            // 
            // tbGiaBan
            // 
            this.tbGiaBan.Location = new System.Drawing.Point(151, 154);
            this.tbGiaBan.Name = "tbGiaBan";
            this.tbGiaBan.Size = new System.Drawing.Size(126, 22);
            this.tbGiaBan.TabIndex = 8;
            this.tbGiaBan.TextChanged += new System.EventHandler(this.tbGiaBan_TextChanged);
            // 
            // tbMaVatLieu
            // 
            this.tbMaVatLieu.Location = new System.Drawing.Point(151, 42);
            this.tbMaVatLieu.Name = "tbMaVatLieu";
            this.tbMaVatLieu.Size = new System.Drawing.Size(126, 22);
            this.tbMaVatLieu.TabIndex = 7;
            // 
            // grButton
            // 
            this.grButton.Controls.Add(this.btBoQua);
            this.grButton.Controls.Add(this.btXoa);
            this.grButton.Controls.Add(this.btSua);
            this.grButton.Controls.Add(this.btThem);
            this.grButton.Location = new System.Drawing.Point(49, 463);
            this.grButton.Name = "grButton";
            this.grButton.Size = new System.Drawing.Size(625, 62);
            this.grButton.TabIndex = 7;
            this.grButton.TabStop = false;
            // 
            // btBoQua
            // 
            this.btBoQua.Location = new System.Drawing.Point(489, 16);
            this.btBoQua.Name = "btBoQua";
            this.btBoQua.Size = new System.Drawing.Size(80, 40);
            this.btBoQua.TabIndex = 26;
            this.btBoQua.Text = "Bỏ Qua";
            this.btBoQua.UseVisualStyleBackColor = true;
            this.btBoQua.Click += new System.EventHandler(this.btBoQua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(338, 16);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(80, 40);
            this.btXoa.TabIndex = 25;
            this.btXoa.Text = "Xoá";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(197, 16);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(80, 40);
            this.btSua.TabIndex = 24;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(57, 16);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(80, 40);
            this.btThem.TabIndex = 23;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // dtDuLieu
            // 
            this.dtDuLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDuLieu.Location = new System.Drawing.Point(49, 301);
            this.dtDuLieu.Name = "dtDuLieu";
            this.dtDuLieu.RowHeadersWidth = 51;
            this.dtDuLieu.RowTemplate.Height = 24;
            this.dtDuLieu.Size = new System.Drawing.Size(859, 159);
            this.dtDuLieu.TabIndex = 8;
            this.dtDuLieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtDuLieu_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 537);
            this.Controls.Add(this.dtDuLieu);
            this.Controls.Add(this.grButton);
            this.Controls.Add(this.grThongTinVatLieu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grThongTinVatLieu.ResumeLayout(false);
            this.grThongTinVatLieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnh)).EndInit();
            this.grButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtDuLieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grThongTinVatLieu;
        private System.Windows.Forms.TextBox tbMaVatLieu;
        private System.Windows.Forms.GroupBox grButton;
        private System.Windows.Forms.DataGridView dtDuLieu;
        private System.Windows.Forms.TextBox tbSoLuong;
        private System.Windows.Forms.TextBox tbTenVatLieu;
        private System.Windows.Forms.TextBox tbDonViTinh;
        private System.Windows.Forms.TextBox tbGiaNhap;
        private System.Windows.Forms.TextBox tbGiaBan;
        private System.Windows.Forms.Button btAnh;
        private System.Windows.Forms.Label lbSoLuong;
        private System.Windows.Forms.Label lbGiaBan;
        private System.Windows.Forms.Label lbGiaNhap;
        private System.Windows.Forms.Label lbDonViTinh;
        private System.Windows.Forms.Label lbTenVatLieu;
        private System.Windows.Forms.Label lbMaVatLieu;
        private System.Windows.Forms.TextBox tbGhiChu;
        private System.Windows.Forms.Label lbGhiChu;
        private System.Windows.Forms.PictureBox pbAnh;
        private System.Windows.Forms.Button btBoQua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
    }
}

