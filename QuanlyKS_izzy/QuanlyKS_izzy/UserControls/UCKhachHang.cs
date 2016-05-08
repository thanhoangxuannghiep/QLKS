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
    }
}
