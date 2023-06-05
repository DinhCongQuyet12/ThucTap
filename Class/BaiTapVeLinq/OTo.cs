using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapVeLinq
{
     class OTo
    {
        public int iD { set; get; }
        public string soKhung { set; get; }
        public string soMay { set; get; }
        public string hangSanXuat { set; get; }
        public double giaNiemYet { set; get; }
        public string tenXe { set; get; }
        public bool noiDia  { set; get; } // noi dia: true, nuoc ngoai: false
        public List<ThongTinThue> danhSachThue { set; get; }

        // Tao Ham Tao cho class OTo
        public OTo(int id,string sokhung)
        {
            this.iD = id;
            this.soKhung = sokhung;
        }
        //Tổng thuế phải nộp
        public double thuePhaiNop()
        {
            double tong = 0; 
            foreach(var thue in this.danhSachThue)
            {
                double tienThue = giaNiemYet * thue.mucDong / 100;
                tong += tienThue; 
            }
            return tong;
        }
    }
}
