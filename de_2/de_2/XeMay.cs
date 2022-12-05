using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace de_2
{
    internal class XeMay:Xe
    {
        private string MauSac;
        private int DongXe;

        public XeMay()
        {

        }

        public XeMay(string id, int nSX, double trongLuong, string mauSac, int dongXe) : base(id, nSX, trongLuong)
        {
            MauSac1 = mauSac;
            DongXe1 = dongXe;
        }

        public string MauSac1 { get => MauSac; set => MauSac = value; }
        public int DongXe1 { get => DongXe; set => DongXe = value; }

        public override void InRaManHinh()
        {
            Console.WriteLine($"{Id1} | {(NSX1==1?"VN":"US")} | {TrongLuong1} | {MauSac1} | {DongXe1}");
        }
    }
}
