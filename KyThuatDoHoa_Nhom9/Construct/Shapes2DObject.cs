using KyThuatDoHoa_Nhom9.Construct.DefineType;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyThuatDoHoa_Nhom9.Construct
{
    public interface Shapes2DObject
    {
        /// <summary>
        /// Initialize object.
        /// </summary>
        void Init();

        /// <summary>
        /// Drawing Object in Graphic.
        /// </summary>
        /// <param name="g">Graphic will be display.</param>
        void Draw(Graphics g);

        /// <summary>
        /// Rotate object.
        /// </summary>
        /// <param name="p">Something point. Object will be rotate around.</param>
        /// <param name="dir">Direction of object will be rotate in next time.</param>
        void Rotate(Point p, Direction dir);

        /// <summary>
        /// Shifting object.
        /// </summary>
        /// <param name="dir">Direction of object in the next time.</param>
        void Shifting(Direction dir);

        /// <summary>
        /// Symmetry object.
        /// </summary>
        void Symmetry();

        /// <summary>
        /// Scale object.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        void Scale(Point start, Point end);

    }
}
