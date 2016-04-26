using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;

namespace QuanlyKS_izzy.UserControls
{
    public partial class UcThuePhong : UserControl
    {
        public UcThuePhong()
        {
            InitializeComponent();
        }
        public void loadGalleryPhong()
        {
            galleryControl1.Gallery.Groups[0].Items.Clear();
            Bitmap image;

            int count = 0;
            for (int i = 0; i < 4; i++ )
            {
                count++;
                if (count == 1)
                {
                    image = new Bitmap(Properties.Resources.close);
                }
                else
                {
                    image = new Bitmap(Properties.Resources.open);
                }

                GalleryItem item = new GalleryItem(image, "Phòng " + count, "P" + count);
                //item.Tag = p.MaLoaiPhong.ToString();
                galleryControl1.Gallery.Groups[0].Items.Add(item);
            }
        }

        public void loadGalleryLau()
        {
            galleryControlTang.Gallery.Groups[0].Items.Clear();
            Bitmap image;

            int count = 0;
            for (int i = 0; i < 4; i++)
            {
                count++;
                if (count == 1)
                {
                    image = new Bitmap(Properties.Resources.hotel);
                }
                else
                {
                    image = new Bitmap(Properties.Resources.hotel);
                }

                GalleryItem item = new GalleryItem(image, "Phòng " + count, "P" + count);
                //item.Tag = p.MaLoaiPhong.ToString();
                galleryControl1.Gallery.Groups[0].Items.Add(item);
            }
        }
        private void UcThuePhong_Load(object sender, EventArgs e)
        {
            loadGalleryPhong();
        }

        public void showBill(string mPhong)
        {

        }
        private void galleryControl1_Gallery_ItemClick(object sender, GalleryItemClickEventArgs e)
        {
            
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnChuyenPhong_Click(object sender, EventArgs e)
        {

            
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPhieuThuePhong_Click(object sender, EventArgs e)
        {
            
        }

        private void btnInPhieuThanhToan_Click(object sender, EventArgs e)
        {
            
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            
        }

    }










}
