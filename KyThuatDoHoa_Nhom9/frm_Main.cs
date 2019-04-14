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
using KyThuatDoHoa_Nhom9.Variables;

namespace KyThuatDoHoa_Nhom9
{
    public partial class frm_Main : Form
    {

        public frm_Main()
        {
            InitializeComponent();

            //2D mode is startup;
            Setup_Toolbar(Globals._Mode_current);
        }

        private void btn_Toolbar_Click(object sender, EventArgs e)
        {
            frm_ChangeMode frm_cm  = new frm_ChangeMode(Globals._Mode_current);

            //them su kien khi form ChangeMode an di
            frm_cm.VisibleChanged += new EventHandler(delegate (object obj, EventArgs ea){
                frm_ChangeMode frm = obj as frm_ChangeMode;
                if (!frm.Visible)
                {
                    frm.Dispose();
                    if (frm.Return_Mode != Globals._Mode_current) //da thay doi che do
                    {
                        Globals._Mode_current = frm.Return_Mode;
                        Setup_Toolbar(Globals._Mode_current); //thay do hien thi
                    }
                }
            });

            //set vi tri hien thi phu thuoc vao thuoc tinh Control.Location
            frm_cm.StartPosition = FormStartPosition.Manual;

            //tinh kich thuowc cua border va thanh titlebar
            int _border_Width = (this.Width - this.ClientSize.Width) / 2;
            int _titlebar_Height = this.Height - (this.ClientSize.Height + _border_Width);

            //set le trai va le tren cung so voi man hinh sao cho nam duoi pnl_Change
            frm_cm.Left = this.Location.X + pnl_Change.Location.X + _border_Width; 
            frm_cm.Top = this.Location.Y + pnl_Change.Location.Y + _titlebar_Height; 

            frm_cm.Show();
        }


        #region Function

        /// <summary>
        /// Hiển thị pnl tương ứng với mode hiện tại
        /// </summary>
        /// <param name="mode">Used to indicate status.</param>
        private void Setup_Toolbar(Constants.Mode mode)
        {   
            //Ẩn toàn bộ các panel trong pnl_toolBox
            foreach(Control ctr in this.pnl_ToolBox.Controls)
            {
                ctr.Visible = false;
            }

            //Hiển thị pnl, thay đổi text, img của btn_Toolbar với mode tương ứng
            if(mode == Constants.Mode._2D)
            {
                this.pnl_Tb_2D.Visible = true;
                this.btn_Toolbar.Text = Collection_Strs._2D_shapes;
                this.btn_Toolbar.Image = Image_Res._2D_Model_25px;
            }
            else if(mode == Constants.Mode._3D)
            {
                this.pnl_Tb_3D.Visible = true;
                this.btn_Toolbar.Text = Collection_Strs._3D_shapes;
                this.btn_Toolbar.Image = Image_Res._3D_Model_25px;
            }
        }

        /// <summary>
        /// Hiển thị text của button hay không
        /// </summary>
        /// <param name="isShow">Used to indicate text.</param>
        private void SetTextForButton(bool isShow)
        {
            if(isShow)
            {
                //set btn_Menu
                btn_Menu.Text = Collection_Strs._Menu;
                btn_Menu.ImageAlign = ContentAlignment.TopCenter;

                //set btn_Toolbar theo mode hien tai
                btn_Toolbar.ImageAlign = ContentAlignment.TopCenter;
                if (Globals._Mode_current == Constants.Mode._2D)
                {
                    btn_Toolbar.Text = Collection_Strs._2D_shapes;
                }
                else if(Globals._Mode_current == Constants.Mode._3D)
                {
                    btn_Toolbar.Text = Collection_Strs._3D_shapes;
                }
            }
            else
            {
                foreach(Button ctr in this.pnl_Mode.Controls)
                {
                    if(ctr is Button)
                    {
                        ctr.Text = "";
                        ctr.ImageAlign = ContentAlignment.MiddleCenter;
                    }
                }
            }
        }
        #endregion

        private void btn_ShowDetails_btn_Click(object sender, EventArgs e)
        {
            if(Globals._btn_isShowDetails)
            {
                Globals._btn_isShowDetails = false;
                btn_ShowDetails_btn.Image = Image_Res.Collapse_Arrow_25px;
            }
            else
            {
                Globals._btn_isShowDetails = true;
                btn_ShowDetails_btn.Image = Image_Res.Expand_Arrow_25px;
            }

            SetTextForButton(Globals._btn_isShowDetails);
        }
    }
}
