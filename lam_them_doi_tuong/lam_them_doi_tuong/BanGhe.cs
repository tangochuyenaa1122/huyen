using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lam_them_doi_tuong
{
    internal class BanGhe
    {
        private string MaBG;
        private string TenBanGhe;
        private string LoaiBanGhe;
        private string ChatLieu;
        private int ChieuCao;
        private int ChieuRong;

        public BanGhe()
        {
            Console.WriteLine("in bàn ghế");
        }

        public BanGhe(string maBG, string tenBanGhe, string loaiBanGhe,
            string chatLieu, int chieuCao, int chieuRong)
        {
            MaBG1 = maBG;
            TenBanGhe1 = tenBanGhe;
            LoaiBanGhe1 = loaiBanGhe;
            ChatLieu1 = chatLieu;
            ChieuCao1 = chieuCao;
            ChieuRong1 = chieuRong;
        }

        public string MaBG1 { get => MaBG; set => MaBG = value; }
        public string TenBanGhe1 { get => TenBanGhe; set => TenBanGhe = value; }
        public string LoaiBanGhe1 { get => LoaiBanGhe; set => LoaiBanGhe = value; }
        public string ChatLieu1 { get => ChatLieu; set => ChatLieu = value; }
        public int ChieuCao1 { get => ChieuCao; set => ChieuCao = value; }
        public int ChieuRong1 { get => ChieuRong; set => ChieuRong = value; }

        public void inBanGhe()
        {
            Console.WriteLine($"{MaBG} | {TenBanGhe} | {LoaiBanGhe} | {ChatLieu} | {ChieuCao} | {ChieuRong}");
        }
    }
}
