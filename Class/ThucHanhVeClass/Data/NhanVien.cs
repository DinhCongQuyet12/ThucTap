using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LyThuyetVeClass.Data
{
    public class NhanVien
    {
        public string maNhanVien { set; get; }
        public string hoVaTen { set; get; }
        public DateTime ngaySinh { set; get; }
        public bool gioiTinh { set; get; }// true:nam,flase: nữ,null:
        public string email { set; get; }
        public string soDienThoai { set; get; }
        public float canNang;
        public float chieuCao;
        public float luong;

        // Ham tao:Khong co gia tri tra ve,Ten Ham giong ten class
        // Su dung:Khi khai bao new doi tuong   
        public NhanVien(float canNang , float chieuCao)
        {
            this.canNang = canNang;
            this.chieuCao = chieuCao;

        }
        
        public NhanVien(string maNhanVien, string hoVaTen)
        {
            this.maNhanVien = maNhanVien;
            this.hoVaTen = hoVaTen;

        }

        //Phuong thuc
        public float bmi()
        {
            float bmiValue = canNang / (chieuCao * chieuCao);
            return bmiValue;
        }
        public float tinhTuoi()
        {
            DateTime ngayHienTai = DateTime.Now;
            int namHienTai = ngayHienTai.Year;

            int namNgaySinh = this.ngaySinh.Year;
            return namHienTai=namNgaySinh;




           
            
        }
    }
}
