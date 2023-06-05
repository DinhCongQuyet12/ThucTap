using System.ComponentModel.DataAnnotations;

namespace MyWebApi.Models
{
    public class HangHoaVM
        

    {
        
        public string TenHangHoa { set; get; }
        public double DonGia { set; get; }

    }
    public class HangHoa : HangHoaVM
    {
        public Guid MaHangHoa { set; get;  }
    }
    public class HangHoaModel
    {
        public Guid MaHangHoa { set; get; }
        public string TenHangHoa { set; get; }
        public double DonGia { set; get; }
        public string TenLoai { set; get; }
    }
}
