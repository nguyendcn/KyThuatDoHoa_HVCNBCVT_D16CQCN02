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
    public class Timepiece : Shapes2DObject, INotifyPropertyChanged
    {
        private Point location;
        private DateTime time;
        private Clock clock;
        private Pendulum pendulum;
        private bool displayNow;

        public Point Location { get => location;
            set
            {
                if(value != this.location)
                {
                    this.location = value;
                    OnPropertyChanged("location");
                }
            }
        }
        public DateTime Time { get => time; set => time = value; }
        public bool DisplayNow { get => displayNow; set => displayNow = value; }

        public event PropertyChangedEventHandler PropertyChanged;



        public Timepiece()
        {
            Setup();
            this.Location = new Point(0, 0);
            this.Time = DateTime.Now;
            if(this.clock != null && this.pendulum != null)
            {
                this.clock.PropertyChanged += Clock_PropertyChanged;
                this.pendulum.PropertyChanged += Pendulum_PropertyChanged;
            }
        }

        public Timepiece(DateTime time, Point location)
        {
            Setup(time, location);
            this.Location = location;
            this.Time = time;

            if (this.clock != null && this.pendulum != null)
            {
                this.clock.PropertyChanged += Clock_PropertyChanged;
                this.pendulum.PropertyChanged += Pendulum_PropertyChanged;
            }
        }

        private void Pendulum_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if(e.PropertyName.Equals("nextStep"))
                this.DisplayNow = true;
        }

        private void Clock_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if(e.PropertyName.Equals("currentDatetime"))
                this.DisplayNow = true;
        }

        protected void OnPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }

        public void Draw(Graphics g)
        {
            this.clock.Draw(g);
            this.pendulum.Draw(g);
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

        private void Setup()
        {
            if(this.clock == null)
            {
                this.clock = new Clock(new Point(this.Location.X + 20, this.Location.Y + 10), 15, DateTime.Now);
            }
            if(this.pendulum == null)
            {
                this.pendulum = new Pendulum(ToaDo.NguoiDungMayTinh(new Point(this.Location.X + 1, this.Location.Y - 6)), ToaDo.NguoiDungMayTinh(new Point(this.Location.X + 40, this.Location.Y + -60)));
            }
        }

        private void Setup(DateTime time, Point p)
        {
            if (this.clock == null)
            {
                this.clock = new Clock(ToaDo.NguoiDungMayTinh(new Point(p.X + 30, p.Y + 5)), 15, time);
            }
            if (this.pendulum == null)
            {
                this.pendulum = new Pendulum(ToaDo.NguoiDungMayTinh(new Point(p.X + 10, p.Y - 13)), ToaDo.NguoiDungMayTinh(new Point(p.X + 50, p.Y + -60)));
            }
        }

        private void ChangeObject(Point p)
        {
            //this.clock.A = new Point(p.X + 100, p.Y + 50);
            //this.pendulum.Rectangle
        }
    }
}
