﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QUANGHANH2.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TCLDEntities : DbContext
    {
        public TCLDEntities()
            : base("name=TCLDEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BangCap> BangCaps { get; set; }
        public virtual DbSet<ChiTiet_BangCap> ChiTiet_BangCap { get; set; }
        public virtual DbSet<ChiTiet_CongViec_NhanVien> ChiTiet_CongViec_NhanVien { get; set; }
        public virtual DbSet<ChiTiet_NhiemVu_NhanVien> ChiTiet_NhiemVu_NhanVien { get; set; }
        public virtual DbSet<CongViec> CongViecs { get; set; }
        public virtual DbSet<GiayTo> GiayToes { get; set; }
        public virtual DbSet<HeHoc> HeHocs { get; set; }
        public virtual DbSet<HoSo> HoSoes { get; set; }
        public virtual DbSet<LichSuBoSungSYLL> LichSuBoSungSYLLs { get; set; }
        public virtual DbSet<Nganh> Nganhs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<NhiemVu> NhiemVus { get; set; }
        public virtual DbSet<QuanHeGiaDinh> QuanHeGiaDinhs { get; set; }
        public virtual DbSet<QuaTrinhCongTac> QuaTrinhCongTacs { get; set; }
        public virtual DbSet<TrinhDo> TrinhDoes { get; set; }
        public virtual DbSet<Truong> Truongs { get; set; }
    }
}
