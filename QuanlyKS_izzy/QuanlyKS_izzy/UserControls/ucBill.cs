using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS;
using DTO;

namespace QuanlyKS_izzy.UserControls
{
    public partial class ucBill : DevExpress.XtraEditors.XtraUserControl
    {
        public ucBill()
        {
            InitializeComponent();
        }

        private void ucBill_Load(object sender, EventArgs e)
        {
            gridCBill.DataSource = DTBill.getHoaDon();

            lookUpRoomID.Properties.DataSource = procUCRent.getRoom();
            lookUpRoomID.Properties.DisplayMember = "TenPhong";
            lookUpRoomID.Properties.ValueMember = "MaPhong";
            lookUpRoomID.EditValue = 1;
            lookUpRoomID2.Properties.DataSource = procUCRent.getRoom();
            lookUpRoomID2.Properties.DisplayMember = "TenPhong";
            lookUpRoomID2.Properties.ValueMember = "MaPhong";
            lookUpRoomID2.EditValue = 1;

            lookUpNhanvienID.Properties.DataSource = DTBill.getNhanVien();
            lookUpNhanvienID.Properties.DisplayMember = "TenNhanVien";
            lookUpNhanvienID.Properties.ValueMember = "MaNV";
            lookUpNhanvienID.EditValue = 1;

            lookUpRentID.Properties.DataSource = DTBill.getRent();
            lookUpRentID.Properties.DisplayMember = "TenPhieuThue";
            lookUpRentID.Properties.ValueMember = "MaPhieuThue";
            lookUpRentID.EditValue = 1;

            lookUpServiceID.Properties.DataSource = procUCService.getAll();
            lookUpServiceID.Properties.DisplayMember = "TenDichVu";
            lookUpServiceID.Properties.ValueMember = "MaDichVu";
            lookUpServiceID.EditValue = 1;

            lookUpBillID.Properties.DataSource = DTBill.getHoaDon();
            lookUpBillID.Properties.DisplayMember = "MaHoaDon";
            lookUpBillID.Properties.ValueMember = "MaHoaDon";
            lookUpBillID.EditValue = 1;

            dateCreate.EditValue = System.DateTime.Now.ToString();
            dateUsed.EditValue = System.DateTime.Now.ToString();

        }

        private void btnAddBill_Click(object sender, EventArgs e)
        {
            string[] _value = {   dateCreate.Text,
                                  txtTotalPrice.Text,
                                  lookUpNhanvienID.EditValue.ToString(),
                                  lookUpRoomID.EditValue.ToString(),
                                  lookUpRentID.EditValue.ToString()
                              };
            if (procUCBill.create(_value) == -1)
            {
                MessageBox.Show("Thêm hóa đơn thành công !", "Thông báo");
                gridCBill.DataSource = null;
                gridCBill.DataSource = DTBill.getHoaDon();
            }
            else
            {
                switch (procUCBill.create(_value))
                {
                    case 0:
                        MessageBox.Show(labelControl5.Text + " không được phép bỏ trống !", "Lỗi");
                        break;
                    case 1:
                        MessageBox.Show(labelControl6.Text + " không được phép bỏ trống !", "Lỗi");
                        break;
                    case 2:
                        MessageBox.Show(labelControl7.Text + " không được phép bỏ trống !", "Lỗi");
                        break;
                    case 3:
                        MessageBox.Show(labelControl8.Text + " không được phép bỏ trống !", "Lỗi");
                        break;
                    case 4:
                        MessageBox.Show(labelControl9.Text + " không được phép bỏ trống !", "Lỗi");
                        break;
                }
            }

        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            txtMaHD.Text = gridView1.GetFocusedRowCellValue("MaHoaDon").ToString();
            dateCreate.EditValue = gridView1.GetFocusedRowCellValue("NgayLap").ToString();
            txtTotalPrice.Text = gridView1.GetFocusedRowCellValue("TongGia").ToString();
            lookUpNhanvienID.EditValue = int.Parse(gridView1.GetFocusedRowCellValue("NhanVien").ToString());
            lookUpRoomID.EditValue = int.Parse(gridView1.GetFocusedRowCellValue("Phong").ToString());
            lookUpRentID.EditValue = int.Parse(gridView1.GetFocusedRowCellValue("MaPhieuThue").ToString());

            gridCBillDetail.DataSource = DTBill.getChiTietHoaDon(int.Parse(gridView1.GetFocusedRowCellValue("MaHoaDon").ToString()));
            lookUpBillID.EditValue = int.Parse(gridView1.GetFocusedRowCellValue("MaHoaDon").ToString());
        }

