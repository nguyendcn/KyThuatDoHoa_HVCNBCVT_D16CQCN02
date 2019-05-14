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
        void Init(Point start, Point end, Size sizeOfLine, Color color);

        /// <summary>
        /// Drawing Object in Graphic.
        /// </summary>
        /// <param name="g">Graphic will be display.</param>
        void Draw(Graphics g);

        /// <summary>
        /// Rotate object.
        /// </summary>
        /// <param name="p">Something point. Object will be rotate around.</param>
        /// <param name="alpha">Rotate around p an alpha angle.</param>
        void Rotate(Point p, double alpha);

        /// <summary>
        /// Shifting object.
        /// </summary>
        /// <param name="pDest">Translation from current point to destination point.</param>
        void Shifting(Point pDest);

        /// <summary>
        /// Symmetry object.
        /// </summary>
        /// <param name="orgin">O the orgin.</param>
        /// <param name="mode">Mode symmetry.</param>
        void Symmetry(Point orgin, SymmetryMode mode);

        /// <summary>
        /// Scale object.
        /// </summary>
        /// <param name="scaleSize">Sx and Sy are called scaling coefficients in the x-axis and y-axis.</param>
        void Scale(SizeF scaleSize);
    }
}
