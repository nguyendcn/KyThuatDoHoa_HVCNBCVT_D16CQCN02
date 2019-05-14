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
        public static Point MayTinhNguoiDung(int x, int y)
        {
            x = LuoiPixel(x) / 5;
            y = LuoiPixel(y) / 5;

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
        public static int LuoiPixel(double p)
        {
            int n;
            
            double d = p % 5;
            if (d >= 3)
                return (int)(p - d + 5);
           
            return (int)(p - d);
        }

        /// <summary>
        /// Chuyển tọa độ người dùng về tọa độ máy tính * Hoãn
        /// </summary>
        public static PointNguoiDungMayTinh(int x, int y)
        {
            //if (x > 0)
            //{
            //    x = (x + Variables.Globals.widthPanel/2) * 5;
            //}
            //else
            //{ 
            //    x = (Variables.Globals.widthPanel / 2 - x) * 5;
            //}
               
            //return new Point(x, Variables.Globals.heightPanel - 5 * y);
        }
    }
}
