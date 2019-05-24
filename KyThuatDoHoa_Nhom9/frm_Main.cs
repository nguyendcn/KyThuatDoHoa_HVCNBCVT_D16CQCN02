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
using KyThuatDoHoa_Nhom9.Construct._3DObject;
using KyThuatDoHoa_Nhom9.UI.UserCtr;

namespace KyThuatDoHoa_Nhom9
{

    public partial class frm_Main : Form
    {

        HinhXe hinhXe;
        Pendulum pendulum;
        XeProperties xe;
        bool flagXe;
        Clock clock;
        ClockProperties clockProperties;

        Point s = new Point(3, 3);
        Point ep = new Point(15, 15);
        Clock cl;
        Timer tm = new Timer
        {
            Interval = 300
        };

        HinhTron ht;

        public frm_Main()
        {
            InitializeComponent();


            hinhXe = new HinhXe();
            xe = new XeProperties();
            // Tạo quả lắc theo kích thước cho trước
            pendulum = new Pendulum(new Point(100, 20), new Point(400, 220));
            pendulum.SetAlpha(-3); // set góc quay alpha 
            pendulum.PropertyChanged += Pendulum_PropertyChanged;

            //flagTimer = false;
            //hinhXe = new HinhXe();

            //// Tạo quả lắc theo kích thước cho trước
            //pendulum = new Pendulum(new Point(100, 20), new Point(400,220));
            //pendulum.SetAlpha(-3); // set góc quay alpha 


            //2D mode is startup;
            Setup_Toolbar(Globals._Mode_current);
            picb_2DArea.Dock = picb_3DArea.Dock = DockStyle.Fill;

            Setup_ToolTips();
            flagXe = false;
        }

