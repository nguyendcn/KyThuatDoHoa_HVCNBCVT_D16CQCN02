using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KyThuatDoHoa_Nhom9.Construct.DefineType;

namespace KyThuatDoHoa_Nhom9.Construct._2DObject
{
    public class HinhChuNhat : Shapes2DObject
    {
        private Point _a;
        private Point _b;
        private Point _c;
        private Point _d;
        private Color color;

        public Point A { get => _a; set => _a = value; }
        public Point B { get => _b; set => _b = value; }
        public Point C { get => _c; set => _c = value; }
        public Point D { get => _d; set => _d = value; }

        public void Draw(Graphics g)
        {
            //Line line;
            //line = new Line(this.A, new Point(this.B.X,this.A.Y));
            //line.Draw(g);
            //line = new Line(new Point(this.B.X, this.A.Y), this.B);
            //line.Draw(g);
            //line = new Line( new Point(this.A.X, this.B.Y),this.B);
            //line.Draw(g);
            //line = new Line(this.A, new Point(this.A.X, this.B.Y));
            //line.Draw(g);

            FillColor(g, Color.Red);
            Line line;
            line = new Line(this.A, this.B);
            line.Draw(g);
            line = new Line(this.B, this.C);
            line.Draw(g);
            line = new Line(this.D, this.C);
            line.Draw(g);
            line = new Line(this.A, this.D);
            line.Draw(g);
            


        }

        public void Draw(Graphics g, Color c)
        {
            FillColor(g, c);
            Line line;
            line = new Line(this.A, this.B);
            line.Draw(g);
            line = new Line(this.B, this.C);
            line.Draw(g);
            line = new Line(this.D, this.C);
            line.Draw(g);
            line = new Line(this.A, this.D);
            line.Draw(g);
        }

        private void FillColor(Graphics g, Color c)
        {
            Point[] curvePoints = { this.A, this.B, this.C, this.D };
            g.FillPolygon(new SolidBrush(c), curvePoints);
        }

        public HinhChuNhat(Point start, Point end)
        {
            this.A = start;
            this.B = new Point(end.X, start.Y);
            this.C = end;
            this.D = new Point(start.X, end.Y);
            this.color = Color.Black;
        }
        public HinhChuNhat(Point start, Point end, Color color)
        {
            this.A = start;
            this.B = new Point(end.X, start.Y);
            this.C = end;
            this.D = new Point(start.X, end.Y);
            this.color = color;
        }

        public void Init(Point start, Point end, Size sizeOfLine, Color color)
        {
            throw new NotImplementedException();
        }

        public void Rotate(Point p, double alpha)
        {
            this.A = this.A.RotateAt(p, (int)alpha);
            this.B = this.B.RotateAt(p, (int)alpha);
            this.C = this.C.RotateAt(p, (int)alpha);
            this.D = this.D.RotateAt(p, (int)alpha);

        }
        public void Scale(SizeF scaleSize)
        {
            this.A = this.A.Scale(scaleSize.Width);
            this.B = this.B.Scale(scaleSize.Width);
            this.C = this.C.Scale(scaleSize.Width);
            this.D = this.D.Scale(scaleSize.Width);

        }

        public void Shifting(int dx, int dy)
        {
            this.A = this.A.Translate(dx, dy);
            this.B = this.B.Translate(dx, dy);
            this.C = this.C.Translate(dx, dy);
            this.D = this.D.Translate(dx, dy);
        }

        public void Symmetry(Point orgin, SymmetryMode mode)
        {
            throw new NotImplementedException();
        }

        public void Shifting(Point pDest)
        {
            throw new NotImplementedException();
        }
    }
}
