using QuanLyThiHocKi.Models.EntitiesNew;
using System.Globalization;

namespace QuanLyThiHocKi
{
    public partial class FormThemLichThi : Form
    {
        public delegate void FormClosedHandler();
        public FormClosedHandler FormClosedCallback;
        public FormThemLichThi()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormThemLichThi_Load(object sender, EventArgs e)
        {
            QuanLyThiHocKiContext context = new QuanLyThiHocKiContext();
            cbLopHoc.DataSource = context.LopHocs.ToList();
            cbHocPhan.DataSource = context.HocPhans.ToList();
            cbDotHoc.DataSource = context.NamHocHocKis
                .Select(x => new { id = x.Id, NamHoc = "Học kì: " + x.HocKi + " Năm: " + x.NamHoc })
                .ToList();
            cbCa.DataSource = context.Cas.ToList();
            cbPhongHoc.DataSource = context.PhongHocs.ToList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            QuanLyThiHocKiContext context = new QuanLyThiHocKiContext();
            LichThi lichThi = new LichThi();

            lichThi.Idlop = (int)cbLopHoc.SelectedValue;
            lichThi.Idhp = (int)cbHocPhan.SelectedValue;
            lichThi.Idnhhk = (int)cbDotHoc.SelectedValue;
            lichThi.Ca = (int)cbHocPhan.SelectedValue;
            lichThi.Idph = (int)cbPhongHoc.SelectedValue;

            lichThi.GhiChu = txtGhiChu.Text;
            lichThi.Nhom = (int)txtNhom.Value;
            lichThi.Sldk = (int)txtSLDK.Value;
            string n = txtNgayThi.Text;
            lichThi.NgayThi = DateTime.ParseExact(n, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            lichThi.TrangThaiToChuc = false;
            lichThi.TrangThai = true;
            lichThi.KinhPhiToChuc = 0;

            var tran = context.Database.BeginTransaction();

            try
            {
                context.LichThis.Add(lichThi);
                context.SaveChanges();
                tran.Commit();
                MessageBox.Show("Thêm lịch thi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm lịch thi thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tran.Rollback();
            }
        }

        private void FormThemLichThi_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (FormClosedCallback != null)
            {
                FormClosedCallback.Invoke();
            }
        }
    }
}
