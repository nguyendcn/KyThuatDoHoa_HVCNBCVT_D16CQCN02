using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using KyThuatDoHoa_Nhom9.Construct._2DObject;
using System.ComponentModel;

namespace KyThuatDoHoa_Nhom9.Construct._3DObject
{
    class HinhTru
    {
        private int _chieuCao;
        public int ChieuCao { get; set; }
        public int BanKinhDay { get; set; }
        public int[,] TamDay { get; set; }


        public HinhTru(int x,int y,int z,int chieuCao,int banKinhDay)
        {
            this.ChieuCao = chieuCao;
            this.BanKinhDay = banKinhDay;
            int[,] temp = { {x-banKinhDay,y,z },
                            {x,y,z },
                            { x+banKinhDay,y,z},
                            { x-banKinhDay,y+chieuCao,z},
                            { x,y+chieuCao,z},
                            { x+banKinhDay,y+chieuCao,z} };
            this.TamDay = temp;

        }

        public HinhTru()
        {
        }
        public void Draw(Graphics g )
        {
            DrawLine(g, 0, 3);
            DrawLine(g, 2, 5);

            Point point = ToaDo.NguoiDungMayTinh_3D(this.TamDay[1, 0], this.TamDay[1, 1], this.TamDay[1, 2]);
            ToaDo.HienThi(point, g, Color.Black);
                point = ToaDo.NguoiDungMayTinh_3D(this.TamDay[4, 0], this.TamDay[4, 1], this.TamDay[4, 2]);
            ToaDo.HienThi(point, g, Color.Black);

            DrawElip(g);

            for (int i = 0; i < 6; i++)
            {
                point = ToaDo.NguoiDungMayTinh_3D(this.TamDay[i, 0], this.TamDay[i, 1], this.TamDay[i, 2]);
                ToaDo.HienThi(point, g, Color.Pink);
                char c = (char)(65 + i);
                g.DrawString(c.ToString(), new Font("Verdana", 14), Brushes.Pink, point);
            }

        }
        public void DrawLine(Graphics g,int A,int B,int n = 1)
        {
            Point point1 = ToaDo.NguoiDungMayTinh_3D(this.TamDay[A, 0], this.TamDay[A, 1], this.TamDay[A, 2]),
                  point2 = ToaDo.NguoiDungMayTinh_3D(this.TamDay[B, 0], this.TamDay[B, 1], this.TamDay[B, 2]);

            //ToaDo.HienThi(point1, g);
            //ToaDo.HienThi(point2, g);
            Line line = new Line(point1, point2,Color.Black);
            if (n == 2)
            {
                line.NetDut(g);
            }
            else
                line.Draw(g);
        }
        public void DrawElip(Graphics g)
        {
            // Tính bán kính nhỏ của elip
            Point point = ToaDo.NguoiDungMayTinh_3D(this.TamDay[2, 0], this.TamDay[2, 1], this.TamDay[2, 2]);
            point = ToaDo.MayTinhNguoiDung_3D(point);

            double d = this.BanKinhDay * (Math.Sqrt(2) / 2);
            int b = (int)d;// this.BanKinhDay / 3 ;// (int)Math.Sqrt(Math.Abs(Math.Pow(this.BanKinhDay, 2) * Math.Pow(point.Y, 2)/(Math.Pow(this.BanKinhDay,2)-Math.Pow(point.X,2))));
            HinhElip hinhElip = new HinhElip(ToaDo.NguoiDungMayTinh_3D(this.TamDay[1, 0], this.TamDay[1, 1], this.TamDay[1, 2]), this.BanKinhDay, b,Color.Black);
            hinhElip.NetDut(g);

            // Vẽ các hình elip
            hinhElip = new HinhElip(ToaDo.NguoiDungMayTinh_3D(this.TamDay[4, 0], this.TamDay[4, 1], this.TamDay[4, 2]), this.BanKinhDay, b, Color.Black);
            hinhElip.Draw(g);

            Line line = new Line(ToaDo.NguoiDungMayTinh_3D(this.TamDay[1, 0], this.TamDay[1, 1], this.TamDay[1, 2]), 
                                 ToaDo.NguoiDungMayTinh_3D(this.TamDay[2, 0], this.TamDay[2, 1], this.TamDay[2, 2]),
                                 Color.Black);
            line.NetDut(g);

            line = new Line(ToaDo.NguoiDungMayTinh_3D(this.TamDay[1, 0], this.TamDay[1, 1], this.TamDay[1, 2]),
                                 ToaDo.NguoiDungMayTinh_3D(this.TamDay[4, 0], this.TamDay[4, 1], this.TamDay[4, 2]),
                                 Color.Black);
            line.NetDut(g);

            line = new Line(ToaDo.NguoiDungMayTinh_3D(this.TamDay[4, 0], this.TamDay[4, 1], this.TamDay[4, 2]),
                                 ToaDo.NguoiDungMayTinh_3D(this.TamDay[5, 0], this.TamDay[5, 1], this.TamDay[5, 2]),
                                 Color.Black);
            line.Draw(g);
        }
    }
}
