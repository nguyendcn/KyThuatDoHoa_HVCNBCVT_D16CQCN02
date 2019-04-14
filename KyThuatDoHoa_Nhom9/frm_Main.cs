using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KyThuatDoHoa_Nhom9.UI;

namespace KyThuatDoHoa_Nhom9
{
    public partial class frm_Main : Form
    {
        

        public frm_Main()
        {
            InitializeComponent();

            //2D mode is startup;
            //pnl_Menu_2Dshapes.Visible = true;
            //pnl_Menu_3Dshapes.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            frm_ChangeMode fr  = new frm_ChangeMode();
            fr.VisibleChanged += Fr_VisibleChanged;
            fr.StartPosition = FormStartPosition.Manual;

            int BorderWidth = (this.Width - this.ClientSize.Width) / 2;
            int TitlebarHeight = this.Height - (this.ClientSize.Height + BorderWidth);

            fr.Left = this.Location.X + pnl_Change.Location.X + BorderWidth;
            fr.Top = this.Location.Y + pnl_Change.Location.Y + TitlebarHeight ;




            fr.Show();

        }

        private void Fr_VisibleChanged(object sender, EventArgs e)
        {
            frm_ChangeMode frm = sender as frm_ChangeMode;
            if (!frm.Visible)
            {
                frm.Dispose();
                MessageBox.Show(frm.ReturnText);
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("sdfsdfasfd");
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            MessageBox.Show("zxcvcxvzxc");
        }
    }
}
