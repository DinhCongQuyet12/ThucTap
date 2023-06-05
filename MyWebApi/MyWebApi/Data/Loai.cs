using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWebApi.Data
{
    [Table("Loai")]
    public class Loai
    {
        [Key]
        public int MaLoai { set; get; }
        [Required]
        [MaxLength(50)]
        public string TenLoai { set; get; }
        public virtual ICollection<HangHoa> HangHoas { get; set; }


    }
}
