using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyThuatDoHoa_Nhom9.Construct._2DObject
{
    class HinhXe
    {
        // danh sách các points để vẽ hình xe
        private Point[] lsPoint = new Point[19];
        // bán kính bánh xe
        private int bkBanh;

        // khởi tạo các giá trị mặc định cho thuộc tính vẽ xe
        public HinhXe()
        {
            lsPoint[0] = new Point(20, 205);
            lsPoint[1] = new Point(420, 205);
            lsPoint[15] = new Point(339, 205);
            lsPoint[16] = new Point(279, 205);
            lsPoint[17] = new Point(129, 205);
            lsPoint[18] = new Point(70, 205);

            lsPoint[2] = new Point(20, 160);

            lsPoint[3] = new Point(60, 160);
            lsPoint[4] = new Point(135, 115);
            lsPoint[5] = new Point(280, 115);
            lsPoint[6] = new Point(350, 160);
            lsPoint[7] = new Point(400, 160);

            lsPoint[8] = new Point(130, 130);
            lsPoint[9] = new Point(255, 165);

            lsPoint[10] = new Point(265, 130);

            lsPoint[11] = new Point(330, 166);
            lsPoint[12] = new Point(265, 166);

            lsPoint[13] = new Point(100, 205);
            lsPoint[14] = new Point(310, 205);
            bkBanh = 25;
        }

        // phép tịnh tiếng xe
        public void traslationXe(int x, int y)
        {
            for (int i = 0; i < this.lsPoint.Length; i++)
            {
                this.lsPoint[i].X += x;
                this.lsPoint[i].Y += y;
            }
        }
        public void drawCar(Graphics g)
        {
            // vẽ gầm Car
            Line lnGamXe1 = new Line(this.lsPoint[1], this.lsPoint[15]);
            lnGamXe1.Draw(g);
            Line lnGamXe2 = new Line(this.lsPoint[16], this.lsPoint[17]);
            lnGamXe2.Draw(g);
            Line lnGamXe3 = new Line(this.lsPoint[0], this.lsPoint[18]);
            lnGamXe3.Draw(g);


            // vẽ  đuôi
            Line lnDuoi = new Line(this.lsPoint[0], this.lsPoint[2]);
            lnDuoi.Draw(g);

            // vẽ hông đuôi
            Line lnHDuoi = new Line(this.lsPoint[2], this.lsPoint[3]);
            lnHDuoi.Draw(g);

            // vẽ hông đuôi trên
            Line lnHDuoiTren = new Line(this.lsPoint[3], this.lsPoint[4]);
            lnHDuoiTren.Draw(g);

            // vẽ trần xe
            Line lnTran = new Line(this.lsPoint[4], this.lsPoint[5]);
            lnTran.Draw(g);

            // vẽ hông đầu trên
            Line lnHDau = new Line(this.lsPoint[5], this.lsPoint[6]);
            lnHDau.Draw(g);
            // vẽ hông đầu dưới
            Line lnHDauDuoi = new Line(this.lsPoint[6], this.lsPoint[7]);
            lnHDauDuoi.Draw(g);
            // vẽ đầu
            Line lnDau = new Line(this.lsPoint[1], this.lsPoint[7]);
            lnDau.Draw(g);
            // vẽ hình chữ nhật
            HinhChuNhat hcn = new HinhChuNhat(this.lsPoint[8], this.lsPoint[9]);
            hcn.Draw(g);

            // vẽ hình tam giác
            HinhTamGiac htg = new HinhTamGiac(this.lsPoint[10], this.lsPoint[11], this.lsPoint[12]);
            htg.Draw(g);

            // vẽ bánh xe sau
            HinhTron htSau = new HinhTron(this.bkBanh, this.lsPoint[13], Color.Black);
            htSau.Draw(g);

            // vẽ bánh xe trước
            HinhTron htTruoc = new HinhTron(this.bkBanh, this.lsPoint[14], Color.Black);
            htTruoc.Draw(g);
        }
    }
}
