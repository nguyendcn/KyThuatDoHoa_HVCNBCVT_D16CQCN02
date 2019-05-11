/* Line 
    A._____________.B
 */

using KyThuatDoHoa_Nhom9.Construct.DefineType;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyThuatDoHoa_Nhom9.Construct._2DObject
{
    public class Line : Shapes2DObject
    {
        private Point _a, _b;
        private Size sizeOfLine;
        private Color colorOfLine;
        private float angle = 0;

        public Point A { get => _a; set => _a = value; }
        public Point B { get => _b; set => _b = value; }
        public Size SizeOfLine { get => sizeOfLine; set => sizeOfLine = value; }
        public Color ColorOfLine { get => colorOfLine; set => colorOfLine = value; }

        /// <summary>
        /// Constructor of Line.
        /// </summary>
        /// <param name="a">Point A or meant point start.</param>
        /// <param name="b">Point B or meant point end.</param>                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               
        /// <param name="color">Color of line.</param>
        public Line(Point a, Point b, Size sizeOfLine, Color color)
        {
            this.A = a;
            this.B = b;
            this.SizeOfLine = sizeOfLine;
            this.ColorOfLine = color;
        }


        public void setAngle(float angle)
        {
            if (angle > 360)
            {
                angle -= 360;
            }
            this.angle = angle;
        }


        public void Draw(Graphics g)
        {
            int Dx = B.X - A.X;
            int Dy = B.Y - A.Y;
            int count = Math.Max(Math.Abs(Dx), Math.Abs(Dy)); // Lấy số bước vẽ dài nhất
            float delta_X, delta_Y, m, n;
            if (count > 0)
            {
                delta_X = (int)Dx;
                delta_X /= count;
                delta_Y = (int)Dy;
                delta_Y /= count;

                m = A.X;
                n = A.Y;
                while (count-- != 0)
                {
                    g.FillRectangle(new SolidBrush(this.ColorOfLine), new RectangleF(m, n, this.SizeOfLine.Height, this.SizeOfLine.Width));
                    m += delta_X;
                    n += delta_Y;
                }
            }
        }

        public void Init(Point start, Point end, Size sizeOFLine, Color color)
        {
            this.A = (start);
            this.B = (end);
            this.ColorOfLine = (color);
        }

        public void Rotate(Point p, double alpha)
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

        public void Scale(SizeF scaleSize)
        {
            throw new NotImplementedException();
        }
    }
}
