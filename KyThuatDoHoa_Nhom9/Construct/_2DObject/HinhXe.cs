using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KyThuatDoHoa_Nhom9.Construct._2DObject
{
    class HinhXe : INotifyPropertyChanged
    {

        // danh sách các points để vẽ hình xe
        private Point[] lsPoint = new Point[25];
        // bán kính bánh xe
        private int bkBanh;
        public Point[] LsPoint
        { get => lsPoint;
          set
            {
                lsPoint = value;
            }
        }
        public int BkBanh { get => bkBanh; set => bkBanh = value; }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
     


        // khởi tạo các giá trị mặc định cho thuộc tính vẽ xe
        public HinhXe()
        {
            LsPoint[0] = new Point(20, 205);
            LsPoint[1] = new Point(420, 205);
            LsPoint[15] = new Point(339, 205);
            LsPoint[16] = new Point(279, 205);
            LsPoint[17] = new Point(129, 205);
            LsPoint[18] = new Point(70, 205);

            LsPoint[2] = new Point(20, 160);

            LsPoint[3] = new Point(60, 160);
            LsPoint[4] = new Point(135, 115);
            LsPoint[5] = new Point(280, 115);
            LsPoint[6] = new Point(350, 160);
            LsPoint[7] = new Point(400, 160);

            LsPoint[8] = new Point(130, 130);
            LsPoint[9] = new Point(255, 165);

            LsPoint[10] = new Point(265, 130);

            LsPoint[11] = new Point(330, 166);
            LsPoint[12] = new Point(265, 166);

            // tâm bánh xe sau
            LsPoint[13] = new Point(100, 200);

            // tâm bánh xe trước
            LsPoint[14] = new Point(310, 200);

            LsPoint[19] = new Point(100, 180);



            LsPoint[20] = new Point(120, 215);

            LsPoint[21] = new Point(80, 215);


            LsPoint[22] = new Point(310, 180);
            LsPoint[23] = new Point(330, 215);
            LsPoint[24] = new Point(290, 215);
            BkBanh = 25;
            NotifyPropertyChanged();

        }


        public void drawCar(Graphics g)
        {
            // tô màu trước

            // vẽ gầm Car
            Line lnGamXe1 = new Line(this.LsPoint[1], this.LsPoint[15]);
            lnGamXe1.Draw(g);
            Line lnGamXe2 = new Line(this.LsPoint[16], this.LsPoint[17]);
            lnGamXe2.Draw(g);
            Line lnGamXe3 = new Line(this.LsPoint[0], this.LsPoint[18]);
            lnGamXe3.Draw(g);


            // vẽ  đuôi
            Line lnDuoi = new Line(this.LsPoint[0], this.LsPoint[2]);
            lnDuoi.Draw(g);

            // vẽ hông đuôi
            Line lnHDuoi = new Line(this.LsPoint[2], this.LsPoint[3]);
            lnHDuoi.Draw(g);

            // vẽ hông đuôi trên
            Line lnHDuoiTren = new Line(this.LsPoint[3], this.LsPoint[4]);
            lnHDuoiTren.Draw(g);

            // vẽ trần xe
            Line lnTran = new Line(this.LsPoint[4], this.LsPoint[5]);
            lnTran.Draw(g);

            // vẽ hông đầu trên
            Line lnHDau = new Line(this.LsPoint[5], this.LsPoint[6]);
            lnHDau.Draw(g);
            // vẽ hông đầu dưới
            Line lnHDauDuoi = new Line(this.LsPoint[6], this.LsPoint[7]);
            lnHDauDuoi.Draw(g);
            // vẽ đầu
            Line lnDau = new Line(this.LsPoint[1], this.LsPoint[7]);
            lnDau.Draw(g);
            // vẽ hình chữ nhật
            HinhChuNhat hcn = new HinhChuNhat(this.LsPoint[8], this.LsPoint[9]);
            hcn.Draw(g);

            // vẽ hình tam giác
            HinhTamGiac htg = new HinhTamGiac(this.LsPoint[10], this.LsPoint[11], this.LsPoint[12]);
            htg.Draw(g);

            // vẽ bánh xe sau
            HinhTron htSau = new HinhTron(this.BkBanh, this.LsPoint[13], Color.Black);
            htSau.Draw(g);

            // vẽ tăm bánh xe sau
            Line tamSau1 = new Line(this.LsPoint[13], this.LsPoint[19]);
            tamSau1.ColorOfLine = Color.DarkRed;
            tamSau1.Draw(g);
            Line tamSau2 = new Line(this.LsPoint[13], this.LsPoint[20]);
            tamSau2.ColorOfLine = Color.DarkRed;
            tamSau2.Draw(g);
            Line tamSau3 = new Line(this.LsPoint[13], this.LsPoint[21]);
            tamSau3.ColorOfLine = Color.DarkRed;
            tamSau3.Draw(g);
            // vẽ bánh xe trước
            HinhTron htTruoc = new HinhTron(this.BkBanh, this.LsPoint[14], Color.Black);
            htTruoc.Draw(g);

            // vẽ tăm bánh xe trước
            Line tamTruoc1 = new Line(this.LsPoint[14], this.LsPoint[22]);
            tamTruoc1.ColorOfLine = Color.DarkRed;
            tamTruoc1.Draw(g);
            Line tamTruoc2 = new Line(this.LsPoint[14], this.LsPoint[23]);
            tamTruoc2.ColorOfLine = Color.DarkRed;
            tamTruoc2.Draw(g);
            Line tamTruoc3 = new Line(this.LsPoint[14], this.LsPoint[24]);
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
            Point[] curvePoints = { this.LsPoint[1], this.LsPoint[0],
                this.LsPoint[2], this.LsPoint[3], this.LsPoint[4], this.LsPoint[5],
                this.LsPoint[6], this.LsPoint[7], this.LsPoint[1] };
            // tô màu hình chữ nhật
            Point d1 = new Point(this.LsPoint[8].X, this.LsPoint[9].Y);
            Point d2 = new Point(this.LsPoint[9].X, this.LsPoint[8].Y);
            Point[] curvePoints1 = {this.LsPoint[8],  d1, this.LsPoint[9], d2, this.LsPoint[8] };

            // tô màu hình tam giác 
            Point[] curvePoints2 = { this.LsPoint[10], this.LsPoint[11], this.LsPoint[12], this.LsPoint[10]};

            
            // Draw polygon to screen.
            g.FillPolygon(brush, curvePoints);
            g.FillPolygon(brush1, curvePoints1);
            g.FillPolygon(brush2, curvePoints2);
            g.FillEllipse(brush3, this.LsPoint[13].X - 28, this.LsPoint[13].Y - 28, 55, 55);
            g.FillEllipse(brush3, this.LsPoint[14].X - 28, this.LsPoint[14].Y - 28, 55, 55);
        }

        // phép tịnh tiếng xe theo tọa độ x, y
        public void traslationXe(int x, int y)
        {
            for (int i = 0; i < this.LsPoint.Length; i++)
            {
                tinhTien(ref this.LsPoint[i], x, y);
            }
            NotifyPropertyChanged();

        }

        public void doiXungQuaOx()
        {

            for (int i = 0; i < this.LsPoint.Length; i++)
            {
                this.lsPoint[i] = ToaDo.MayTinhNguoiDung(this.lsPoint[i]);
                doiXungOX(ref this.lsPoint[i]);
                this.lsPoint[i] = ToaDo.NguoiDungMayTinh(this.lsPoint[i]);
            }

            NotifyPropertyChanged();

        }

        public void doiXungQuaOy()
        {

            for (int i = 0; i < this.LsPoint.Length; i++)
            {
                this.lsPoint[i] = ToaDo.MayTinhNguoiDung(this.lsPoint[i]);
                doiXungOY(ref this.lsPoint[i]);
                this.lsPoint[i] = ToaDo.NguoiDungMayTinh(this.lsPoint[i]);
            }

            NotifyPropertyChanged();

        }
        public void doiXungQuaTruc()
        {

            for (int i = 0; i < this.LsPoint.Length; i++)
            {
                this.lsPoint[i] = ToaDo.MayTinhNguoiDung(this.lsPoint[i]);
                doiXungQuaTruc(ref this.lsPoint[i]);
                this.lsPoint[i] = ToaDo.NguoiDungMayTinh(this.lsPoint[i]);
            }

            NotifyPropertyChanged();

        }



        public void quayBanhXe(int goc)
        {

            LsPoint[19] = LsPoint[19].RotateAt(LsPoint[13], goc);
            LsPoint[20] = LsPoint[20].RotateAt(LsPoint[13], goc);
            LsPoint[21] = LsPoint[21].RotateAt(LsPoint[13], goc);

            LsPoint[22] = LsPoint[22].RotateAt(LsPoint[14], goc);
            LsPoint[23] = LsPoint[23].RotateAt(LsPoint[14], goc);
            LsPoint[24] = LsPoint[24].RotateAt(LsPoint[14], goc);
            NotifyPropertyChanged();

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
        private void doiXungOX(ref Point pn)
        {
            double[] matran1 = new double[3] { pn.X, pn.Y, 1 };
            // khởi tạo ma trận tịnh tiến
            double[,] matran2 = new double[3, 3] { { -1,  0 , 0 },
                                             { 0,  1 , 0 },
                                             { 0,  0, 1} };

            pn = nhanMT(matran2, matran1);
            
        }

        private void doiXungOY(ref Point pn)
        {
            double[] matran1 = new double[3] { pn.X, pn.Y, 1 };
            // khởi tạo ma trận tịnh tiến
            double[,] matran2 = new double[3, 3] { { 1,  0 , 0 },
                                             { 0,  -1 , 0 },
                                             { 0,  0, 1} };

            pn = nhanMT(matran2, matran1);

        }

        private void doiXungQuaTruc(ref Point pn)
        {
            double[] matran1 = new double[3] { pn.X, pn.Y, 1 };
            // khởi tạo ma trận tịnh tiến
            double[,] matran2 = new double[3, 3] { {- 1,  0 , 0 },
                                             { 0,  -1 , 0 },
                                             { 0,  0, 1} };

            pn = nhanMT(matran2, matran1);

        }

    }
}
