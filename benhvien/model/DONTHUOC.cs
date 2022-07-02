using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace benhvien.model
{
    class DONTHUOC
    {
        /// <summary>
        /// THÔNG TIN BỆNH NHÂN
        /// </summary>
        public string MaBN { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }

        /// <summary>
        /// THÔNG TIN BÁC SĨ
        /// </summary>
        public string MaBS { get; set; }
        public string HoTenBS { get; set; }

        /// <summary>
        /// ĐƠN THUỐC
        /// </summary>
        public DateTime NgayKeDonThuoc { get; set; }

        public DateTime GioTao { get; set; }

        public string LoiDan { get; set; }

        public string MaDonThuoc { get; set; }


        public string MaThuoc { get; set; }
        public string TenThuoc { get; set; }
        public int? SoLuong { get; set; }

        public string Lieu { get; set; }
        public string Ngay { get; set; }

        public string ThoiDiemSuDung { get; set; }

        //public virtual Thuoc Thuoc { get; set; }

        //public virtual ToaThuoc ToaThuoc { get; set; }
    }
}
