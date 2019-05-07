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
        private Bitmap bm;
        private Graphics grp;
         
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
            foreach (Control ctr in this.pnl_ToolBox.Controls) // List control trong pnl_ToolBox
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
        private void Btn_Toolbar_Click(object sender, EventArgs e)
        {
            UI.UserCtr.ChooseMode cm = new UI.UserCtr.ChooseMode(Variables.Globals._Mode_current);
            // Tạo event thay đổi từ Mode 2D sang 3D và ngược lại
            cm.VisibleChanged += new EventHandler(delegate (object obj, EventArgs ea)
            {
                UI.UserCtr.ChooseMode _cm = obj as UI.UserCtr.ChooseMode;
                if (!_cm.Visible)
                {
                    _cm.Dispose(); // Xóa toàn bộ component có trong _cm
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


        #region Vẽ trên pnl_WorkStation
        private void Pnl_WorkStation_Paint(object sender, PaintEventArgs e)
        {
            // check 3d hay 2d
            
            VeLuoiPixel(new Pen(Color.Red));

        }

        public void VeLuoiPixel( Pen pen)
        {
            int i = 0,
                width = Variables.Globals.widthPanel,
                height = Variables.Globals.heightPanel;
            Graphics g = this.pnl_WorkStation.CreateGraphics();
            // Vẽ 2 đường biên Ox và Oy
            g.DrawLine(pen, 5 *width / 2, 0, 5 * width / 2, pnl_WorkStation.Height);
            g.DrawLine(pen, 0, 5 * height / 2, pnl_WorkStation.Width, 5 * height / 2);

            if (chkLuoiPixel.Checked)
            {
                // Vẽ toàn bộ đường dọc
                for (; i <= width; i++)
                {
                    if (i == width / 2)
                        continue;
                    g.DrawLine(new Pen(Color.Black), 5 * i, 0, 5 * i, pnl_WorkStation.Height);
                }
                // Vẽ toàn bộ đường ngang
                for (i = 0; i <= height; i++)
                {
                    if (i == height / 2)
                        continue;
                    g.DrawLine(new Pen(Color.Black), 0, 5 * i, pnl_WorkStation.Width, 5 * i);
                }
            }
        }

        private void Pnl_WorkStation_SizeChanged(object sender, EventArgs e)
        {
            // Lấy kích thước mới khi SizeChanged
            Variables.Globals.widthPanel = ReturnEvenNumber( pnl_WorkStation.Width / 5);
            Variables.Globals.heightPanel = ReturnEvenNumber( pnl_WorkStation.Height / 5);
            pnl_WorkStation.Refresh();
            VeLuoiPixel(new Pen(Color.Red));
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            Variables.Globals.widthPanel = ReturnEvenNumber( pnl_WorkStation.Width / 5);
            Variables.Globals.heightPanel = ReturnEvenNumber(pnl_WorkStation.Height / 5);
        }

        private void Pnl_WorkStation_MouseMove(object sender, MouseEventArgs e)
        {
            int x = 0, y = 0;
            Point p, q;
            //p = new Point(ToaDo.(e.Location.X), ToaDo.LuoiPixel(e.Location.Y));
            Int32.TryParse(e.Location.X.ToString(), out x);
            Int32.TryParse(e.Location.Y.ToString(), out y);
            p =  ToaDo.MayTinhNguoiDung(x,y);
            q = ToaDo.NguoiDungMayTinh(p.X, p.Y);
            // Kích thước của pnl_WorkStation
            lblWidth.Text = Variables.Globals.widthPanel.ToString();
            lblHeight.Text = Variables.Globals.heightPanel.ToString();

            // Vị trí trên màn hình máy tính
            lblXcpt.Text = q.X.ToString();
            lblYcmt.Text = q.Y.ToString();

            // Vị trí của chuột trên đồ thị người dùng
            lblX.Text = p.X.ToString();
            lblY.Text = p.Y.ToString();
        }
        /// <summary>
        /// Trả về giá trị chẵn của pnl_WorkStation
        /// </summary>
        public int ReturnEvenNumber(int number)
        {
            if (number % 2 == 0)
                return number;
            return number - 1;
        }

        private void ChkLuoiPixel_CheckedChanged(object sender, EventArgs e)
        {
            // Lấy kích thước mới khi SizeChanged
            Variables.Globals.widthPanel = ReturnEvenNumber(pnl_WorkStation.Width / 5);
            Variables.Globals.heightPanel = ReturnEvenNumber(pnl_WorkStation.Height / 5);
            pnl_WorkStation.Refresh();
            VeLuoiPixel(new Pen(Color.Red));    
        }

        private void Pnl_WorkStation_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.Location.X,
                y = e.Location.Y;

            int pointX = ToaDo.LuoiPixel(x),
            pointY = ToaDo.LuoiPixel(y);


            if (e.Button == MouseButtons.Left)
            {
                // Vẽ pixel 
                Graphics gp = this.pnl_WorkStation.CreateGraphics();
                Pen p = new Pen(Color.Green);
                SolidBrush b = new SolidBrush(Color.Green);
                gp.DrawEllipse(p, pointX, pointY, 2, 2);
                gp.FillEllipse(b, pointX, pointY, 2, 2);
                gp.DrawEllipse(p, pointX - 2, pointY - 2, 2, 2);
                gp.FillEllipse(b, pointX - 2, pointY - 2, 2, 2);
                gp.DrawEllipse(p, pointX, pointY - 2, 2, 2);
                gp.FillEllipse(b, pointX, pointY - 2, 2, 2);
                gp.DrawEllipse(p, pointX - 2, pointY, 2, 2);
                gp.FillEllipse(b, pointX - 2, pointY, 2, 2);
            }
        }
        /// <summary>
        /// Chuyển từ tọa máy tính sang tọa độ của người dùng
        /// </summary>
        public int ConvertToCoordinatesUser()
        {
            

            return 1;
        }

        #endregion
    }
}
