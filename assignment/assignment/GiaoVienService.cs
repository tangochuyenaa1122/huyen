using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    internal class GiaoVienService
    {
        private List<GiaoVien> _lstGiaoVien;
        private GiaoVien _giaoVien;
        private string _inPut;

        public GiaoVienService()
        {
            Console.OutputEncoding = Encoding.UTF8;
            _lstGiaoVien = new List<GiaoVien>();
            Fake5Data();
        }

        public void Fake5Data()
        {
            _lstGiaoVien = new List<GiaoVien>()
            {
                new GiaoVien("Nguyễn","A","Thị",1990,0,"Hà Nội","GV1245","5246426565","athin@fpt",500),
                new GiaoVien("Nguyễn","Ba","Văn",1989,1,"Đà Nẵng","GV8643","5473573673","bvann@fpt",540),
                new GiaoVien("Nguyễn","D","Minh",1993,1,"Nam Định","GV8157","2657686574","dminhn@fpt",407),
                new GiaoVien("Nguyễn","F","Ngọc",1985,0,"Hà Nội","GV8646","6635675677","fngocn@fpt",70),
                new GiaoVien("Nguyễn","T","Thị",1997,0,"Hải Phòng","GV3563","7353535737","tthin@fpt",400)
            };
        }
        public string getInPut(string Nhap)
        {
            Console.Write($"Mời bạn Nhập {Nhap}: ");
            return Console.ReadLine();
        }

        public void Them_Sua_Xoa()
        {
            do
            {
            Console.WriteLine("Mời bạn chọn chức năng phụ");
            Console.WriteLine("1.Thêm GV");
            Console.WriteLine("2.Sửa GV");
            Console.WriteLine("3.Xóa GV");
            Console.WriteLine("0.Thoát chức năng phụ");
            _inPut = Console.ReadLine();
            switch (_inPut)
            {
                case "1":
                    ThemGiaoVien();
                    break;
                case "2":
                    SuaTTGV();
                    break;
                case "3":
                    XoaGV();
                    break;
                default:
                    break;
            }
            } while (_inPut !="0");
        }
        public void ThemGiaoVien()
        {
            _inPut = getInPut("số lượng cần thêm");
            for (int i = 0; i < Convert.ToInt32(_inPut); i++)
            {
                Console.WriteLine($"Mời nhập thông tin giáo viên thứ {i+1}:");
                _giaoVien = new GiaoVien();
                _giaoVien.Ten = getInPut("tên GV");
                _giaoVien.Ho = getInPut("họ GV");
                _giaoVien.TenDem = getInPut("tên đệm");
                _giaoVien.NamSinh = Convert.ToInt32(getInPut("năm sinh"));
                _giaoVien.GioITinh = Convert.ToInt32(getInPut("giới tính(1:nam, 0:nữ)"));
                _giaoVien.QueQuan = getInPut("quê quán");
                _giaoVien.MaGv1 = getInPut("mã GV");
                _giaoVien.Sdt11 = getInPut("số điện thoại");
                _giaoVien.Email1 = getInPut("Email");
                _giaoVien.SoGioDay1 = Convert.ToInt32(getInPut("số giờ dạy"));
                _lstGiaoVien.Add(_giaoVien);
                
            }
            foreach (var x in _lstGiaoVien)
            {
                x.InRaManHinh();
            }
        }
        public void SuaTTGV()
        {
            _inPut = getInPut("Mã gv cần sửa");
            for (int i = 0; i < _lstGiaoVien.Count; i++)
            {
                if (_lstGiaoVien[i].MaGv1 == _inPut)
                {
                    Console.WriteLine("1.Sửa tên");
                    Console.WriteLine("2.Sửa họ");
                    Console.WriteLine("3.Sửa tên đệm");
                    Console.WriteLine("4.Sửa năm sinh");
                    Console.WriteLine("5.Sửa giới tính");
                    Console.WriteLine("6.Sửa quê quán");
                    Console.WriteLine("7.Sửa số điện thoại");
                    Console.WriteLine("8.Sửa email");
                    Console.WriteLine("Mời bạn chọn:");
                    _inPut = Console.ReadLine();
                    switch (_inPut)
                    {
                        case "1":
                            _lstGiaoVien[i].Ten = getInPut("tên GV");
                            break;
                        case "2":
                            _lstGiaoVien[i].Ho = getInPut("họ GV");
                            break;
                        case "3":
                            _lstGiaoVien[i].TenDem = getInPut("tên đệm");
                            break;
                        case "4":
                            _lstGiaoVien[i].NamSinh = Convert.ToInt32(getInPut("năm sinh"));
                            break;
                        case "5":
                            _lstGiaoVien[i].GioITinh = Convert.ToInt32(getInPut("giới tính(1:nam, 0:nữ)"));
                            break;
                        case "6":
                            _lstGiaoVien[i].QueQuan = getInPut("quê quán");
                            break;
                        case "7":
                            _lstGiaoVien[i].Sdt11 = getInPut("số điện thoại");
                            break;
                        case "8":
                            _lstGiaoVien[i].Email1 = getInPut("Email");
                            break;
                        default:
                            break;
                    }
                    Console.WriteLine("Sửa thành công");
                    foreach (var x in _lstGiaoVien)
                    {
                        x.InRaManHinh();
                    }
                    return;
                }
                
            }
            Console.WriteLine("ko tìm thấy");
        }

        public void XoaGV()
        {
            Console.Write("Mời bạn nhập Mã gv cần xóa: ");
            _inPut = Console.ReadLine();
            for (int i = 0; i < _lstGiaoVien.Count; i++)
            {
                if (_lstGiaoVien[i].MaGv1 == _inPut)
                {
                    _lstGiaoVien.RemoveAt(i);
                    Console.WriteLine("Xóa thành công");
                    foreach (var x in _lstGiaoVien)
                    {
                        x.InRaManHinh();
                    }
                    return;
                }

            }
            Console.WriteLine("ko tìm thấy");
        }

        public void TimThemMaGV()
        {
            Console.WriteLine("CHỨC NĂNG 3: TÌM KIẾM GIÁO VIÊN THEO MÃ GIÁO VIÊN");
            _inPut = getInPut("Mã gv cần tìm");
            for (int i = 0; i < _lstGiaoVien.Count; i++)
            {
                if (_lstGiaoVien[i].MaGv1 == _inPut)
                {
                    _lstGiaoVien[i].InRaManHinh();
                    return;
                }
            }
            Console.WriteLine("ko tìm thấy");
        }

        public void LoadTheoGT()
        {
            Console.WriteLine("CHỨC NĂNG 4: LOAD TẤT TT CẢ GV  - (Lưu ý: Khi hiển thị những " +
                                    "người có giới tính là NAM thì hiển thị là Thầy và NỮ thì hiển thị là CÔ)");
            for (int i = 0; i < _lstGiaoVien.Count; i++)
            {
                //if (_lstGiaoVien[i].GioITinh ==1)
                //{
                //    Console.Write("Thầy: ");
                //    _lstGiaoVien[i].InRaManHinh();
                //}
                //else
                //{
                //    Console.Write("Cô: ");
                //    _lstGiaoVien[i].InRaManHinh();
                //}
                string TC = _lstGiaoVien[i].GioITinh == 1 ? "Thầy:" : "Cô:";
                Console.Write(TC);
                _lstGiaoVien[i].InRaManHinh();
            }
            
        }

        public void TimTheoTen()
        {
            Console.WriteLine("CHỨC NĂNG 5: TÌM KIẾM THEO TÊN GV GẦN ĐÚNG");
            _inPut = getInPut("Tên cần tìm");
            foreach (var x in _lstGiaoVien.Where(b=>b.Ten.ToLower().Contains(_inPut.ToLower())))
            {
                    x.InRaManHinh();
            }
        }

        public void LoadTheoSoGioDay()
        {
            Console.WriteLine("CHỨC NĂNG 6: LOAD TẤT CẢ GIÁO VIÊN CÓ SỐ GIỜ DẠY LỚN HƠN 500 GIỜ");
            for (int i = 0; i < _lstGiaoVien.Count; i++)
            {
                if (_lstGiaoVien[i].SoGioDay1 > 500)
                {
                    _lstGiaoVien[i].InRaManHinh();
                }
            }
        }

        public void LoadTheoVung()
        {
            Console.WriteLine("CHỨC NĂNG 7: LOAD TẤT CẢ GIÁO VIÊN VÀ PH N CHIA DANH SÁCH KHI HIỂN THỊ THEO NHÓM VÙNG MIỀN" +
                                    "( - Hà Nội: danh sách các GV ở HN - Hải phòng: Tất cả giáo viên hải phòng)");
            Console.WriteLine("Những giáo viên ở Hà Nội");
                foreach (var x in _lstGiaoVien.Where(c => c.QueQuan.StartsWith("Hà Nội")))
                {
                    x.InRaManHinh();
                }
            Console.WriteLine("Những giáo viên ở Hải Phòng");
                foreach (var x in _lstGiaoVien)
                {
                if (_giaoVien.QueQuan.StartsWith(_inPut))
                {
                    x.InRaManHinh();
                }
                    
                }
        }
    }
}
