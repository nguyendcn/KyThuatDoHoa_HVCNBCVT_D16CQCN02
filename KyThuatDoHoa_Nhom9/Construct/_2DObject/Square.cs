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
        /// Constructor for square with four params.
        /// </summary>
        /// <param name="a">Point A</param>
        /// <param name="b">Point B</param>
        /// <param name="c">Point C</param>
        /// <param name="d">Point D</param>
        public Square(Point a, Point b, Point c, Point d)
        {
            this.A = a;
            this.B = b;
            this.C = c;
            this.D = d;
        }


        /// <summary>
        /// 
        /// </summary>
        void Shapes2DObject.Init()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="g"></param>
        void Shapes2DObject.Draw(System.Drawing.Graphics g)
        {

        }
    }
}
