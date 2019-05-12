using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing; 

namespace KyThuatDoHoa_Nhom9
{
    public class ToaDo
    {
        /// <summary>
        /// Chuyển từ tọa độ máy tính về tọa độ người dùng
        /// </summary>
        public static Point MayTinhNguoiDung(Point p)
        {
            int x = p.X,
                y = p.Y;

            x = RoundPixel(x) / 5;
            y = RoundPixel(y) / 5;

            if (x > Variables.Globals.widthPanel / 2)
                x -= Variables.Globals.widthPanel / 2;
            else
                x = (Variables.Globals.widthPanel / 2 - x) * -1;

            if (y > Variables.Globals.heightPanel / 2)
                y = (Variables.Globals.heightPanel / 2 - y);
            else
                y = Variables.Globals.heightPanel / 2 - y;

            //return new Point(x / 5 - Variables.Globals.widthPanel, Variables.Globals.heightPanel - y / 5);
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
        public static Point RoundPixel(Point p)
        {

            int x = p.X % 5,
                y = p.Y % 5;
            if (x >= 3)
                x = p.X - x + 5;
            else
                x = p.X - x;
            if (y >= 3)
                y = p.Y - y + 5;
            else
                y = p.Y - y;
            return new Point(x,y);
        }

        /// <summary>
        /// Chuyển tọa độ người dùng về tọa độ máy tính 
        /// </summary>
        public static Point NguoiDungMayTinh(Point p)
        {
            int x = p.X,
                y = p.Y;

            if (x > 0)
            {
                x = (x + Variables.Globals.widthPanel / 2) * 5;
            }
            else
            {
                x = (Variables.Globals.widthPanel / 2 - Math.Abs(x)) * 5;
            }

            if (y > 0)
            {
                y = (Variables.Globals.heightPanel / 2 - y) * 5;
            }
            else
            {
                y = (Variables.Globals.heightPanel / 2 + Math.Abs(y)) * 5;
            }
            return new Point(x, y);
        }
        /// <summary>
        /// Hiển thị 1 điểm lên màn hình ( Theo tọa độ máy tính)
        /// </summary>
        /// <param name="p"></param>
        public static void HienThi(Point p, Graphics g)
        {
            int pointX = RoundPixel(p.X),
                pointY = RoundPixel(p.Y);
            Pen p1 = new Pen(Color.Green);
            SolidBrush b = new SolidBrush(Color.Green);

            g.DrawEllipse(p1, pointX, pointY, 2, 2);
            g.FillEllipse(b, pointX, pointY, 2, 2);
            g.DrawEllipse(p1, pointX - 2, pointY - 2, 2, 2);
            g.FillEllipse(b, pointX - 2, pointY - 2, 2, 2);
            g.DrawEllipse(p1, pointX, pointY - 2, 2, 2);
            g.FillEllipse(b, pointX, pointY - 2, 2, 2);
            g.DrawEllipse(p1, pointX - 2, pointY, 2, 2);
            g.FillEllipse(b, pointX - 2, pointY, 2, 2);
        }
        public static void HienThi(int x, int y, Graphics g)
        {
            Point p = new Point(x, y);
            int pointX = RoundPixel(p.X),
                pointY = RoundPixel(p.Y);
            Pen p1 = new Pen(Color.Green);
            SolidBrush b = new SolidBrush(Color.Green);

            g.DrawEllipse(p1, pointX, pointY, 2, 2);
            g.FillEllipse(b, pointX, pointY, 2, 2);
            g.DrawEllipse(p1, pointX - 2, pointY - 2, 2, 2);
            g.FillEllipse(b, pointX - 2, pointY - 2, 2, 2);
            g.DrawEllipse(p1, pointX, pointY - 2, 2, 2);
            g.FillEllipse(b, pointX, pointY - 2, 2, 2);
            g.DrawEllipse(p1, pointX - 2, pointY, 2, 2);
            g.FillEllipse(b, pointX - 2, pointY, 2, 2);
        }
    }
}
