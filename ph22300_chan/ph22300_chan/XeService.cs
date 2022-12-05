using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ph22300_chan
{
    internal class XeService
    {
        List<Xe> _lstOto= new List<Xe>();
        Oto _xeOto= new Oto();
        string _input;

        public XeService()
        {
           _lstOto = new List<Xe>();
           fake3Data();
        }
         
        public void fake3Data()
        {
            _lstOto = new List<Xe>();
            _xeOto = new Oto("xe123",1,100,"đỏ",2);
            _xeOto = new Oto("xe234",2,149,"xanh",1);
            _xeOto = new Oto("xe123",1,200,"vàng",1);
            _xeOto.InRaManHinh();
        }

        public string getInPut(string nHAP)
        {
            Console.WriteLine($"moiwf nhaaoj{nHAP}:");
            return Console.ReadLine();
        }
        public void ThemXe()
        {
            Console.WriteLine("Mời bạn nhập số lượng :");
            _input = Console.ReadLine();
            for (int i = 0; i < ; i++)
            {

            }
        }

        public void Sua()
        {
            Console.WriteLine("Mời bạn nhập ID :");
            _input = Console.ReadLine();
            for (int i = 0; i < _lstOto.Count; i++)
            {
                if (_input == _xeOto.Id)
                {
                    int x = new int();
                    Console.WriteLine("1.sửa NSX");
                    Console.WriteLine("2.sửa tải trọng");
                    Console.WriteLine("1.sửa màu sắc");
                    Console.WriteLine("1.sửa dòng xe");
                    switch (x)
                    {
                        case 1:
                            _xeOto.NSX1 = getInPut("nsx");
                            break;
                        case 2:
                            _xeOto.TaiTrong = getInPut("tải trọng");
                            break;
                        case 3:
                            _xeOto.MauSac = getInPut("màu");
                            break; 
                        case 4:
                            _xeOto.DongXe = getInPut("dòng xe");
                            break;
                        default:
                            break;
                    }
                }

            }          
        }

        public void InDS()
        {
            foreach (var x in _lstOto)
            {
                x.InRaManHinh();
            }
        }

        public void Xoa()
        {
            Console.WriteLine("Mời bạn nhập ID :");
            _input = Console.ReadLine();
            for (int i = 0; i < _lstOto.Count; i++)
            {
                if (_input == _xeOto.Id)
                {
                    _lstOto.RemoveAt(i);
                }
            }
        }

        public void Tim()
        {
            Console.WriteLine("Mời bạn nhập ID :");
            _input = Console.ReadLine();
            for (int i = 0; i < _lstOto.Count; i++)
            {
                if (_input == _xeOto.Id)
                {
                    _lstOto[i].InRaManHinh();
                }
            }
        }
    }
}
