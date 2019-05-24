using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KyThuatDoHoa_Nhom9.Construct.DefineType;

namespace KyThuatDoHoa_Nhom9.Construct._2DObject
{
    class HinhTamGiac : Shapes2DObject
    {
        private Point point1 { get; set; }
        private Point point2 { get; set; }
        private Point point3 { get; set; }
        public HinhTamGiac(Point point1, Point point2, Point point3)
        {
            this.point1 = point1;
            this.point2 = point2;
            this.point3 = point3;
        }
        public void Draw(Graphics g)
        {
            FillColor(g, Color.AliceBlue);
            Line line;
            line = new Line(this.point1, this.point2, Color.Black);
            line.Draw(g);
            line = new Line(this.point2, this.point3, Color.Black);
            line.Draw(g);
            line = new Line(this.point3, this.point1, Color.Black);
            line.Draw(g);
        }

        public void Draw(Graphics g, Color c)
        {
            FillColor(g, c);
            Line line;
            line = new Line(this.point1, this.point2);
            line.Draw(g);
            line = new Line(this.point2, this.point3);
            line.Draw(g);
            line = new Line(this.point3, this.point1);
            line.Draw(g);
        }

        private void FillColor(Graphics g, Color c)
        {
            
            Point[] curvePoints = { this.point1, this.point2, this.point3 };
            g.FillPolygon(new SolidBrush(c), curvePoints);
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
