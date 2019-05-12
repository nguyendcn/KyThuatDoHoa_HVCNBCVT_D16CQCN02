using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyThuatDoHoa_Nhom9
{
    /// <summary>
    /// Vẽ đường thẳng bằng Mid-Point
    /// </summary>
    class Drawn
    {
        #region Vẽ đường thẳng
        public static void Line(Point P1, Point P2, Graphics g)
        {
            // Làm tròn tạo độ trên Lưới Pixel
            P1 = ToaDo.RoundPixel(P1);
            P2 = ToaDo.RoundPixel(P2);

            /* Dùng Bresanhen:
             https://www.facebook.com/notes/it2-center-information-tech-one/th%C3%B4%CC%81ng-nh%C3%A2%CC%81t-thu%C3%A2%CC%A3t-toa%CC%81n-%C4%91%C6%B0%C6%A1%CC%80ng-th%C4%83%CC%89ng-bresenham/717098638478141/
             https://www.youtube.com/watch?v=kTAkWgJ4bko&list=PLZEIt444jqpB-bzArUv3dSpDuh3OhM0BJ&index=14   
             */

            int Dx = P2.X - P1.X,
                Dy = P2.Y - P1.Y,
                x = P1.X,
                y = P1.Y,
                p;
            float m = (float)Dy / Dx;
            Console.WriteLine(m);

            ToaDo.HienThi(new Point(P1.X, P1.Y), g);
            if (m > 0 && m <= 1)
            {
                if (P1.X > P2.X)
                {
                    Point p1 = P1;
                    P1 = P2;
                    P2 = p1;
                }
                Dx = P2.X - P1.X;
                Dy = P2.Y - P1.Y;
                x = P1.X;
                y = P1.Y;
                p = 2 * Dy - Dx;
                while (x < P2.X)
                {
                    x += 5;
                    if (p < 0)
                    {
                        p = p + 2 * Dy;
                    }
                    else
                    {
                        p = p + 2 * (Dy - Dx); 
                        y += 5;
                    }
                    ToaDo.HienThi(new Point(x, y), g);
                }
                return;
            }
            if (m >= -1 && m < 0)
            {
                if (P1.X > P2.X)
                {
                    Point p1 = P1;
                    P1 = P2;
                    P2 = p1;
                }
                Dx = P2.X - P1.X;
                Dy = P2.Y - P1.Y;
                x = P1.X;
                y = P1.Y;
                p = 2 * Dy - Dx;
                while (x < P2.X)
                {
                    ToaDo.HienThi(new Point(x, y), g);
                    x += 5;
                    if (p < 0)
                    {
                        y -= 5;
                        p = p + 2 * (Dx + Dy);  
                    }
                    else
                    {
                        p = p + 2 * Dy; 
                    }
                }
                return;
            }
            if (m > 1)
            {
                if (P1.Y > P2.Y)
                {
                    Point p1 = P1;
                    P1 = P2;
                    P2 = p1;
                }
                Dx = P2.X - P1.X;
                Dy = P2.Y - P1.Y;
                x = P1.X;
                y = P1.Y;
                p = 2 * Dx - Dy;
                while (y < P2.Y)
                {
                    y += 5;
                    if (p < 0)
                    {
                        p = p + 2 * Dx;
                    }
                    else
                    {
                        x += 5;
                        p = p + 2 * (Dx - Dy);
                    }
                    ToaDo.HienThi(new Point(x, y), g);
                }
                return;
            }
            if (m < -1)
            {
                if (P1.Y > P2.Y)
                {
                    Point p1 = P1;
                    P1 = P2;
                    P2 = p1;
                }
                Dx = P2.X - P1.X;
                Dy = P2.Y - P1.Y;
                x = P1.X;
                y = P1.Y;
                p = 2 * Dx + Dy;
                while (y <= P2.Y)
                {
                    ToaDo.HienThi(new Point(x, y), g);
                    y += 5;
                    if (p < 0)
                    {
                        x -= 5;
                        p = p + 2 * (Dx+Dy);  
                    }
                    else
                    {
                        p = p + 2 * Dx;  
                    }
                    
                }
            }
            // Trùng Ox
            if (P1.Y == P2.Y)
            {
                if (P1.X > P2.X)
                {
                    Point p1 = P1;
                    P1 = P2;
                    P2 = p1;
                }
                while (P1.X <= P2.X)
                {
                    ToaDo.HienThi(new Point(P1.X, P1.Y),g);
                    P1.X+=5;
                }
            }
            return;
        }
        #endregion
        #region Vẽ đường tròn 
        public static void Drawn8Point(int x0, int y0, int x, int y, Graphics g)
        {
            ToaDo.HienThi(x + x0, y + y0, g);
            ToaDo.HienThi(y + x0, x + y0, g);
            ToaDo.HienThi(-x + x0, -y + y0,g);
            ToaDo.HienThi(-y + x0, -x + y0, g);
            ToaDo.HienThi(-x + x0, y + y0, g);
            ToaDo.HienThi(-y + x0, x + y0,g);
            ToaDo.HienThi(x + x0, -y + y0, g);
            ToaDo.HienThi(y + x0, -x + y0, g); ;
        }
        public static void Circle(int x0,int y0, int R, Graphics g)
        {
            //p = ToaDo.RoundPixel(p);
            int x = 0,
                y = R,
                p = 3 - 2 * R;
            while (x <= y)
            {
                if (p < 0)
                    p = p + 4 * x - 6;
                else
                {
                    y-=5;
                    p = p + 4 * (x - y) + 10;
                }
                Drawn8Point(x0, y0, x,y,g);
                x+=5;
            }
        }
        #endregion
        #region Vẽ hình chữ nhật
        public static void HinhChuNhat(Point p1,Point p2, Graphics g)
        {
            Line(p1,new Point(p2.X, p1.Y), g);
            Line(new Point(p2.X, p1.Y), new Point(p2.X, p2.Y), g);
            Line(new Point(p2.X, p2.Y), new Point(p1.X, p2.Y), g);
            Line(new Point(p1.X, p2.Y), p1, g);
        }
        #endregion
        #region Vẽ Elip
        public static void Drawn4Point(int x,int y, int xc, int yc, Graphics g)
        {
            ToaDo.HienThi(xc + x, yc + y, g);
            ToaDo.HienThi(xc - x, yc + y, g);
            ToaDo.HienThi(xc - x, yc - y, g);
            ToaDo.HienThi(xc + x, yc - y, g);
        }
        public static void Elipse(int x_center,int y_center, int a, int b, Graphics g)
        {
            double p, a2, b2;
            int x, y;
            a2 = Math.Pow(a, 2);
            b2 = Math.Pow(b, 2);
            x = 0;
            y = b;
            p = 2 * ((double)b2 / a2) - (2 * b) + 1;

            // Vẽ nhánh từ trên xuống
            while (((double)b2 / a2) * x <= y)
            {
                Drawn4Point(x, y, x_center, y_center, g);
                if (p < 0)
                    p = p + 2 * ((double)b2 / a2) * (2 * x + 3);
                else
                {
                    p = p - 4 * y + 2 * ((double)b2 / a2) * (2 * x + 3);
                    y-=5;
                }
                x+=5;
            }
            // Vẽ nhánh từ dưới lên
            y = 0;
            x = a;
            p = 2 * ((double)a2 / b2) - 2 * a + 1;
            while (((double)a2 / b2) * y <= x)
            {
                Drawn4Point( x, y,x_center,y_center, g);
                if (p < 0)
                    p = p + 2 * ((double)a2 / b2) * (2 * y + 3);
                else
                {
                    p = p - 4 * x + 2 * ((double)a2 / b2) * (2 * y + 3);
                    x-=5;
                }
                y+=5;
            }
        }
        #endregion
    }
}
