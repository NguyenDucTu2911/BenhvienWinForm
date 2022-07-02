using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace benhvien.model
{
    
    public class Quyen
    {
        public string Taikhoan { get; set; }
        public string Matkhau { get; set; }
        public string MaNhom { get; set; }

        public string taikhoan { get => Taikhoan; set => Taikhoan = value; }
        public string matkhau { get => Matkhau; set => Matkhau = value; }
        public string maNhom { get => MaNhom; set => MaNhom = value; }

        public Quyen(string Taikhoan,string Matkhau, string MaNhom)
        {
            this.taikhoan = Taikhoan;
            this.matkhau = Matkhau;
            this.maNhom = MaNhom;
        }
        nhomnguoidung A = new nhomnguoidung();
        
    }
}
