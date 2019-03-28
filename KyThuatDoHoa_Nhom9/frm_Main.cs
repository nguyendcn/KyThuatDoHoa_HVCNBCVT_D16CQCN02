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
    public partial class frm_Main : Form
    {
        private enum Mode { _3D, _2D};
        private Mode _Mode_current = Mode._2D;

        public frm_Main()
        {
            InitializeComponent();
        }
        

        #region Creating drag form by pnl_ControlBar
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void pnl_ControlBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }
        #endregion

        private void pnl_ControlBar_Paint(object sender, PaintEventArgs e)
        {
            PaintTransparentBackground(this.pnl_ControlBar, e);
            using (Brush b = new SolidBrush(Color.FromArgb(128, this.pnl_ControlBar.BackColor)))
            {
                e.Graphics.FillRectangle(b, e.ClipRectangle);
            }
        }

        private static void PaintTransparentBackground(Control c, PaintEventArgs e)
        {
            if (c.Parent == null || !Application.RenderWithVisualStyles)
                return;

            ButtonRenderer.DrawParentBackground(e.Graphics, c.ClientRectangle, c);
        }

        private void pnl_MenuBar_Paint(object sender, PaintEventArgs e)
        {
            PaintTransparentBackground(this.pnl_MenuBar, e);
            using (Brush b = new SolidBrush(Color.FromArgb(128, this.pnl_MenuBar.BackColor)))
            {
                e.Graphics.FillRectangle(b, e.ClipRectangle);
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Toolbar_Click(object sender, EventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Toolbar_MouseDown(object sender, MouseEventArgs e)
        {
            if (pnl_ShowToolBarDialog.Visible)
            {
                pnl_ShowToolBarDialog.Visible = false;
            }
            else
            {
                pnl_ShowToolBarDialog.Visible = true;
                this.pnl_ShowToolBarDialog.BringToFront();
            }
        }

        private void btn_pnl_ShowTB_3D_Click(object sender, EventArgs e)
        {
            btn_Toolbar.Image = KyThuatDoHoa_Nhom9.Image_Res._3D_shapes_32px;
            btn_Toolbar.Text = Str_Collection._3D_shapes.ToString();
            pnl_ShowToolBarDialog.Visible = false;
            this._Mode_current = Mode._3D;
        }

        private void btn_pnl_ShowTB_2D_Click(object sender, EventArgs e)
        {
            btn_Toolbar.Image = KyThuatDoHoa_Nhom9.Image_Res._2D_shapes_32px;
            btn_Toolbar.Text = Str_Collection._2D_shapes.ToString();
            pnl_ShowToolBarDialog.Visible = false;
            this._Mode_current = Mode._2D;
        }

        private void btn_ChangeTextMenuBar_MouseDown(object sender, MouseEventArgs e)
        {
            if(btn_Toolbar.Text != String.Empty) // Mọi text tên chức năng đều trống(trạng thái chỉ có icon)
            {
                btn_Menu.Text = String.Empty;
                btn_Menu.ImageAlign = ContentAlignment.MiddleCenter;

                btn_Toolbar.Text = String.Empty;
                btn_Toolbar.ImageAlign = ContentAlignment.MiddleCenter;

                btn_ChangeTextMenuBar.Image = KyThuatDoHoa_Nhom9.Image_Res.Collapse_Arrow_32px;
            }
            else 
            {
                btn_Menu.Text = Str_Collection._Menu.ToString();
                btn_Menu.ImageAlign = ContentAlignment.TopCenter;

                if(this._Mode_current == Mode._2D)
                {
                    btn_Toolbar.Text = Str_Collection._2D_shapes.ToString();
                }
                else if(this._Mode_current == Mode._3D)
                {
                    btn_Toolbar.Text = Str_Collection._3D_shapes.ToString();
                }
                else { }
                
                btn_Toolbar.ImageAlign = ContentAlignment.TopCenter;

                btn_ChangeTextMenuBar.Image = KyThuatDoHoa_Nhom9.Image_Res.Expand_Arrow_32px;
            }
        }

        #region handle btn_Toolbar

        private void btn_Toolbar_MouseHover(object sender, EventArgs e)
        {
            if(btn_Toolbar.Text == String.Empty)
            {
                btn_Toolbar.ImageAlign = ContentAlignment.TopCenter;
                if(this._Mode_current == Mode._2D)
                {
                    btn_Toolbar.Text = Str_Collection._2D_shapes.ToString();
                }
                else
                {
                    btn_Toolbar.Text = Str_Collection._3D_shapes.ToString();
                }
            }
        }

        private void btn_Toolbar_MouseLeave(object sender, EventArgs e)
        {
            if (btn_Toolbar.Text != String.Empty)
            {
                btn_Toolbar.ImageAlign = ContentAlignment.MiddleCenter;
                btn_Toolbar.Text = String.Empty;
            }
        }

        #endregion
    }
}
