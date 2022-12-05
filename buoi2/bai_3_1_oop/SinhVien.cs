using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_3_1_oop
{
    internal class SinhVien
    {
        //Phần 1: khai báo tất cả các thuộc tính mà đối tượng cần
        
        //phần 1 khai báo tất cả thuộc tính đối tượng cần
        private string ten, masv, que;
        private int gioitinh, namsinh;
        string truonghoc = "FPTPOLY";
        //phần 2 contructor-hàm tạo
        //ctructor không tham số - ctor+tab

        //Phần 2: Contructor- hàm tạo
        //contructor : không tham số - ctor + tab
       
        public SinhVien()
        {

        }

        //contructor có tham số giúp gán giá trị cho thuộc tính ngay khi khởi tạo đối tượng
        public SinhVien(string ten, string masv, string que, int gioitinh, int namsinh, string truonghoc)
        {
            this.Ten = ten;
            this.Masv = masv;
            this.Que = que;
            this.Gioitinh = gioitinh;
            this.Namsinh = namsinh;
            this.Truonghoc = truonghoc;
            //this tham chiếu đến thuộc tính và phương thức của lớp hiện tại
        }
        //Phần 3: triển khai property của thuộc tính vì các thuộc tính bị private ko thể truy cập trực tiếp
        public string Ten { get => ten; set => ten = value; }
        public string Masv { get => masv; set => masv = value; }
        public string Que { get => que; set => que = value; }
        public int Gioitinh { get => gioitinh; set => gioitinh = value; }
        public int Namsinh { get => namsinh; set => namsinh = value; }
        public string Truonghoc { get => truonghoc; set => truonghoc = value; }


        

        //Phần 4: các phương thức của đối tượng
        public void inRaManHinh()
        {
            Console.WriteLine($"{ten}|{masv}|{que}|{(gioitinh==1?"nam":"nữ")}|{namsinh}|{truonghoc}");
        }


}
}
