using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnThi
{
    internal class QLSV
    {
        private List<SinhVienUDPM> _lstSinhVien;
        private SinhVienUDPM _SinhVien;
        private string _inPut;

        public QLSV()
        {
            _lstSinhVien = new List<SinhVienUDPM>();
            fakeData();
        }
        
        public void fakeData()
        {
            _lstSinhVien = new List<SinhVienUDPM>
            {
                new SinhVienUDPM(1,"Huyền",1,2),
                new SinhVienUDPM(2,"Bảo",2,4),
                new SinhVienUDPM(3,"Đức",1,1),
                new SinhVienUDPM(4,"Quân",1,2),
            };
        }
        public string GetInPut(string Nhap)
        {
            Console.WriteLine($"Mời bạn nhập {Nhap}: ");
            return Console.ReadLine();
        }

        public void ThemSV()
        {
            do
            {
                _SinhVien = new SinhVienUDPM();
                _SinhVien.MaSV = _lstSinhVien.Max(c=>c.MaSV) +1;
                _SinhVien.HoTen = GetInPut("Họ Tên");
                _SinhVien.ChuyenNganh =Convert.ToInt32(GetInPut("chuyên ngành(1-UDPM , 2-WEB)"));
                if (_SinhVien.ChuyenNganh == 1)
                {
                    _SinhVien.ChuyenNganhHep = Convert.ToInt32(GetInPut("chuyên ngành hẹp( 1 - Chuyên Ngành Java, 2 - Chuyên Ngành C#)"));
                }                
                _lstSinhVien.Add(_SinhVien);
                Console.WriteLine("Bạn có nhập thêm không?");
                Console.WriteLine("1.Có");
                Console.WriteLine("2.Không");
                _inPut = GetInPut("Lựa chọn");
                switch (_inPut)
                {
                    case "1":
                        break;
                    case "2":
                        SuatDS();
                        break;
                    default:
                        break;
                }
            } while (_inPut =="1");
            
        }

        public void SuatDS()
        {
            foreach (var x in _lstSinhVien)
            {
                x.InThongTin();
            }
        }

        public void TimSV()
        {
            int a, b;
            Console.WriteLine("Tìm SV theo khoảng mã từ a đến b");
            a =Convert.ToInt32(GetInPut("a"));
            b =Convert.ToInt32(GetInPut("b"));
            for (int i = 0; i <_lstSinhVien.Count; i++)
            {
                if (_lstSinhVien[i].MaSV >=a && _lstSinhVien[i].MaSV <= b)
                {
                    _lstSinhVien[i].InThongTin();
                }
            }
        }

        public void XoaSV()
        {
            _inPut =GetInPut("mã SV cần xóa");
            for (int i = 0; i < _lstSinhVien.Count; i++)
            {
                if (_lstSinhVien[i].MaSV ==Convert.ToInt32(_inPut))
                {
                    _lstSinhVien.RemoveAt(i);
                    Console.WriteLine("Xóa thành công");
                    SuatDS();
                    return;
                }
            }
            Console.WriteLine("Không Tìm Thấy");
        }
    }
}
