﻿using System;
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
using DTO;
using System.Globalization;

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

            //cboLoaiPhong.DataSource = LoaiKH.getAll("LOAIKHACHHANG");

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

                // load thong tin người trong phòng
                try
                {
                    DataTable dtHoaDon = DTBill.getAllWhere("HOADON", "PHONG = " + txtSoPhong.Tag.ToString() + " AND (TinhTrang = 0 OR TinhTrang = 1)");
                    string maHD = dtHoaDon.Rows[0]["MaHoaDon"].ToString();

                    DataTable dtPhieuThuePhong = DTRent.getAllWhere("PHIEUTHUE", "MaPhong = " + txtSoPhong.Tag.ToString() + " AND TinhTrangPhieuThue = 1");
                    string maPhieuThue = dtPhieuThuePhong.Rows[0]["MaPhieuThue"].ToString();
                    txtMaPhieuThue.Text = maPhieuThue; 
                    
                    DataTable dtKH = KhachHang.getAllWhere("KHACHHANG", "MaKH = " + dtPhieuThuePhong.Rows[0]["MaKH"].ToString());
                    txtKhachHang.Text = dtKH.Rows[0]["TenKH"].ToString();
                    txtSoCMT.Text = dtKH.Rows[0]["SoCMND"].ToString();
                    cboGioiTinh.SelectedItem = dtKH.Rows[0]["GioiTinh"].ToString() == "1" ? "Nam" : "Nữ";
                    txtSoDT.Text = dtKH.Rows[0]["SoDienThoai"].ToString();
                    cboLoaiKH.SelectedItem = dtKH.Rows[0]["LoaiKHID"].ToString() == "1" ? "Nội Địa" : "Quốc Tế";


                    txtSoNguoi.Text = "1";
                    dtNgayThue.Text = dtPhieuThuePhong.Rows[0]["NgayBatDau"].ToString();
                    dtNgayTra.Text = dtPhieuThuePhong.Rows[0]["NgayKetThuc"].ToString();

                    //HD
                    txtSoBill.Text = dtHoaDon.Rows[0]["MaHoaDon"].ToString();
                    txtPhiDichVu.Text = "0";
                    double phuThu = dtKH.Rows[0]["LoaiKHID"].ToString() == "1" ? 0 : (Double.Parse(dtHoaDon.Rows[0]["TongGia"].ToString()) * 0.1);
                    txtPhuThu.Text = phuThu.ToString();
                    txtTienThuePhong.Text = dtHoaDon.Rows[0]["TongGia"].ToString();
                    txtVAT.Text = (Double.Parse(dtHoaDon.Rows[0]["TongGia"].ToString()) * 0.1).ToString();
                    txtTongTien.Text = (Double.Parse(dtHoaDon.Rows[0]["TongGia"].ToString()) + (Double.Parse(dtHoaDon.Rows[0]["TongGia"].ToString()) * 0.1)).ToString();

                    //dsdv hien co
                    DataTable dttb = DTService.getAll();
                    DataColumn[] keys = new DataColumn[1];
                    keys[0] = dttb.Columns[0];
                    dttb.PrimaryKey = keys;
                    gridDSDichVu.DataSource = dttb;

                    //ds dich vu da su dung
                    DataTable dtCTHD = DTBillDetail.getAllWhere("CHITIETHOADON", "MAHD = " + txtSoBill.Text + " AND Phong = " + txtSoPhong.Tag.ToString());
                    string[] arrayDV = new string[dtCTHD.Rows.Count];
                    for (int i = 0; i < dtCTHD.Rows.Count; i++)
                    {
                        arrayDV[i] = dtCTHD.Rows[i]["MaDichVu"].ToString();
                    }
                    DataTable dtDVSD = DTService.getAllWhere("DICHVU", "MaDichVu in (" + String.Join(",", arrayDV) + ")");
                    DataColumn[] keysDVSD = new DataColumn[1];
                    keysDVSD[0] = dtDVSD.Columns[0];
                    dtDVSD.PrimaryKey = keysDVSD;
                    gridControlDVSuDung.DataSource = dtDVSD;
                }
                catch (Exception)
                {
                    return;
                    throw;
                }

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
            int maKH = QLKhachHang.insert("KHACHHANG", column_name, txtKhachHang.Text, (cboGioiTinh.SelectedItem == "Nam" ? 1 : 0), txtSoCMT.Text, (cboLoaiKH.SelectedItem == "Nội Địa" ? 1 : 2), txtSoDT.Text, null, 0);
            txtMaKH.Text = maKH.ToString();
            int maPhieuThue = RentAdd();

            int maHD = AddOrder(maPhieuThue);
            txtSoBill.Text = maHD.ToString();
            if (maHD != -1)
            {
                MessageBox.Show("Hóa Đơn Đã được thêm!");

                DataTable dttb = DTService.getAll();
                DataColumn[] keys = new DataColumn[1];
                keys[0] = dttb.Columns[0];
                dttb.PrimaryKey = keys;
                gridDSDichVu.DataSource = dttb;

                DataTable dtDVSD = DTBillDetail.getAllWhere("CHITIETHOADON", "MAHD = " + txtSoBill.Text + " AND Phong = " + txtSoPhong.Tag.ToString());
                DataColumn[] keysDVSD = new DataColumn[1];
                keysDVSD[0] = dtDVSD.Columns[0];
                dtDVSD.PrimaryKey = keysDVSD;
                gridControlDVSuDung.DataSource = dtDVSD;

                Phong.update("PHONG", "TinhTrangPhong = 1", "MaPhong = " + txtSoPhong.Tag.ToString());
                loadGalleryPhong();
            }
            else
            {
                MessageBox.Show("Lỗi khi thêm hóa đơn!");
            }
        }

        private int AddOrder(int maPhieuThue)
        {
            try
            {
                //user_m.userID.ToString()
                string[] arr_values = { DateTime.Now.ToString("yyyy-MM-dd"), "0", "2", txtSoPhong.Tag.ToString(), maPhieuThue.ToString(), "1" };
                return DTBill.createGetID(arr_values);
            }
            catch (Exception)
            {
                return -1;
                throw;
            }
        }
        private int RentAdd()
        {
            // Tình trạng phiếu thue giờ qui đinh là :
            // -1 là hủy phiếu
            // 0 là phiếu đang chờ checkin
            // 1 là phiếu đã checkin rồi
            DateTime dateNgayTra = DateTime.ParseExact(dtNgayTra.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime dateNgayThue = DateTime.ParseExact(dtNgayThue.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime dateLapPhieu = DateTime.Now;
            string[] value = { "Phiếu Thuê Phòng " + txtSoPhong.Text, "0", txtSoPhong.Tag.ToString(), dateLapPhieu.ToString("yyyy-MM-dd"), dateNgayTra.ToString("yyyy-MM-dd"), dateNgayThue.ToString("yyyy-MM-dd"), txtMaKH.Text };
            int maPhieuThue = procUCRent.createGetID(value);
            txtMaPhieuThue.Text = maPhieuThue.ToString();
            if (txtMaPhieuThue.Text != "-1")
            {
                MessageBox.Show("Thêm phiếu thuê thành công !", "Thông báo");
                //gridCRent.DataSource = null;
                //gridCRent.DataSource = procUCRent.getAll();

            }
            else
            {
                MessageBox.Show("Thêm phiếu thuê phòng lỗi!");
            }
            //else
            //{
            //    switch (procUCRent.create(value))
            //    {
            //        case 0:
            //            MessageBox.Show(labelControl6.Text + " không được phép bỏ trống !", "Lỗi");
            //            break;
            //        case 1:
            //            MessageBox.Show(labelControl7.Text + " không được phép bỏ trống !", "Lỗi");
            //            break;
            //        case 2:
            //            MessageBox.Show(labelControl8.Text + " không được phép bỏ trống !", "Lỗi");
            //            break;
            //        case 3:
            //            MessageBox.Show(labelControl1.Text + " không được phép bỏ trống !", "Lỗi");
            //            break;
            //        case 4:
            //            MessageBox.Show(labelControl2.Text + " không được phép bỏ trống !", "Lỗi");
            //            break;
            //        case 5:
            //            MessageBox.Show(labelControl5.Text + " không được phép bỏ trống !", "Lỗi");
            //            break;
            //        case 6:
            //            MessageBox.Show(labelControl9.Text + " không được phép bỏ trống !", "Lỗi");
            //            break;
            //    }
            //}
            return maPhieuThue;
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
            try
            {
                
                DTBill.update("TinhTrang = 2", "MaHoaDon = " + txtSoBill.Text);
                Phong.update("PHONG", "TinhTrangPhong = -1", "MaPhong = " + txtSoPhong.Tag.ToString());
                DTRent.update("TinhTrangPhieuThue = 2", "MaPhieuThue = " + txtMaPhieuThue.Text.ToString());
                //load lại danh sách phòng
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
                MessageBox.Show("Thanh Toán Thành Công!");
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Trong Quá trình thanh toán");
                throw;
            }
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
            string maDV = txtDichVuSelect.Text;
            if (String.IsNullOrEmpty(maDV))
            {
                MessageBox.Show("Bạn phải chọn 1 dịch vụ khi thêm!");
            }
            else
            {
                string[] values = { txtSoBill.Text, maDV, DateTime.Now.ToString("yyyy-MM-dd"), txtSoPhong.Tag.ToString() };
                if (DTBillDetail.create(values))
                {
                    //
                    DataTable dtDVSD = DTBillDetail.getAllWhere("CHITIETHOADON", "MAHD = " + txtSoBill.Text + " AND Phong = " + txtSoPhong.Tag.ToString());
                    DataColumn[] keysDVSD = new DataColumn[1];
                    keysDVSD[0] = dtDVSD.Columns[0];
                    dtDVSD.PrimaryKey = keysDVSD;
                    gridControlDVSuDung.DataSource = dtDVSD;
                    MessageBox.Show("Thêm Dịch vụ thành công!");
                }
                else
                {
                    MessageBox.Show("Lỗi không thêm được dịch vụ!");
                }
	        }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int rowHandle = gridView1.FocusedRowHandle;
            if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                DataRow dr = this.gridView1.GetDataRow(rowHandle);
                txtDichVuSelect.Text = dr["MaDichVu"].ToString();
            }
        }

        private void btnXoaDV_Click(object sender, EventArgs e)
        {

        }

    }


}
