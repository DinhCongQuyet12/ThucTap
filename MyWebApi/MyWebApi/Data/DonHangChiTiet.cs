namespace MyWebApi.Data
{
    public class DonHangChiTiet
    {
        public Guid MaHh { set; get; }
        public Guid MaDh { set; get; }
        public int SoLuong { set; get; }
        public double DonGia { set; get; }
        public byte GiamGia { set; get; }
        public DonHang DonHang { set; get; }
        public HangHoa HangHoa { set; get; }

    }
}
