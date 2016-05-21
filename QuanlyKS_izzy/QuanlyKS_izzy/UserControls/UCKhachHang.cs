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
            QLKhachHang qlkh = new QLKhachHang();
            gridControlKhachHang.DataSource = qlkh.getAll();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //cboLoaiKH.SelectedValue.ToString()
            string[] column_name = { "TenKH", "SoCMND", "LoaiKHID", "GioiTinh", "DiemThuong", "Email", "SoDienThoai" };
            string[] column_values = { txtTenKH.Text, txtSoCMT.Text, "1", cboGioiTinh.SelectedText == "Nam" ? "1" : "0", txtDiemThuong.Text, txtEmail.Text, txtSoDT.Text };
            if(!QLKhachHang.insert("KHACHHANG", column_name, column_values))
            {
                MessageBox.Show("Insert Lỗi!");
            }
        }
    }
}
