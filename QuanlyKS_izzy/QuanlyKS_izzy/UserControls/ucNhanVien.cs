using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using BUS;

namespace QuanlyKS_izzy.UserControls
{
    public partial class ucNhanVien : UserControl
    {
        public ucNhanVien()
        {
            InitializeComponent();
        }

        private void ucNhanVien_Load(object sender, EventArgs e)
        {
            gridControlNhanVien.DataSource = TaiKhoanBUS.getAll();

            //lookUpRoomID.Properties.DataSource = procUCRent.getRoom();
            //lookUpRoomID.Properties.DisplayMember = "TenPhong";
            //lookUpRoomID.Properties.ValueMember = "MaPhong";
            //lookUpRoomID.EditValue = 1;

            //lookUpCustomer.Properties.DataSource = procUCRent.getCustomer();
            //lookUpCustomer.Properties.DisplayMember = "TenKH";
            //lookUpCustomer.Properties.ValueMember = "MaKH";
            //lookUpCustomer.EditValue = 1;

            //dateCreate.EditValue = System.DateTime.Now.ToString();
            //dateStart.EditValue = System.DateTime.Now.ToString();
            //dateEnd.EditValue = System.DateTime.Now.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }
    }
}
