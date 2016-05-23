namespace QuanlyKS_izzy.UserControls
{
    partial class ucRent
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucRent));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.lookUpCustomer = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpRoomID = new DevExpress.XtraEditors.LookUpEdit();
            this.cbRentStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dateStart = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dateCreate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dateEnd = new DevExpress.XtraEditors.DateEdit();
            this.btnRentUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnRentDel = new DevExpress.XtraEditors.SimpleButton();
            this.btnRentAdd = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtRentName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtRentID = new DevExpress.XtraEditors.TextEdit();
            this.gridCRent = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColMaPT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColTenPT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColTTPT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColMaPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColNgayLap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColStart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColEnd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColCUS = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpRoomID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRentStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCreate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCreate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRentName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCRent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.lookUpCustomer);
            this.splitContainerControl1.Panel1.Controls.Add(this.lookUpRoomID);
            this.splitContainerControl1.Panel1.Controls.Add(this.cbRentStatus);
            this.splitContainerControl1.Panel1.Controls.Add(this.dateStart);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainerControl1.Panel1.Controls.Add(this.dateCreate);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl1);
            this.splitContainerControl1.Panel1.Controls.Add(this.dateEnd);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnRentUpdate);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnRentDel);
            this.splitContainerControl1.Panel1.Controls.Add(this.btnRentAdd);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl9);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl8);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl7);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl6);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtRentName);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl5);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl4);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtRentID);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridCRent);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1031, 612);
            this.splitContainerControl1.SplitterPosition = 310;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // lookUpCustomer
            // 
            this.lookUpCustomer.Location = new System.Drawing.Point(3, 349);
            this.lookUpCustomer.Name = "lookUpCustomer";
            this.lookUpCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpCustomer.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpCustomer.Size = new System.Drawing.Size(301, 20);
            this.lookUpCustomer.TabIndex = 43;
            // 
            // lookUpRoomID
            // 
            this.lookUpRoomID.Location = new System.Drawing.Point(3, 163);
            this.lookUpRoomID.Name = "lookUpRoomID";
            this.lookUpRoomID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpRoomID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpRoomID.Size = new System.Drawing.Size(301, 20);
            this.lookUpRoomID.TabIndex = 42;
            // 
            // cbRentStatus
            // 
            this.cbRentStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRentStatus.Location = new System.Drawing.Point(4, 117);
            this.cbRentStatus.Name = "cbRentStatus";
            this.cbRentStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbRentStatus.Properties.Items.AddRange(new object[] {
            "Tình trạng 1",
            "Tình trạng 2",
            "Tình trạng 3"});
            this.cbRentStatus.Size = new System.Drawing.Size(300, 20);
            this.cbRentStatus.TabIndex = 38;
            // 
            // dateStart
            // 
            this.dateStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateStart.EditValue = null;
            this.dateStart.Location = new System.Drawing.Point(3, 255);
            this.dateStart.Name = "dateStart";
            this.dateStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateStart.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateStart.Size = new System.Drawing.Size(301, 20);
            this.dateStart.TabIndex = 37;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(4, 235);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(86, 16);
            this.labelControl2.TabIndex = 36;
            this.labelControl2.Text = "Ngày bắt đầu";
            // 
            // dateCreate
            // 
            this.dateCreate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateCreate.EditValue = null;
            this.dateCreate.Enabled = false;
            this.dateCreate.Location = new System.Drawing.Point(4, 209);
            this.dateCreate.Name = "dateCreate";
            this.dateCreate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateCreate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateCreate.Size = new System.Drawing.Size(300, 20);
            this.dateCreate.TabIndex = 35;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(5, 189);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 16);
            this.labelControl1.TabIndex = 34;
            this.labelControl1.Text = "Ngày lập";
            // 
            // dateEnd
            // 
            this.dateEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateEnd.EditValue = null;
            this.dateEnd.Location = new System.Drawing.Point(3, 301);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEnd.Size = new System.Drawing.Size(301, 20);
            this.dateEnd.TabIndex = 33;
            // 
            // btnRentUpdate
            // 
            this.btnRentUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRentUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnRentUpdate.Image")));
            this.btnRentUpdate.Location = new System.Drawing.Point(111, 386);
            this.btnRentUpdate.Name = "btnRentUpdate";
            this.btnRentUpdate.Size = new System.Drawing.Size(88, 23);
            this.btnRentUpdate.TabIndex = 32;
            this.btnRentUpdate.Text = "Cập nhật";
            this.btnRentUpdate.Click += new System.EventHandler(this.btnRentUpdate_Click);
            // 
            // btnRentDel
            // 
            this.btnRentDel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRentDel.Image = ((System.Drawing.Image)(resources.GetObject("btnRentDel.Image")));
            this.btnRentDel.Location = new System.Drawing.Point(216, 386);
            this.btnRentDel.Name = "btnRentDel";
            this.btnRentDel.Size = new System.Drawing.Size(88, 23);
            this.btnRentDel.TabIndex = 31;
            this.btnRentDel.Text = "Xóa";
            this.btnRentDel.Click += new System.EventHandler(this.btnRentDel_Click);
            // 
            // btnRentAdd
            // 
            this.btnRentAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRentAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnRentAdd.Image")));
            this.btnRentAdd.Location = new System.Drawing.Point(7, 386);
            this.btnRentAdd.Name = "btnRentAdd";
            this.btnRentAdd.Size = new System.Drawing.Size(88, 23);
            this.btnRentAdd.TabIndex = 30;
            this.btnRentAdd.Text = "Thêm";
            this.btnRentAdd.Click += new System.EventHandler(this.btnRentAdd_Click);
            // 
            // labelControl9
            // 
            this.labelControl9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Location = new System.Drawing.Point(4, 327);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(75, 16);
            this.labelControl9.TabIndex = 29;
            this.labelControl9.Text = "Khách hàng";
            // 
            // labelControl8
            // 
            this.labelControl8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Location = new System.Drawing.Point(6, 143);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(63, 16);
            this.labelControl8.TabIndex = 27;
            this.labelControl8.Text = "Mã phòng";
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(4, 97);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(139, 16);
            this.labelControl7.TabIndex = 25;
            this.labelControl7.Text = "Tình trạng phiếu thuê";
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(4, 51);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(96, 16);
            this.labelControl6.TabIndex = 23;
            this.labelControl6.Text = "Tên phiếu thuê";
            // 
            // txtRentName
            // 
            this.txtRentName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRentName.Location = new System.Drawing.Point(3, 71);
            this.txtRentName.Name = "txtRentName";
            this.txtRentName.Size = new System.Drawing.Size(301, 20);
            this.txtRentName.TabIndex = 22;
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(4, 281);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(90, 16);
            this.labelControl5.TabIndex = 21;
            this.labelControl5.Text = "Ngày kết thúc";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(4, 6);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(92, 16);
            this.labelControl4.TabIndex = 20;
            this.labelControl4.Text = "Mã phiếu thuê";
            // 
            // txtRentID
            // 
            this.txtRentID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRentID.Location = new System.Drawing.Point(3, 26);
            this.txtRentID.Name = "txtRentID";
            this.txtRentID.Properties.ReadOnly = true;
            this.txtRentID.Size = new System.Drawing.Size(301, 20);
            this.txtRentID.TabIndex = 19;
            // 
            // gridCRent
            // 
            this.gridCRent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridCRent.Location = new System.Drawing.Point(4, 29);
            this.gridCRent.MainView = this.gridView1;
            this.gridCRent.Name = "gridCRent";
            this.gridCRent.Size = new System.Drawing.Size(709, 580);
            this.gridCRent.TabIndex = 11;
            this.gridCRent.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColMaPT,
            this.gridColTenPT,
            this.gridColTTPT,
            this.gridColMaPhong,
            this.gridColNgayLap,
            this.gridColStart,
            this.gridColEnd,
            this.gridColCUS});
            this.gridView1.GridControl = this.gridCRent;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindDelay = 100;
            this.gridView1.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click);
            // 
            // gridColMaPT
            // 
            this.gridColMaPT.Caption = "Mã phiếu thuê";
            this.gridColMaPT.FieldName = "MaPhieuThue";
            this.gridColMaPT.Name = "gridColMaPT";
            this.gridColMaPT.OptionsColumn.AllowEdit = false;
            this.gridColMaPT.Visible = true;
            this.gridColMaPT.VisibleIndex = 0;
            // 
            // gridColTenPT
            // 
            this.gridColTenPT.Caption = "Tên phiếu thuê";
            this.gridColTenPT.FieldName = "TenPhieuThue";
            this.gridColTenPT.Name = "gridColTenPT";
            this.gridColTenPT.OptionsColumn.AllowEdit = false;
            this.gridColTenPT.OptionsColumn.AllowFocus = false;
            this.gridColTenPT.Visible = true;
            this.gridColTenPT.VisibleIndex = 1;
            // 
            // gridColTTPT
            // 
            this.gridColTTPT.Caption = "Tình trạng phiếu thuê";
            this.gridColTTPT.FieldName = "TinhTrangPhieuThue";
            this.gridColTTPT.Name = "gridColTTPT";
            this.gridColTTPT.OptionsColumn.AllowEdit = false;
            this.gridColTTPT.OptionsColumn.AllowFocus = false;
            this.gridColTTPT.Visible = true;
            this.gridColTTPT.VisibleIndex = 2;
            // 
            // gridColMaPhong
            // 
            this.gridColMaPhong.Caption = "Mã phòng";
            this.gridColMaPhong.FieldName = "MaPhong";
            this.gridColMaPhong.Name = "gridColMaPhong";
            this.gridColMaPhong.OptionsColumn.AllowEdit = false;
            this.gridColMaPhong.OptionsColumn.AllowFocus = false;
            this.gridColMaPhong.Visible = true;
            this.gridColMaPhong.VisibleIndex = 3;
            // 
            // gridColNgayLap
            // 
            this.gridColNgayLap.Caption = "Ngày lập";
            this.gridColNgayLap.FieldName = "NgayLap";
            this.gridColNgayLap.Name = "gridColNgayLap";
            this.gridColNgayLap.OptionsColumn.AllowEdit = false;
            this.gridColNgayLap.OptionsColumn.AllowFocus = false;
            this.gridColNgayLap.Visible = true;
            this.gridColNgayLap.VisibleIndex = 4;
            // 
            // gridColStart
            // 
            this.gridColStart.Caption = "Ngày bắt đầu";
            this.gridColStart.FieldName = "NgayBatDau";
            this.gridColStart.Name = "gridColStart";
            this.gridColStart.OptionsColumn.AllowEdit = false;
            this.gridColStart.OptionsColumn.AllowFocus = false;
            this.gridColStart.Visible = true;
            this.gridColStart.VisibleIndex = 5;
            // 
            // gridColEnd
            // 
            this.gridColEnd.Caption = "Ngày kết thúc";
            this.gridColEnd.FieldName = "NgayKetThuc";
            this.gridColEnd.Name = "gridColEnd";
            this.gridColEnd.OptionsColumn.AllowEdit = false;
            this.gridColEnd.OptionsColumn.AllowFocus = false;
            this.gridColEnd.Visible = true;
            this.gridColEnd.VisibleIndex = 6;
            // 
            // gridColCUS
            // 
            this.gridColCUS.Caption = "Khách hàng";
            this.gridColCUS.FieldName = "MaKH";
            this.gridColCUS.Name = "gridColCUS";
            this.gridColCUS.OptionsColumn.AllowEdit = false;
            this.gridColCUS.OptionsColumn.AllowFocus = false;
            this.gridColCUS.Visible = true;
            this.gridColCUS.VisibleIndex = 7;
            // 
            // ucRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "ucRent";
            this.Size = new System.Drawing.Size(1031, 612);
            this.Load += new System.EventHandler(this.ucRent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpRoomID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbRentStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCreate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateCreate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRentName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCRent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridCRent;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColMaPT;
        private DevExpress.XtraGrid.Columns.GridColumn gridColTenPT;
        private DevExpress.XtraGrid.Columns.GridColumn gridColTTPT;
        private DevExpress.XtraGrid.Columns.GridColumn gridColMaPhong;
        private DevExpress.XtraGrid.Columns.GridColumn gridColNgayLap;
        private DevExpress.XtraGrid.Columns.GridColumn gridColStart;
        private DevExpress.XtraGrid.Columns.GridColumn gridColEnd;
        private DevExpress.XtraGrid.Columns.GridColumn gridColCUS;
        private DevExpress.XtraEditors.DateEdit dateStart;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dateCreate;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dateEnd;
        private DevExpress.XtraEditors.SimpleButton btnRentUpdate;
        private DevExpress.XtraEditors.SimpleButton btnRentDel;
        private DevExpress.XtraEditors.SimpleButton btnRentAdd;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtRentName;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtRentID;
        private DevExpress.XtraEditors.ComboBoxEdit cbRentStatus;
        private DevExpress.XtraEditors.LookUpEdit lookUpRoomID;
        private DevExpress.XtraEditors.LookUpEdit lookUpCustomer;
    }
}
