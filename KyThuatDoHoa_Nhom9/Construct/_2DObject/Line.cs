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
        private Color color;
        private float angle = 0;

        public Point A { get => _a; set => _a = value; }
        public Point B { get => _b; set => _b = value; }
        public Size SizeOfLine { get => sizeOfLine; set => sizeOfLine = value; }
        public Color ColorOfLine { get => color; set => color = value; }

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
        public Line(Point a, Point b)
        {
            this.A = a;
            this.B = b;
            this.ColorOfLine = Color.Black;
        }
        public Line(Point a, Point b, Color color)
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

        public void SwapPoint()
        {
            Point p = this.A;
            this.A = this.B;
            this.B = p;
        }
        /// <summary>
        ///  Vẽ đường thẳng dạng nét đứt
        /// </summary>
        public void NetDut(Graphics g)
        {
            // Làm tròn tạo độ trên Lưới Pixel
            this.A = ToaDo.RoundPixel(this.A);
            this.B = ToaDo.RoundPixel(this.B);

            int Dx = this.B.X - this.A.X,
                Dy = this.B.Y - this.A.Y,
                x = this.A.X,
                y = this.A.Y,
                p;
            // Trùng Ox
            if (this.A.X == this.B.X)
            {
                if (this.A.Y > this.B.Y)
                    SwapPoint();
                y = this.A.Y;
                ToaDo.HienThi(new Point(x, y), g, this.ColorOfLine);
                while (y < this.B.Y)
                {
                    y += 5;
                    if (y % 10 == 0)
                        continue;
                    ToaDo.HienThi(new Point(this.A.X, y), g, this.ColorOfLine);
                }
                return;
            }
            // Trùng Oy
            if (this.A.Y == this.B.Y)
            {
                if (this.A.X > this.B.X)
                    SwapPoint();
                x = this.A.X;
                ToaDo.HienThi(new Point(x, y), g, this.ColorOfLine);
                while (x < this.B.X)
                {
                    x += 5;
                    if (x % 10 == 0)
                        continue;
                    ToaDo.HienThi(new Point(x, this.A.Y), g, this.ColorOfLine);
                }
                return;
            }
            float m = (float)Dy / Dx;
            if (m > 0 && m <= 1)
            {
                if (this.A.X > this.B.X)
                {
                    SwapPoint();
                    Dx = this.B.X - this.A.X;
                    Dy = this.B.Y - this.A.Y;
                    x = this.A.X;
                    y = this.A.Y;
                }
                p = 2 * Dy - Dx;
                ToaDo.HienThi(new Point(x, y), g, this.ColorOfLine);
                while (x < this.B.X)
                {
                    x += 5;
                    if (p < 0)
                        p = p + 2 * Dy;
                    else
                    {
                        p = p + 2 * (Dy - Dx);
                        y += 5;
                    }
                    if (x % 10 == 0)
                        continue;
                    ToaDo.HienThi(new Point(x, y), g,this.ColorOfLine);
                }
                return;
            }
            if (m >= -1 && m < 0)
            {
                if (this.A.X > this.B.X)
                {
                    SwapPoint();
                    Dx = this.B.X - this.A.X;
                    Dy = this.B.Y - this.A.Y;
                    x = this.A.X;
                    y = this.A.Y;
                }
                p = 2 * Dy + Dx;
                ToaDo.HienThi(new Point(x, y), g, this.ColorOfLine);
                while (x < this.B.X)
                {
                    x += 5;
                    if (p < 0)
                    {
                        y -= 5;
                        p = p + 2 * (Dx + Dy);
                    }
                    else
                        p = p + 2 * Dy;
                    if (x % 10 == 0)
                        continue;
                    ToaDo.HienThi(new Point(x, y), g, this.ColorOfLine);
                }
                return;
            }
            if (m > 1)
            {
                if (this.A.Y > this.B.Y)
                {
                    SwapPoint();
                    Dx = this.B.X - this.A.X;
                    Dy = this.B.Y - this.A.Y;
                    x = this.A.X;
                    y = this.A.Y;
                }
                p = 2 * Dx - Dy;
                ToaDo.HienThi(new Point(x, y), g, this.ColorOfLine);
                while (y < this.B.Y)
                {
                    y += 5;
                    if (p < 0)
                        p = p + 2 * Dx;
                    else
                    {
                        x += 5;
                        p = p + 2 * (Dx - Dy);
                    }
                    if (y % 10 == 0)
                        continue;
                    ToaDo.HienThi(new Point(x, y), g, this.ColorOfLine);
                }
                return;
            }
            if (m < -1)
            {
                if (this.A.Y > this.B.Y)
                {
                    SwapPoint();
                    Dx = this.B.X - this.A.X;
                    Dy = this.B.Y - this.A.Y;
                    x = this.A.X;
                    y = this.A.Y;
                }
                p = 2 * Dx + Dy;
                ToaDo.HienThi(new Point(x, y), g, this.ColorOfLine);
                while (y < this.B.Y)
                {
                    y += 5;
                    if (p < 0)
                    {
                        x -= 5;
                        p = p + 2 * (Dx + Dy);
                    }
                    else
                        p = p + 2 * Dx;
                    if (y % 10 == 0)
                        continue;
                    ToaDo.HienThi(new Point(x, y), g, this.ColorOfLine);
                }
                return;
            }
        }

        /// <summary>
        /// Vẽ đường thẳng lên hệ tọa độ
        /// </summary>
        public void Draw(Graphics g)
        {
            // Làm tròn tạo độ trên Lưới Pixel
            this.A = ToaDo.RoundPixel(this.A);
            this.B = ToaDo.RoundPixel(this.B);

            int Dx = this.B.X - this.A.X,
                Dy = this.B.Y - this.A.Y,
                x = this.A.X,
                y = this.A.Y,
                p;
            // Trùng Ox
            if (this.A.X == this.B.X)
            {
                if (this.A.Y > this.B.Y)
                    SwapPoint();
                y = this.A.Y;
                while (y <= this.B.Y)
                {
                    ToaDo.HienThi(new Point(this.A.X, y), g, ColorOfLine);
                    y += 5;
                }
                return;
            }
            // Trùng Oy
            if (this.A.Y == this.B.Y)
            {
                if (this.A.X > this.B.X)
                    SwapPoint();
                x = this.A.X;
                while (x <= this.B.X)
                {
                    ToaDo.HienThi(new Point(x, this.A.Y), g, ColorOfLine);
                    x += 5;
                }
                return;
            }
            float m = (float)Dy / Dx;
            if (m > 0 && m <= 1)
            {
                if (this.A.X > this.B.X)
                {
                    SwapPoint();
                    Dx = this.B.X - this.A.X;
                    Dy = this.B.Y - this.A.Y;
                    x = this.A.X;
                    y = this.A.Y;
                }
                p = 2 * Dy - Dx;
                while (x <= this.B.X)
                {
                    ToaDo.HienThi(new Point(x, y), g, ColorOfLine);
                    x += 5;
                    if (p < 0)
                        p = p + 2 * Dy;
                    else
                    {
                        p = p + 2 * (Dy - Dx);
                        y += 5;
                    }
                }
                return;
            }
            if (m >= -1 && m < 0)
            {
                if (this.A.X > this.B.X)
                {
                    SwapPoint();
                    Dx = this.B.X - this.A.X;
                    Dy = this.B.Y - this.A.Y;
                    x = this.A.X;
                    y = this.A.Y;
                }
                p = 2 * Dy + Dx;
                while (x <= this.B.X)
                {
                    ToaDo.HienThi(new Point(x, y), g, ColorOfLine);
                    x += 5;
                    if (p < 0)
                    {
                        y -= 5;
                        p = p + 2 * (Dx + Dy);
                    }
                    else
                        p = p + 2 * Dy;
                }
                return;
            }
            if (m > 1)
            {
                if (this.A.Y > this.B.Y)
                {
                    SwapPoint();
                    Dx = this.B.X - this.A.X;
                    Dy = this.B.Y - this.A.Y;
                    x = this.A.X;
                    y = this.A.Y;
                }
                p = 2 * Dx - Dy;
                while (y <= this.B.Y)
                {
                    ToaDo.HienThi(new Point(x, y), g, ColorOfLine);
                    y += 5;
                    if (p < 0)
                        p = p + 2 * Dx;
                    else
                    {
                        x += 5;
                        p = p + 2 * (Dx - Dy);
                    }
                }
                return;
            }
            if (m < -1)
            {
                if (this.A.Y > this.B.Y)
                {
                    SwapPoint();
                    Dx = this.B.X - this.A.X;
                    Dy = this.B.Y - this.A.Y;
                    x = this.A.X;
                    y = this.A.Y;
                }
                p = 2 * Dx + Dy;
                while (y <= this.B.Y)
                {
                    ToaDo.HienThi(new Point(x, y), g, ColorOfLine);
                    y += 5;
                    if (p < 0)
                    {
                        x -= 5;
                        p = p + 2 * (Dx + Dy);
                    }
                    else
                        p = p + 2 * Dx;
                }
                return;
            }
        }

        public void Init(Point start, Point end, Size sizeOFLine, Color color)
        {
            this.A = (start);
            this.B = (end);
            this.ColorOfLine = (color);
        }

        /// <summary>
        /// Rotate line. Applies a clockwise rotation.
        /// </summary>
        /// <param name="p"></param>
        /// <param name="alpha"></param>
        public void Rotate(Point p, double alpha)
        {
            this.A = this.A.RotateAt(p, (int)alpha);
            this.B = this.B.RotateAt(p, (int)alpha);
        }

        public void Shifting(int dx, int dy)
        {
            this.A = this.A.Translate(dx, dy);
            this.B = this.B.Translate(dx, dy);
        }

        public void Symmetry(Point orgin, SymmetryMode mode)
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
    }
}
