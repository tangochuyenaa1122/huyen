using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ph22300_chan
{
    internal class Xe
    {
        private string id;
        private int NSX;
        private double taiTrong;

        public Xe()
        {

        }
        public Xe(string id, int nSX, double taiTrong)
        {
            this.Id = id;
            NSX1 = nSX;
            this.TaiTrong = taiTrong;
        }

        public string Id { get => id; set => id = value; }
        public int NSX1 { get => NSX; set => NSX = value; }
        public double TaiTrong { get => taiTrong; set => taiTrong = value; }

        public virtual void InRaManHinh()
        {

        }
    }
}
