using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using BUS;

namespace QuanlyKS_izzy.UserControls
{
    public partial class ucTaiKhoan : UserControl
    {
        public ucTaiKhoan()
        {
            InitializeComponent();
        }

        private void gridControlNhanVien_Load(object sender, EventArgs e)
        {
            gridControlTaiKhoan.DataSource = TaiKhoanBUS.getAll();

            DataTable ds = new DataTable();
            ds = TaiKhoanBUS.get_loainhanvien();
            cboLoaiNV.DisplayMember = "TenLoaiNhanVien";
            cboLoaiNV.ValueMember = "MaLoaiNV";
            cboLoaiNV.DataSource = ds;

        }
        bool IsValidEmail(string strIn)
        {
            // Return true if strIn is in valid e-mail format.
            return Regex.IsMatch(strIn, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }
        bool check_username(string username)
        {
            if (TaiKhoanBUS.get_user_byUsername(username).Rows.Count==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        bool check_email(string email)
        {
            if (TaiKhoanBUS.get_email_byEmail(txtEmail.Text).Rows.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string gt = cboGioiTinh.Text;
            string gt_temp;
            if (gt == "nam")
                gt_temp = "1";
            else
                gt_temp = "0";
            gt = gt_temp;
            string email = txtEmail.Text;
            if (!IsValidEmail(email) && email != "")
            {
                MessageBox.Show(label11.Text + " không hợp lệ !", "Lỗi");
            }
            if (!check_email(email) && email != "")
            {
                MessageBox.Show(label11.Text + " đã tồn tại !", "Lỗi");
            }
            if (!check_username(txtUsername.Text) && txtUsername.Text != "")
            {
                MessageBox.Show(label8.Text + " đã tồn tại !", "Lỗi");
            }
            string stt = cboTrangThai.Text;
            string stt_temp;
            if (stt == "Đang hoạt động")
                stt_temp = "0";
            else
                stt_temp = "1";
            stt = stt_temp;
            if(txtPassword.Text != ""){
                using (MD5 md5Hash = MD5.Create())
                {
                    txtPassword.Text = GetMd5Hash(md5Hash, txtPassword.Text);
                }
            }
            string type = cboLoaiNV.SelectedValue.ToString();
            int active = 0;
            if (checkActive.Checked) { active = 1; }
            string[] value = { 
                                txtTenNV.Text, txtSoCMND.Text, dateNgayVaoLam.Text,
                                dateNgaySinh.Text, email, txtSoDT.Text, txtUsername.Text, txtPassword.Text,
                                type, gt, stt, active.ToString()
                             };
            if (TaiKhoanBUS.create(value) == -1)
            {
                MessageBox.Show("Thêm Tài Khoản thành công !", "Thông báo");
                gridControlTaiKhoan.DataSource = null;
                gridControlTaiKhoan.DataSource = TaiKhoanBUS.getAll();
            }
            else
            {
                switch (procUCRent.create(value))
                {
                    case 0:
                        MessageBox.Show(label1.Text + " không được phép bỏ trống !", "Lỗi");
                        break;
                    case 1:
                        MessageBox.Show(label2.Text + " không được phép bỏ trống !", "Lỗi");
                        break;
                    case 2:
                        MessageBox.Show(label6.Text + " không được phép bỏ trống !", "Lỗi");
                        break;
                    case 3:
                        MessageBox.Show(label3.Text + " không được phép bỏ trống !", "Lỗi");
                        break;
                    case 9:
                        MessageBox.Show(label4.Text + " không được phép bỏ trống !", "Lỗi");
                        break;
                    case 10:
                        MessageBox.Show(label7.Text + " không được phép bỏ trống !", "Lỗi");
                        break;
                    case 6:
                        MessageBox.Show(label8.Text + " không được phép bỏ trống !", "Lỗi");
                        break;
                    case 7:
                        MessageBox.Show(label9.Text + " không được phép bỏ trống !", "Lỗi");
                        break;
                    case 5:
                        MessageBox.Show(label10.Text + " không được phép bỏ trống !", "Lỗi");
                        break;
                    case 4:
                        MessageBox.Show(label11.Text + " không được phép bỏ trống !", "Lỗi");
                        break;
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string gt = cboGioiTinh.Text;
            string gt_temp;
            if (gt == "nam")
                gt_temp = "1";
            else
                gt_temp = "0";
            gt = gt_temp;
            string email = txtEmail.Text;
            if (!IsValidEmail(email) && email != "")
            {
                MessageBox.Show(label11.Text + " không hợp lệ !", "Lỗi");
            }
            if (!check_email(email) && email != "")
            {
                MessageBox.Show(label11.Text + " đã tồn tại !", "Lỗi");
            }
            if (!check_username(txtUsername.Text) && txtUsername.Text != "")
            {
                MessageBox.Show(label8.Text + " đã tồn tại !", "Lỗi");
            }
            string stt = cboTrangThai.Text;
            string stt_temp;
            if (stt == "Đang hoạt động")
                stt_temp = "0";
            else
                stt_temp = "1";
            stt = stt_temp;
            if (txtPassword.Text != "")
            {
                using (MD5 md5Hash = MD5.Create())
                {
                    txtPassword.Text = GetMd5Hash(md5Hash, txtPassword.Text);
                }
            }
            string type = cboLoaiNV.SelectedValue.ToString();
            int active = 0;
            if (checkActive.Checked) { active = 1; }
            string[] value = { 
                                txtTenNV.Text, txtSoCMND.Text, dateNgayVaoLam.Text,
                                dateNgaySinh.Text, email, txtSoDT.Text, txtUsername.Text, txtPassword.Text,
                                type, gt, stt, active.ToString()
                             };
            string _where = "MaTaiKhoan = '" + txtMaTk.Text + "'";
            if (TaiKhoanBUS.update(value, _where) == -1)
            {
                MessageBox.Show("Thêm Tài Khoản thành công !", "Thông báo");
                gridControlTaiKhoan.DataSource = null;
                gridControlTaiKhoan.DataSource = TaiKhoanBUS.getAll();
            }
            else
            {
                switch (procUCRent.create(value))
                {
                    case 0:
                        MessageBox.Show(label1.Text + " không được phép bỏ trống !", "Lỗi");
                        break;
                    case 1:
                        MessageBox.Show(label2.Text + " không được phép bỏ trống !", "Lỗi");
                        break;
                    case 2:
                        MessageBox.Show(label6.Text + " không được phép bỏ trống !", "Lỗi");
                        break;
                    case 3:
                        MessageBox.Show(label3.Text + " không được phép bỏ trống !", "Lỗi");
                        break;
                    case 9:
                        MessageBox.Show(label4.Text + " không được phép bỏ trống !", "Lỗi");
                        break;
                    case 10:
                        MessageBox.Show(label7.Text + " không được phép bỏ trống !", "Lỗi");
                        break;
                    case 6:
                        MessageBox.Show(label8.Text + " không được phép bỏ trống !", "Lỗi");
                        break;
                    case 7:
                        MessageBox.Show(label9.Text + " không được phép bỏ trống !", "Lỗi");
                        break;
                    case 5:
                        MessageBox.Show(label10.Text + " không được phép bỏ trống !", "Lỗi");
                        break;
                    case 4:
                        MessageBox.Show(label11.Text + " không được phép bỏ trống !", "Lỗi");
                        break;
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
