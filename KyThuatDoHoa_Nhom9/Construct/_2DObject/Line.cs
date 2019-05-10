/* Line 
    A._____________.B
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
    public class Line : Shapes2DObject
    {
        private Point _a, _b;
        private Size sizeOfLine;
        private Color colorOfLine;
        private float angle = 0;

        public Point A { get => _a; set => _a = value; }
        public Point B { get => _b; set => _b = value; }
        public Size SizeOfLine { get => sizeOfLine; set => sizeOfLine = value; }
        public Color ColorOfLine { get => colorOfLine; set => colorOfLine = value; }

        /// <summary>
        /// Constructor of Line.
        /// </summary>
        /// <param name="a">Point A or meant point start.</param>
        /// <param name="b">Point B or meant point end.</param>                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               
        /// <param name="color">Color of line.</param>
        public Line(Point a, Point b, Size sizeOfLine, Color color)
        {
            this.A = a;
            this.B = b;
            this.SizeOfLine = sizeOfLine;
            this.ColorOfLine = color;
        }


        public void setAngle(float angle)
        {
            if (angle > 360)
            {
                angle -= 360;
            }
            this.angle = angle;
        }


        public void Draw(Graphics g)
        {
            int Dx = B.X - A.X;
            int Dy = B.Y - A.Y;
            int count = Math.Max(Math.Abs(Dx), Math.Abs(Dy)); // Lấy số bước vẽ dài nhất
            float delta_X, delta_Y, m, n;
            if (count > 0)
            {
                delta_X = (int)Dx;
                delta_X /= count;
                delta_Y = (int)Dy;
                delta_Y /= count;

                m = A.X;
                n = A.Y;
                while (count-- != 0)
                {
                    g.FillRectangle(new SolidBrush(this.ColorOfLine), new RectangleF(m, n, this.SizeOfLine.Height, this.SizeOfLine.Width));
                    m += delta_X;
                    n += delta_Y;
                }
            }
        }

        public void Init(Point start, Point end, Size sizeOFLine, Color color)
        {
            this.A = (start);
            this.B = (end);
            this.ColorOfLine = (color);
        }


        //public bool impact(Point p)
        //{
        //    int AB = (int)Math.sqrt(Math.pow((A.x - B.x), 2) + Math.pow(A.y - B.y, 2));
        //    int AP = (int)Math.sqrt(Math.pow((A.x - p.x), 2) + Math.pow(A.y - p.y, 2));
        //    int PB = (int)Math.sqrt(Math.pow((p.x - B.x), 2) + Math.pow(p.y - B.y, 2));
        //    return (((AP + PB) - AB) < size);
        //}


        //public void move(Point start, Point end)
        //{
        //    int dx = end.x - start.x;
        //    int dy = end.y - start.y;
        //    this.setA(new Point(this.getA().x + dx, this.getA().y + dy));
        //    this.setB(new Point(this.getB().x + dx, this.getB().y + dy));
        //}


        public void Rotate(Point a, Direction b)
        {
            //float a = Display.angleBetweenTwoLines(start, end);
            //Point p1 = new Point(Display.rotateAround(this.getA(), a));
            //Point p2 = new Point(Display.rotateAround(this.getB(), a));
            //setA(p1);
            //setB(p2);
            //this.setAngle(this.getAngle() + a);
        }


        public void Scale(Point start, Point end)
        {
            //double AP = Math.sqrt(Math.pow((this.getA().x - start.x), 2) + Math.pow(this.getA().y - start.y, 2));
            //double PB = Math.sqrt(Math.pow((start.x - this.getB().x), 2) + Math.pow(start.y - this.getB().y, 2));
            //if (AP < PB)
            //{
            //    this.setA(this.getB());
            //    this.setB(end);
            //}
            //else
            //{
            //    this.setA(this.getA());
            //    this.setB(end);
            //}
        }

        public void Shifting(Direction dir)
        {

        }

        public void Symmetry()
        {

        }

        
    }
}
