namespace QuanLyThiHocKi
{
    partial class FormQuanLyLichThi
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLyLichThi));
            this.tableLichThi = new System.Windows.Forms.DataGridView();
            this.clMaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaHocPhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenHocPhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNHHK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgayThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSLDangKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPhongThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddLichThi = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbHocPhan = new System.Windows.Forms.ComboBox();
            this.hocPhanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDotHoc = new System.Windows.Forms.ComboBox();
            this.namHocHocKiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnRefresh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lichThiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tableLichThi)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hocPhanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.namHocHocKiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lichThiBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLichThi
            // 
            this.tableLichThi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLichThi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableLichThi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tableLichThi.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableLichThi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tableLichThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLichThi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaLop,
            this.clMaHocPhan,
            this.clTenHocPhan,
            this.clGhiChu,
            this.clNhom,
            this.clNHHK,
            this.clThu,
            this.clNgayThi,
            this.clCa,
            this.clSLDangKy,
            this.clPhongThi});
            this.tableLichThi.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.tableLichThi.Location = new System.Drawing.Point(12, 252);
            this.tableLichThi.MultiSelect = false;
            this.tableLichThi.Name = "tableLichThi";
            this.tableLichThi.RowHeadersWidth = 51;
            this.tableLichThi.RowTemplate.Height = 29;
            this.tableLichThi.Size = new System.Drawing.Size(853, 372);
            this.tableLichThi.TabIndex = 2;
            this.tableLichThi.Tag = "ID";
            // 
            // clMaLop
            // 
            this.clMaLop.DataPropertyName = "MaLop";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clMaLop.DefaultCellStyle = dataGridViewCellStyle2;
            this.clMaLop.HeaderText = "Mã lớp";
            this.clMaLop.MinimumWidth = 6;
            this.clMaLop.Name = "clMaLop";
            // 
            // clMaHocPhan
            // 
            this.clMaHocPhan.DataPropertyName = "MaHocPhan";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clMaHocPhan.DefaultCellStyle = dataGridViewCellStyle3;
            this.clMaHocPhan.HeaderText = "Mã học phần";
            this.clMaHocPhan.MinimumWidth = 6;
            this.clMaHocPhan.Name = "clMaHocPhan";
            // 
            // clTenHocPhan
            // 
            this.clTenHocPhan.DataPropertyName = "TenHP";
            this.clTenHocPhan.HeaderText = "Tên học phần";
            this.clTenHocPhan.MinimumWidth = 6;
            this.clTenHocPhan.Name = "clTenHocPhan";
            // 
            // clGhiChu
            // 
            this.clGhiChu.DataPropertyName = "GhiChu";
            this.clGhiChu.HeaderText = "Ghi chú";
            this.clGhiChu.MinimumWidth = 6;
            this.clGhiChu.Name = "clGhiChu";
            // 
            // clNhom
            // 
            this.clNhom.DataPropertyName = "Nhom";
            this.clNhom.HeaderText = "Nhóm";
            this.clNhom.MinimumWidth = 6;
            this.clNhom.Name = "clNhom";
            // 
            // clNHHK
            // 
            this.clNHHK.DataPropertyName = "NHHK";
            this.clNHHK.HeaderText = "Đợt học";
            this.clNHHK.MinimumWidth = 6;
            this.clNHHK.Name = "clNHHK";
            // 
            // clThu
            // 
            this.clThu.DataPropertyName = "Thu";
            this.clThu.HeaderText = "Thứ";
            this.clThu.MinimumWidth = 6;
            this.clThu.Name = "clThu";
            // 
            // clNgayThi
            // 
            this.clNgayThi.DataPropertyName = "NgayThi";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clNgayThi.DefaultCellStyle = dataGridViewCellStyle4;
            this.clNgayThi.HeaderText = "Ngày thi";
            this.clNgayThi.MinimumWidth = 6;
            this.clNgayThi.Name = "clNgayThi";
            // 
            // clCa
            // 
            this.clCa.DataPropertyName = "Ca";
            this.clCa.HeaderText = "Ca";
            this.clCa.MinimumWidth = 6;
            this.clCa.Name = "clCa";
            // 
            // clSLDangKy
            // 
            this.clSLDangKy.DataPropertyName = "SLDK";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clSLDangKy.DefaultCellStyle = dataGridViewCellStyle5;
            this.clSLDangKy.HeaderText = "SLĐK";
            this.clSLDangKy.MinimumWidth = 6;
            this.clSLDangKy.Name = "clSLDangKy";
            // 
            // clPhongThi
            // 
            this.clPhongThi.DataPropertyName = "PhongThi";
            this.clPhongThi.HeaderText = "Phòng thi";
            this.clPhongThi.MinimumWidth = 6;
            this.clPhongThi.Name = "clPhongThi";
            // 
            // btnAddLichThi
            // 
            this.btnAddLichThi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddLichThi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddLichThi.BackgroundImage")));
            this.btnAddLichThi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddLichThi.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddLichThi.FlatAppearance.BorderSize = 2;
            this.btnAddLichThi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddLichThi.Location = new System.Drawing.Point(6, 21);
            this.btnAddLichThi.Name = "btnAddLichThi";
            this.btnAddLichThi.Size = new System.Drawing.Size(65, 65);
            this.btnAddLichThi.TabIndex = 0;
            this.btnAddLichThi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddLichThi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnAddLichThi, "Thêm lịch thi");
            this.btnAddLichThi.UseVisualStyleBackColor = true;
            this.btnAddLichThi.Click += new System.EventHandler(this.btnAddLichThi_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUpdate.FlatAppearance.BorderSize = 2;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(77, 21);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(65, 65);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnUpdate, "Sửa lịch thi");
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemove.BackgroundImage")));
            this.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRemove.FlatAppearance.BorderSize = 2;
            this.btnRemove.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemove.Location = new System.Drawing.Point(148, 21);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(65, 65);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnRemove, "Xoá lịch thi");
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDownload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDownload.BackgroundImage")));
            this.btnDownload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDownload.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDownload.FlatAppearance.BorderSize = 2;
            this.btnDownload.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDownload.Location = new System.Drawing.Point(219, 21);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(65, 65);
            this.btnDownload.TabIndex = 6;
            this.btnDownload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDownload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnDownload, "Tải mẫu Excel");
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnChooseFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChooseFile.BackgroundImage")));
            this.btnChooseFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnChooseFile.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnChooseFile.FlatAppearance.BorderSize = 2;
            this.btnChooseFile.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChooseFile.Location = new System.Drawing.Point(290, 21);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(65, 65);
            this.btnChooseFile.TabIndex = 4;
            this.btnChooseFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChooseFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnChooseFile, "Chọn file Excel");
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBack.FlatAppearance.BorderSize = 2;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(782, 21);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(65, 65);
            this.btnBack.TabIndex = 5;
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnBack, "Quay lại");
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtKeyword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbHocPhan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbDotHoc);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(12, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(853, 136);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // txtKeyword
            // 
            this.txtKeyword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKeyword.Location = new System.Drawing.Point(105, 87);
            this.txtKeyword.Multiline = true;
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(671, 33);
            this.txtKeyword.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Học phần:";
            // 
            // cbHocPhan
            // 
            this.cbHocPhan.DataSource = this.hocPhanBindingSource;
            this.cbHocPhan.DisplayMember = "TenHp";
            this.cbHocPhan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbHocPhan.FormattingEnabled = true;
            this.cbHocPhan.Location = new System.Drawing.Point(505, 29);
            this.cbHocPhan.Name = "cbHocPhan";
            this.cbHocPhan.Size = new System.Drawing.Size(271, 34);
            this.cbHocPhan.TabIndex = 5;
            this.cbHocPhan.ValueMember = "Id";
            // 
            // hocPhanBindingSource
            // 
            this.hocPhanBindingSource.DataSource = typeof(QuanLyThiHocKi.Models.EntitiesNew.HocPhan);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Từ khoá:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Đợt học:";
            // 
            // cbDotHoc
            // 
            this.cbDotHoc.DataSource = this.namHocHocKiBindingSource;
            this.cbDotHoc.DisplayMember = "NamHoc";
            this.cbDotHoc.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbDotHoc.FormattingEnabled = true;
            this.cbDotHoc.Location = new System.Drawing.Point(105, 28);
            this.cbDotHoc.Name = "cbDotHoc";
            this.cbDotHoc.Size = new System.Drawing.Size(271, 34);
            this.cbDotHoc.TabIndex = 3;
            this.cbDotHoc.ValueMember = "ID";
            // 
            // namHocHocKiBindingSource
            // 
            this.namHocHocKiBindingSource.DataSource = typeof(QuanLyThiHocKi.Models.EntitiesNew.NamHocHocKi);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRefresh.FlatAppearance.BorderSize = 2;
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.Location = new System.Drawing.Point(797, 20);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(50, 50);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnRefresh, "Reload");
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(797, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 1;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.button1, "Tìm kiếm");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lichThiBindingSource
            // 
            this.lichThiBindingSource.DataSource = typeof(QuanLyThiHocKi.Models.EntitiesNew.LichThi);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXacNhan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXacNhan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXacNhan.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnXacNhan.FlatAppearance.BorderSize = 2;
            this.btnXacNhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXacNhan.Location = new System.Drawing.Point(711, 21);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(65, 65);
            this.btnXacNhan.TabIndex = 5;
            this.btnXacNhan.Text = "OK";
            this.toolTip1.SetToolTip(this.btnXacNhan, "Xác nhận");
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtFilePath);
            this.groupBox2.Controls.Add(this.btnAddLichThi);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnXacNhan);
            this.groupBox2.Controls.Add(this.btnBack);
            this.groupBox2.Controls.Add(this.btnRemove);
            this.groupBox2.Controls.Add(this.btnChooseFile);
            this.groupBox2.Controls.Add(this.btnDownload);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(853, 92);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thao tác";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilePath.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtFilePath.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFilePath.Location = new System.Drawing.Point(361, 21);
            this.txtFilePath.Multiline = true;
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFilePath.Size = new System.Drawing.Size(344, 65);
            this.txtFilePath.TabIndex = 7;
            // 
            // FormQuanLyLichThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 632);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLichThi);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormQuanLyLichThi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý lịch thi";
            this.Load += new System.EventHandler(this.FormQuanLyLichThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableLichThi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hocPhanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.namHocHocKiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lichThiBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridView tableLichThi;
        private Button btnAddLichThi;
        private Button btnUpdate;
        private Button btnRemove;
        private Button btnChooseFile;
        private GroupBox groupBox1;
        private Button button1;
        private BindingSource lichThiBindingSource;
        private Button btnBack;
        private Button btnRefresh;
        private OpenFileDialog openFileDialog1;
        private Button btnDownload;
        private ToolTip toolTip1;
        private GroupBox groupBox2;
        private TextBox txtFilePath;
        private Button btnXacNhan;
        private ComboBox cbDotHoc;
        private Label label1;
        private Label label2;
        private ComboBox cbHocPhan;
        private TextBox txtKeyword;
        private Label label3;
        private BindingSource hocPhanBindingSource;
        private BindingSource namHocHocKiBindingSource;
        private DataGridViewTextBoxColumn clMaLop;
        private DataGridViewTextBoxColumn clMaHocPhan;
        private DataGridViewTextBoxColumn clTenHocPhan;
        private DataGridViewTextBoxColumn clGhiChu;
        private DataGridViewTextBoxColumn clNhom;
        private DataGridViewTextBoxColumn clNHHK;
        private DataGridViewTextBoxColumn clThu;
        private DataGridViewTextBoxColumn clNgayThi;
        private DataGridViewTextBoxColumn clCa;
        private DataGridViewTextBoxColumn clSLDangKy;
        private DataGridViewTextBoxColumn clPhongThi;
    }
}