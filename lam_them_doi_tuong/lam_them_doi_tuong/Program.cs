using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lam_them_doi_tuong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.OutputEncoding = Encoding.UTF8;
            //1.  Nguoi(Ten,Tuoi,Sdt,DiaChi,NgaySinh,QueQuan,TrinhDo)
            Nguoi N1;
            N1 = new Nguoi("Huyền", 19, "0935392002", "HN", "20-10-2002", "HN", "Cao đẳng");
            N1.InNguoi();

            //2.Meo(Ten, Tuoi, DiaChi, GioiTinh, NgaySinh)
            Meo M1 = new Meo("mèo anh khá bảnh",3, "Bắc Ninh",1, "10/12/2019");
            M1.inMeo();

            //3.GiaoVien(Ten, TenDem, HoTen, MaGV, Email1, Email2, Sdt, SoGioDay, ChucVu)
            GiaoVien GV1 = new GiaoVien();
            GV1.InGiaoVien();

            //4.SinhVien(Ten, TenDem, HoTen, MaSV, Email, Sdt, SdtNguoiThan, NganhHoc)
            SinhVien SV1 = new SinhVien();
            SV1.inSinhVien();

            //5.DongVat(MaDV, TenLoai, GiongLoai, KhuVucSong, ThucAn)
            DongVat DV1 = new DongVat();
            DV1.inDongVat();

            //6.Oto(MaOto, HangOto, DongCo, NhienLieu, GiaTien)
            Oto oto1 = new Oto();
            oto1.inOto();

            //7.ThucVat(MaTV, TenLoai, KhuVuc)
            ThucVat TV1 = new ThucVat();
            TV1.inThucVat();

            //8.BanGhe(MaBG, TenBanGhe, LoaiBanGhe, ChatLieu, ChieuCao, ChieuRong)
            BanGhe BG1 = new BanGhe();
            BG1.inBanGhe();

            //9.XeMay(MaXeMay, TenXeMay, HangXeMay, LoaiXeMay, NhienLieu, DongCo, GiaTien)
            XeMay XM1 = new XeMay();
            XM1.inXeMay();

            //10.Cho(MaCho, TenCho, GioiTinh, ThucAnYeuThich, NgaySinh)
            Cho C1 = new Cho();
            C1.inCho();
        }
    }
}
