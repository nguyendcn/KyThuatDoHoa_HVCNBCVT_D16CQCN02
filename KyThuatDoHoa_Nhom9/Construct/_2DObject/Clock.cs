using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KyThuatDoHoa_Nhom9.Construct.DefineType;

namespace KyThuatDoHoa_Nhom9.Construct._2DObject
{
    public class Clock : Shapes2DObject, INotifyPropertyChanged
    {
        private Point _a;
        private int _r;
        private DateTime currentDatetime;

        Timer tm = new Timer
        {
            Interval = 1000
        };

        HinhTron ht;
        private Line hHours, hMinute, hSecond;

        /// <summary>
        /// Get or set current time of clock.
        /// </summary>
        public DateTime CurrentDatetime { get => currentDatetime;
            set
            {
                if (value != currentDatetime)//changed
                {
                    currentDatetime = value;
                    OnPropertyChanged("currentDatetime");
                }
            }
        }

        /// <summary>
        /// Get or set original point.
        /// </summary>
        public Point A { get => _a;
            set
            {
                if(value != _a)//changed
                {
                    _a = value;
                    OnPropertyChanged("_a");
                }
            }
        }

        /// <summary>
        /// Get or set the radius.
        /// </summary>
        public int R { get => _r;
            set
            {
                if(value != _r) //change
                {
                    _r = value;
                    OnPropertyChanged("_r");
                }
            }
        }

        public Line HHours { get => hHours;
            set
            {
                if (value != hHours)
                {
                    hHours = value;
                   //OnPropertyChanged("hHours");
                }
            }
        }
        public Line HMinute { get => hMinute;
            set
            {
                if (value != hMinute)
                {
                    hMinute = value;
                    //OnPropertyChanged("hMinute");
                }
            }
        }
        public Line HSecond { get => hSecond;
            set
            {
                if (value != hSecond)
                {
                    hSecond = value;
                    //OnPropertyChanged("hSecond");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public Clock()
        {
            this.R = 10;
            this.A = new Point{ X = 0, Y = 0};
            this.CurrentDatetime = DateTime.Now;
            SetupClockwise(this.CurrentDatetime);
            tm.Tick += Tm_Tick;
            tm.Start();
        }

        public Clock(Point p, int r, DateTime dt)
        {
            this.R = r;
            this.A = p;
            this.CurrentDatetime = dt;
            SetupClockwise(this.CurrentDatetime);
            tm.Tick += Tm_Tick;
            tm.Start();
        }

        private void Tm_Tick(object sender, EventArgs e)
        {
            this.CurrentDatetime = this.CurrentDatetime.Add(new TimeSpan(0, 0, 0, 1));
        }

        protected void OnPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
            {
                SetupClockwise(this.CurrentDatetime);
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }

        public void Draw(Graphics g)
        {
            if(ht == null)
                ht = new HinhTron(A, 11);
            ht.Draw(g, Color.Beige);
            hHours.Draw(g);
            hMinute.Draw(g);
            hSecond.Draw(g);
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


        private void SetupClockwise(DateTime dt)
        {
            ht = new HinhTron(ToaDo.NguoiDungMayTinh(A), R);
            HSecond = new Line(ToaDo.NguoiDungMayTinh(A), (msCoord(dt.Second, R * 5 - 10)),Color.Black);
            HMinute = new Line(ToaDo.NguoiDungMayTinh(A), (msCoord(dt.Minute, R * 5 - 20)), Color.Black);
            HHours = new Line (ToaDo.NguoiDungMayTinh(A), (hrCoord(dt.Hour, dt.Minute, R * 5 - 30)), Color.Black);
        }

        private Point msCoord(int val, int hlen)
        {
            Point p = new Point();
            val *= 6; // note: each minute and seconds make a 6 degree  
            if (val >= 0 && val <= 100)
            {
                p.X = ToaDo.NguoiDungMayTinh(A).X + (int)(hlen * Math.Sin(Math.PI * val / 180));
                p.Y = ToaDo.NguoiDungMayTinh(A).Y - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            else
            {
                p.X = ToaDo.NguoiDungMayTinh(A).X - (int)(hlen * -Math.Sin(Math.PI * val / 180));
                p.Y = ToaDo.NguoiDungMayTinh(A).Y - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            return p;
        }
        //coord for hour  
        private Point hrCoord(int hval, int mval, int hlen)
        {
            Point p = new Point();
            //each hour makes 60 degree with min making 0.5 degree  
            int val = (int)((hval * 30) + (mval * 0.5));
            if (val >= 0 && val <= 180)
            {
                p.X = ToaDo.NguoiDungMayTinh(A).X + (int)(hlen * Math.Sin(Math.PI * val / 180));
                p.Y = ToaDo.NguoiDungMayTinh(A).Y - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            else
            {
                p.X = ToaDo.NguoiDungMayTinh(A).X - (int)(hlen * -Math.Sin(Math.PI * val / 180));
                p.Y = ToaDo.NguoiDungMayTinh(A).Y - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            return p;

        }
    }
}
