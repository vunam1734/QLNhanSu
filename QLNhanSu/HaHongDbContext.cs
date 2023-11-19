using System;
using System.Data.Entity;
using System.Linq;

namespace QLNhanSu
{
    public class HaHongDbContext : DbContext
    {
        public DbSet<NHANVIEN> NHANVIENs { get; set; }
        public DbSet<PHONGBAN> PHONGBANs { get; set; }
        public DbSet<ChucVu> ChucVus { get; set; }
        public HaHongDbContext()
            : base("name=HaHongDbContext")
        {
        }
    }
}