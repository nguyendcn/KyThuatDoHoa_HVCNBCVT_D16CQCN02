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
        ///  Draw object in graphic.
        /// </summary>
        /// <param name="g"></param>
        public void Draw(System.Drawing.Graphics g)
        {
            Line line;
            if (this.SizeOfPen.Width > 1)
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
        public void Rotate(Point p, double alpha)
        {
            float[][] matrix_Trans = {
                new float[] { (float)Math.Cos(alpha), -(float)Math.Sin(alpha), (float)(((1 - Math.Cos(alpha)) *  p.X) + Math.Sin(alpha) * p.Y) },
                new float[] { (float)Math.Sin(alpha), (float)Math.Cos(alpha), (float)(-Math.Sin(alpha) * p.X  + ((1 - Math.Cos(alpha)) *  p.Y))},
                new float[] { 0, 0, 1 }
            };

            CalAndUpdateNewLoca(matrix_Trans);
        }

        /// <summary>
        /// Shifting object.
        /// </summary>
        /// <param name="dir">Direction of object in the next time.</param>
        public void Shifting(Point pDest)
        {
            int _trx = pDest.X - this.A.X;
            int _try = pDest.Y - this.A.Y;

            float[][] matrix_Trans = {
                new float[] { 1, 0, _trx },
                new float[] { 0, 1, _try },
                new float[] { 0, 0, 1 }
            };

            CalAndUpdateNewLoca(matrix_Trans);
        }

        /// <summary>
        /// Symmetry object.
        /// </summary>
        public void Symmetry(Point orgin, SymmetryMode mode)
        {
            if (mode == SymmetryMode.X_Coordinate)
            {
                float[][] matrix_Trans = {
                new float[] { 1, 0, 0 },
                new float[] { 0, -1, 0 },
                new float[] { 0, 0, 1 }
                };

                CalSymmetry(orgin, matrix_Trans, mode);
            }
            else if (mode == SymmetryMode.Y_Coordinate)
            {
                float[][] matrix_Trans = {
                new float[] { -1, 0, 0 },
                new float[] { 0, 1, 0 },
                new float[] { 0, 0, 1 }
                };

                CalSymmetry(orgin, matrix_Trans, mode);
            }
            else if (mode == SymmetryMode.O_TheOrigin)
            {
                float[][] matrix_Trans = {
                new float[] { -1, 0, 0 },
                new float[] { 0, -1, 0 },
                new float[] { 0, 0, 1 }
                };

                CalSymmetry(orgin, matrix_Trans, mode);
            }
            else
            {
                throw new Exception("The mode doesn't define.");
            }
        }

        /// <summary>
        /// Scale object.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        public void Scale(SizeF sizeScale)
        {
            float[][] matrix_Trans = {
                new float[] { sizeScale.Width, 0, 0 },
                new float[] { 0, sizeScale.Height, 0 },
                new float[] { 0, 0, 1 }
            };

            CalAndUpdateNewLoca(matrix_Trans);
        }

        private void CalAndUpdateNewLoca(float[][] matrix_Trans)
        {
            int[][] matrix_Point = {
                new int[] {this.A.X},
                new int[] {this.A.Y},
                new int[] {1},
             };

            

            int[][] newPoint = Matrixs.Multiply(matrix_Trans, matrix_Point);

            _a.X = newPoint[0][0];
            _a.Y = newPoint[1][0];

            matrix_Point[0][0] = this.B.X;
            matrix_Point[1][0] = this.B.Y;
            newPoint = Matrixs.Multiply(matrix_Trans, matrix_Point);
            _b.X = newPoint[0][0];
            _b.Y = newPoint[1][0];

            matrix_Point[0][0] = this.C.X;
            matrix_Point[1][0] = this.C.Y;
            newPoint = Matrixs.Multiply(matrix_Trans, matrix_Point);
            _c.X = newPoint[0][0];
            _c.Y = newPoint[1][0];

            matrix_Point[0][0] = this.D.X;
            matrix_Point[1][0] = this.D.Y;
            newPoint = Matrixs.Multiply(matrix_Trans, matrix_Point);
            _d.X = newPoint[0][0];
            _d.Y = newPoint[1][0];
        }

        private void CalSymmetry(Point orgin, float[][] matrix_Trans, SymmetryMode mode)
        {
            int[][] matrix_Point = {
                new int[] {this.A.X},
                new int[] {this.A.Y},
                new int[] {1},
             };
            int buffer = 0;
            int[][] newPoint = Matrixs.Multiply(matrix_Trans, matrix_Point);

            if (mode == SymmetryMode.X_Coordinate)
            {
                buffer = this.A.Y - orgin.Y;
                _a.X = newPoint[0][0];
                _a.Y = -(newPoint[1][0] + 2 * buffer);
            }
            else if (mode == SymmetryMode.Y_Coordinate)
            {
                buffer = this.A.X - orgin.X;
                _a.X = -(newPoint[0][0] + 2 * buffer);
                _a.Y = newPoint[1][0];
            }
            else if (mode == SymmetryMode.O_TheOrigin)
            {
                buffer = this.A.X - orgin.Y;
                _a.X = -(newPoint[0][0] + 2 * buffer);
                buffer = this.A.Y - orgin.Y;
                _a.Y = -(newPoint[1][0] + 2 * buffer);
            }

            matrix_Point[0][0] = this.B.X;
            matrix_Point[1][0] = this.B.Y;
            newPoint = Matrixs.Multiply(matrix_Trans, matrix_Point);

            if (mode == SymmetryMode.X_Coordinate)
            {
                buffer = this.B.Y - orgin.Y;
                _b.X = newPoint[0][0];
                _b.Y = -(newPoint[1][0] + 2 * buffer);
            }
            else if (mode == SymmetryMode.Y_Coordinate)
            {
                buffer = this.B.X - orgin.X;
                _b.X = -(newPoint[0][0] + 2 * buffer);
                _b.Y = newPoint[1][0];
            }
            else if (mode == SymmetryMode.O_TheOrigin)
            {
                buffer = this.B.X - orgin.Y;
                _b.X = -(newPoint[0][0] + 2 * buffer);
                buffer = this.B.Y - orgin.Y;
                _b.Y = -(newPoint[1][0] + 2 * buffer);
            }

            matrix_Point[0][0] = this.C.X;
            matrix_Point[1][0] = this.C.Y;
            newPoint = Matrixs.Multiply(matrix_Trans, matrix_Point);

            if (mode == SymmetryMode.X_Coordinate)
            {
                buffer = this.C.Y - orgin.Y;
                _c.X = newPoint[0][0];
                _c.Y = -(newPoint[1][0] + 2 * buffer);
            }
            else if (mode == SymmetryMode.Y_Coordinate)
            {
                buffer = this.C.X - orgin.X;
                _c.X = -(newPoint[0][0] + 2 * buffer);
                _c.Y = newPoint[1][0];
            }
            else if (mode == SymmetryMode.O_TheOrigin)
            {
                buffer = this.C.X - orgin.Y;
                _c.X = -(newPoint[0][0] + 2 * buffer);
                buffer = this.C.Y - orgin.Y;
                _c.Y = -(newPoint[1][0] + 2 * buffer);
            }

            matrix_Point[0][0] = this.D.X;
            matrix_Point[1][0] = this.D.Y;
            newPoint = Matrixs.Multiply(matrix_Trans, matrix_Point);

            if (mode == SymmetryMode.X_Coordinate)
            {
                buffer = this.D.Y - orgin.Y;
                _d.X = newPoint[0][0];
                _d.Y = -(newPoint[1][0] + 2 * buffer);
            }
            else if (mode == SymmetryMode.Y_Coordinate)
            {
                buffer = this.D.X - orgin.X;
                _d.X = -(newPoint[0][0] + 2 * buffer);
                _d.Y = newPoint[1][0];
            }
            else if (mode == SymmetryMode.O_TheOrigin)
            {
                buffer = this.D.X - orgin.Y;
                _d.X = -(newPoint[0][0] + 2 * buffer);
                buffer = this.D.Y - orgin.Y;
                _d.Y = -(newPoint[1][0] + 2 * buffer);
            }
        }
    }
}