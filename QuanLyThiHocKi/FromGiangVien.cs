using QuanLyThiHocKi.Models.EntitiesNew;

namespace QuanLyThiHocKi
{
    public partial class FromGiangVien : Form
    {
        private readonly TaiKhoan tk;
        public FromGiangVien(TaiKhoan tk)
        {
            InitializeComponent();
            this.tk = tk;
        }
    }
}
