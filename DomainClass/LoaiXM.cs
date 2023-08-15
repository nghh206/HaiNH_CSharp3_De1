using System.ComponentModel.DataAnnotations;

namespace DomainClass
{
    public class LoaiXM
    {
        [Key]
        public int MaLoaiXe { get ; set; }
        public string? TenLoaiXe { get; set; }   
    }
}
