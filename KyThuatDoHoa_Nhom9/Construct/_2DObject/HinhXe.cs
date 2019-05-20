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



            lsPoint[20] = new Point(120, 220);

            lsPoint[21] = new Point(80, 220);


            lsPoint[22] = new Point(310, 180);
            lsPoint[23] = new Point(330, 220);
            lsPoint[24] = new Point(290, 220);
            bkBanh = 25;
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

            // vẽ tăm bánh xe sau
            Line tamSau1 = new Line(this.lsPoint[13], this.lsPoint[19]);
            tamSau1.Draw(g);
            Line tamSau2 = new Line(this.lsPoint[13], this.lsPoint[20]);
            tamSau2.Draw(g);
            Line tamSau3 = new Line(this.lsPoint[13], this.lsPoint[21]);
            tamSau3.Draw(g);
            // vẽ bánh xe trước
            HinhTron htTruoc = new HinhTron(this.bkBanh, this.lsPoint[14], Color.Black);
            htTruoc.Draw(g);

            // vẽ tăm bánh xe trước
            Line tamTruoc1 = new Line(this.lsPoint[14], this.lsPoint[22]);
            tamTruoc1.Draw(g);
            Line tamTruoc2 = new Line(this.lsPoint[14], this.lsPoint[23]);
            tamTruoc2.Draw(g);
            Line tamTruoc3 = new Line(this.lsPoint[14], this.lsPoint[24]);
            tamTruoc3.Draw(g);
        }

        // Quay 1 diem (x,y)quanh diem(xo,yo)1 goc a;
        // hàm quay quanh một điểm bất kỳ
        //public void quayQuanhMotDiemBatKy(ref Point ptVien, Point ptTam)
        //{
        //    Point Vien, Tam;

        //    chuyển đổi hệ tọa độ máy sang hệ tọa độ người dùng
        //    Vien = ToaDo.MayTinhNguoiDung(ptVien);
        //    Tam = ToaDo.MayTinhNguoiDung(ptTam);

        //    tịnh tiến Tam về gốc tọa độ, và Vien tương ứng
        //    tinhTien(ref Tam, -1 * Tam.X, -1 * Tam.Y);
        //    tinhTien(ref Vien, -1 * Tam.X, -1 * Tam.Y);

        //    quay Vien quanh gộc tọa độ một góc 45 *
        //  quayQuanhGocToaDo(ref Vien, 180);

        //    tịnh tiến Tam về vị trí cụ và Vien tương ứng
        //    tinhTien(ref Tam, Tam.X, Tam.Y);
        //    tinhTien(ref Vien, Tam.X, Tam.Y);

        //    chuyển đổi hệ tọa độ người dùng về lại hệ tọa độ máy tính


        //    ptVien = ToaDo.NguoiDungMayTinh(Vien);

        //}


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

        //// hàm quay tọa độ pn một góc quanh gốc tọa độ
        //private void quayQuanhGocToaDo(ref Point pn, int goc)
        //{
        //    double sin, cos;

        //    // tính toán sin, cos với góc đổi thành radian
        //    sin = Math.Sin((Math.PI * goc) / 180);
        //    cos = Math.Cos((Math.PI * goc) / 180);
        //    double[] matran1 = new double[3] { pn.X, pn.Y, 1 };
        //    // khởi tạo ma trận tịnh tiến
        //    double[,] matran2 = new double[3, 3] { { cos,  sin , 0 },
        //                                     { -1 * sin,  cos , 0 },
        //                                     { 0  ,    0    , 1} };

        //    pn = nhanMT(matran2, matran1);
        //}
    }
}
