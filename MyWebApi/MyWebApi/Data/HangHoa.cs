using MyWebApi.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWebApi.Data
{
    [Table("HangHoa")]
    public class HangHoa
    {
        [Key]
        public Guid MaHh { set; get; }
        [Required]
        [MaxLength(100)]
        public string TenHh { set; get; }
        public string MoTa { set; get; }
        [Range(0,double.MaxValue)]
        public double DonGia { set; get; }

        public byte GiamGia { set; get; }
        public int? MaLoai { set; get; }
        [ForeignKey("MaLoai")]
        public Loai  Loai { set; get; }

        public ICollection<DonHangChiTiet> DonHangChiTiets { set; get; }
        public HangHoa()
        {
            DonHangChiTiets = new HashSet<DonHangChiTiet>();
        }
    }
}
