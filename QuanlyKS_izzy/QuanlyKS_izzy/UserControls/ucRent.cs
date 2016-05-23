using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using BUS;
namespace QuanlyKS_izzy.UserControls
{
    public partial class ucRent : DevExpress.XtraEditors.XtraUserControl
    {
        
        public ucRent()
        {
            InitializeComponent();
        }

        private void btnRentAdd_Click(object sender, EventArgs e)
        {
            string[] value = { txtRentName.Text, cbRentStatus.SelectedText.ToString(), lookUpRoomID.EditValue.ToString(), dateCreate.EditValue.ToString(), dateStart.EditValue.ToString(), dateEnd.EditValue.ToString(), lookUpCustomer.EditValue.ToString() };
            if (procUCRent.create(value) == -1)
            {
                MessageBox.Show("Thêm phiếu thuê thành công !","Thông báo");
                gridCRent.DataSource = null;
                gridCRent.DataSource = procUCRent.getAll();
            }
            else 
            {
                switch (procUCRent.create(value))
                { 
                    case 0:
                        MessageBox.Show(labelControl6.Text + " không được phép bỏ trống !", "Lỗi");
                        break;
                    case 1:
                        MessageBox.Show(labelControl7.Text + " không được phép bỏ trống !", "Lỗi");
                        break;
                    case 2:
                        MessageBox.Show(labelControl8.Text + " không được phép bỏ trống !", "Lỗi");
                        break;
                    case 3:
                        MessageBox.Show(labelControl1.Text + " không được phép bỏ trống !", "Lỗi");
                        break;
                    case 4:
                        MessageBox.Show(labelControl2.Text + " không được phép bỏ trống !", "Lỗi");
                        break;
                    case 5:
                        MessageBox.Show(labelControl5.Text + " không được phép bỏ trống !", "Lỗi");
                        break;
                    case 6:
                        MessageBox.Show(labelControl9.Text + " không được phép bỏ trống !", "Lỗi");
                        break;
                }
            }
        }

        private void ucRent_Load(object sender, EventArgs e)
        {
            gridCRent.DataSource = procUCRent.getAll();

            lookUpRoomID.Properties.DataSource = procUCRent.getRoom();
            lookUpRoomID.Properties.DisplayMember = "TenPhong";
            lookUpRoomID.Properties.ValueMember = "MaPhong";
            lookUpRoomID.EditValue = 1;

            lookUpCustomer.Properties.DataSource = procUCRent.getCustomer();
            lookUpCustomer.Properties.DisplayMember = "TenKH";
            lookUpCustomer.Properties.ValueMember = "MaKH";
            lookUpCustomer.EditValue = 1;

            dateCreate.EditValue = System.DateTime.Now.ToString();
            dateStart.EditValue = System.DateTime.Now.ToString();
            dateEnd.EditValue = System.DateTime.Now.ToString();
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            txtRentID.Text = gridView1.GetFocusedRowCellValue("MaPhieuThue").ToString();
            txtRentName.Text = gridView1.GetFocusedRowCellValue("TenPhieuThue").ToString();
            cbRentStatus.EditValue = gridView1.GetFocusedRowCellValue("TinhTrangPhieuThue").ToString();
            lookUpRoomID.EditValue = gridView1.GetFocusedRowCellValue("MaPhong");
            dateCreate.EditValue = gridView1.GetFocusedRowCellValue("NgayLap").ToString();
            dateStart.EditValue = gridView1.GetFocusedRowCellValue("NgayBatDau").ToString();
            dateEnd.EditValue = gridView1.GetFocusedRowCellValue("NgayKetThuc").ToString();
            lookUpCustomer.EditValue = gridView1.GetFocusedRowCellValue("MaKH");
        }

        private void btnRentUpdate_Click(object sender, EventArgs e)
        {
            string[] value = { txtRentName.Text, cbRentStatus.SelectedText.ToString(), lookUpRoomID.EditValue.ToString(), dateCreate.EditValue.ToString(), dateStart.EditValue.ToString(), dateEnd.EditValue.ToString(), lookUpCustomer.EditValue.ToString() };
            string _where = "MaPhieuThue='"+ txtRentID.Text + "'" ;

            if (dateCreate.DateTime > dateEnd.DateTime)
            {
                MessageBox.Show("Ngày bắt đầu không được phép là tương lai !", "Lỗi");
                return;
            }

            if (procUCRent.update(value,_where) == -1)
            {
                MessageBox.Show("Cập nhật phiếu thuê thành công !", "Thông báo");
                gridCRent.DataSource = null;
                gridCRent.DataSource = procUCRent.getAll();
            }
            else
            {
                switch (procUCRent.update(value, _where))
                {
                    case 0:
                        MessageBox.Show(labelControl6.Text + " không được phép bỏ trống !", "Lỗi");
                        break;
                    case 1:
                        MessageBox.Show(labelControl7.Text + " không được phép bỏ trống !", "Lỗi");
                        break;
                    case 2:
                        MessageBox.Show(labelControl8.Text + " không được phép bỏ trống !", "Lỗi");
                        break;
                    case 3:
                        MessageBox.Show(labelControl1.Text + " không được phép bỏ trống !", "Lỗi");
                        break;
                    case 4:
                        MessageBox.Show(labelControl2.Text + " không được phép bỏ trống !", "Lỗi");
                        break;
                    case 5:
                        MessageBox.Show(labelControl5.Text + " không được phép bỏ trống !", "Lỗi");
                        break;
                    case 6:
                        MessageBox.Show(labelControl9.Text + " không được phép bỏ trống !", "Lỗi");
                        break;
                }
            }
        }

        private void btnRentDel_Click(object sender, EventArgs e)
        {
            if (procUCRent.delbyid(txtRentID.Text))
            {
                MessageBox.Show("Xóa phiếu thuê thành công !", "Thông báo");
                gridCRent.DataSource = null;
                gridCRent.DataSource = procUCRent.getAll();
            }
            else 
            {
                MessageBox.Show("Mã phiếu thuê không được phép bỏ trống !", "Lỗi");
            }
        }
    }
}
