namespace QLNhanSu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v7 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChucVus",
                c => new
                    {
                        MaChucVu = c.String(nullable: false, maxLength: 4),
                        TenChucVu = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.MaChucVu);
            
            CreateTable(
                "dbo.NHANVIEN",
                c => new
                    {
                        MaNV = c.String(nullable: false, maxLength: 3),
                        HoTen = c.String(maxLength: 50),
                        MaChucVu = c.String(),
                        MaPhong = c.String(),
                        Luong = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.MaNV);
            
            CreateTable(
                "dbo.PHONGBAN",
                c => new
                    {
                        MaPhong = c.String(nullable: false, maxLength: 4),
                        TenPH = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.MaPhong);
            
            CreateTable(
                "dbo.NHANVIENChucVus",
                c => new
                    {
                        NHANVIEN_MaNV = c.String(nullable: false, maxLength: 3),
                        ChucVu_MaChucVu = c.String(nullable: false, maxLength: 4),
                    })
                .PrimaryKey(t => new { t.NHANVIEN_MaNV, t.ChucVu_MaChucVu })
                .ForeignKey("dbo.NHANVIEN", t => t.NHANVIEN_MaNV, cascadeDelete: true)
                .ForeignKey("dbo.ChucVus", t => t.ChucVu_MaChucVu, cascadeDelete: true)
                .Index(t => t.NHANVIEN_MaNV)
                .Index(t => t.ChucVu_MaChucVu);
            
            CreateTable(
                "dbo.PHONGBANNHANVIENs",
                c => new
                    {
                        PHONGBAN_MaPhong = c.String(nullable: false, maxLength: 4),
                        NHANVIEN_MaNV = c.String(nullable: false, maxLength: 3),
                    })
                .PrimaryKey(t => new { t.PHONGBAN_MaPhong, t.NHANVIEN_MaNV })
                .ForeignKey("dbo.PHONGBAN", t => t.PHONGBAN_MaPhong, cascadeDelete: true)
                .ForeignKey("dbo.NHANVIEN", t => t.NHANVIEN_MaNV, cascadeDelete: true)
                .Index(t => t.PHONGBAN_MaPhong)
                .Index(t => t.NHANVIEN_MaNV);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PHONGBANNHANVIENs", "NHANVIEN_MaNV", "dbo.NHANVIEN");
            DropForeignKey("dbo.PHONGBANNHANVIENs", "PHONGBAN_MaPhong", "dbo.PHONGBAN");
            DropForeignKey("dbo.NHANVIENChucVus", "ChucVu_MaChucVu", "dbo.ChucVus");
            DropForeignKey("dbo.NHANVIENChucVus", "NHANVIEN_MaNV", "dbo.NHANVIEN");
            DropIndex("dbo.PHONGBANNHANVIENs", new[] { "NHANVIEN_MaNV" });
            DropIndex("dbo.PHONGBANNHANVIENs", new[] { "PHONGBAN_MaPhong" });
            DropIndex("dbo.NHANVIENChucVus", new[] { "ChucVu_MaChucVu" });
            DropIndex("dbo.NHANVIENChucVus", new[] { "NHANVIEN_MaNV" });
            DropTable("dbo.PHONGBANNHANVIENs");
            DropTable("dbo.NHANVIENChucVus");
            DropTable("dbo.PHONGBAN");
            DropTable("dbo.NHANVIEN");
            DropTable("dbo.ChucVus");
        }
    }
}
