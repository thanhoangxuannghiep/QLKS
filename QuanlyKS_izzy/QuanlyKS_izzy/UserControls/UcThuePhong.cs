using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using BUS;

namespace QuanlyKS_izzy.UserControls
{
    public partial class UcThuePhong : UserControl
    {
        string maPhongClick;
        DataTable dt;
        public UcThuePhong()
        {
            InitializeComponent();
        }
        public void loadGalleryPhong()
        {
            dt = QLThuePhong.getAll();
            galleryControl1.Gallery.Groups[0].Items.Clear();
            Bitmap image;

            foreach (DataRow dr in dt.Rows)
            {
                int tinhTrang = Int32.Parse(dr["TinhTrangPhong"].ToString());
                if (tinhTrang == 1)
                {
                    image = new Bitmap(Properties.Resources.close);
                }
                else if (tinhTrang == 0)
                {
                    image = new Bitmap(Properties.Resources.checkInRom);
                } 
                else
                {
                    image = new Bitmap(Properties.Resources.open);
                }

                GalleryItem item = new GalleryItem(image, dr["TenPhong"].ToString(), dr["MoTaPhong"].ToString() == "" ? "Ghi Chú" : dr["MoTaPhong"].ToString());
                item.Tag = dr["MaPhong"].ToString() + "_" + dr["TinhTrangPhong"].ToString().Trim();
                galleryControl1.Gallery.Groups[0].Items.Add(item);
            }
        }

        private void UcThuePhong_Load(object sender, EventArgs e)
        {
            loadGalleryPhong();
        }

        public void showBill(string mPhong)
        {

        }
        private void galleryControl1_Gallery_ItemClick(object sender, GalleryItemClickEventArgs e)
        {
            //clear dữ liệu
            txtKhachHang.Text = "";
            txtSoCMT.Text = "";
            txtSoDT.Text = "";
            txtSoNguoi.Text = "";
            dtNgayTra.Text = "";
            dtNgayThue.DateTime = DateTime.Now;
            txtSoBill.Text = "";
            txtTienThuePhong.Text = "";
            txtTongTien.Text = "";
            txtPhuThu.Text = "";
            txtPhiDichVu.Text = "";
            cboLoaiKH.Text = "";


            string GhiChu = e.Item.Description;
            maPhongClick = e.Item.Caption;
            txtSoPhong.Text = e.Item.Caption;

            string maPhong_TrangThai = e.Item.Tag.ToString();
            txtSoPhongBill.Text = e.Item.Caption;

            // add maphong vao txtSoPhong.Tag de su dung khi dat phong, ko phai lay lai ma phong
            txtSoPhong.Tag = maPhong_TrangThai.Split('_')[0];
            string trangThaiP = maPhong_TrangThai.Split('_')[1];

            if (trangThaiP == "0" || trangThaiP == "1")
            {
                btnDatPhong.Enabled = false;
                btnChuyenPhong.Enabled = true;
                btnThayDoiThongTin.Enabled = true;
                btnInPhieuThuePhong.Enabled = true;

                btnThemKH.Enabled = true;
                btnXoaKH.Enabled = true;
                btnSuaKH.Enabled = true;
                showBill(maPhongClick);

            }
            else
            {
                btnDatPhong.Enabled = true;
                btnChuyenPhong.Enabled = false;
                btnThayDoiThongTin.Enabled = false;
                btnInPhieuThuePhong.Enabled = false;

                gridKhachHang.DataSource = null;
                btnThemKH.Enabled = false;
                btnXoaKH.Enabled = false;
                btnSuaKH.Enabled = false;

            }
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            string[] column_name = { "TenKH", "GioiTinh", "SoCMND", "LoaiKHID", "SoDienThoai", "Email", "DiemThuong" };
            QLKhachHang.insert("KHACHHANG", column_name, txtKhachHang.Text, (cboGioiTinh.SelectedItem == "Nam" ? 1 : 0), txtSoCMT.Text, (cboLoaiKH.SelectedItem == "Nội Địa" ? 1 : 2), txtSoDT.Text, null, 0);


        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnChuyenPhong_Click(object sender, EventArgs e)
        {
            dt = QLThuePhong.getAll();
            lblPhongChuyen.Visible = true;
            cboPhongChuyen.DataSource = dt;
            cboPhongChuyen.DisplayMember = "TenPhong";
            cboPhongChuyen.ValueMember = "MaPhong";
            cboPhongChuyen.Visible = true;
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPhieuThuePhong_Click(object sender, EventArgs e)
        {
            
        }

        private void btnInPhieuThanhToan_Click(object sender, EventArgs e)
        {
            
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            
        }

        private void cboPhongChuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int maPhongMoi = (int)cboPhongChuyen.SelectedValue;
                int maPhongCu = Int32.Parse(txtSoPhong.Tag.ToString());

                if(QLThuePhong.updateTrangThaiPhong(maPhongCu, -1) && QLThuePhong.updateTrangThaiPhong(maPhongMoi, 1))
                {
                    MessageBox.Show("Chuyển Thành Công!");
                    lblPhongChuyen.Visible = false;
                    cboPhongChuyen.Visible = false;
                    btnDatPhong.Enabled = true;
                    btnChuyenPhong.Enabled = false;
                    btnThayDoiThongTin.Enabled = false;
                    btnInPhieuThuePhong.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Có Lỗi Trong Quá Trình Chuyển Phòng!");
                }
                loadGalleryPhong();
            }
            catch (Exception)
            {
                cboPhongChuyen.SelectedValue = null;
                throw;
            }
        }

        private void btnThemDV_Click(object sender, EventArgs e)
        {

        }

    }


}
