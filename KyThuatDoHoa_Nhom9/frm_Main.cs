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
using KyThuatDoHoa_Nhom9.Construct._2DObject;
using KyThuatDoHoa_Nhom9.UI.UserCtr;

namespace KyThuatDoHoa_Nhom9
{

    public partial class frm_Main : Form
    {
        private Bitmap bm;
        private Graphics grp;

   
        public frm_Main()
        {
            InitializeComponent();
            
            flagTimer = false;
            hinhXe = new HinhXe();

            // Tạo quả lắc theo kích thước cho trước
            pendulum = new Pendulum(new Point(100, 20), new Point(400,220));
            pendulum.SetAlpha(-3); // set góc quay alpha 
            pendulum.PropertyChanged += Pendulum_PropertyChanged;

            picb_2DArea.Dock = picb_3DArea.Dock = DockStyle.Fill;

            //2D mode is startup;
            Setup_Toolbar(Globals._Mode_current);

            Setup_ToolTips();
          
        }

        private void Pendulum_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            this.picb_2DArea.Refresh();
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
                picb_2DArea.BringToFront();

            }
            else if (mode == Constants.Mode._3D)
            {
                this.pnl_Tb_3D.Visible = true;
                if (Variables.Globals._btn_isShowDetails)
                    this.btn_Toolbar.Text = Collection_Strs._3D_shapes;
                this.btn_Toolbar.Image = Image_Res._3D_Model_25px;
                picb_3DArea.BringToFront();
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

        private void Button_MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            if(btn.Tag.Equals("Circle"))
            {
                CircleProperties circleProperties = new CircleProperties(this.pnl_Tb_2D.Size);
                circleProperties.PropertyChanged += CircleProperties_PropertyChanged;
                this.pnl_ToolBox.Controls.Add(circleProperties);
                circleProperties.BringToFront();

                ht = new HinhTron(new Point(550, 320), 10);
                circleProperties.CoorOriginal = ToaDo.MayTinhNguoiDung(new Point(550, 320));
                circleProperties.Radius = 10;
                ht.Draw(picb_2DArea.CreateGraphics());
                ht.PropertyChanged += Ht_PropertyChanged;
            }
            else if(btn.Tag.Equals("Clock"))
            {
                clockProperties = new ClockProperties();

                clockProperties.PropertyChanged += ClockProperties_PropertyChanged;
                this.pnl_ToolBox.Controls.Add(clockProperties);
                clockProperties.Refresh();
                clockProperties.BringToFront();

                DateTime dt = DateTime.Now;
                clock = new Clock(new Point(580, 315), 15, dt);
                clock.CurrentDatetime = new DateTime(2019, 05, 19, 12, 30, 15);
                clock.Draw(this.picb_2DArea.CreateGraphics());
                clock.PropertyChanged += Clock_PropertyChanged;
            }
            else if(btn.Tag.Equals("TimePiece"))
            {
                timepieceProperties = new TimepieceProperties();
                timepieceProperties.PropertyChanged += TimepieceProperties_PropertyChanged;
                this.pnl_ToolBox.Controls.Add(timepieceProperties);
                timepieceProperties.BringToFront();

                timepiece = new Timepiece();
                timepiece.PropertyChanged += Timepiece_PropertyChanged;
            }
   
        }

