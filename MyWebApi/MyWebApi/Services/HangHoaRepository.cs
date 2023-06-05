using MyWebApi.Data;
using MyWebApi.Models;

namespace MyWebApi.Services
{
    public class HangHoaRepository : IHangHoaRepository
    {
        private readonly MyDbContext _context;

        public HangHoaRepository(MyDbContext context)
        {
            _context = context;
        }
        public List <HangHoaModel> GetAll(string search)
        {
            var allProducts = _context.HangHoas.AsQueryable();
            if (!string.IsNullOrEmpty(search))
            {
               allProducts = allProducts.Where (hh => hh.TenHh.Contains(search));
            }
           
            var result = allProducts.Select(hh => new HangHoaModel
            {
                MaHangHoa = hh.MaHh,
                TenHangHoa = hh.TenHh,
                DonGia = hh.DonGia,
                TenLoai = hh.Loai.TenLoai
            });
            return result.ToList();
            }
       }
}