        private void Pendulum_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (flagXe == false)
            {
                this.picb_2DArea.Refresh();
            }

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
            foreach (Control ctr in this.grb_2DShapes.Controls)
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
                if (Variables.Globals._btn_isShowDetails)
                    this.btn_Toolbar.Text = Collection_Strs._2D_shapes;
                this.btn_Toolbar.Image = Image_Res._2D_Model_25px;
                this.picb_2DArea.Dock = DockStyle.Fill;
                picb_2DArea.BringToFront();

            }
            else if (mode == Constants.Mode._3D)
            {
                this.pnl_Tb_3D.Visible = true;
                if (Variables.Globals._btn_isShowDetails)
                    this.btn_Toolbar.Text = Collection_Strs._3D_shapes;
                this.btn_Toolbar.Image = Image_Res._3D_Model_25px;
                this.picb_3DArea.Dock = DockStyle.Fill;
                picb_3DArea.BringToFront();
            }

        }

        /// <summary>
        /// Hiển thị text của button hay không
        /// </summary>
        /// <param name="isShow">Used to indicate text.</param>
        private void SetTextForButton(bool isShow)
        {
            if (isShow)
            {
                //set btn_Menu
                btn_Menu.Text = Collection_Strs._Menu;
                btn_Menu.ImageAlign = ContentAlignment.TopCenter;

                //set btn_Author
                btn_Author.Text = Collection_Strs._Author;
                btn_Author.ImageAlign = ContentAlignment.TopCenter;

                //set btn_Help
                btn_Help.Text = Collection_Strs._Help;
                btn_Help.ImageAlign = ContentAlignment.TopCenter;

                //set btn_Toolbar theo mode hien tai
                btn_Toolbar.ImageAlign = ContentAlignment.TopCenter;
                if (Globals._Mode_current == Constants.Mode._2D)
                {
                    btn_Toolbar.Text = Collection_Strs._2D_shapes;
                }
                else if (Globals._Mode_current == Constants.Mode._3D)
                {
                    btn_Toolbar.Text = Collection_Strs._3D_shapes;
                }
            }
            else
            {
                foreach (Control ctr in this.pnl_Mode.Controls)
                {
                    if (ctr is Button)
                    {
                        Button btn = ctr as Button;
                        btn.Text = "";
                        btn.ImageAlign = ContentAlignment.MiddleCenter;

                    }
                }
                btn_Author.Text = "";
                btn_Author.ImageAlign = ContentAlignment.MiddleCenter;

                btn_Help.Text = "";
                btn_Help.ImageAlign = ContentAlignment.MiddleCenter;
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
            if (btn.Tag.Equals("Circle"))
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
            else if (btn.Tag.Equals("Clock"))
            {
                clockProperties = new ClockProperties();

                clockProperties.PropertyChanged += ClockProperties_PropertyChanged;
                this.pnl_ToolBox.Controls.Add(clockProperties);
                if (flagXe == false)
                {
                    clockProperties.Refresh();
                }

                clockProperties.BringToFront();

                DateTime dt = DateTime.Now;
                clock = new Clock(new Point(0, 0), 15, dt);
                clock.CurrentDatetime = new DateTime(2019, 05, 19, 12, 30, 15);
                clock.Draw(this.picb_2DArea.CreateGraphics());
                clock.PropertyChanged += Clock_PropertyChanged;
            }
            else if (btn.Tag.Equals("TimePiece"))
            {
                timepieceProperties = new TimepieceProperties();
                timepieceProperties.PropertyChanged += TimepieceProperties_PropertyChanged;
                this.pnl_ToolBox.Controls.Add(timepieceProperties);
                timepieceProperties.BringToFront();

                timepiece = new Timepiece();
                timepiece.PropertyChanged += Timepiece_PropertyChanged;
            }
            else if (btn.Tag.Equals("Car"))
            {
                flagXe = true;
                this.pnl_ToolBox.Controls.Add(xe);
                xe.BringToFront();
                xe.Visible = true;
                this.timer1.Start();
                //this.picb_2DArea.Refresh();

                //if (flagXe)
                //{

                //    // biểu diễn các hoạt động của xe
                //    hinhXe.PropertyChanged += HinhXe_PropertyChanged;
                //    hinhXe.ToMau(e.Graphics);
                //    hinhXe.drawCar(e.Graphics);

                //    if (dem <= 30)
                //    {
                //        dem++;
                //        // tịnh tiến 5 đơn vị
                //        // đi phải qua trái
                //        hinhXe.traslationXe(5, 0);
                //        hinhXe.quayBanhXe(30);


                //    }
                //    else if (dem <= 60)
                //    {
                //        dem++;
                //        //tịnh tiến 5 đơn vị
                //        // đi phải qua trái
                //        hinhXe.traslationXe(0, 5);
                //        hinhXe.quayBanhXe(30);
                //    }
                //    else if (dem <= 90)
                //    {
                //        dem++;
                //        // đi từ trên xuống dưới
                //        hinhXe.traslationXe(-5, 0);
                //        hinhXe.quayBanhXe(-30);
                //    }
                //    else if (dem <= 120)
                //    {
                //        dem++;
                //        // đi từ dưới lên trên
                //        hinhXe.traslationXe(0, -5);
                //        hinhXe.quayBanhXe(-30);
                //    }else
                //    {
                //        // cập nhật lại
                //        dem = 0;
                //    }
                //}
            }

        }

        #region Timepiece action
        TimepieceProperties timepieceProperties;
        Timepiece timepiece;
        private void Timepiece_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName.Equals("location"))
            {
                timepieceProperties.MainLocation = timepiece.Location;
            }
            else if (e.PropertyName.Equals("item_clock"))
            {
                this.picb_2DArea.Refresh();
                if (timepieceProperties != null && timepiece != null)
                {
                    timepieceProperties.ClockProperties.CurrentTime = timepiece.Item_clock.CurrentDatetime;
                    timepieceProperties.ClockProperties.HHours = timepiece.Item_clock.HHours;
                    timepieceProperties.ClockProperties.HMinute = timepiece.Item_clock.HMinute;
                    timepieceProperties.ClockProperties.HSecond = timepiece.Item_clock.HSecond;
                }
            }
        }
        private void TimepieceProperties_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName.Equals("timeChanged"))
            {
                timepiece.Item_clock.CurrentDatetime = timepieceProperties.ClockProperties.CurrentTime;
            }
            else if (e.PropertyName.Equals("mainLocation"))
            {
                timepiece.Location = timepieceProperties.MainLocation;
            }
            else if (e.PropertyName.Equals("dispose"))
            {
                this.timepiece = null;
                this.timepieceProperties = null;
            }
        }
        #endregion

        #region Clock action
        //Clock clock;
        //ClockProperties clockProperties;
        private void Clock_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {

            if (flagXe == false)
            {
                this.picb_2DArea.Refresh();
            }
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

        private void CircleProperties_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (ht != null)
            {
                CircleProperties cp = (sender as CircleProperties);
                if (e.PropertyName.Equals("radius"))
                    ht.Radius = cp.Radius;
                else if (e.PropertyName.Equals("coorOriginal"))
                {
                    ht.Point = ToaDo.NguoiDungMayTinh(cp.CoorOriginal);
                }
            }
        }

        private void Ht_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (flagXe == false)
            {
                this.picb_2DArea.Refresh();
            }

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
            //this.Invalidate();
            if (flagXe == false)
            {
                this.picb_2DArea.Refresh();
            }
        }

        int dem = 0;
        private void picb_2DArea_Paint(object sender, PaintEventArgs e)
        {
            //if (test)
            //{
            //    line.Draw(e.Graphics);
            //    line.Rotate(new Point(550, 320), 20);
            //    hinhChuNhat.Draw(e.Graphics);
            //    hinhChuNhat.Rotate(new Point(550, 320), 90);
            //    cl.CurrentDatetime = DateTime.Now;
            //    cl.Draw(e.Graphics);
            //}

            //if (clock != null)
            //    clock.Draw(e.Graphics);

            //pendulum.Draw(e.Graphics);

            // Vẽ tam giác
            Point point = new Point(0, 0);

            HinhTamGiac hinhTamGiac = new HinhTamGiac(ToaDo.NguoiDungMayTinh(new Point(0, 0)),
                                                      ToaDo.NguoiDungMayTinh(new Point(-10, -10)),
                                                      ToaDo.NguoiDungMayTinh(new Point(10, -10)));
            hinhTamGiac.Draw(e.Graphics);

            if (flagXe)
            {

                // biểu diễn các hoạt động của xe
                hinhXe.PropertyChanged += HinhXe_PropertyChanged;
                hinhXe.ToMau(e.Graphics);
                hinhXe.drawCar(e.Graphics);

                if (dem <= 30)
                {
                    dem++;
                    // tịnh tiến 5 đơn vị
                    // đi phải qua trái
                    hinhXe.traslationXe(5, 0);
                    hinhXe.quayBanhXe(30);


                }
                else if (dem <= 60)
                {
                    dem++;
                    //tịnh tiến 5 đơn vị
                    // đi phải qua trái
                    hinhXe.traslationXe(0, 5);
                    hinhXe.quayBanhXe(30);
                }
                else if (dem <= 90)
                {
                    dem++;
                    // đi từ trên xuống dưới
                    hinhXe.traslationXe(-5, 0);
                    hinhXe.quayBanhXe(-30);
                }
                else if (dem <= 120)
                {
                    dem++;
                    // đi từ dưới lên trên
                    hinhXe.traslationXe(0, -5);
                    hinhXe.quayBanhXe(-30);
                }
                else
                {
                    // cập nhật lại
                    dem = 0;
                }
            }

            if (clock != null)
            {
                clock.Draw(e.Graphics);
            }
            else if (timepiece != null)
            {
                timepiece.Draw(e.Graphics);
            }

            //pendulum.Draw(e.Graphics);

        }

        private void HinhXe_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {

            // cập nhật lspoint từ class HinhXe vào class Xeproperties
            xe.lsPoint = (Point[])hinhXe.LsPoint.Clone();
            xe.bankinh = hinhXe.BkBanh;
            xe.HienThiThongTin();
             
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            this.picb_2DArea.Refresh();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (flagXe == false)
            {
                this.timer1.Start();

            }
            // bật chế độ của xe
            flagXe = true;
            this.pnl_ToolBox.Controls.Add(xe);
            xe.BringToFront();
            xe.Visible = true;



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
            this.timer1.Start();
        }


        private void picb_2DArea_MouseMove(object sender, MouseEventArgs e)
        {
            Point p = e.Location;


            lbl_SizeGird.Text = picb_2DArea.ToString();

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

            lbl_SizeGird.Text = ((picb_2DArea.Size.Width / 5) / 2) + ", " + ((picb_2DArea.Size.Height / 5) / 2);
            lbl_LocationInGird.Text = p.X + ", " + p.Y;

            // Chuyển từ tọa độ người dùng về tọa độ máy tính
            p = ToaDo.NguoiDungMayTinh(p);
            lblX4.Text = p.X.ToString();
            lblY4.Text = p.Y.ToString();

        }
        #region Vẽ trên picb_3DArea sử dụng Cavalier
        private void Picb_3DArea_Paint(object sender, PaintEventArgs e)
        {
            VeLuoi3D(e.Graphics);

            //HinhHopChuNhat hinhHopChuNhat = new HinhHopChuNhat(-10, -20, 0, 20, 20, 20);
            //hinhHopChuNhat.Draw(e.Graphics);


            HinhTru hinhTru = new HinhTru(10, -10, 0, 30, 40);
            hinhTru.Draw(e.Graphics);
            hinhTru.DrawElip(e.Graphics);

        }

        private void Picb_3DArea_MouseMove(object sender, MouseEventArgs e)
        {
            Point p = e.Location;

            //lblWidth.Text = picb_3DArea.Width.ToString();
            //lblHeight.Text = picb_3DArea.Height.ToString();
            lblWidth.Text = Variables.Globals.sizeOfNewCoor_3D.Width.ToString();
            lblHeight.Text = Variables.Globals.sizeOfNewCoor_3D.Height.ToString();

            // Tọa độ của chuột khi move
            lblX1.Text = e.Location.X.ToString();
            lblY1.Text = e.Location.Y.ToString();

            // Làm tròn tọa độ trên lưới Pixel
            p = ToaDo.RoundPixel(e.Location);
            lblX2.Text = p.X.ToString();
            lblY2.Text = p.Y.ToString();

            // Chuyển từ tọa độ máy tính về tọa độ người dùng
            p = ToaDo.MayTinhNguoiDung_3D(p);
            lblX3.Text = p.X.ToString();
            lblY3.Text = p.Y.ToString();

        }

        private void Picb_3DArea_SizeChanged(object sender, EventArgs e)
        {
            Variables.Globals.sizeOfNewCoor_3D.Width = ReturnEvenNumber(picb_3DArea.Width / Variables.Globals.sizePerPoint.Width);
            Variables.Globals.sizeOfNewCoor_3D.Height = ReturnEvenNumber(picb_3DArea.Height / Variables.Globals.sizePerPoint.Height);

            picb_3DArea.Width = Variables.Globals.sizeOfNewCoor_3D.Width * 5;
            picb_3DArea.Height = Variables.Globals.sizeOfNewCoor_3D.Height * 5;
        }

        private void Picb_3DArea_MouseClick(object sender, MouseEventArgs e)
        {
            ToaDo.HienThi(e.Location, picb_3DArea.CreateGraphics(), Color.Black);
        }

        public void VeLuoi3D(Graphics g)
        {
            Pen pen = new Pen(Color.Black);


            // Vẽ lưới 
            for (int i = 0; i < picb_3DArea.Width; i += 5)
            {
                g.DrawLine(pen, new Point(i, 0), new Point(i, picb_3DArea.Height));
            }
            for (int i = 0; i < picb_3DArea.Height; i += 5)
            {
                g.DrawLine(pen, new Point(0, i), new Point(picb_3DArea.Width, i));
            }

            // Vẽ trục tọa độ
            pen = new Pen(Color.Red);
            int x = picb_3DArea.Width * 2 / 5,//365,
               y = picb_3DArea.Height / 2; //305,

            g.DrawLine(pen, new Point(x, y), new Point(picb_3DArea.Width, y));         // trục Ox
            g.DrawLine(pen, new Point(x, y), new Point(x, 0));                          // trục Oy
            g.DrawLine(pen, new Point(x, y), new Point(x - y, y + y));                      // trục Oz
            System.Console.WriteLine((x - y) + " " + (y));
            ;
        }



        #endregion

        private void btn_Author_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nhom 9 nha", "Hahahah", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nhom 9 nha", "Hoi cham", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button41_Click(object sender, EventArgs e)
       

        private void zoom_Click_1(object sender, EventArgs e)
        {
            hinhXe.doiXungQuaTruc();
        }

        private void button41_Click_1(object sender, EventArgs e)
        {
            hinhXe.doiXungQuaOx();
        }

        private void button42_Click_1(object sender, EventArgs e)
        {
            hinhXe.doiXungQuaOy();
        }
    }

    
}

