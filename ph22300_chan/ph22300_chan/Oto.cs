using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ph22300_chan
{
    internal class Oto:Xe
    {
        private string mauSac;
        private int dongXe;
        
        public Oto()
        {

        }
        public Oto(string id, int nSX, double taiTrong, string mauSac, int dongXe) : base(id, nSX, taiTrong)
        {
            this.MauSac = mauSac;
            this.DongXe = dongXe;
        }

        public string MauSac { get => mauSac; set => mauSac = value; }
        public int DongXe { get => dongXe; set => dongXe = value; }

        public override void InRaManHinh()
        {
            Console.WriteLine($"{Id} | {(NSX1==1?"VN":"Pháp")} | {TaiTrong} | {MauSac}| {(DongXe==1?"Điện":"Xăng")}");
        }
    }
}
