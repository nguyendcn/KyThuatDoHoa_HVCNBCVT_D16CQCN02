using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace KyThuatDoHoa_Nhom9
{
    public static class ToaDo
    {
        /// <summary>
        /// Chuyển từ tọa độ máy tính về tọa độ người dùng
        /// </summary>
        public static Point MayTinhNguoiDung(Point p)
        {
            p = RoundPixel(p);
            int width = Variables.Globals.sizeOfNewCoor_2D.Width,
                height = Variables.Globals.sizeOfNewCoor_2D.Height,
                x = p.X / 5,
                y = p.Y / 5;

            x = x > width / 2 ? x - width / 2 : (width / 2 - x) * -1;
            y = y > height / 2 ? (height / 2 - y) : height / 2 - y;

            return new Point(x, y);
        }
        /// <summary>
        /// Làm tròn tọa độ khi click để hiển thị trên lưới pixel.
        /// </summary>
        public static int RoundPixel(int p)
        {
            double d = p % 5;
            if (d >= 3)
                return (int)(p - d + 5);

            return (int)(p - d);
        }
        /// <summary>
        /// Làm tròn tọa độ khi click để hiển thị trên lưới pixel.
        /// </summary>
        public static Point RoundPixel(Point p)
        {
            int x = p.X % 5,
                y = p.Y % 5;

            x = (x >= 3 ? p.X - x + 5 : p.X - x);
            y = (y >= 3 ? y = p.Y - y + 5 : y = p.Y - y);

            return new Point(x, y);
        }

        /// <summary>
        /// Chuyển tọa độ người dùng về tọa độ máy tính 
        /// </summary>
        public static Point NguoiDungMayTinh(Point p)
        {
            int width = Variables.Globals.sizeOfNewCoor_2D.Width,
                height = Variables.Globals.sizeOfNewCoor_2D.Height,
                x = p.X,
                y = p.Y;
            x = x > 0 ? (x + width / 2) * 5 : (width / 2 - Math.Abs(x)) * 5;
            y = y > 0 ? (height / 2 - y) * 5 : y = (height / 2 + Math.Abs(y)) * 5;

            return new Point(x, y);
        }
        /// <summary>
        /// Hiển thị 1 điểm lên màn hình ( Theo tọa độ máy tính)
        /// </summary>
        public static void HienThi(Point p, Graphics g, Color color)
        {
            if (g == null)
                return;
            int pointX = RoundPixel(p.X),
                pointY = RoundPixel(p.Y);
            // Pen p1 = new Pen(Color.Green);
            SolidBrush b = new SolidBrush(color);

            //g.DrawEllipse(p1, pointX, pointY, 2, 2);
            //g.FillEllipse(b, pointX, pointY, 2, 2);
            //g.DrawEllipse(p1, pointX - 2, pointY - 2, 2, 2);
            //g.FillEllipse(b, pointX - 2, pointY - 2, 2, 2);
            //g.DrawEllipse(p1, pointX, pointY - 2, 2, 2);
            //g.FillEllipse(b, pointX, pointY - 2, 2, 2);
            //g.DrawEllipse(p1, pointX - 2, pointY, 2, 2);
            //g.FillEllipse(b, pointX - 2, pointY, 2, 2);
            g.FillRectangle(b, p.X - 2, p.Y - 2, 5, 5);
        }
        /// <summary>
        /// Hiển thị 1 điểm lên màn hình ( Theo tọa độ máy tính)
        /// </summary>
        //public static void HienThi(Point p, Graphics g, Color color)
        //{
        //    if (g == null)
        //        return;
        //    int pointX = RoundPixel(p.X),
        //        pointY = RoundPixel(p.Y);
        //    Pen p1 = new Pen(color);
        //    SolidBrush b = new SolidBrush(color);

        //    g.DrawEllipse(p1, pointX, pointY, 2, 2);
        //    g.FillEllipse(b, pointX, pointY, 2, 2);
        //    g.DrawEllipse(p1, pointX - 2, pointY - 2, 2, 2);
        //    g.FillEllipse(b, pointX - 2, pointY - 2, 2, 2);
        //    g.DrawEllipse(p1, pointX, pointY - 2, 2, 2);
        //    g.FillEllipse(b, pointX, pointY - 2, 2, 2);
        //    g.DrawEllipse(p1, pointX - 2, pointY, 2, 2);
        //    g.FillEllipse(b, pointX - 2, pointY, 2, 2);
        //}
        /// <summary>
        /// Hiển thị 1 điểm lên màn hình ( Theo tọa độ máy tính)
        /// </summary>
        public static void HienThi(int x, int y, Graphics g, Color color)
        {
            Point p = new Point(x, y);
            int pointX = RoundPixel(p.X),
                pointY = RoundPixel(p.Y);
            // Pen p1 = new Pen(Color.Green);
            SolidBrush b = new SolidBrush(color);

            //g.DrawEllipse(p1, pointX, pointY, 2, 2);
            //g.FillEllipse(b, pointX, pointY, 2, 2);
            //g.DrawEllipse(p1, pointX - 2, pointY - 2, 2, 2);
            //g.FillEllipse(b, pointX - 2, pointY - 2, 2, 2);
            //g.DrawEllipse(p1, pointX, pointY - 2, 2, 2);
            //g.FillEllipse(b, pointX, pointY - 2, 2, 2);
            //g.DrawEllipse(p1, pointX - 2, pointY, 2, 2);
            //g.FillEllipse(b, pointX - 2, pointY, 2, 2);
            g.FillRectangle(b, x - 2, y - 2, 5, 5);
        }
        /// <summary>
        /// Chuyển điểm 3D về điểm 2D dùng Cavalier
        /// </summary>
        /// <param name="X">Tọa độ trên Ox</param>
        /// <param name="Y">Tọa độ trên Oy</param>
        /// <param name="Z">Tọa độ trên Oz</param>
        /// <param name="Xp">Tọa độ đã chuyển trên Ox</param>
        /// <param name="Yp">Tọa độ đã chuyển trên Oy</param>
        public static Point Chuyen3DThanh2D(float X, float Y, float Z)
        {
            float alpha = (float)Math.PI / 4,
                  phi = (float)Math.PI / 4,
                  L,
                  Xp,
                  Yp;
            L = Z / (float)Math.Tan(alpha);
            //Xp = (float)(X + L * (float)Math.Cos(phi));
            //Yp = (float)(Y + L * (float)Math.Sin(phi));


            Xp = (float)(X - (float)Z * Math.Sqrt(2) / 2);
            Yp = (float)(Y - (float)Z * Math.Sqrt(2) / 2);

            return new Point((int)Xp, (int)Yp);
        }
        /// <summary>
        /// Chuyển từ tọa độ máy tính về tọa độ người dùng trong 3D
        /// </summary>
        public static Point MayTinhNguoiDung_3D(Point p)
        {
            p = RoundPixel(p);
            int width = Variables.Globals.sizeOfNewCoor_3D.Width,
                height = Variables.Globals.sizeOfNewCoor_3D.Height,
                x = p.X / 5,
                y = p.Y / 5;

            x = x > width * 2 / 5 ? x - width * 2 / 5 : (width * 2 / 5 - x) * -1;
            y = y > height / 2 ? (height / 2 - y) : height / 2 - y;

            return new Point(x, y);
        }
        /// <summary>
        /// Chuyển tọa độ người dùng về tọa độ máy tính trong 3D
        /// </summary>
        public static Point NguoiDungMayTinh_3D(int X, int Y, int Z)
        {
            Point point = new Point();
            point = Chuyen3DThanh2D(X, Y, Z);
            int width = Variables.Globals.sizeOfNewCoor_3D.Width,
                height = Variables.Globals.sizeOfNewCoor_3D.Height,
                x = point.X,
                y = point.Y;

            x = x > 0 ? (x + width * 2 / 5) * 5 : (width * 2 / 5 - Math.Abs(x)) * 5;
            y = y > 0 ? (height / 2 - y) * 5 : y = (height / 2 + Math.Abs(y)) * 5;

            return new Point(x, y);
        }
    }
}
