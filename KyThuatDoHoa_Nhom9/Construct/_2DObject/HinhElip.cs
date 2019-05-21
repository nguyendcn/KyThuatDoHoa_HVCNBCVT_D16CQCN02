using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KyThuatDoHoa_Nhom9.Construct.DefineType;

namespace KyThuatDoHoa_Nhom9.Construct._2DObject
{
    class HinhElip : Shapes2DObject
    {
        private Point point { get; set; }
        private int a { get; set; }
        private int b { get; set; }

        private Color color { get; set; }
        public void Drawn4Point(int x,int y,Graphics g)
        {
            ToaDo.HienThi(point.X + x, point.Y + y, g, color);
            ToaDo.HienThi(point.X - x, point.Y + y, g, color);
            ToaDo.HienThi(point.X - x, point.Y - y, g, color);
            ToaDo.HienThi(point.X + x, point.Y - y, g, color);
        }
        public void Draw(Graphics g)
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
                Drawn4Point(x, y, g);
                if (p < 0)
                    p = p + 2 * ((double)b2 / a2) * (2 * x + 3);
                else
                {
                    p = p - 4 * y + 2 * ((double)b2 / a2) * (2 * x + 3);
                    y -= 5;
                }
                x += 5;
            }
            // Vẽ nhánh từ dưới lên
            y = 0;
            x = a;
            p = 2 * ((double)a2 / b2) - 2 * a + 1;
            while (((double)a2 / b2) * y <= x)
            {
                Drawn4Point(x, y, g);
                if (p < 0)
                    p = p + 2 * ((double)a2 / b2) * (2 * y + 3);
                else
                {
                    p = p - 4 * x + 2 * ((double)a2 / b2) * (2 * y + 3);
                    x -= 5;
                }
                y += 5;
            }
        }
        public HinhElip(Point point,int a,int b)
        {
            this.point = point;
            this.a = a * 5;
            this.b = b * 5;
            this.color = Color.Black;
        }
        public void Init(Point start, Point end, Size sizeOfLine, Color color)
        {
            throw new NotImplementedException();
        }

        public void Rotate(Point p, double alpha)
        {
            throw new NotImplementedException();
        }

        public void Scale(SizeF scaleSize)
        {
            throw new NotImplementedException();
        }

        public void Shifting(Point pDest)
        {
            throw new NotImplementedException();
        }

        public void Symmetry(Point orgin, SymmetryMode mode)
        {
            throw new NotImplementedException();
        }
    }
}
