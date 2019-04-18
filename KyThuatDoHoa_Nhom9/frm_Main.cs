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

            Setup_ToolTips();
        }


        #region Function

        /// <summary>
        /// Setup tooltip for all controls in this form
        /// </summary>
        private void Setup_ToolTips()
        {
            ToolTip tt = new ToolTip();
            tt.AutoPopDelay = 5000;
            tt.InitialDelay = 500;
            tt.ReshowDelay = 500;
            tt.ShowAlways = true;

            #region Set tooltip for button inside pnl_Change

            tt.SetToolTip(this.btn_Menu, this.btn_Menu.Tag.ToString());
            tt.SetToolTip(this.btn_Toolbar, this.btn_Toolbar.Tag.ToString());
            tt.SetToolTip(this.btn_ShowBtnDetails, this.btn_ShowBtnDetails.Tag.ToString());
            #endregion

            #region Set tooltip for button inside pnl_2D

            //grb 2D
            foreach(Control ctr in this.grb_2DShapes.Controls)
            {
                if(ctr is Button)
                {
                    if (ctr.Tag == null)
                    {
                        tt.SetToolTip(ctr, "Tag_name null");
                    }
                    else
                    {
                        tt.SetToolTip(ctr, ctr.Tag.ToString());
                    }
                }
            }

            //grb line
            foreach (Control ctr in this.grb_2DLine.Controls)
            {
                if (ctr is Button)
                {
                    if (ctr.Tag == null)
                    {
                        tt.SetToolTip(ctr, "Tag_name null");
                    }
                    else
                    {
                        tt.SetToolTip(ctr, ctr.Tag.ToString());
                    }
                }
            }

            #endregion

            #region Set tooltip for button inside pnl_3D
            foreach (Control ctr in this.grb_3Dobject.Controls)
            {
                if (ctr is Button)
                {
                    if (ctr.Tag == null)
                    {
                        tt.SetToolTip(ctr, "Tag_name null");
                    }
                    else
                    {
                        tt.SetToolTip(ctr, ctr.Tag.ToString());
                    }
                }
            }
            #endregion
        }

        /// <summary>
        /// Hiển thị pnl tương ứng với mode hiện tại
        /// </summary>
        /// <param name="mode">Used to indicate status.</param>
        private void Setup_Toolbar(Constants.Mode mode)
        {
            // Ẩn toàn bộ các panel trong pnl_toolBox
            foreach (Control ctr in this.pnl_ToolBox.Controls)
            {
                ctr.Visible = false;
            }

            //Hiển thị pnl, thay đổi text, img của btn_Toolbar với mode tương ứng
            if (mode == Constants.Mode._2D)
            {
                this.pnl_Tb_2D.Visible = true;
                if(Variables.Globals._btn_isShowDetails)
                    this.btn_Toolbar.Text = Collection_Strs._2D_shapes;
                this.btn_Toolbar.Image = Image_Res._2D_Model_25px;
            }
            else if (mode == Constants.Mode._3D)
            {
                this.pnl_Tb_3D.Visible = true;
                if (Variables.Globals._btn_isShowDetails)
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
                foreach(Control ctr in this.pnl_Mode.Controls)
                {
                    if(ctr is Button)
                    {
                        Button btn = ctr as Button;
                        btn.Text = "";
                        btn.ImageAlign = ContentAlignment.MiddleCenter;
                        
                    }
                }
            }
        }

        #endregion

        private void Btn_Menu_Click(object sender, EventArgs e)
        {

        }

        #region Event Handl

        /// <summary>
        /// Whent user click to button ShowDetails
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_ShowBtnDetails_Click(object sender, EventArgs e)
        {
            if (Globals._btn_isShowDetails)
            {
                Globals._btn_isShowDetails = false;
                btn_ShowBtnDetails.Image = Image_Res.Collapse_Arrow_25px;
            }
            else
            {
                Globals._btn_isShowDetails = true;
                btn_ShowBtnDetails.Image = Image_Res.Expand_Arrow_25px;
            }

            SetTextForButton(Globals._btn_isShowDetails);
        }

        /// <summary>
        /// When user click to button Toolbar 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Toolbar_Click(object sender, EventArgs e)
        {
            UI.UserCtr.ChooseMode cm = new UI.UserCtr.ChooseMode(Variables.Globals._Mode_current);

            cm.VisibleChanged += new EventHandler(delegate (object obj, EventArgs ea)
            {
                UI.UserCtr.ChooseMode _cm = obj as UI.UserCtr.ChooseMode;
                if (!_cm.Visible)
                {
                    _cm.Dispose();
                    if (_cm.Return_Mode != Globals._Mode_current) //da thay doi che do
                    {
                        Globals._Mode_current = _cm.Return_Mode;
                        Setup_Toolbar(Globals._Mode_current); //thay do hien thi

                    }
                }
            });
            cm.Location = new Point(this.pnl_Change.Location.X, this.pnl_Change.Location.Y);
            this.Controls.Add(cm);
            cm.BringToFront();
            cm.Focus();
        }


        /// <summary>
        /// Event Handl whent mouse enter to button.
        /// </summary>
        /// <param name="sender">Button clicked.</param>
        /// <param name="e">Event.</param>
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.FlatAppearance.BorderSize = 1; //Resize border
        }

        /// <summary>
        /// Event Handl whent mouse leave this button.
        /// </summary>
        /// <param name="sender">Button clicked.</param>
        /// <param name="e">Event</param>
        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.FlatAppearance.BorderSize = 0; //Resize border
        }

        /// <summary>
        /// Handl Event whent clicked.
        /// </summary>
        /// <param name="sender">Button clicked.</param>
        /// <param name="e">Event.</param>
        private void Button_Click(object sender, EventArgs e)
        {
            if (Variables.Globals._Mode_current == Constants.Mode._2D)
            {
                //End focus button in grb_2DShapes
                foreach (Control ctr in grb_2DShapes.Controls)
                {
                    if (ctr is Button)
                    {
                        Button b = ctr as Button;
                        b.BackColor = Color.Transparent;
                    }
                }
            }
            else if (Variables.Globals._Mode_current == Constants.Mode._3D)
            {
                //End focus button in grb_3Dobject
                foreach (Control ctr in grb_3Dobject.Controls)
                {
                    if (ctr is Button)
                    {
                        Button b = ctr as Button;
                        b.BackColor = Color.Transparent;
                    }
                }
            }

            //Focus button clicked
            Button btn = sender as Button;
            btn.BackColor = Color.BlueViolet;
        }


        #endregion
    }
}
