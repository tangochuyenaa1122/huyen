using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_3_6_BTMau_CRUD_OBJ
{
    internal class Nguoi
    {
        private string ten;
        private string sdt;
        private int gioiTinh;//1=nam 0=nữ

        public Nguoi()
        {

        }
        public Nguoi(string ten, string sdt, int gioiTinh)
        {
            this.Ten = ten;
            this.Sdt = sdt;
            this.GioiTinh = gioiTinh;
        }
        
        public string Ten { get => ten; set => ten = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public int GioiTinh { get => gioiTinh; set => gioiTinh = value; }

        public virtual void InRaManHinh()
        {

        }
    }
}
