using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KyThuatDoHoa_Nhom9.UI.UserCtr
{
    public partial class XeProperties : UserControl
    {
        public Point[] lsPoint = new Point[25];
        public int bankinh;
        public XeProperties()
        {
            InitializeComponent();
            HienThiThongTin();
        }

        public void HienThiThongTin()
        {
            // in ra thông tin hình chữ nhật
      
            this.lblHcn1.Text = this.lsPoint[8].ToString();
            this.lblHcn2.Text = new Point(this.lsPoint[8].X, this.lsPoint[9].Y).ToString();
            this.lblHcn3.Text = this.lsPoint[9].ToString();
            this.lblHcn4.Text = new Point(this.lsPoint[9].X, this.lsPoint[8].Y).ToString();
            this.lblHcn5.Text = "Chiều rộng: " + (this.lsPoint[9].Y - this.lsPoint[8].Y).ToString();
            this.lblHcn6.Text = "Chiều dài : " + (this.lsPoint[9].X - this.lsPoint[8].X).ToString();
            // in thông tin hình tam giác
            this.lblTG1.Text = this.lsPoint[10].ToString();
            this.lblTG2.Text = this.lsPoint[11].ToString();
            this.lblTG3.Text = this.lsPoint[12].ToString();
            // in thông tin bánh xe trước
            this.lblBt1.Text = this.lsPoint[19].ToString();
            this.lblBt2.Text = this.lsPoint[20].ToString();
            this.lblBt3.Text = this.lsPoint[21].ToString();
            this.lblTam1.Text = "Bánh Kính: " + this.bankinh.ToString();
            this.lblBk1.Text = "   Tâm: " + this.lsPoint[13].ToString();

            // in thông tin bánh xe sau
            this.lblBx1.Text = this.lsPoint[22].ToString();
            this.lblBx2.Text = this.lsPoint[23].ToString();
            this.lblBx3.Text = this.lsPoint[24].ToString();
            this.lblTam2.Text = "Bánh Kính: " + this.bankinh.ToString();
            this.lblBk2.Text = "   Tâm: " + this.lsPoint[14].ToString();

            // in thông tin các điểm khác
            this.lblK.Text = this.lsPoint[0].ToString();
            this.lblKhac2.Text = this.lsPoint[1].ToString();
            this.lblKhac3.Text = this.lsPoint[2].ToString();
            this.lblKhac4.Text = this.lsPoint[3].ToString();
            this.lblKhac5.Text = this.lsPoint[4].ToString();
            this.lblKhac6.Text = this.lsPoint[5].ToString();
            this.lblKhac7.Text = this.lsPoint[6].ToString();
            this.lblKhac8.Text = this.lsPoint[7].ToString();
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void lblBtrc1_Click(object sender, EventArgs e)
        {

        }

        private void lblTam2_Click(object sender, EventArgs e)
        {

        }

        private void lblKhac2_Click(object sender, EventArgs e)
        {

        }
    }
}
