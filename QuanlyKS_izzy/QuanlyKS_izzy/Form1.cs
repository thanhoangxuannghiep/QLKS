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


namespace QuanlyKS_izzy
{
    public partial class Form1 : RibbonForm
    {
        public Form1()
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
            gridDataList.Add(new Person("John", "Smith"));
            gridDataList.Add(new Person("Gabriel", "Smith"));
            gridDataList.Add(new Person("Ashley", "Smith", "some comment"));
            gridDataList.Add(new Person("Adrian", "Smith", "some comment"));
            gridDataList.Add(new Person("Gabriella", "Smith", "some comment"));
            gridControl.DataSource = gridDataList;
        }

        private void btnThuePhong_ItemClick(object sender, ItemClickEventArgs e)
        {
            UserControls.UcThuePhong ucThuePhong = new UserControls.UcThuePhong();
            addNewTab("Thuê Phòng", ucThuePhong);
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

        private void btnQuanLyKH_ItemClick(object sender, ItemClickEventArgs e)
        {
            UserControls.UCKhachHang ucKhachHang = new UserControls.UCKhachHang();
            addNewTab("Quản Lý Khách Hàng", ucKhachHang);
        }

        private void btnThayDoiQuiDinh_ItemClick(object sender, ItemClickEventArgs e)
        {
            UserControls.UcThayDoiQuiDinh ucThayDoiQuiDinh = new UserControls.UcThayDoiQuiDinh();
            addNewTab("Thay Đổi Qui Định", ucThayDoiQuiDinh);
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            UserControls.ucServices ucService = new UserControls.ucServices();
            addNewTab("Dịch vụ", ucService);
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            UserControls.ucBill ucBill = new UserControls.ucBill();
            addNewTab("Hóa đơn", ucBill);
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            UserControls.ucRent ucRent = new UserControls.ucRent();
            addNewTab("Phiếu thuê", ucRent);
        }
    }
}