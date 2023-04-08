using System;
using System.Collections.Generic;

namespace QuanLyThiHocKi.Models.EntitiesNew
{
    public partial class TaiKhoan
    {
        public TaiKhoan()
        {
            GiangViens = new HashSet<GiangVien>();
        }

        public int Id { get; set; }
        public string? TaiKhoan1 { get; set; }
        public string? MatKhau { get; set; }
        public int? Idvt { get; set; }

        public virtual VaiTro? IdvtNavigation { get; set; }
        public virtual ICollection<GiangVien> GiangViens { get; set; }
    }
}
