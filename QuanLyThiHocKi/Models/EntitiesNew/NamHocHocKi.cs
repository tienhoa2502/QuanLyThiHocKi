using System;
using System.Collections.Generic;

namespace QuanLyThiHocKi.Models.EntitiesNew
{
    public partial class NamHocHocKi
    {
        public NamHocHocKi()
        {
            CanBoCoiThis = new HashSet<CanBoCoiThi>();
            LichThis = new HashSet<LichThi>();
        }

        public int Id { get; set; }
        public string? NamHoc { get; set; }
        public string? HocKi { get; set; }
        public DateTime? Tu { get; set; }
        public DateTime? Den { get; set; }

        public virtual ICollection<CanBoCoiThi> CanBoCoiThis { get; set; }
        public virtual ICollection<LichThi> LichThis { get; set; }
    }
}
