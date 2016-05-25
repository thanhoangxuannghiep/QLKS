using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using BUS;
namespace QuanlyKS_izzy.UserControls
{
    public partial class UCKhachHang : UserControl
    {
        DataTable dttb;

        public UCKhachHang()
        {
            InitializeComponent();
        }

        private void UCKhachHang_Load(object sender, EventArgs e)
        {
            //cboLoaiKH.DataSource =            
          
        }

        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            
        }

        private void btnLichSuKH_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            UCLichSuKH ucLichSuKH = new UCLichSuKH();
            ucLichSuKH.Show();
            form.Controls.Add(ucLichSuKH);
        }

        private void gridControlKhachHang_Load(object sender, EventArgs e)
        {
            dttb = QLKhachHang.getAll();
            DataColumn[] keys = new DataColumn[1];
            keys[0] = dttb.Columns[0];
            dttb.PrimaryKey = keys;
            gridControlKhachHang.DataSource = dttb;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                //cboLoaiKH.SelectedValue.ToString()
                decimal diemThuong;
                if(!Decimal.TryParse(txtDiemThuong.Text, out diemThuong))
                {
                    diemThuong = 0;
                }
                string[] column_name = { "TenKH", "GioiTinh", "SoCMND", "LoaiKHID", "SoDienThoai", "Email", "DiemThuong" };

                int id = QLKhachHang.insert("KHACHHANG", column_name, txtTenKH.Text, (cboGioiTinh.SelectedItem == "Nam" ? 1 : 0), txtSoCMT.Text, (cboLoaiKH.SelectedItem == "Nội Địa" ? 1 : 2), txtSoDT.Text, txtEmail.Text, diemThuong);
                if (id != -1)
                {
                    DataRow dr = dttb.NewRow();
                    dr[0] = id;
                    dr[1] = txtTenKH.Text;
                    dr[2] = (string)cboGioiTinh.SelectedItem;
                    dr[3] = txtSoCMT.Text;
                    dr[4] = (string)cboLoaiKH.SelectedItem;
                    dr[5] = txtSoDT.Text;
                    dr[6] = txtEmail.Text;
                    dr[7] = diemThuong;
                    dttb.Rows.Add(dr);
                    gridControlKhachHang.DataSource = dttb;
                    MessageBox.Show("Thêm thành công");
                } 
                else
                {
                    MessageBox.Show("Thêm Lỗi!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm Lỗi!");
                throw;
            }
        }

        private void gridView_RowClick(object sender, RowClickEventArgs e)
        {
            int rowHandle = gridView.FocusedRowHandle;
            if (rowHandle != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
            {
                DataRow dr = this.gridView.GetDataRow(rowHandle);
                txtMaKH.Text = dr["MaKH"].ToString();
                txtTenKH.Text = (string)dr["TenKH"];
                cboGioiTinh.SelectedItem = dr["GioiTinh"];
                txtSoCMT.Text = (string)dr["SoCMND"];
                cboLoaiKH.SelectedItem = dr["LoaiKHID"];
                txtSoDT.Text = (string)dr["SoDienThoai"];
                txtEmail.Text = (string)dr["Email"];
                txtDiemThuong.Text = dr["DiemThuong"].ToString();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int maKH;
            if (!int.TryParse(txtMaKH.Text, out maKH))
            {
                maKH = -1;
            }

            if (maKH != -1)
            {
                decimal diemThuong;
                if (!Decimal.TryParse(txtDiemThuong.Text, out diemThuong))
                {
                    diemThuong = 0;
                }
                string[] column_name = { "TenKH", "GioiTinh", "SoCMND", "LoaiKHID", "SoDienThoai", "Email", "DiemThuong" };

                if (QLKhachHang.update("KHACHHANG", column_name, maKH, txtTenKH.Text, (cboGioiTinh.SelectedItem == "Nam" ? 1 : 0), txtSoCMT.Text, 1, txtSoDT.Text, txtEmail.Text, diemThuong))
	            {
                    MessageBox.Show("Cập nhật thành công!");
                    dttb.Rows.Find(maKH)["TenKH"] = txtTenKH.Text;
                    dttb.Rows.Find(maKH)["GioiTinh"] = (string)cboGioiTinh.SelectedItem;
                    dttb.Rows.Find(maKH)["SoCMND"] = txtSoCMT.Text;
                    dttb.Rows.Find(maKH)["LoaiKHID"] = (string)cboLoaiKH.SelectedItem;
                    dttb.Rows.Find(maKH)["SoDienThoai"] = txtSoDT.Text;
                    dttb.Rows.Find(maKH)["Email"] = txtEmail.Text;
                    dttb.Rows.Find(maKH)["DiemThuong"] = diemThuong;
                    gridControlKhachHang.DataSource = dttb;
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Bạn Phải chọn khách hàng trước!");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int maKH;
            if (!int.TryParse(txtMaKH.Text, out maKH))
            {
                maKH = -1;
            }

            if (maKH != -1)
            {
                if (/*QLKhachHang.delete(maKH)*/true)
                {
                    MessageBox.Show("Xóa thành công!");
                    dttb.Rows.Remove(dttb.Rows.Find(maKH));
                    gridControlKhachHang.DataSource = dttb;
                }
                else
                {
                    MessageBox.Show("Có lỗi trong quá trình xóa!");
                }
            }
            else
            {
                MessageBox.Show("Bạn Phải chọn khách hàng trước!");
            }
        }
    }
}
