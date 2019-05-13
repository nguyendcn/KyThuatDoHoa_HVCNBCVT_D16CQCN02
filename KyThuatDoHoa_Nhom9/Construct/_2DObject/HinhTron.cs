using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KyThuatDoHoa_Nhom9.Construct.DefineType;

namespace KyThuatDoHoa_Nhom9.Construct._2DObject
{
    class HinhTron : Shapes2DObject
    {
        private Point point { get; set; }
        private int R { get; set; }
        public void Drawn8Point( int x,int y, Graphics g)
        {
            ToaDo.HienThi(x + point.X, y + point.Y, g);
            ToaDo.HienThi(y + point.X, x + point.Y, g);
            ToaDo.HienThi(-x + point.X, -y + point.Y, g);
            ToaDo.HienThi(-y + point.X, -x + point.Y, g);
            ToaDo.HienThi(-x + point.X, y + point.Y, g);
            ToaDo.HienThi(-y + point.X, x + point.Y, g);
            ToaDo.HienThi(x + point.X, -y + point.Y, g);
            ToaDo.HienThi(y + point.X, -x + point.Y, g); 
        }
        public HinhTron(Point point,int R)
        {
            this.point = point;
            this.R = R * 5;
        }
        public void Draw(Graphics g)
        {
            int x = 0,
             y = R,
             p = 3 - 2 * R;
            while (x <= y)
            {
                if (p < 0)
                    p = p + 4 * x - 6;
                else
                {
                    y -= 5;
                    p = p + 4 * (x - y) + 10;
                }
                Drawn8Point( x, y, g);
                x += 5;
            }
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
