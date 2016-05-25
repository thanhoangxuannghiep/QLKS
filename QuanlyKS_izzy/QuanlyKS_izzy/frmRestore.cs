using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Configuration;
using DTO;

namespace QuanlyKS_izzy
{
    public partial class frmRestore : DevExpress.XtraEditors.XtraForm
    {
        public frmRestore()
        {
            InitializeComponent();
        }

        private void frmRestore_Load(object sender, EventArgs e)
        {
            var appSettings = ConfigurationManager.AppSettings;
            string result = appSettings["dirBackup"] ?? "Not Found";
            string[] files = System.IO.Directory.GetFiles(@result, "*.bak");
            this.comboBox1.Items.AddRange(files);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DBManager.importDB(this.comboBox1.Text);
        }
    }
}