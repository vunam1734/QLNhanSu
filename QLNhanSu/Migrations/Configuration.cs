namespace QLNhanSu.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<QLNhanSu.HaHongDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(QLNhanSu.HaHongDbContext context)
        {
            context.ChucVus.Add(new ChucVu { MaChucVu = "TP", TenChucVu = "Trưởng phòng" });
            context.ChucVus.Add(new ChucVu { MaChucVu = "KS", TenChucVu = "Kỹ sư" });
            context.ChucVus.Add(new ChucVu { MaChucVu = "PDV", TenChucVu = "Phiên dịch viên" });
            context.ChucVus.Add(new ChucVu { MaChucVu = "NV", TenChucVu = "Nhân viên" });
            context.ChucVus.Add(new ChucVu { MaChucVu = "KTT", TenChucVu = "Kế toán trưởng" });
            context.ChucVus.Add(new ChucVu { MaChucVu = "KTV", TenChucVu = "Kế toán viên" });
            context.ChucVus.Add(new ChucVu { MaChucVu = "TK1", TenChucVu = "Trưởng kho 1" });
            context.ChucVus.Add(new ChucVu { MaChucVu = "TK2", TenChucVu = "Trưởng kho 2" });
            context.ChucVus.Add(new ChucVu { MaChucVu = "PP", TenChucVu = "Phó phòng" });
            context.ChucVus.Add(new ChucVu { MaChucVu = "CN", TenChucVu = "Công nhân" });

            context.PHONGBANs.Add(new PHONGBAN { MaPhong = "CG", TenPH = "Chuyên gia" });
            context.PHONGBANs.Add(new PHONGBAN { MaPhong = "TCHC", TenPH = "Tổ chức hành chính" });
            context.PHONGBANs.Add(new PHONGBAN { MaPhong = "KT", TenPH = "Kế toán" });
            context.PHONGBANs.Add(new PHONGBAN { MaPhong = "QLVT", TenPH = "Quản lý vật tư" });
            context.PHONGBANs.Add(new PHONGBAN { MaPhong = "KTH", TenPH = "Kỹ thuật" });
            context.PHONGBANs.Add(new PHONGBAN { MaPhong = "DA", TenPH = "Dự án" });
            context.PHONGBANs.Add(new PHONGBAN { MaPhong = "KD", TenPH = "Kinh Doanh" });
            context.PHONGBANs.Add(new PHONGBAN { MaPhong = "KTD", TenPH = "Kỹ thuật điện" });
            context.PHONGBANs.Add(new PHONGBAN { MaPhong = "TCC", TenPH = "Thi công cơ" });
            context.PHONGBANs.Add(new PHONGBAN { MaPhong = "XNK", TenPH = "Xuất nhập khẩu" });
            context.PHONGBANs.Add(new PHONGBAN { MaPhong = "BPSX", TenPH = "Bộ phận sản xuất" });

            context.NHANVIENs.Add(new NHANVIEN { MaNV = "A01", HoTen = "Liu Jin He", MaChucVu = "KS", MaPhong = "CG", Luong = 28000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "A02", HoTen = "Feng Meng Xiong", MaChucVu = "KS", MaPhong = "CG", Luong = 30000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "A03", HoTen = "Ji Liu", MaChucVu = "KS", MaPhong = "CG", Luong = 23000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "A04", HoTen = "Đặng Thành Côn", MaChucVu = "PDV", MaPhong = "CG", Luong = 18000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "A05", HoTen = "Doãn Cường", MaChucVu = "KS", MaPhong = "CG", Luong = 25000000 });

            context.NHANVIENs.Add(new NHANVIEN { MaNV = "B01", HoTen = "Trần Thị Thu Hương", MaChucVu = "TP", MaPhong = "TCHC", Luong = 22000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "B02", HoTen = "Nguyễn Thị Nhàn ", MaChucVu = "NV", MaPhong = "TCHC", Luong = 17000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "B03", HoTen = "Nguyễn Ngọc Minh", MaChucVu = "NV", MaPhong = "TCHC", Luong = 16000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "B04", HoTen = "Nguyễn Minh Hiệp", MaChucVu = "NV", MaPhong = "TCHC", Luong = 15000000 });

            context.NHANVIENs.Add(new NHANVIEN { MaNV = "C01", HoTen = "Bùi Thị Hồng Sen", MaChucVu = "KTT", MaPhong = "KT", Luong = 26000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "C02", HoTen = "Nguyễn Thị Thúy Hằng", MaChucVu = "KTV", MaPhong = "KT", Luong = 23000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "C03", HoTen = "Nguyễn Thị Ngọc Diễm", MaChucVu = "KTV", MaPhong = "KT", Luong = 21000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "C04", HoTen = "Trần Thị Thắm", MaChucVu = "KTV", MaPhong = "KT", Luong = 22000000 });

            context.NHANVIENs.Add(new NHANVIEN { MaNV = "D01", HoTen = "Nguyễn Văn Tùng", MaChucVu = "TP", MaPhong = "QLVT", Luong = 28000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "D02", HoTen = "Nguyễn Ngọc Thanh", MaChucVu = "TK1", MaPhong = "QLVT", Luong = 28000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "D03", HoTen = "Nguyễn Huy Hiệp", MaChucVu = "TK2", MaPhong = "QLVT", Luong = 28000000 });

            context.NHANVIENs.Add(new NHANVIEN { MaNV = "E01", HoTen = "Vũ Tuyên Khôi", MaChucVu = "TP", MaPhong = "KTH", Luong = 24000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "E02", HoTen = "Trần Xuân Tú", MaChucVu = "PP", MaPhong = "KTH", Luong = 23000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "E03", HoTen = "Thiều Lê Thanh Tâm", MaChucVu = "NV", MaPhong = "KTH", Luong = 21000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "E04", HoTen = "Trần Công Lập", MaChucVu = "NV", MaPhong = "KTH", Luong = 20000000 });

            context.NHANVIENs.Add(new NHANVIEN { MaNV = "F01", HoTen = "Đào Thanh Quang", MaChucVu = "TP", MaPhong = "DA", Luong = 21000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "F02", HoTen = "Lê Đức Trường", MaChucVu = "NV", MaPhong = "DA", Luong = 16000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "F03", HoTen = "Đỗ Văn Hà", MaChucVu = "NV", MaPhong = "DA", Luong = 17000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "F04", HoTen = "Trần Thanh Tùng", MaChucVu = "NV", MaPhong = "DA", Luong = 18000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "F05", HoTen = "Nguyễn Duy Lợi", MaChucVu = "NV", MaPhong = "DA", Luong = 16000000 });

            context.NHANVIENs.Add(new NHANVIEN { MaNV = "K01", HoTen = "Đỗ Văn Thịnh", MaChucVu = "TP ", MaPhong = "BPSX", Luong = 21000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "K02", HoTen = "Phan Công Anh", MaChucVu = "PP", MaPhong = "BPSX", Luong = 18000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "K03", HoTen = "Lê Khắc Tùng", MaChucVu = "CN", MaPhong = "BPSX", Luong = 16000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "K04", HoTen = "Phạm Hoàng Nhân", MaChucVu = "CN", MaPhong = "BPSX", Luong = 16000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "K05", HoTen = "Huỳnh Anh Nguyên", MaChucVu = "CN", MaPhong = "BPSX", Luong = 15000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "K06", HoTen = "Trần Văn Đức", MaChucVu = "CN", MaPhong = "BPSX", Luong = 15000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "K07", HoTen = "Phạm Văn Hồng Phúc", MaChucVu = "CN", MaPhong = "BPSX", Luong = 12000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "K08", HoTen = "Phan Đặng Huệ", MaChucVu = "CN", MaPhong = "BPSX", Luong = 15000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "K09", HoTen = "Nguyễn Chờ Anh", MaChucVu = "CN", MaPhong = "BPSX", Luong = 14000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "K10", HoTen = "Hồ Văn Thiền", MaChucVu = "CN", MaPhong = "BPSX", Luong = 13000000 });

            context.NHANVIENs.Add(new NHANVIEN { MaNV = "J01", HoTen = "Nguyễn Lê Thuận", MaChucVu = "TP", MaPhong = "XNK", Luong = 24000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "J02", HoTen = "Nguyễn Tiến Hùng", MaChucVu = "PP", MaPhong = "XNK", Luong = 22000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "J03", HoTen = "Lê Mạnh Trường", MaChucVu = "NV", MaPhong = "XNK", Luong = 20000000 });

            context.NHANVIENs.Add(new NHANVIEN { MaNV = "I01", HoTen = "Đỗ Cao Sơn", MaChucVu = "TP", MaPhong = "TCC", Luong = 25000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "I02", HoTen = "Hoàng Giang Nam", MaChucVu = "PP", MaPhong = "TCC", Luong = 23000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "I03", HoTen = "Trần Thanh Tâm", MaChucVu = "NV", MaPhong = "TCC", Luong = 21000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "I04", HoTen = "Phan Anh Tuấn", MaChucVu = "NV", MaPhong = "TCC", Luong = 17000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "I05", HoTen = "Lê Xuân Huy", MaChucVu = "NV", MaPhong = "TCC", Luong = 16000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "I06", HoTen = "Bùi Hữu Phước", MaChucVu = "NV", MaPhong = "TCC", Luong = 19000000 });

            context.NHANVIENs.Add(new NHANVIEN { MaNV = "H01", HoTen = "Lâm Quang Minh", MaChucVu = "TP", MaPhong = "KTD", Luong = 23000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "H02", HoTen = "Trương Quang Viên", MaChucVu = "PP", MaPhong = "KTD", Luong = 20000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "H03", HoTen = "Huỳnh Tấn Thành", MaChucVu = "NV", MaPhong = "KTD", Luong = 16000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "H04", HoTen = "Nguyễn Trung Kiên", MaChucVu = "NV", MaPhong = "KTD", Luong = 17000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "H05", HoTen = "Huỳnh Tấn Linh Vỹ", MaChucVu = "NV", MaPhong = "KTD", Luong = 14000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "H06", HoTen = "Phạm Đình Hiệp", MaChucVu = "NV", MaPhong = "KTD", Luong = 15000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "H07", HoTen = "Hồ Văn Thiền", MaChucVu = "NV", MaPhong = "KTD", Luong = 16000000 });

            context.NHANVIENs.Add(new NHANVIEN { MaNV = "G01", HoTen = "Nguyễn Mạnh Hùng", MaChucVu = "TP", MaPhong = "KD", Luong = 24000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "G02", HoTen = "Đặng Thanh Hoàng", MaChucVu = "NV", MaPhong = "KD", Luong = 20000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "G03", HoTen = "Lê Thành Hưng", MaChucVu = "NV", MaPhong = "KD", Luong = 19000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "G04", HoTen = "Phan Thế Hùng", MaChucVu = "NV", MaPhong = "KD", Luong = 20000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "G05", HoTen = "Lê Văn Nam", MaChucVu = "NV", MaPhong = "KD", Luong = 18000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "G06", HoTen = "Lê Thanh Bình", MaChucVu = "NV", MaPhong = "KD", Luong = 17000000 });
            context.NHANVIENs.Add(new NHANVIEN { MaNV = "G07", HoTen = "Đoàn Bách Khoa", MaChucVu = "NV", MaPhong = "KD", Luong = 21000000 });
        }
    }
}
