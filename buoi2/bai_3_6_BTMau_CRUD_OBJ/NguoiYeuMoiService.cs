using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_3_6_BTMau_CRUD_OBJ
{
    //code các chức năng ở đây
    internal class NguoiYeuMoiService 
    {
        
        //triển khai các biến toàn cục trên đầu
        private List<NguoiYeuMoi> _lstNYMoi;
        private NguoiYeuMoi _NYMoi;
        private string _input;
        public NguoiYeuMoiService()
        {
            Console.OutputEncoding = Encoding.UTF8;
            _lstNYMoi = new List<NguoiYeuMoi>();
            fake5Data();//khi khởi tạo lớp service sẽ có sẵn 5 phần tử
        }
        private void fake5Data()
        {
            _lstNYMoi = new List<NguoiYeuMoi> 
            {
                new NguoiYeuMoi("A","0957346334",0,45.5,"game"),
                new NguoiYeuMoi("B","0957868476",1,70,"học"),
                new NguoiYeuMoi("G","0926846768",1,63,"phim"),
                new NguoiYeuMoi("D","0936767998",0,50,"nhạc"),
                new NguoiYeuMoi("Y","0945756867",1,90,"game LOL")
            };
        }
        public void themNY()
        {
            Console.WriteLine("THÊM NYM");
            Console.Write("Mời nhập số lượng: ");
            _input = Console.ReadLine();
            for (int i = 0; i < Convert.ToInt32(_input); i++)
            {
                _lstNYMoi.Add(new NguoiYeuMoi(getInputValue("tên"), getInputValue("sdt"), Convert.ToInt32(getInputValue("giới tính")), Convert.ToDouble(getInputValue("cân nặng")), getInputValue("sở thích")));
            }
        }
        public string getInputValue(string msg)
        {
            Console.Write($"Mời bạn nhập {msg}: ");
            return Console.ReadLine();
        }
        public void InDS()
        {
            foreach (var x in _lstNYMoi)
            {
                x.InRaManHinh();
            }
        }
        //Đã làm được tìm sẽ làm được xóa và sửa
        public void TimKiem()
        {
            Console.Write("Mời bạn nhập sđt: ");
            _input = Console.ReadLine();
            for (int i = 0; i < _lstNYMoi.Count; i++)
            {
                if (_lstNYMoi[i].Sdt==_input)
                {
                    _lstNYMoi[i].InRaManHinh();
                    //break;
                    return;
                }
            }
            Console.WriteLine("ko tìm thấy");
        }
        public void Xoa()
        {
            Console.Write("Mời bạn nhập sđt: ");
            _input = Console.ReadLine();
            for (int i = 0; i < _lstNYMoi.Count; i++)
            {
                if (_lstNYMoi[i].Sdt == _input)
                {
                    _lstNYMoi.RemoveAt(i);
                    Console.WriteLine("Xóa thành công");
                    return;
                }
            }
            Console.WriteLine("ko tìm thấy");
        }
        public void Sua()
        {
            Console.Write("Mời bạn nhập sđt: ");
            _input = Console.ReadLine();
            for (int i = 0; i < _lstNYMoi.Count; i++)
            {
                if (_lstNYMoi[i].Sdt == _input)
                {
                    Console.WriteLine("1.Sửa Tên");
                    Console.WriteLine("2.Sửa cân nặng");
                    Console.WriteLine("Mời bạn chọn: ");
                    _input = Console.ReadLine();
                    switch (_input)
                    {
                        case "1":
                            Console.Write("Mời bạn nhập tên: ");
                            _lstNYMoi[i].Ten = Console.ReadLine();
                            break;
                        case "2":
                            Console.Write("Mời bạn nhập Cân nặng: ");
                            _lstNYMoi[i].CanNang = Convert.ToDouble(Console.ReadLine());
                            break;
                        default:
                            break;
                    }
                    Console.WriteLine("Sửa thành công");
                    return;
                }
            }
            Console.WriteLine("ko tìm thấy");
        }
    }
}
