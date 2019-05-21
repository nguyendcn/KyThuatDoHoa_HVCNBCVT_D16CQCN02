using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace KyThuatDoHoa_Nhom9.Construct._3DObject
{
    class HinhHopChuNhat
    {
        private int ChieuDai { get; set; }
        private int ChieuRong { get; set; }
        private int ChieuCao { get; set; }
        private Point Dinh { get; set; }

        public HinhHopChuNhat(Point point, int chieuDai,int chieuRong,int chieuCao)
        {
            this.Dinh = point;
            this.ChieuDai = chieuDai;
            this.ChieuRong = chieuRong;
            this.ChieuCao = chieuCao;
        }
    }
}
