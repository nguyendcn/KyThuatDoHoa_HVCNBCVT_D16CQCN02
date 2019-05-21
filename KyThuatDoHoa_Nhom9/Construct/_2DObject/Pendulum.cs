using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KyThuatDoHoa_Nhom9.Construct.DefineType;

namespace KyThuatDoHoa_Nhom9.Construct._2DObject
{
    class Pendulum : Shapes2DObject, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public int alpha { get; set; } // Góc quay alpha
        public HinhTron hinhTron { get; set; }
        public Line line { get; set; }
        public HinhChuNhat hinhNhat { get; set; }

        public Pendulum(Point point1, Point point2)
        {
            point1 = ToaDo.RoundPixel(point1);
            point2 = ToaDo.RoundPixel(point2);

            int x = (point1.X + point2.X) / 2,
                y = (point1.Y + point2.Y) / 2;

            this.alpha = -5;
            this.hinhNhat = new HinhChuNhat(point1, point2);
            this.line = new Line(new Point(x, point1.Y), new Point(x, y + (point2.Y - y) / 2+1));
            this.hinhTron = new HinhTron(new Point(x, y + (point2.Y - y) / 2 + (point2.Y - y) / 4), (point2.Y - y ) / (4 * 5) - 1);
        }
        public void Draw(Graphics g)
        {
            hinhNhat.Draw(g);

            this.line.B = this.line.B.RotateAt(this.line.A, alpha);
            this.hinhTron.Point = this.hinhTron.Point.RotateAt(this.line.A, alpha);
            if (!check())
            {
                this.alpha = -this.alpha;

                this.line.B = this.line.B.RotateAt(this.line.A, alpha);
                this.hinhTron.Point = this.hinhTron.Point.RotateAt(this.line.A, alpha);

                this.line.B = this.line.B.RotateAt(this.line.A, alpha);
                this.hinhTron.Point = this.hinhTron.Point.RotateAt(this.line.A, alpha);
            }

            line.Draw(g);
            hinhTron.Draw(g);

        }
        public bool check()
        {
            int d1 = this.hinhNhat.C.X - this.hinhTron.Point.X,
                d2 = this.hinhTron.Point.X - this.hinhNhat.A.X;
            if (this.hinhTron.Radius >= d1 || this.hinhTron.Radius >= d2)
                return false;
            return true;
        }
        /// <summary>
        /// sset giá trị của góc quay alpha
        /// </summary>
        public void SetAlpha(int n)
        {
            this.alpha = n;
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
