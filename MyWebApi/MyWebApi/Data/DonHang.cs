namespace MyWebApi.Data
{
    public enum TinhTrangDonDatHang
    {
        New =0,Payment=1,Complete = 2, Cancel = -1
    }
    public class DonHang
    {
        public Guid MaDh { set; get; }
        public DateTime NgayDat { set; get; }
        public DateTime? NgayGiao { set; get; }
        public TinhTrangDonDatHang TinhTrangDonHang { set; get; }
        public string NguoiNhan { set; get; }
        public string DiaChiGiao { set; get; }
        public string SoDienThoai { set; get; }
        public ICollection<DonHangChiTiet> DonHangChiTiets { set; get; }
        public DonHang()
        {
            DonHangChiTiets = new List<DonHangChiTiet>();
        }

    }
}
