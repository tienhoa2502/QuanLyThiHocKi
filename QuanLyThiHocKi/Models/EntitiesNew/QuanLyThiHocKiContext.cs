using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace QuanLyThiHocKi.Models.EntitiesNew
{
    public partial class QuanLyThiHocKiContext : DbContext
    {
        public QuanLyThiHocKiContext()
        {
        }

        public QuanLyThiHocKiContext(DbContextOptions<QuanLyThiHocKiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Ca> Cas { get; set; } = null!;
        public virtual DbSet<CanBoCoiThi> CanBoCoiThis { get; set; } = null!;
        public virtual DbSet<CoiThi> CoiThis { get; set; } = null!;
        public virtual DbSet<GiangVien> GiangViens { get; set; } = null!;
        public virtual DbSet<HocPhan> HocPhans { get; set; } = null!;
        public virtual DbSet<KinhPhi> KinhPhis { get; set; } = null!;
        public virtual DbSet<LichThi> LichThis { get; set; } = null!;
        public virtual DbSet<LopHoc> LopHocs { get; set; } = null!;
        public virtual DbSet<NamHocHocKi> NamHocHocKis { get; set; } = null!;
        public virtual DbSet<PhongHoc> PhongHocs { get; set; } = null!;
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; } = null!;
        public virtual DbSet<VaiTro> VaiTros { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-D15AOHSH\\SQLEXPRESS;Initial Catalog=QuanLyThiHocKi;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ca>(entity =>
            {
                entity.ToTable("Ca");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.TenCa).HasMaxLength(50);
            });

            modelBuilder.Entity<CanBoCoiThi>(entity =>
            {
                entity.ToTable("CanBoCoiThi");

                entity.HasIndex(e => e.MaGv, "UQ__CanBoCoi__2725AEF26F7A5FE9")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.HoTen).HasMaxLength(50);

                entity.Property(e => e.Idhp).HasColumnName("IDHP");

                entity.Property(e => e.Idnhhk).HasColumnName("IDNHHK");

                entity.Property(e => e.Idph).HasColumnName("IDPH");

                entity.Property(e => e.MaGv)
                    .HasMaxLength(10)
                    .HasColumnName("MaGV");

                entity.Property(e => e.Phone).HasMaxLength(20);

                entity.HasOne(d => d.IdhpNavigation)
                    .WithMany(p => p.CanBoCoiThis)
                    .HasForeignKey(d => d.Idhp)
                    .HasConstraintName("FK__CanBoCoiTh__IDHP__619B8048");

                entity.HasOne(d => d.IdnhhkNavigation)
                    .WithMany(p => p.CanBoCoiThis)
                    .HasForeignKey(d => d.Idnhhk)
                    .HasConstraintName("FK__CanBoCoiT__IDNHH__6383C8BA");

                entity.HasOne(d => d.IdphNavigation)
                    .WithMany(p => p.CanBoCoiThis)
                    .HasForeignKey(d => d.Idph)
                    .HasConstraintName("FK__CanBoCoiTh__IDPH__628FA481");
            });

            modelBuilder.Entity<CoiThi>(entity =>
            {
                entity.ToTable("CoiThi");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Idcbct).HasColumnName("IDCBCT");

                entity.Property(e => e.IdlichThi).HasColumnName("IDLichThi");

                entity.HasOne(d => d.IdcbctNavigation)
                    .WithMany(p => p.CoiThis)
                    .HasForeignKey(d => d.Idcbct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CoiThi__IDCBCT__7E37BEF6");

                entity.HasOne(d => d.IdlichThiNavigation)
                    .WithMany(p => p.CoiThis)
                    .HasForeignKey(d => d.IdlichThi)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CoiThi__IDLichTh__75A278F5");
            });

            modelBuilder.Entity<GiangVien>(entity =>
            {
                entity.ToTable("GiangVien");

                entity.HasIndex(e => e.MaGv, "UQ__GiangVie__2725AEF20A27A95F")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.HoTen).HasMaxLength(50);

                entity.Property(e => e.Idhp).HasColumnName("IDHP");

                entity.Property(e => e.Idph).HasColumnName("IDPH");

                entity.Property(e => e.Idtk).HasColumnName("IDTK");

                entity.Property(e => e.MaGv)
                    .HasMaxLength(10)
                    .HasColumnName("MaGV");

                entity.Property(e => e.Phone).HasMaxLength(20);

                entity.HasOne(d => d.IdhpNavigation)
                    .WithMany(p => p.GiangViens)
                    .HasForeignKey(d => d.Idhp)
                    .HasConstraintName("FK__GiangVien__IDHP__31EC6D26");

                entity.HasOne(d => d.IdphNavigation)
                    .WithMany(p => p.GiangViens)
                    .HasForeignKey(d => d.Idph)
                    .HasConstraintName("FK__GiangVien__IDPH__32E0915F");

                entity.HasOne(d => d.IdtkNavigation)
                    .WithMany(p => p.GiangViens)
                    .HasForeignKey(d => d.Idtk)
                    .HasConstraintName("FK__GiangVien__IDTK__35BCFE0A");
            });

            modelBuilder.Entity<HocPhan>(entity =>
            {
                entity.ToTable("HocPhan");

                entity.HasIndex(e => e.MaHp, "UQ__HocPhan__2725A6EDA995D588")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaHp)
                    .HasMaxLength(10)
                    .HasColumnName("MaHP");

                entity.Property(e => e.TenHp)
                    .HasMaxLength(100)
                    .HasColumnName("TenHP");
            });

            modelBuilder.Entity<KinhPhi>(entity =>
            {
                entity.ToTable("KinhPhi");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.TenGia).HasMaxLength(50);
            });

            modelBuilder.Entity<LichThi>(entity =>
            {
                entity.ToTable("LichThi");

                entity.HasIndex(e => new { e.Idlop, e.Idhp, e.Idnhhk, e.Idph }, "UQ__LichThi__98E1579FBA00605F")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.GhiChu).HasMaxLength(500);

                entity.Property(e => e.Idhp).HasColumnName("IDHP");

                entity.Property(e => e.Idlop).HasColumnName("IDLop");

                entity.Property(e => e.Idnhhk).HasColumnName("IDNHHK");

                entity.Property(e => e.Idph).HasColumnName("IDPH");

                entity.Property(e => e.NgayThi).HasColumnType("date");

                entity.Property(e => e.Sldk).HasColumnName("SLDK");

                entity.HasOne(d => d.CaNavigation)
                    .WithMany(p => p.LichThis)
                    .HasForeignKey(d => d.Ca)
                    .HasConstraintName("FK__LichThi__Ca__5070F446");

                entity.HasOne(d => d.IdhpNavigation)
                    .WithMany(p => p.LichThis)
                    .HasForeignKey(d => d.Idhp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LichThi__IDHP__45F365D3");

                entity.HasOne(d => d.IdlopNavigation)
                    .WithMany(p => p.LichThis)
                    .HasForeignKey(d => d.Idlop)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LichThi__IDLop__151B244E");

                entity.HasOne(d => d.IdnhhkNavigation)
                    .WithMany(p => p.LichThis)
                    .HasForeignKey(d => d.Idnhhk)
                    .HasConstraintName("FK__LichThi__IDNHHK__6FE99F9F");

                entity.HasOne(d => d.IdphNavigation)
                    .WithMany(p => p.LichThis)
                    .HasForeignKey(d => d.Idph)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LichThi__IDPH__46E78A0C");
            });

            modelBuilder.Entity<LopHoc>(entity =>
            {
                entity.ToTable("LopHoc");

                entity.HasIndex(e => e.MaLop, "UQ__LopHoc__3B98D272B2E26A7A")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Idgv).HasColumnName("IDGV");

                entity.Property(e => e.Idhp).HasColumnName("IDHP");

                entity.Property(e => e.Idph).HasColumnName("IDPH");

                entity.Property(e => e.MaLop).HasMaxLength(10);

                entity.Property(e => e.TenLop).HasMaxLength(50);

                entity.HasOne(d => d.IdgvNavigation)
                    .WithMany(p => p.LopHocs)
                    .HasForeignKey(d => d.Idgv)
                    .HasConstraintName("FK__LopHoc__IDGV__403A8C7D");

                entity.HasOne(d => d.IdhpNavigation)
                    .WithMany(p => p.LopHocs)
                    .HasForeignKey(d => d.Idhp)
                    .HasConstraintName("FK__LopHoc__IDHP__3F466844");

                entity.HasOne(d => d.IdphNavigation)
                    .WithMany(p => p.LopHocs)
                    .HasForeignKey(d => d.Idph)
                    .HasConstraintName("FK__LopHoc__IDPH__3E52440B");
            });

            modelBuilder.Entity<NamHocHocKi>(entity =>
            {
                entity.ToTable("NamHocHocKi");

                entity.HasIndex(e => new { e.NamHoc, e.HocKi }, "UQ__NamHocHo__A593D26B5544A6B8")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Den).HasColumnType("date");

                entity.Property(e => e.HocKi).HasMaxLength(50);

                entity.Property(e => e.NamHoc).HasMaxLength(50);

                entity.Property(e => e.Tu).HasColumnType("date");
            });

            modelBuilder.Entity<PhongHoc>(entity =>
            {
                entity.ToTable("PhongHoc");

                entity.HasIndex(e => e.MaPhong, "UQ__PhongHoc__20BD5E5AF085F522")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaPhong).HasMaxLength(10);

                entity.Property(e => e.TenPhong).HasMaxLength(50);
            });

            modelBuilder.Entity<TaiKhoan>(entity =>
            {
                entity.ToTable("TaiKhoan");

                entity.HasIndex(e => e.TaiKhoan1, "UQ__TaiKhoan__D5B8C7F0E7940D74")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Idvt).HasColumnName("IDVT");

                entity.Property(e => e.MatKhau).HasMaxLength(50);

                entity.Property(e => e.TaiKhoan1)
                    .HasMaxLength(50)
                    .HasColumnName("TaiKhoan");

                entity.HasOne(d => d.IdvtNavigation)
                    .WithMany(p => p.TaiKhoans)
                    .HasForeignKey(d => d.Idvt)
                    .HasConstraintName("FK__TaiKhoan__IDVT__7F2BE32F");
            });

            modelBuilder.Entity<VaiTro>(entity =>
            {
                entity.ToTable("VaiTro");

                entity.HasIndex(e => e.MaVaiTro, "UQ__VaiTro__C24C41CE8669C5AD")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaVaiTro).HasMaxLength(10);

                entity.Property(e => e.TenVaiTro).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
