using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KyThuatDoHoa_Nhom9.Construct.DefineType;

namespace KyThuatDoHoa_Nhom9.Construct._2DObject
{
    class HinhChuNhat : Shapes2DObject
    {
        private Point A { get; set; }
        private Point B { get; set; }
        public void Draw(Graphics g)
        {
            Line line;
            line = new Line(this.A, new Point(this.B.X,this.A.Y));
            line.Draw(g);
            line = new Line(new Point(this.B.X, this.A.Y), this.B);
            line.Draw(g);
            line = new Line( new Point(this.A.X, this.B.Y),this.B);
            line.Draw(g);
            line = new Line(this.A, new Point(this.A.X, this.B.Y));
            line.Draw(g);


        }
        public HinhChuNhat(Point start, Point end)
        {
            this.A = start;
            this.B = end;
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
