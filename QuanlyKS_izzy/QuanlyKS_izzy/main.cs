using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraTab;
using DevExpress.XtraEditors;
using Microsoft.SqlServer;
using DTO;
namespace QuanlyKS_izzy
{
    public partial class main : RibbonForm
    {
        public main()
        {
            InitializeComponent();
            InitSkinGallery();
            InitGrid();

        }
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }
        BindingList<Person> gridDataList = new BindingList<Person>();
        void InitGrid()
        {
            
        }
        public void addNewTab(string tabName, UserControl uc)
        {
            foreach (XtraTabPage tabpage in tabContent.TabPages)
            {
                if (tabName == tabpage.Text)
                {
                    tabContent.SelectedTabPage = tabpage;
                    return;
                }
            }
            //tao 1 panel
            PanelControl panel = new PanelControl();
            panel.Dock = DockStyle.Fill;
            panel.Name = "panel" + tabName;
            panel.TabIndex = 2;

            //tao tabpage
            XtraTabPage newtabPage = new XtraTabPage();
            newtabPage.Name = tabName;
            newtabPage.Text = tabName;

            //add user control vao panel
            uc.Dock = DockStyle.Fill;
            panel.Controls.Add(uc);

            newtabPage.Controls.Add(panel);
            tabContent.TabPages.Add(newtabPage);
            tabContent.SelectedTabPage = newtabPage;
        }

        private void iHome_ItemClick(object sender, ItemClickEventArgs e)
        {
            UserControls.MainForm mainForm = new UserControls.MainForm();
            tabContent.Controls.Clear();
            mainForm.Dock = DockStyle.Fill;
            tabContent.Controls.Add(mainForm);
        }
        private void btnThuePhong_ItemClick(object sender, ItemClickEventArgs e)
        {
            UserControls.UcThuePhong ucThuePhong = new UserControls.UcThuePhong();
            tabContent.Controls.Clear();
            ucThuePhong.Dock = DockStyle.Fill;
            tabContent.Controls.Add(ucThuePhong);
        }

        private void btnQuanLyKH_ItemClick(object sender, ItemClickEventArgs e)
        {
            UserControls.UCKhachHang ucKhachHang = new UserControls.UCKhachHang();
            tabContent.Controls.Clear();
            ucKhachHang.Dock = DockStyle.Fill;
            tabContent.Controls.Add(ucKhachHang);
        }

        private void btnHoaDon_ItemClick(object sender, ItemClickEventArgs e)
        {
            UserControls.ucBill ucBill = new UserControls.ucBill();
            tabContent.Controls.Clear();
            ucBill.Dock = DockStyle.Fill;
            tabContent.Controls.Add(ucBill);
        }

        private void btnQuyDinh_ItemClick(object sender, ItemClickEventArgs e)
        {
            UserControls.UcThayDoiQuiDinh ucThayDoiQuiDinh = new UserControls.UcThayDoiQuiDinh();
            tabContent.Controls.Clear();
            ucThayDoiQuiDinh.Dock = DockStyle.Fill;
            tabContent.Controls.Add(ucThayDoiQuiDinh);

        }

        //private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        //{
        //    UserControls.ucServices ucService = new UserControls.ucServices();
        //    tabContent.Controls.Clear();
        //    ucService.Dock = DockStyle.Fill;
        //    tabContent.Controls.Add(ucService);
        //}

        //private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        //{
        //    UserControls.ucRent ucRent = new UserControls.ucRent();
        //    tabContent.Controls.Clear();
        //    ucRent.Dock = DockStyle.Fill;
        //    tabContent.Controls.Add(ucRent);
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            UserControls.MainForm mainForm = new UserControls.MainForm();
            tabContent.Controls.Clear();
            mainForm.Dock = DockStyle.Fill;
            tabContent.Controls.Add(mainForm);
        }

        private void btnPhieuThue_ItemClick(object sender, ItemClickEventArgs e)
        {
            UserControls.ucRent ucRent = new UserControls.ucRent();
            tabContent.Controls.Clear();
            ucRent.Dock = DockStyle.Fill;
            tabContent.Controls.Add(ucRent);
        }

        private void btnDichvu_ItemClick(object sender, ItemClickEventArgs e)
        {
            UserControls.ucServices ucService = new UserControls.ucServices();
            tabContent.Controls.Clear();
            ucService.Dock = DockStyle.Fill;
            tabContent.Controls.Add(ucService);
        }

        private void btnDSNV_ItemClick(object sender, ItemClickEventArgs e)
        {
            UserControls.ucNhanVien ucNhanVien = new UserControls.ucNhanVien();
            tabContent.Controls.Clear();
            ucNhanVien.Dock = DockStyle.Fill;
            tabContent.Controls.Add(ucNhanVien);
        }

        private void btnBackup_ItemClick(object sender, ItemClickEventArgs e)
        {
            string backup = "Backup";
            bool exists = System.IO.Directory.Exists(backup);

            if (!exists)
                System.IO.Directory.CreateDirectory(backup);

            string fullpath = "quanlykhachsan-" + System.DateTime.Now.Date.ToString("dd-MM-yyyy") + ".bak";

            DBManager.exportDB(fullpath);


        }

        private void btnImport_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmRestore restore = new frmRestore();
            restore.Show();
        }

        

        
    }
}