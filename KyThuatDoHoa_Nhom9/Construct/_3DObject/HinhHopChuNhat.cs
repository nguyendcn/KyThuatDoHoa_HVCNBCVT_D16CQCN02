using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using KyThuatDoHoa_Nhom9.Construct._2DObject;


namespace KyThuatDoHoa_Nhom9.Construct._3DObject
{
    class HinhHopChuNhat
    {
        private int ChieuDai { get; set; }
        private int ChieuRong { get; set; }
        private int ChieuCao { get; set; }
        private int[,] Dinh { get; set; }
        /// <summary>
        /// Khởi tạo hình hộp chữ nhật
        /// </summary>
        /// <param name="x">Tọa độ Ox</param>
        /// <param name="y">Tọa độ Oy</param>
        /// <param name="z">Tọa độ Oz</param>
        /// <param name="chieuDai">Chiều dài của hình hộp chữ nhật</param>
        /// <param name="chieuCao">Chiều cao của hình hộp chữ nhật</param>
        /// <param name="chieuRong">Chiều rộng của hình hộp chữ nhật</param>
        public HinhHopChuNhat(int x,int y,int z, int chieuDai,int chieuCao,int chieuRong)
        {
            this.ChieuDai = chieuDai;
            this.ChieuRong = chieuRong;
            this.ChieuCao = chieuCao;
            int[,] temp = { { x,y,z},
                            { x+chieuDai,y,z },
                            { x+chieuDai,y,z+chieuRong },
                            { x,y,z+chieuRong},

                            { x,y+chieuCao,z },
                            { x+chieuDai,y+chieuCao,z },
                            { x+chieuDai,y+chieuCao,z+ chieuRong},
                            { x,y+chieuCao,z+chieuRong} };

            this.Dinh = temp;
        }
        public void Draw(Graphics g)
        {
            // Vẽ nét đứt
            DrawLine(g, 0, 1,2); 
            DrawLine(g, 3, 0,2); 
            DrawLine(g, 0, 4,2); 
            // Vẽ nét liền
            DrawLine(g, 1, 2);
            DrawLine(g, 2, 3);
            DrawLine(g, 4, 5);
            DrawLine(g, 5, 6);
            DrawLine(g, 6, 7);
            DrawLine(g, 7, 4);
            DrawLine(g, 1, 5);
            DrawLine(g, 2, 6);
            DrawLine(g, 3, 7);

            Point point;
            for (int i = 0; i < 8; i++)
            {
                point = ToaDo.NguoiDungMayTinh_3D(this.Dinh[i, 0], this.Dinh[i, 1], this.Dinh[i, 2]);
                ToaDo.HienThi(point, g, Color.Pink);
                char c = (char)(65 + i);
                g.DrawString(c.ToString(), new Font("Verdana", 14), Brushes.Pink, point);
            }
        }
        /// <summary>
        /// Vẽ đường thẳng nối liền giữa 2 điểm A và B
        /// </summary>
        /// <param name="n">1: Vẽ nét liền 2: Vẽ nét đứt</param>
        public void DrawLine(Graphics g,int A,int B,int n = 1)
        {
            Point point1 = ToaDo.NguoiDungMayTinh_3D(this.Dinh[A,0], this.Dinh[A, 1], this.Dinh[A, 2]),
                  point2 = ToaDo.NguoiDungMayTinh_3D(this.Dinh[B, 0], this.Dinh[B, 1], this.Dinh[B, 2]);

            //ToaDo.HienThi(point1, g);
            //ToaDo.HienThi(point2, g);
            Line line = new Line(point1, point2);
            if (n == 2)
            {
                line.NetDut(g);
            }
            else
                line.Draw(g);
        }
    }
}