        private void btnUpdateBill_Click(object sender, EventArgs e)
        {
            string[] _value = {   dateCreate.Text,
                                  txtTotalPrice.Text,
                                  lookUpNhanvienID.EditValue.ToString(),
                                  lookUpRoomID.EditValue.ToString(),
                                  lookUpRentID.EditValue.ToString()
                              };
            string _where = "MaHoaDon=N'" + int.Parse(txtMaHD.Text) + "'";
            int flag = procUCBill.update(_value, _where);
            if (flag == -1)
            {
                MessageBox.Show("Cập nhật hóa đơn thành công !", "Thông báo");
                gridCBill.DataSource = null;
                gridCBill.DataSource = DTBill.getHoaDon();
            }
            else
            {
                switch (flag)
                {
                    case 0:
                        MessageBox.Show(labelControl5.Text + " không được phép bỏ trống !", "Lỗi");
                        break;
                    case 1:
                        MessageBox.Show(labelControl6.Text + " không được phép bỏ trống !", "Lỗi");
                        break;
                    case 2:
                        MessageBox.Show(labelControl7.Text + " không được phép bỏ trống !", "Lỗi");
                        break;
                    case 3:
                        MessageBox.Show(labelControl8.Text + " không được phép bỏ trống !", "Lỗi");
                        break;
                    case 4:
                        MessageBox.Show(labelControl9.Text + " không được phép bỏ trống !", "Lỗi");
                        break;
                }
            }
        }

        private void btnDelBill_Click(object sender, EventArgs e)
        {
            if (procUCBill.delbyid(txtMaHD.Text))
            {
                MessageBox.Show("Xóa phiếu thuê thành công !", "Thông báo");
                gridCBill.DataSource = null;
                gridCBill.DataSource = DTBill.getHoaDon();
                gridCBillDetail.DataSource = null;
            }
            else
            {
                MessageBox.Show("Mã phiếu thuê không được phép bỏ trống !", "Lỗi");
            }
        }

        private void btnAddBill2_Click(object sender, EventArgs e)
        {
            string[] _value = {
                                txtMaHD.Text,
                                lookUpServiceID.EditValue.ToString(),
                                dateUsed.EditValue.ToString(),
                                lookUpRoomID2.EditValue.ToString()
                              };
            if (procUCBillDetail.create(_value) == -1)
            {
                MessageBox.Show("Thêm chi tiết hóa đơn thành công !", "Thông báo");
                gridCBillDetail.DataSource = null;
                gridCBillDetail.DataSource = DTBill.getChiTietHoaDon(int.Parse(txtMaHD.Text));
            }
            else
            {
                switch (procUCBillDetail.create(_value))
                {
                    case 0:
                        MessageBox.Show(labelControl5.Text + " không được phép bỏ trống !", "Lỗi");
                        break;
                    case 1:
                        MessageBox.Show(labelControl7.Text + " không được phép bỏ trống !", "Lỗi");
                        break;
                    case 2:
                        MessageBox.Show(labelControl8.Text + " không được phép bỏ trống !", "Lỗi");
                        break;
                    case 3:
                        MessageBox.Show(labelControl9.Text + " không được phép bỏ trống !", "Lỗi");
                        break;

                }
            }
        }

        private void btnUpdateBill2_Click(object sender, EventArgs e)
        {
            string[] _value = {
                                lookUpBillID.EditValue.ToString(),
                                lookUpServiceID.EditValue.ToString(),
                                dateUsed.EditValue.ToString(),
                                lookUpRoomID2.EditValue.ToString()
                              };
            string _where = "UUID=N'" + int.Parse(gridView2.GetFocusedRowCellValue("UUID").ToString()) + "'";
            int flag = procUCBillDetail.update(_value, _where);
            if (flag == -1)
            {
                MessageBox.Show("Cập nhật chi tiết hóa đơn thành công !", "Thông báo");
                gridCBillDetail.DataSource = null;
                gridCBillDetail.DataSource = DTBill.getChiTietHoaDon(int.Parse(txtMaHD.Text));
            }
            else
            {
                switch (flag)
                {
                    case 0:
                        MessageBox.Show(labelControl5.Text + " không được phép bỏ trống !", "Lỗi");
                        break;
                    case 1:
                        MessageBox.Show(labelControl7.Text + " không được phép bỏ trống !", "Lỗi");
                        break;
                    case 2:
                        MessageBox.Show(labelControl8.Text + " không được phép bỏ trống !", "Lỗi");
                        break;
                    case 3:
                        MessageBox.Show(labelControl9.Text + " không được phép bỏ trống !", "Lỗi");
                        break;
                }
            }
        }

        private void gridView2_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            dateUsed.EditValue = gridView2.GetFocusedRowCellValue("NgaySuDung").ToString();
            lookUpBillID.EditValue = int.Parse(gridView2.GetFocusedRowCellValue("MaHD").ToString());
            lookUpServiceID.EditValue = int.Parse(gridView2.GetFocusedRowCellValue("MaDichVu").ToString());
            lookUpRoomID2.EditValue = int.Parse(gridView2.GetFocusedRowCellValue("Phong").ToString());
        }

        private void btnDelBill2_Click(object sender, EventArgs e)
        {
            if (procUCBillDetail.delbyid(gridView2.GetFocusedRowCellValue("UUID").ToString()))
            {
                MessageBox.Show("Xóa phiếu thuê thành công !", "Thông báo");
                gridCBillDetail.DataSource = null;
                gridCBillDetail.DataSource = DTBill.getChiTietHoaDon(int.Parse(txtMaHD.Text));

            }
            else
            {
                MessageBox.Show("Mã phiếu thuê không được phép bỏ trống !", "Lỗi");
            }
        }
    }
}
