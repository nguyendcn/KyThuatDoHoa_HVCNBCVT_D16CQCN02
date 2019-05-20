using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KyThuatDoHoa_Nhom9.Construct.DefineType;

namespace KyThuatDoHoa_Nhom9.Construct._2DObject
{
    public static class Transformations
    {
        public static Point ToSmall(this Point p)
        {
            return (new Point(p.X / 5 - 40, 40 - p.Y / 5));//voi x va y deu chia het cho 5
        }

        public static Point ToBig(this Point p)//nho ra lon
        {

            return (new Point(p.X * 5 + 200, 200 - 5 * p.Y));
        }

        public static Point GetNewPointByMulMatixs(double[,] matran, double[] mang)
        {
            //Multiply two matrics: 3x3 and 3x1. Else => result false.
            double[] mangtam;
            mangtam = new double[3];

            int dem = 0;
            for (int i = 0; i < 3; i++)
            {
                mangtam[i] = mang[0] * matran[0, dem] + mang[1] * matran[1, dem] + mang[2] * matran[2, dem];
                dem++;
            }

            Point pt = new Point(Convert.ToInt16(mangtam[0]), Convert.ToInt16(mangtam[1]));
            return pt;
        }

        public static double[] ConvertToMatrix(this Point p)
        {
            return new double[] {p.X, p.Y, 1 };
        }

        public static Point ConvertToPoint(this double[] matrix)
        {
            if (matrix.Length == 0 || matrix.Length > 3)
                throw new Exception("The matrix doesn't match with format");
            return new Point((int)matrix[0], (int)matrix[1]);
        }

        /// <summary>
        /// Applies a clockwise rotation.
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="alpha"></param>
        /// <returns></returns>
        private static double[,] SetUpForMatrixRotate(this double[,] matrix, int alpha)
        {
            double s = Math.Sin((Math.PI * alpha) / 180),
                    c = Math.Cos((Math.PI * alpha) / 180);

            if (matrix.Length == 0 || matrix == null)
            {
                matrix = new double[3, 3] {
                   { c, -s, 0},
                   { s, c, 0},
                   { 0, 0, 1}
                };
                return matrix;
            }

            matrix[0, 0] = c; matrix[0, 1] = -s; matrix[0, 2] = 0;
            matrix[1, 0] = s; matrix[1, 1] = c; matrix[1, 2] = 0;
            matrix[2, 0] = 0; matrix[2, 1] = 0; matrix[2, 2] = 1;
            return matrix;
        }

        private static double[,] SetUpForMatrixTranslate(this double[,] matrix, Point d)
        {
            if (matrix.Length == 0 || matrix == null)
            {
                matrix = new double[3, 3] {
                   { 1, 0, d.X},
                   { 0, 1, d.Y},
                   { 0, 0, 1}
                };
                return matrix;
            }

            matrix[0, 0] = 1; matrix[0, 1] = 0; matrix[0, 2] = d.X;
            matrix[1, 0] = 0; matrix[1, 1] = 1; matrix[1, 2] = d.Y;
            matrix[2, 0] = 0; matrix[2, 1] = 0; matrix[2, 2] = 1;
            return matrix;
        }

        /// <summary>
        /// Matrix Translation To Original Coordinate
        /// </summary>
        /// <returns></returns>
        private static double[,] SetUpForMatrixTransToOriCoor(this double[,] matrix, Point p)
        {
            if (matrix.Length == 0 || matrix == null)
            {
                matrix = new double[3, 3] {
                   { 1, 0, 0},
                   { 0, 1, 0},
                   { -p.X, -p.Y, 1}
                };
                return matrix;
            }

            matrix[0, 0] = 1; matrix[0, 1] = 0; matrix[0, 2] = 0;
            matrix[1, 0] = 0; matrix[1, 1] = 1; matrix[1, 2] = 0;
            matrix[2, 0] = -p.X; matrix[2, 1] = -p.Y; matrix[2, 2] = 1;
            return matrix;
        }

        /// <summary>
        /// Applies a clockwise rotation.
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2">Original point.</param>
        /// <param name="alpha">Alpha.</param>
        /// <returns></returns>
        public static Point RotateAt(this Point d1, Point d2, int alpha)
        {
            Point dd1, dd2;
            dd1 = d1.ToSmall();
            dd2 = d2.ToSmall();
            int xo, yo;
            xo = dd2.X; yo = dd2.Y;

            double[] mang = new double[3];

            double[,] matran1 = new double[3, 3],
                      matran2 = new double[3, 3],
                      matran3 = new double[3, 3];

            matran1.SetUpForMatrixTransToOriCoor(dd2);
            mang = dd1.ConvertToMatrix();

            Point pt = GetNewPointByMulMatixs(matran1, mang);

            matran2.SetUpForMatrixRotate(alpha);
            mang = pt.ConvertToMatrix();

            Point pt1 = GetNewPointByMulMatixs(matran2, mang);

            // ma tran doi diem ve toa do cu
            matran3[0, 0] = 1; matran3[0, 1] = 0; matran3[0, 2] = 0;
            matran3[1, 0] = 0; matran3[1, 1] = 1; matran3[1, 2] = 0;
            matran3[2, 0] = xo; matran3[2, 1] = yo; matran3[2, 2] = 1;

            mang = pt1.ConvertToMatrix();
            Point pt2 = GetNewPointByMulMatixs(matran3, mang);
            Point kq = pt2.ToBig();
            return kq;
        }

        public static Point Translate(this Point d1, Point d2)
        {
            double[] arr = new double[3];
            double[,] matrix = new double[3, 3];

            arr = d1.ConvertToMatrix();
            matrix = matrix.SetUpForMatrixTranslate(new Point(d2.X - d1.X, d2.Y - d1.Y));
            Point p = GetNewPointByMulMatixs(matrix, arr);

            return p;
        }
        
    }
}
