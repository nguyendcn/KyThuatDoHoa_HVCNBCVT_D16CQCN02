using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KyThuatDoHoa_Nhom9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        /// <summary>
        /// Phép chiếu Cavalier
        /// </summary
        public void VeLuoi3D(Graphics grp)
        {
            int xCenter = picb3D.Width/2,
                yCenter = picb3D.Height/2;

            grp.DrawLine(new Pen(Color.Red), new Point(xCenter, yCenter), new Point(picb3D.Width,yCenter));
            grp.DrawLine(new Pen(Color.Red), new Point(xCenter, yCenter), new Point(xCenter, 0));
            grp.DrawLine(new Pen(Color.Red), new Point(xCenter, yCenter), new Point(xCenter - yCenter, picb3D.Height));

        }

        private void Picb3D_Paint(object sender, PaintEventArgs e)
        {
            VeLuoi3D(e.Graphics);

        }
    }
}
