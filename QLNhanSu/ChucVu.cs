using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhanSu
{
    public class ChucVu
    {
        [Key]
        [StringLength(4)]
        public string MaChucVu { get; set; }
        [StringLength(50)]
        public string TenChucVu { get; set; }
        public List<NHANVIEN> NHANVIENs { get; set; }
    }
}
