using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GioiThieuLinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SinhVien sv1 = new SinhVien();
            sv1.tenSinhVien = "Nguyen Văn A";
            sv1.ngaySinh = new DateTime(1999, 1 ,1);
            sv1.diemTrungBinh = 5;

            SinhVien sv3 = new SinhVien();
            sv3.tenSinhVien = "Nguyen Văn A";
            sv3.ngaySinh = new DateTime(1999, 1, 1);
            sv3.diemTrungBinh = 5;



            SinhVien sv2 = new SinhVien();
            sv2.tenSinhVien = "Nguyen Van B";
            sv2.ngaySinh = new DateTime(1999, 3, 1);
            sv2.diemTrungBinh = 6;
            // đưa 2 đội tượng vào danh sách
            //1 Tạo 1 danh sách
            List<SinhVien> danhSachSinhVien = new List<SinhVien>();

            // Lệnh Add:Thêm đối tượng vào danh sách
            danhSachSinhVien.Add(sv1);
            danhSachSinhVien.Add(sv2);
            danhSachSinhVien.Add(sv3);


            // 1 Đếm số lượng trong danh sách
            //int soLuongSV = (from sv in danhSachSinhVien
            //                 select sv
            //                 ).Count();
            //int soLuong = danhSachSinhVien.Count();

            // 2 Đếm có điều kiện
            //int soLuong = (from sv in danhSachSinhVien
            //               where sv.tenSinhVien.Contains("A") == true
            //               select sv
            //                 ).Count();
            //int soLuong2 = danhSachSinhVien.Count(item => item.tenSinhVien.Contains("A") == true);

            // 3.Lựa chọn danh sách đối tượng trong danh sách nguồn
            //List<SinhVien> ketQua = (from sv in danhSachSinhVien
            //                         where sv.tenSinhVien.Contains("A") == true
            //                         select sv
            //                         ).ToList();
            //Console.WriteLine("Số Lượng Sinh Viên: " + ketQua.Count);

            // 4.Sắp xếp kết quả select :Oder by
            //List<SinhVien> ketQua = (from sv in danhSachSinhVien
            //                         where sv.tenSinhVien.Contains("A") == true
            //                         orderby sv.ngaySinh descending
            //                         select sv
            //                         ).ToList();
            // 5 Lấy min max
            //DateTime maxNgaySinh = danhSachSinhVien.Max(m => m.ngaySinh);

            //double diemTB = danhSachSinhVien.Average(i => i.diemTrungBinh);

            //Console.WriteLine("Điểm trung bình : " + diemTB);

            //6 Lay đầu hoặc cuối
            //var svDauSo = danhSachSinhVien.OrderBy(i => i.tenSinhVien).First();
            //var svCuoiSo = danhSachSinhVien.OrderBy(i => i.tenSinhVien).Last();

            // 7 Tim kiếm theo thuộc tính khóa
            //var SV = danhSachSinhVien.Find(i => i.tenSinhVien == "   ");

            // 8 Xoá bỏ 
            // 1 đối tượng
            //List<SinhVien> svTenA = danhSachSinhVien.Where(i => i.tenSinhVien.Contains("A") == true).ToList();
            //foreach (var i in svTenA)
            //{
            //    danhSachSinhVien.Remove(i);
            //}
            //// Xoá nhiều đối tượng có điều kiện
            //danhSachSinhVien.RemoveAll(i => i.tenSinhVien.Contains("A") == true);

            //// xoá toàn bộ danh sách
            //danhSachSinhVien.Clear();
            //// Loại bỏ trùng

            var ketQuaTrung= danhSachSinhVien.Distinct();
            Console.WriteLine("Số Lượng" + danhSachSinhVien.Count());
            
              
            Console.ReadLine();

        }
    }
}
