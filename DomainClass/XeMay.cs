using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainClass
{
    public class XeMay
    {
        [Key]
        public int  MaXe { get; set; }
        public string? TenXe { get; set; }
        public string? MoTa { get; set; }   
        public double GiaNhap { get; set; }
        public int SoLuong { get; set; }
        public int MaLoaiXe { get; set; }

    }
}
