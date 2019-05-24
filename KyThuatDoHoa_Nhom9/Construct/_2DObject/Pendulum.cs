using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KyThuatDoHoa_Nhom9.Construct.DefineType;

namespace KyThuatDoHoa_Nhom9.Construct._2DObject
{
    public class Pendulum : Shapes2DObject, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int alpha;
        private HinhTron circle;
        private Line rope;
        private HinhChuNhat rectangle;
        private bool nextStep;
        private Timer timer = new Timer { Interval = 90 };
        private Point mainLocation;

        public int Alpha { get => alpha; set => alpha = value; }
        public Line Rope { get => rope; set => rope = value; }
        public HinhTron Circle { get => circle; set => circle = value; }
        public HinhChuNhat Rectangle { get => rectangle; set => rectangle = value; }

        public bool NextStep { get => nextStep;
            set
            {
                this.nextStep = value;
                OnPropertyChanged("nextStep");
            }
        }

        public Point MainLocation { get => mainLocation;
            set
            {
                if(value != this.mainLocation)
                {
                    ChangeAllObject(value);
                    this.mainLocation = value;
                }
            }
        }

        protected void OnPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }

        public Pendulum(Point point1, Point point2)
        {
            point1 = ToaDo.RoundPixel(point1);
            point2 = ToaDo.RoundPixel(point2);

            int x = (point1.X + point2.X) / 2,
                y = (point1.Y + point2.Y) / 2;
            
            this.Alpha = -5;
            this.mainLocation = point1;
            this.Rectangle = new HinhChuNhat(point1, point2);
            this.Rope = new Line(new Point(x, point1.Y), new Point(x, y + (point2.Y - y) / 2+1),Color.Black);
            this.Circle = new HinhTron(new Point(x, y + (point2.Y - y) / 2 + (point2.Y - y) / 4), (point2.Y - y ) / (4 * 5) - 1);

            this.timer.Tick += Timer_Tick;
            this.timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.NextStep = true;
        }

        private void ChangeAllObject(Point p)
        {
            int dx =p.X - this.mainLocation.X,
                dy =p.Y - this.mainLocation.Y;
            this.Rectangle.Shifting(dx, dy);
            this.Rope.Shifting(dx, dy);
            this.Circle.Shifting(dx, dy);
        }

        public void Draw(Graphics g)
        {
            this.Rectangle.Draw(g);

            this.Rope.B = this.Rope.B.RotateAt(this.Rope.A, Alpha);
            this.Circle.Point = this.Circle.Point.RotateAt( this.Rope.A, Alpha);
            if (!check())
            {
                this.Alpha = -this.Alpha;

                this.Rope.B = this.Rope.B.RotateAt(this.Rope.A, Alpha);
                this.Circle.Point = this.Circle.Point.RotateAt(this.Rope.A, Alpha);

                this.Rope.B = this.Rope.B.RotateAt(this.Rope.A, Alpha);
                this.Circle.Point = this.Circle.Point.RotateAt(this.Rope.A, Alpha);
            }

            this.Rope.Draw(g);
            this.Circle.Draw(g);

        }
        public bool check()
        {
            int d1 = this.Rectangle.C.X - this.Circle.Point.X,
                d2 = this.Circle.Point.X - this.Rectangle.A.X;
            if (this.Circle.Radius >= d1 || this.Circle.Radius >= d2)
                return false;
            return true;
        }
        /// <summary>
        /// sset giá trị của góc quay alpha
        /// </summary>
        public void SetAlpha(int n)
        {
            this.Alpha = n;
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
