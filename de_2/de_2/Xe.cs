using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace de_2
{
    internal class Xe
    {
        private string Id;
        private int NSX;
        private double TrongLuong;

        public Xe()
        {

        }

        public Xe(string id, int nSX, double trongLuong)
        {
            Id1 = id;
            NSX1 = nSX;
            TrongLuong1 = trongLuong;
        }

        public string Id1 { get => Id; set => Id = value; }
        public int NSX1 { get => NSX; set => NSX = value; }
        public double TrongLuong1 { get => TrongLuong; set => TrongLuong = value; }

        public virtual void InRaManHinh()
        {

        }
    }
}
