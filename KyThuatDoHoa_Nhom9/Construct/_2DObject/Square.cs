/* This Square like that:
    A___________B
    |           |
    |           |
    |           |
   D|___________|C
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
    public class Square : Shapes2DObject
    {
        /// <summary>
        /// Size of the pen draw. 
        /// </summary>
        private Size sizeOfPen;

        /// <summary>
        /// Color of pen.
        /// </summary>
        private Color colorOfPen;

        /// <summary>
        /// One  of four top of Square
        /// </summary>
        private Point _a, _b, _c, _d;

        /// <summary>
        /// Get or set point A of square.
        /// </summary>
        public Point A { get => _a; set => _a = value; }

        /// <summary>
        /// Get or set point B of square.
        /// </summary>
        public Point B { get => _b; set => _b = value; }

        /// <summary>
        /// Get or set point C of square.
        /// </summary>
        public Point C { get => _c; set => _c = value; }

        /// <summary>
        /// Get or set point D of square.
        /// </summary>
        public Point D { get => _d; set => _d = value; }

        /// <summary>
        /// Get or set Color Pen
        /// </summary>
        public Color ColorOfPen { get => colorOfPen; set => colorOfPen = value; }

        /// <summary>
        /// Get or Set size of the pen.
        /// </summary>
        public Size SizeOfPen { get => sizeOfPen; set => sizeOfPen = value; }

        /// <summary>
        /// Constructor for square with four params.
        /// </summary>
        /// <param name="a">Point A</param>
        /// <param name="b">Point B</param>
        /// <param name="c">Point C</param>
        /// <param name="d">Point D</param>
        public Square(Point a, Point b, Point c, Point d, Size sizeOfPen, Color colorOfPen)
        {
            this.A = a;
            this.B = b;
            this.C = c;
            this.D = d;
            this.ColorOfPen = colorOfPen;
            this.SizeOfPen = sizeOfPen;
        }


        /// <summary>
        /// 
        /// </summary>
        public void Init(Point start, Point end, Size sizeOfPen, Color colorofPen)
        {
            int shortEdge; // Cạnh lấy theo cạnh ngắn của HCN

            this.A = start;
            if ((start.X <= end.X) && (start.Y < end.Y))
            { // góc Đông Nam
                shortEdge = Math.Min(end.X - start.X, end.Y - start.Y);
                this.C = (new Point(shortEdge + start.X, shortEdge + start.Y));
            }
            else if ((start.X > end.X) && (start.Y <= end.Y))
            { // góc Tây Nam
                shortEdge = Math.Min(start.X - end.X, end.Y - start.Y);
                this.C = (new Point(start.X - shortEdge, start.Y + shortEdge));
            }
            else if ((start.X >= end.X) && (start.Y > end.Y))
            { // góc Tây Bắc
                shortEdge = Math.Min(start.X - end.X, start.Y - end.Y);
                this.C = (new Point(start.X - shortEdge, start.Y - shortEdge));
            }
            else if ((start.X < end.X) && (start.Y >= end.Y))
            { // góc Đông Bắc
                shortEdge = Math.Min(end.X - start.X, start.Y - end.Y);
                this.C = (new Point(start.X + shortEdge, start.Y - shortEdge));
            }

            this.B = (new Point(this.C.X, start.Y));
            this.D = (new Point(start.X, this.C.Y));

            this.SizeOfPen = sizeOfPen;
            this.ColorOfPen = colorOfPen;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="g"></param>
        public void Draw(System.Drawing.Graphics g)
        {
            Line line;
            //		 Nếu size pixel == 1 thì dùng hàm của hệ thống để chạy nhanh hơn
            // Còn > 1 phải dùng hàm tự định nghĩa mới set được size pixel
            if (2 > 1)
            {
                //Draw line AB
                line = new Line(A, B, this.SizeOfPen, this.ColorOfPen);
                line.Draw(g);

                //Draw line BC
                line = new Line(B, C, this.SizeOfPen, this.ColorOfPen);
                line.Draw(g);

                //Draw line CD
                line = new Line(C, D, this.SizeOfPen, this.ColorOfPen);
                line.Draw(g);

                //Draw line DA
                line = new Line(D, A, this.SizeOfPen, this.ColorOfPen);
                line.Draw(g);
            }
            else
            {
                Pen p = new Pen(this.ColorOfPen);
                g.DrawLine(p, A.X, A.Y, B.X, B.Y);
                g.DrawLine(p, B.X, B.Y, C.X, C.Y);
                g.DrawLine(p, C.X, C.Y, D.X, D.Y);
                g.DrawLine(p, D.X, D.Y, A.X, A.Y);
            }
        }

        /// <summary>
        /// Rotate object.
        /// </summary>
        /// <param name="p">Something point. Object will be rotate around.</param>
        /// <param name="dir">Direction of object will be rotate in next time.</param>
        public void Rotate(Point p, Direction dir)
        {

        }

        /// <summary>
        /// Shifting object.
        /// </summary>
        /// <param name="dir">Direction of object in the next time.</param>
        public void Shifting(Direction dir)
        {

        }

        /// <summary>
        /// Symmetry object.
        /// </summary>
        public void Symmetry()
        {

        }

        /// <summary>
        /// Scale object.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        public void Scale(Point start, Point end)
        {

        }
    }
}
