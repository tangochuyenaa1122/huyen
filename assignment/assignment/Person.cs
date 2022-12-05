using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    internal class Person
    {
        private string ho;
        private string ten;
        private string tenDem;
        private int namSinh;
        private int gioITinh;
        private string queQuan;
        
        public Person()
        {

        }

        public Person(string ho, string ten, string tenDem, int namSinh, int gioITinh, string queQuan)
        {
            this.Ho = ho;
            this.Ten = ten;
            this.TenDem = tenDem;
            this.NamSinh = namSinh;
            this.GioITinh = gioITinh;
            this.QueQuan = queQuan;
        }

        public string Ho { get => ho; set => ho = value; }
        public string Ten { get => ten; set => ten = value; }
        public string TenDem { get => tenDem; set => tenDem = value; }
        public int NamSinh { get => namSinh; set => namSinh = value; }
        public int GioITinh { get => gioITinh; set => gioITinh = value; }
        public string QueQuan { get => queQuan; set => queQuan = value; }

        public virtual void InRaManHinh()
        {

        }
    }
}
