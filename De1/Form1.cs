using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace De1
{
    public partial class Form1 : Form
    {   Classes.DataProcesser dtBase=new Classes.DataProcesser();
        string imageName = "";
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            DataTable dtHang = dtBase.ReadData("Select MaVL,TenVatLieu," +
                "DonViTinh,GiaNhap,GiaBan," +""+
                "Anh,GhiChu,SoLuong from VatLieu");
        //    DataTable dtHang = dtBase.ReadData("Select MaVL,TenVatLieu," +
        //"DonViTinh,GiaNhap,GiaBan,Anh,GhiChu,SoLuong from VatLieu");
            dtDuLieu.DataSource = dtHang;
            dtDuLieu.Columns[0].HeaderText = "Mã Vật Liệu";
            dtDuLieu.Columns[1].HeaderText = "Tên Vật Liệu";
            dtDuLieu.Columns[2].HeaderText = "Đơn Vị Tính";
            dtDuLieu.Columns[3].HeaderText = "Giá Nhập";
            dtDuLieu.Columns[4].HeaderText = "Giá Bán";
            dtDuLieu.Columns[5].HeaderText = "File Ảnh";
            dtDuLieu.Columns[6].HeaderText = "Ghi Chú";
            dtDuLieu.Columns[7].HeaderText = "Số Lượng";

            btSua.Enabled = false;
            btXoa.Enabled = false;
        }

        private void btAnh_Click(object sender, EventArgs e)
        {
            string[] file;
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Bitmap Images|*.bmp|JPEG Images|*.jpg;*.jpeg|All Files|*.*";

            openFile.FilterIndex = 2;
            openFile.InitialDirectory = System.Windows.Forms.Application.StartupPath + "\\images";
            if (openFile.ShowDialog() == DialogResult.OK)
            {

                pbAnh.Image = System.Drawing.Image.FromFile(openFile.FileName);
                file = openFile.FileName.Split('\\');
                imageName = file[file.Length - 1];
            }
        }
        private bool IsTextValid(string text)
        {
            foreach (char c in text)
            {
                if (!char.IsDigit(c))
                {
                    return false; // Trả về false nếu có ký tự không phải số
                }
            }
            return true; // Trả về true nếu tất cả đều là số
        }

        private void tbGiaNhap_TextChanged(object sender, EventArgs e)
        {
             if (!IsTextValid(tbGiaNhap.Text))
                {
                tbGiaNhap.Clear();
                }
        }

        private void tbGiaBan_TextChanged(object sender, EventArgs e)
        {
            if (!IsTextValid(tbGiaBan.Text))
            {
                tbGiaBan.Clear();
            }
        }

        private void tbSoLuong_TextChanged(object sender, EventArgs e)
        {
            if (!IsTextValid(tbSoLuong.Text))
            {
                tbSoLuong.Clear();
            }
        }

        private void btBoQua_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close(); // Thoát chương trình
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbMaVatLieu.Text) ||
        string.IsNullOrWhiteSpace(tbTenVatLieu.Text) ||
        string.IsNullOrWhiteSpace(tbDonViTinh.Text) ||
        string.IsNullOrWhiteSpace(tbGiaNhap.Text) ||
        string.IsNullOrWhiteSpace(tbGiaBan.Text) ||
        string.IsNullOrWhiteSpace(tbSoLuong.Text) ||
                    string.IsNullOrWhiteSpace(tbGhiChu.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string MaVatLieu = tbMaVatLieu.Text.Trim();

            // Kiểm tra mã vật liệu đã tồn tại hay chưa
            string queryCheck = $"SELECT COUNT(*) FROM VatLieu WHERE MaVL = '{MaVatLieu}'";
            DataTable dt = dtBase.ReadData(queryCheck);
            if(dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0][0]) > 0)
            {
                MessageBox.Show("Mã vật liệu đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string insertHoaDonQuery = $"INSERT INTO VatLieu (MaVL, TenVatLieu, DonViTinh, GiaNhap, GiaBan,SoLuong,Anh,GhiChu) " +
                           $"VALUES (N'{MaVatLieu}', N'{tbTenVatLieu.Text.Trim()}', N'{tbDonViTinh.Text.Trim()}', N'{tbGiaNhap.Text.Trim()}', N'{tbGiaBan.Text.Trim()}', N'{tbSoLuong.Text.Trim()}', N'{imageName}',N'{tbGhiChu.Text.Trim()}')";
            dtBase.ChangeData(insertHoaDonQuery);
            MessageBox.Show("Succesfully!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            LoadData();
            tbGhiChu.Text = "";
            tbDonViTinh.Text = "";
            tbGiaBan.Text = "";
            tbGiaNhap.Text = "";
            tbMaVatLieu.Text = "";
            tbSoLuong.Text = "";
            tbTenVatLieu.Text = "";
        }

        private void dtDuLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy giá trị từ các ô của dòng được chọn trong DataGridView
            tbMaVatLieu.Text = dtDuLieu.CurrentRow.Cells[0].Value.ToString();
            tbTenVatLieu.Text = dtDuLieu.CurrentRow.Cells[1].Value.ToString();
            tbDonViTinh.Text = dtDuLieu.CurrentRow.Cells[2].Value.ToString();
            tbGiaNhap.Text = dtDuLieu.CurrentRow.Cells[3].Value.ToString();
            tbGiaBan.Text = dtDuLieu.CurrentRow.Cells[4].Value.ToString();
            tbSoLuong.Text = dtDuLieu.CurrentRow.Cells[7].Value.ToString();
            tbGhiChu.Text = dtDuLieu.CurrentRow.Cells[6].Value.ToString();
            imageName = dtDuLieu.CurrentRow.Cells[5].Value.ToString();

            // Nếu có ảnh, hiển thị ảnh trong PictureBox
            if (imageName != "")
            {
                
                pbAnh.Image = System.Drawing.Image.FromFile(System.Windows.Forms.Application.StartupPath + "\\images\\" + imageName);
                btSua.Enabled=true;
                btXoa.Enabled=true;
                btThem.Enabled =
    false;
                tbMaVatLieu.Enabled=false;
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {

            string MaVatLieu = tbMaVatLieu.Text.Trim();
            string queryCheck = $"DELETE FROM VatLieu WHERE MaVL = '{MaVatLieu}'";
            DialogResult result = MessageBox.Show("Bạn có muốn xoá không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            { dtBase.ChangeData(queryCheck);
        
            LoadData();
            tbGhiChu.Text = "";
            tbDonViTinh.Text = "";
             tbGiaBan.Text = "";
                tbGiaNhap.Text = "";
                tbMaVatLieu.Text = "";
                tbSoLuong.Text = "";
                tbTenVatLieu.Text = "";
                pbAnh.Image=null;
            }
           
        }

        private void btSua_Click(object sender, EventArgs e)
        {
     tbMaVatLieu.Enabled = true;
            // Kiểm tra xem các TextBox có đầy đủ dữ liệu không
            if (string.IsNullOrWhiteSpace(tbMaVatLieu.Text) ||
                string.IsNullOrWhiteSpace(tbTenVatLieu.Text) ||
                string.IsNullOrWhiteSpace(tbDonViTinh.Text) ||
                string.IsNullOrWhiteSpace(tbGiaNhap.Text) ||
                string.IsNullOrWhiteSpace(tbGiaBan.Text) ||
                string.IsNullOrWhiteSpace(tbSoLuong.Text) ||
                string.IsNullOrWhiteSpace(tbGhiChu.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Cập nhật thông tin vật liệu trong cơ sở dữ liệu
            string MaVatLieu = tbMaVatLieu.Text.Trim();
            string updateQuery = $"UPDATE VatLieu SET " +
                                 $"TenVatLieu = N'{tbTenVatLieu.Text.Trim()}', " +
                                 $"DonViTinh = N'{tbDonViTinh.Text.Trim()}', " +
                                 $"GiaNhap = N'{tbGiaNhap.Text.Trim()}', " +
                                 $"GiaBan = N'{tbGiaBan.Text.Trim()}', " +
                                 $"SoLuong = N'{tbSoLuong.Text.Trim()}', " +
                                 $"Anh = N'{imageName}', " +
                                 $"GhiChu = N'{tbGhiChu.Text.Trim()}' " +
                                 $"WHERE MaVL = '{MaVatLieu}'";

            dtBase.ChangeData(updateQuery);

            // Hiển thị lại danh sách vật liệu
            LoadData();

            // Xóa rỗng các ô TextBox và ảnh đại diện
            tbGhiChu.Text = "";
            tbDonViTinh.Text = "";
            tbGiaBan.Text = "";
            tbGiaNhap.Text = "";
            tbMaVatLieu.Text = "";
            tbSoLuong.Text = "";
            tbTenVatLieu.Text = "";
            pbAnh.Image = null;

            btThem.Enabled = true;
        }
    }
}
