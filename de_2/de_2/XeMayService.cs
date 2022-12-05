using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace de_2
{
    internal class XeMayService
    {
        public List<XeMay> _lstXeMay;
        public XeMay _XM;
        public string _InPut;
         public XeMayService()
        {
            Console.OutputEncoding = Encoding.UTF8;
            _lstXeMay = new List<XeMay>();
            fake5Data();
        }

        public void fake5Data()
        {
            _lstXeMay = new List<XeMay> 
            {
                new XeMay("X001",1,100.4,"đỏ",303) ,
                new XeMay("X004",2,103.5,"cam",234) ,
                new XeMay("X054",2,455,"xanh",556) ,
                new XeMay("X062",1,465,"hồng",655) ,
                new XeMay("X016",2,122,"đen",454) 
            };
        }
        public void ThemXe()
        {
            Console.WriteLine("Mời Nhập Số Lượng: ");
            _InPut = Console.ReadLine();    
            for (int i = 0; i < Convert.ToInt32(_InPut); i++)
            {
                _XM = new XeMay();
                Console.WriteLine("Mời nhập ID: ");
                _XM.Id1 = Console.ReadLine();
                Console.WriteLine("Mời nhập NSX (1=VN; 2=US): ");
                _XM.NSX1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Mời nhập Trọng Lượng: ");
                _XM.TrongLuong1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Mời nhập Màu Sắc: ");
                _XM.MauSac1 = Console.ReadLine();
                Console.WriteLine("Mời nhập Dòng Xe: ");
                _XM.DongXe1 = Convert.ToInt32(Console.ReadLine());
                _lstXeMay.Add(_XM);
            }
        }

        public void Sua()
        {
            Console.WriteLine("Mời nhập ID của xe cần sửa:");
            _InPut= Console.ReadLine();
            for (int i = 0; i < _lstXeMay.Count; i++)
            {
                if (_lstXeMay[i].Id1 == _InPut)
                {
                    Console.WriteLine("1.Sửa NSX");
                    Console.WriteLine("2.Sửa Trọng Lượng");
                    Console.WriteLine("3.Sửa Màu Sắc");
                    Console.WriteLine("4.Sửa Dòng Xe");
                    Console.WriteLine("Mời chọn:");
                    _InPut=Console.ReadLine();
                    switch (_InPut)
                    {
                        case "1":
                            Console.WriteLine("Mời nhập NSX: ");
                            _XM.NSX1 = Convert.ToInt32(Console.ReadLine());
                            _lstXeMay.Add(_XM);
                            break;
                        case "2":
                            Console.WriteLine("Mời nhập Trọng Lượng: ");
                            _XM.TrongLuong1 = Convert.ToDouble(Console.ReadLine());
                            _lstXeMay.Add(_XM);
                            break;
                        case "3":
                            Console.WriteLine("Mời nhập Màu Sắc: ");
                            _XM.MauSac1 = Console.ReadLine();
                            break;
                        case "4":
                            Console.WriteLine("Mời nhập Dòng Xe: ");
                            _XM.DongXe1 = Convert.ToInt32(Console.ReadLine());
                            break;
                        default:
                            break;
                    }
                }
            }
            Console.WriteLine("Không tìm thấy!");
        }

        public void Xoa()
        {
            Console.WriteLine("Mời nhập ID của xe cần Xóa:");
            _InPut = Console.ReadLine();
            for (int i = 0; i < _lstXeMay.Count; i++)
            {
                if (_lstXeMay[i].Id1 == _InPut)
                {
                    _lstXeMay.RemoveAt(i);
                    Console.WriteLine("Xóa Thành công");
                    return;
                }
            }
            Console.WriteLine("Không tìm thấy!");
        }
        public void TimKiem()
        {
            Console.WriteLine("Mời nhập ID của xe cần Tìm:");
            _InPut = Console.ReadLine();
            for (int i = 0; i < _lstXeMay.Count; i++)
            {
                if (_lstXeMay[i].Id1 == _InPut)
                {
                    _lstXeMay[i].InRaManHinh();
                    return;
                }
            }
            Console.WriteLine("Không tìm thấy!");
        }

        public void Xuat()
        {
            foreach (var x in _lstXeMay)
            {
                x.InRaManHinh();
            }
        }
    }
}
