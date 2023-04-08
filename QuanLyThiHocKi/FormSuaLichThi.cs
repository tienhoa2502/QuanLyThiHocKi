using QuanLyThiHocKi.Models.EntitiesNew;
using System.Globalization;

namespace QuanLyThiHocKi
{
    public partial class FormSuaLichThi : Form
    {
        private LichThi _lichThi;
        public delegate void FormClosedHandler();
        public FormClosedHandler FormClosedCallback;
        public FormSuaLichThi(LichThi lichThi)
        {
            InitializeComponent();
            _lichThi = lichThi;
        }

        private void FormSuaLichThi_Load(object sender, EventArgs e)
        {
            QuanLyThiHocKiContext context = new QuanLyThiHocKiContext();
            cbLopHoc.DataSource = context.LopHocs.ToList();
            cbLopHoc.SelectedValue = _lichThi.Idlop;

            cbHocPhan.DataSource = context.HocPhans.ToList();
            cbHocPhan.SelectedValue = _lichThi.Idhp;

            cbDotHoc.DataSource = context.NamHocHocKis
                .Select(x => new { id = x.Id, NamHoc = "Học kì: " + x.HocKi + " Năm: " + x.NamHoc })
                .ToList();
            cbDotHoc.SelectedValue = _lichThi.Idnhhk;

            cbCa.DataSource = context.Cas.ToList();
            cbCa.SelectedValue = _lichThi.Ca;

            cbPhongHoc.DataSource = context.PhongHocs.ToList();
            cbPhongHoc.SelectedValue = _lichThi.Idph;

            txtGhiChu.Text = _lichThi.GhiChu;
            txtNgayThi.Value = _lichThi.NgayThi;
            txtNhom.Value = (decimal)_lichThi.Nhom;
            txtSLDK.Value = (decimal)_lichThi.Sldk;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            QuanLyThiHocKiContext context = new QuanLyThiHocKiContext();


            _lichThi.Idlop = (int)cbLopHoc.SelectedValue;
            _lichThi.Idhp = (int)cbHocPhan.SelectedValue;
            _lichThi.Idnhhk = (int)cbDotHoc.SelectedValue;
            _lichThi.Ca = (int)cbHocPhan.SelectedValue;
            _lichThi.Idph = (int)cbPhongHoc.SelectedValue;

            _lichThi.GhiChu = txtGhiChu.Text;
            _lichThi.Nhom = (int)txtNhom.Value;
            _lichThi.Sldk = (int)txtSLDK.Value;
            string n = txtNgayThi.Text;
            _lichThi.NgayThi = DateTime.ParseExact(n, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            _lichThi.TrangThaiToChuc = false;
            _lichThi.TrangThai = true;
            _lichThi.KinhPhiToChuc = 0;

            var tran = context.Database.BeginTransaction();

            try
            {
                context.LichThis.Update(_lichThi);
                context.SaveChanges();
                tran.Commit();
                MessageBox.Show("Sửa lịch thi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa lịch thi thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tran.Rollback();
            }
        }

        private void FormSuaLichThi_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (FormClosedCallback != null)
            {
                FormClosedCallback.Invoke();
            }
        }
    }
}
