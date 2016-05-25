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

namespace QuanlyKS_izzy.UserControls
{
    public partial class ucServices : DevExpress.XtraEditors.XtraUserControl
    {
        private int serviceID;

        public ucServices()
        {
            InitializeComponent();
        }

        private void ucServices_Load(object sender, EventArgs e)
        {
            gridCBill.DataSource = procUCService.getAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string[] value = {txtName.Text, txtPrice.Text };
            float v;
            if (!float.TryParse(txtPrice.Text, out v))
            {
                MessageBox.Show(labelControl2.Text + " phải là số !", "Lỗi");
                return;
            }
            if (procUCService.create(value) == -1)
            {
                MessageBox.Show("Thêm dịch vụ thành công !", "Thông báo");
                gridCBill.DataSource = null;
                gridCBill.DataSource = procUCService.getAll();
            }
            else
            {
                switch (procUCService.create(value))
                {
                    case 0:
                        MessageBox.Show(labelControl1.Text + " không được phép bỏ trống !", "Lỗi");
                        break;
                    case 1:
                        MessageBox.Show(labelControl2.Text + " không được phép bỏ trống !", "Lỗi");
                        break;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string[] value = { txtName.Text, txtPrice.Text };
            string _where = "MaDichVu='" + serviceID.ToString() + "'";
            float v;

            if (!float.TryParse(txtPrice.Text, out v))
            {
                MessageBox.Show(labelControl2.Text + " phải là số !", "Lỗi");
                return;
            }

            if (serviceID == null)
            {
                MessageBox.Show("Bạn phải chọn dịch vụ cần cập nhật trước !", "Lỗi");
                return;
            }

            if (procUCService.update(value,_where) == -1)
            {
                MessageBox.Show("Cập nhật dịch vụ thành công !", "Thông báo");
                gridCBill.DataSource = null;
                gridCBill.DataSource = procUCService.getAll();
            }
            else
            {
                switch (procUCService.update(value, _where))
                {
                    case 0:
                        MessageBox.Show(labelControl1.Text + " không được phép bỏ trống !", "Lỗi");
                        break;
                    case 1:
                        MessageBox.Show(labelControl2.Text + " không được phép bỏ trống !", "Lỗi");
                        break;
                }
            }
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            serviceID = int.Parse(gridView1.GetFocusedRowCellValue("MaDichVu").ToString());
            txtName.Text = gridView1.GetFocusedRowCellValue("TenDichVu").ToString();
            txtPrice.Text = gridView1.GetFocusedRowCellValue("Gia").ToString();
            //MessageBox.Show(serviceID.ToString());
        }
    }
}
