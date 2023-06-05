using MyWebApi.Models;

namespace MyWebApi.Services
{
    public interface IHangHoaRepository
    {
        List<HangHoaModel> GetAll(string search);
    }
}