        TimepieceProperties timepieceProperties;
        Timepiece timepiece;
        private void Timepiece_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if(e.PropertyName.Equals("location"))
            {

            }
            else if(e.PropertyName.Equals("item_clock"))
            {
                this.picb_2DArea.Refresh();
                timepieceProperties.ClockProperties.CurrentTime = timepiece.Item_clock.CurrentDatetime;
                timepieceProperties.ClockProperties.HHours = timepiece.Item_clock.HHours;
                timepieceProperties.ClockProperties.HMinute = timepiece.Item_clock.HMinute;
                timepieceProperties.ClockProperties.HSecond = timepiece.Item_clock.HSecond;
            }
        }

        private void TimepieceProperties_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
           if(e.PropertyName.Equals("timeChanged"))
            {
                timepiece.Item_clock.CurrentDatetime = timepieceProperties.ClockProperties.CurrentTime;
            }
        }


        #region Timepiece action
        #endregion


        #region Clock action
        Clock clock;
        ClockProperties clockProperties;
        private void Clock_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            this.picb_2DArea.Refresh();
            clockProperties.CurrentTime = clock.CurrentDatetime;
            clockProperties.HHours = clock.HHours;
            clockProperties.HMinute = clock.HMinute;
            clockProperties.HSecond = clock.HSecond;
        }


        private void ClockProperties_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            clock.CurrentDatetime = clockProperties.CurrentTime;
        }
        #endregion

        #region Circle action
        HinhTron ht;
        private void CircleProperties_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (ht != null)
            {
                CircleProperties cp = (sender as CircleProperties);
                if (e.PropertyName.Equals("radius"))
                    ht.Radius = cp.Radius;
                else if(e.PropertyName.Equals("coorOriginal"))
                {
                    ht.Point = ToaDo.NguoiDungMayTinh(cp.CoorOriginal);
                }
            }
        }

        private void Ht_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            this.picb_2DArea.Refresh();
            (sender as HinhTron).Draw(this.picb_2DArea.CreateGraphics());
        }
        #endregion


        #endregion


        #region Vẽ trên pnl_WorkStation

        private Bitmap DrawCoordinate(Size size)
        {
            Bitmap bm = new Bitmap(size.Width, size.Height);

            DrawPixelGril(bm, new Pen(Color.Red, 1));

            return bm;
        }

        private void DrawPixelGril(Bitmap bm, Pen pen)
        {
            Graphics g = Graphics.FromImage(bm);
            int i = 0,
               width = Variables.Globals.sizeOfNewCoor_2D.Width,
               height = Variables.Globals.sizeOfNewCoor_2D.Height;

            if (chkLuoiPixel.Checked)
            {
                // Vẽ toàn bộ đường dọc
                for (; i <= width; i++)
                {
                    if (i == width / 2)
                        continue;
                    g.DrawLine(new Pen(Color.Black), 5 * i, 0, 5 * i, picb_2DArea.Height);
                }
                // Vẽ toàn bộ đường ngang
                for (i = 0; i <= height; i++)
                {
                    if (i == height / 2)
                        continue;
                    g.DrawLine(new Pen(Color.Black), 0, 5 * i, picb_2DArea.Width, 5 * i);
                }
            }

            // Vẽ 2 đường biên Ox và Oy 
            g.DrawLine(pen, 5 * width / 2, 0, 5 * width / 2, picb_2DArea.Height);
            g.DrawLine(pen, 0, 5 * height / 2, picb_2DArea.Width, 5 * height / 2);
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            
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
            Variables.Globals.sizeOfNewCoor_2D.Width = ReturnEvenNumber(picb_2DArea.Width / Variables.Globals.sizePerPoint.Width);
            Variables.Globals.sizeOfNewCoor_2D.Height = ReturnEvenNumber(picb_2DArea.Height / Variables.Globals.sizePerPoint.Height);
                
            this.picb_2DArea.BackgroundImage = DrawCoordinate(new Size(picb_2DArea.Width, picb_2DArea.Height));
        }

        private void Pnl_WorkStation_MouseClick(object sender, MouseEventArgs e)
        {
            ////pnl_WorkStation.Refresh();
            //if (chkLuoiPixel.Checked)
            //{
               // VeLuoiPixel(new Pen(Color.Red));
            //}

            //grp = picb_2DArea.CreateGraphics();

        }

        #endregion


        Graphics g;
        Graphics g1;
        int y1 = 1, y2 = 5;
        Point s = new Point(3, 3);
        Point ep = new Point(15, 15);
        Bitmap bmTemp;
        bool test = false;
        HinhChuNhat hinhChuNhat;
        Clock cl;
        Line line;
        Timer tm = new Timer
        {
            Interval = 300
        };

        int x;
        int y;

        private void button37_Click(object sender, EventArgs e)
        {
            cl = new Clock(new Point(550, 320), 20, DateTime.Now);
            cl.PropertyChanged += Cl_PropertyChanged;

            //hinhChuNhat = new HinhChuNhat(ToaDo.NguoiDungMayTinh(s), ToaDo.NguoiDungMayTinh(ep));
            ////line = new Line(ToaDo.NguoiDungMayTinh(s), ToaDo.NguoiDungMayTinh(ep));
            //tm.Tick += timer1_Tick;
            //tm.Start();
        }

        private void Cl_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            label4.Text = cl.CurrentDatetime.ToString();
            test = true;
            //this.Invalidate();
            this.picb_2DArea.Refresh();
        }
        int i = 0, j = 0;
        HinhXe hinhXe;
        Pendulum pendulum;
        private bool flagTimer;
        private void picb_2DArea_Paint(object sender, PaintEventArgs e)
        {
            //if (test)
            //{
            //    //line.Draw(e.Graphics);
            //    //line.Rotate(new Point(550, 320), 20);
            //    //hinhChuNhat.Draw(e.Graphics);
            //    //hinhChuNhat.Rotate(new Point(550, 320), 90);
            //    //cl.CurrentDatetime = DateTime.Now;
            //    cl.Draw(e.Graphics);
            //}

            if (clock != null)
                clock.Draw(e.Graphics);
            if (timepiece != null)
                timepiece.Draw(e.Graphics);
            

           // e.Graphics.DrawString("12", new Font("Time New Roman", 10), Brushes.Aquamarine, ToaDo.NguoiDungMayTinh(new Point(0, 0)));

            //pendulum.Draw(e.Graphics);

            //hinhXe.traslationXe(i, j);
            //hinhXe.drawCar(e.Graphics);

            //i = i + 5;
            //j = j + 5;

            //hinhXe.quayBanhXe(30);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            flagTimer = true;
            this.picb_2DArea.Refresh();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            XeProperties x = new XeProperties();
           //  x.Size = this.pnl_ToolBox.Size;
            this.pnl_ToolBox.Controls.Add(x);
            x.BringToFront();
            
        }

        private void picb_2DArea_SizeChanged(object sender, EventArgs e)
        {
            Variables.Globals.sizeOfNewCoor_2D.Width = ReturnEvenNumber(picb_2DArea.Width / Variables.Globals.sizePerPoint.Width);
            Variables.Globals.sizeOfNewCoor_2D.Height = ReturnEvenNumber(picb_2DArea.Height / Variables.Globals.sizePerPoint.Height);
        }

        private void lblX1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
        private void button40_Click(object sender, EventArgs e)
        {
            
        }
       

        private void button39_Click(object sender, EventArgs e)
        {
            //this.timer1.Start();
         

        }


        private void picb_2DArea_MouseMove(object sender, MouseEventArgs e)
        {
            Point p = e.Location;

            lblWidth.Text = picb_2DArea.Width.ToString();
            lblHeight.Text = picb_2DArea.Height.ToString();

            // Tọa độ của chuột khi move
            lblX1.Text = e.Location.X.ToString();
            lblY1.Text = e.Location.Y.ToString();

            // Làm tròn tọa độ trên lưới Pixel
            p = ToaDo.RoundPixel(e.Location);
            lblX2.Text = p.X.ToString();
            lblY2.Text = p.Y.ToString();

            // Chuyển từ tọa độ máy tính về tọa độ người dùng
            p = ToaDo.MayTinhNguoiDung(p);
            lblX3.Text = p.X.ToString();
            lblY3.Text = p.Y.ToString();

            // Chuyển từ tọa độ người dùng về tọa độ máy tính
            p = ToaDo.NguoiDungMayTinh(p);
            lblX4.Text = p.X.ToString();
            lblY4.Text = p.Y.ToString();
        }
       

    }
}
