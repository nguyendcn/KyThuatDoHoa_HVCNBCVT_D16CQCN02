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
        private Point[] lsPoint = new Point[25];

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

            // tâm bánh xe sau
            lsPoint[13] = new Point(100, 200);

            // tâm bánh xe trước
            lsPoint[14] = new Point(310, 200);

            lsPoint[19] = new Point(100, 180);



            lsPoint[20] = new Point(120, 215);

            lsPoint[21] = new Point(80, 215);


            lsPoint[22] = new Point(310, 180);
            lsPoint[23] = new Point(330, 215);
            lsPoint[24] = new Point(290, 215);
            bkBanh = 25;
        }

        
        public void drawCar(Graphics g)
        {
            // tô màu trước

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

            // vẽ tăm bánh xe sau
            Line tamSau1 = new Line(this.lsPoint[13], this.lsPoint[19]);
            tamSau1.ColorOfLine = Color.DarkRed;
            tamSau1.Draw(g);
            Line tamSau2 = new Line(this.lsPoint[13], this.lsPoint[20]);
            tamSau2.ColorOfLine = Color.DarkRed;
            tamSau2.Draw(g);
            Line tamSau3 = new Line(this.lsPoint[13], this.lsPoint[21]);
            tamSau3.ColorOfLine = Color.DarkRed;
            tamSau3.Draw(g);
            // vẽ bánh xe trước
            HinhTron htTruoc = new HinhTron(this.bkBanh, this.lsPoint[14], Color.Black);
            htTruoc.Draw(g);

            // vẽ tăm bánh xe trước
            Line tamTruoc1 = new Line(this.lsPoint[14], this.lsPoint[22]);
            tamTruoc1.ColorOfLine = Color.DarkRed;
            tamTruoc1.Draw(g);
            Line tamTruoc2 = new Line(this.lsPoint[14], this.lsPoint[23]);
            tamTruoc2.ColorOfLine = Color.DarkRed;
            tamTruoc2.Draw(g);
            Line tamTruoc3 = new Line(this.lsPoint[14], this.lsPoint[24]);
            tamTruoc3.ColorOfLine = Color.DarkRed;
            tamTruoc3.Draw(g);
        }
        public void ToMau(Graphics g) 
        {
            // Create solid brush.
            SolidBrush brush = new SolidBrush(Color.Purple);
            SolidBrush brush1 = new SolidBrush(Color.LawnGreen);
            SolidBrush  brush2 = new SolidBrush(Color.Orange);
            SolidBrush brush3 = new SolidBrush(Color.Chocolate);
            // Create points that define polygon.
            // tô màu bên ngoài
            Point[] curvePoints = { this.lsPoint[1], this.lsPoint[0],
                this.lsPoint[2], this.lsPoint[3], this.lsPoint[4], this.lsPoint[5],
                this.lsPoint[6], this.lsPoint[7], this.lsPoint[1] };
            // tô màu hình chữ nhật
            Point d1 = new Point(this.lsPoint[8].X, this.lsPoint[9].Y);
            Point d2 = new Point(this.lsPoint[9].X, this.lsPoint[8].Y);
            Point[] curvePoints1 = {this.lsPoint[8],  d1, this.lsPoint[9], d2, this.lsPoint[8] };

            // tô màu hình tam giác 
            Point[] curvePoints2 = { this.lsPoint[10], this.lsPoint[11], this.lsPoint[12], this.lsPoint[10]};

            
            // Draw polygon to screen.
            g.FillPolygon(brush, curvePoints);
            g.FillPolygon(brush1, curvePoints1);
            g.FillPolygon(brush2, curvePoints2);
            g.FillEllipse(brush3, this.lsPoint[13].X - 28, this.lsPoint[13].Y - 28, 55, 55);
            g.FillEllipse(brush3, this.lsPoint[14].X - 28, this.lsPoint[14].Y - 28, 55, 55);
        }

        // phép tịnh tiếng xe theo tọa độ x, y
        public void traslationXe(int x, int y)
        {
            for (int i = 0; i < this.lsPoint.Length; i++)
            {
                tinhTien(ref this.lsPoint[i], x, y);
            }
        }


        public void quayBanhXe(int goc)
        {

            lsPoint[19] = lsPoint[19].RotateAt(lsPoint[13], goc);
            lsPoint[20] = lsPoint[20].RotateAt(lsPoint[13], goc);
            lsPoint[21] = lsPoint[21].RotateAt(lsPoint[13], goc);

            lsPoint[22] = lsPoint[22].RotateAt(lsPoint[14], goc);
            lsPoint[23] = lsPoint[23].RotateAt(lsPoint[14], goc);
            lsPoint[24] = lsPoint[24].RotateAt(lsPoint[14], goc);

        }
        private Point nhanMT(double[,] matran, double[] mang)
        {
            double[] mangtam = new double[3];

            int dem = 0;
            for (int i = 0; i < 3; i++)
            {
                mangtam[i] = mang[0] * matran[0, dem] + mang[1] * matran[1, dem] + mang[2] * matran[2, dem];
                dem++;
            }

            Point pt = new Point(Convert.ToInt16(mangtam[0]), Convert.ToInt16(mangtam[1]));
            return pt;
        }

        // hàm tịnh tiến tọa đồ pn xDonVi, yDonVi
        private void tinhTien( ref Point pn, int xDonVi, int yDonVi)
        {
            double[] matran1 = new double[3] { pn.X, pn.Y, 1 };
            // khởi tạo ma trận tịnh tiến
            double[,] matran2 = new double[3, 3] { { 1,  0 , 0 },
                                             { 0,  1 , 0 },
                                             { xDonVi,  yDonVi, 1} };

            pn = nhanMT(matran2, matran1);
        }

    }
}
