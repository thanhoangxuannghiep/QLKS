using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS;
namespace QuanlyKS_izzy
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (procLogin.Login(textBox1.Text, textBox2.Text) == -1)
            {
                this.Hide();
                main a = new main();
                a.Show();
            }
            else
            {
                switch (procLogin.Login(textBox1.Text, textBox2.Text))
                { 
                    case -2:
                        MessageBox.Show("Tài khoản không được phép trống","Lỗi");
                        break;
                    case -3:
                        MessageBox.Show("Mật khẩu không được phép trống", "Lỗi");
                        break;
                }
            }
        }
    }
}