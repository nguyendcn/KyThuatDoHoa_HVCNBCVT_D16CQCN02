using KyThuatDoHoa_Nhom9.Construct._2DObject;
using KyThuatDoHoa_Nhom9.Construct._3DObject;
using KyThuatDoHoa_Nhom9.UI.UserCtr;
using KyThuatDoHoa_Nhom9.Variables;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace KyThuatDoHoa_Nhom9
{

    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        
            Variables.Globals.hinhTru = new HinhTru(10, -10, 0, 30, 10);
            Variables.Globals.hinhTruProperties = new HinhTruProperties();
            Variables.Globals.hinhTruProperties.Visible = false;

            Variables.Globals.hinhHopChuNhat = new HinhHopChuNhat(0, 0, 0, 10, 10, 10);
            Variables.Globals.hinhHopChuNhatProperties = new HinhHopChuNhatProperties();
            Variables.Globals.hinhHopChuNhatProperties.Visible = false;

            //2D mode is startup;
            Setup_Toolbar(Globals._Mode_current);
            picb_2DArea.Dock = picb_3DArea.Dock = DockStyle.Fill;

            Setup_ToolTips();
            Variables.Globals.flagXe = false;
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
                this.panel9.Visible = true;
                picb_2DArea.BringToFront();

            }
            else if (mode == Constants.Mode._3D)
            {
                this.pnl_Tb_3D.Visible = true;
                if (Variables.Globals._btn_isShowDetails)
                    this.btn_Toolbar.Text = Collection_Strs._3D_shapes;
                this.btn_Toolbar.Image = Image_Res._3D_Model_25px;
                this.picb_3DArea.Dock = DockStyle.Fill;
                this.panel9.Visible = false;
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

        private void btn_Author_Click(object sender, EventArgs e)
        {
            AboutBox1 box1 = new AboutBox1();
            box1.ShowDialog();
        }

        private void btn_Help_Click(object sender, EventArgs e)
        {
            string target = "https://github.com/nguyendcn/KyThuatDoHoa_HVCNBCVT_D16CQCN02";

            try
            {
                System.Diagnostics.Process.Start(target);
            }
            catch
                (
                 System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }

            //MessageBox.Show("https://github.com/nguyendcn/KyThuatDoHoa_HVCNBCVT_D16CQCN02", "Hoi cham", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

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

            if (btn.Tag.Equals("Clock"))
            {
                Variables.Globals.clockProperties = new ClockProperties();

                Variables.Globals.clockProperties.PropertyChanged += ClockProperties_PropertyChanged;
                this.pnl_ToolBox.Controls.Add(Variables.Globals.clockProperties);
                if (Variables.Globals.flagXe == false)
                {
                    Variables.Globals.clockProperties.Refresh();
                }

                Variables.Globals.clockProperties.BringToFront();

                DateTime dt = DateTime.Now;
                Variables.Globals.clock = new Clock(new Point(0, 0), 15, dt);
                Variables.Globals.clock.CurrentDatetime = new DateTime(2019, 05, 19, 12, 30, 15);
                Variables.Globals.clock.Draw(this.picb_2DArea.CreateGraphics());
                Variables.Globals.clock.PropertyChanged += Clock_PropertyChanged;
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
                this.timer1.Start();
                Variables.Globals.xe =  new XeProperties();
                Variables.Globals.flagXe = true;
                Variables.Globals.hinhXe = new HinhXe();
                this.pnl_ToolBox.Controls.Add(Variables.Globals.xe);
                Variables.Globals.xe.BringToFront();
                Variables.Globals.xe.Visible = true;
                Variables.Globals.xe.PropertyChanged += Xe_PropertyChanged;
            }
            else
            {
                MessageBox.Show("The function is unavailable. Please contact the author to get more information.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Timepiece action
        TimepieceProperties timepieceProperties;
        Timepiece timepiece;
        private void Timepiece_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName.Equals("nextStep"))
            {
                this.picb_2DArea.Refresh();
            }
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
            if (e.PropertyName.Equals("currentTime"))
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
            else if(e.PropertyName.Equals("ZoomIn"))
            {
                this.timepiece.Item_clock.R += 5;
            }
            else if(e.PropertyName.Equals("ZoomOut"))
            {
                this.timepiece.Item_clock.R -= 5;
            }
        }
        #endregion

        private void Xe_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName.Equals("ox"))
            {
                Variables.Globals.hinhXe.doiXungQuaOx();
            }
            else if (e.PropertyName.Equals("oy"))
            {
                Variables.Globals.hinhXe.doiXungQuaOy();
            }
            else if (e.PropertyName.Equals("goc"))
            {
                Variables.Globals.hinhXe.doiXungQuaGoc();
            }
            else if (e.PropertyName.Equals("xoa"))
            {
                Variables.Globals.flagXe = false;

            }
           
        }
        #endregion

        #region Clock action

        private void Clock_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (Variables.Globals.flagXe == false)
            {
                this.picb_2DArea.Refresh();
            }
            if (Variables.Globals.clockProperties != null && Variables.Globals.clock != null)
            {
                Variables.Globals.clockProperties.CurrentTime = Variables.Globals.clock.CurrentDatetime;
                Variables.Globals.clockProperties.HHours = Variables.Globals.clock.HHours;
                Variables.Globals.clockProperties.HMinute = Variables.Globals.clock.HMinute;
                Variables.Globals.clockProperties.HSecond = Variables.Globals.clock.HSecond;
            }
        }


        private void ClockProperties_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName.Equals("ZoomIn"))
            {
                Variables.Globals.clock.R += 5;
            }
            else if(e.PropertyName.Equals("ZoomOut"))
            {
                Variables.Globals.clock.R -= 5;
            }
            else if(e.PropertyName.Equals("Dispose"))
            {
                Variables.Globals.clock = null;
                return;
            }
            Variables.Globals.clock.CurrentDatetime = Variables.Globals.clockProperties.CurrentTime;
        }
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
            g.DrawString("Y", new Font("Time New Roman", 10), Brushes.Yellow, ToaDo.NguoiDungMayTinh(new Point(1, 59)));
            g.DrawString("X", new Font("Time New Roman", 10), Brushes.Yellow, ToaDo.NguoiDungMayTinh(new Point(107, -1)));
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

        #endregion

        int dem = 0;
        private void picb_2DArea_Paint(object sender, PaintEventArgs e)
        {
            if (Variables.Globals.flagXe)
            {

                // biểu diễn các hoạt động của xe
                Variables.Globals.hinhXe.PropertyChanged += HinhXe_PropertyChanged;
                Variables.Globals.hinhXe.ToMau(e.Graphics);
                Variables.Globals.hinhXe.drawCar(e.Graphics);

                if (dem <= 30)
                {
                    
                    dem++;
                    // tịnh tiến 5 đơn vị
                    // đi phải qua trái
                    Variables.Globals.hinhXe.traslationXe(5, 0);
                    Variables.Globals.hinhXe.quayBanhXe(30);
                }
                else if (dem <= 60)
                {
                    dem++;
                    //tịnh tiến 5 đơn vị
                    // đi phải qua trái
                    Variables.Globals.hinhXe.traslationXe(0, 5);
                    Variables.Globals.hinhXe.quayBanhXe(30);
                }
                else if (dem <= 90)
                {
                    dem++;
                    // đi từ trên xuống dưới
                    Variables.Globals.hinhXe.traslationXe(-5, 0);
                    Variables.Globals.hinhXe.quayBanhXe(-30);
                }
                else if (dem <= 120)
                {
                    dem++;
                    // đi từ dưới lên trên
                    Variables.Globals.hinhXe.traslationXe(0, -5);
                    Variables.Globals.hinhXe.quayBanhXe(-30);
                }
                else
                {
                    // cập nhật lại
                    dem = 0;
                }
            }

            if (Variables.Globals.clock != null)
            {
                Variables.Globals.clock.Draw(e.Graphics);
            }
            if (timepiece != null)
            {
                timepiece.Draw(e.Graphics);
            }
        }
        private void HinhXe_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            // cập nhật lspoint từ class HinhXe vào class Xeproperties
            Variables.Globals.xe.lsPoint = (Point[])Variables.Globals.hinhXe.LsPoint.Clone();
            Variables.Globals.xe.bankinh = Variables.Globals.hinhXe.BkBanh;
            Variables.Globals.xe.HienThiThongTin(); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.picb_2DArea.Refresh();
        }

        private void picb_2DArea_SizeChanged(object sender, EventArgs e)
        {
            Variables.Globals.sizeOfNewCoor_2D.Width = ReturnEvenNumber(picb_2DArea.Width / Variables.Globals.sizePerPoint.Width);
            Variables.Globals.sizeOfNewCoor_2D.Height = ReturnEvenNumber(picb_2DArea.Height / Variables.Globals.sizePerPoint.Height);
        }

        private void picb_2DArea_MouseMove(object sender, MouseEventArgs e)
        {
            Point p = e.Location;

            lbl_SizeGird.Text = picb_2DArea.ToString();

            p = ToaDo.MayTinhNguoiDung(p);
            lbl_SizeGird.Text = ((picb_2DArea.Size.Width / 5) / 2) + ", " + ((picb_2DArea.Size.Height / 5) / 2);
            lbl_LocationInGird.Text = p.X + ", " + p.Y;
        }

        #region Vẽ trên picb_3DArea sử dụng Cavalier
        private void Picb_3DArea_Paint(object sender, PaintEventArgs e)
        {
            VeLuoi3D(e.Graphics);

            if (Variables.Globals.hinhTruProperties.Visible == true)
            {
                Variables.Globals.hinhTru.Draw(e.Graphics);
                Variables.Globals.hinhTruProperties.Dinh = Variables.Globals.hinhTru.TamDay;
            }
            if (Variables.Globals.hinhHopChuNhatProperties.Visible == true)
            {
                Variables.Globals.hinhHopChuNhat.Draw(e.Graphics);
                Variables.Globals.hinhHopChuNhatProperties.Dinh = Variables.Globals.hinhHopChuNhat.Dinh;
            }
        }

        private void Picb_3DArea_MouseMove(object sender, MouseEventArgs e)
        {
            Point p = e.Location;
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

            // Vẽ trục tọa độ
            pen = new Pen(Color.Black);
            int x = picb_3DArea.Width * 2 / 5,//365,
               y = picb_3DArea.Height / 2; //305,

            g.DrawLine(pen, new Point(x, y), new Point(picb_3DArea.Width, y));         // trục Ox
            g.DrawLine(pen, new Point(x, y), new Point(x, 0));                          // trục Oy
            g.DrawLine(pen, new Point(x, y), new Point(x-y, y + y));                      // trục Oz
            System.Console.WriteLine((x - y) + " " + (y ));

             g.DrawString("Y", new Font("Time New Roman", 10), Brushes.Yellow, new Point(450,55));

            g.DrawString("X", new Font("Time New Roman", 10), Brushes.Yellow, new Point(1082, 330));
            g.DrawString("Z", new Font("Time New Roman", 10), Brushes.Yellow, new Point(88, 673));
        }

        #endregion

        private void HinhTruProperties_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {

            string[] str = e.PropertyName.Split(',');
            int x = Int16.Parse(str[0]),
                y = Int16.Parse(str[1]),
                z = Int16.Parse(str[2]),
                chieuCao = Int16.Parse(str[3]),
                banKinhDay = Int16.Parse(str[4]);

            Variables.Globals.hinhTru = new HinhTru(x, y, z, chieuCao, banKinhDay);

            picb_3DArea.Refresh();
            Variables.Globals.hinhTru.Draw(picb_3DArea.CreateGraphics());
        }
        private void HinhHopChuNhatProperties_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            string[] str = e.PropertyName.Split(',');
            int x = Int16.Parse(str[0]),
                y = Int16.Parse(str[1]),
                z = Int16.Parse(str[2]),
                chieuDai = Int16.Parse(str[3]),
                chieuCao = Int16.Parse(str[4]),
                chieuRong = Int16.Parse(str[5]);

            Variables.Globals.hinhHopChuNhat = new HinhHopChuNhat(x, y, z, chieuDai, chieuCao,chieuRong);

            picb_3DArea.Refresh();
            Variables.Globals.hinhHopChuNhat.Draw(picb_3DArea.CreateGraphics());
        }

        private void BTN3D_MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            if(btn.Tag.Equals("Cylinder"))
            {
                this.pnl_ToolBox.Controls.Add(Variables.Globals.hinhTruProperties);
                Variables.Globals.hinhTruProperties.PropertyChanged += HinhTruProperties_PropertyChanged;
                if (Variables.Globals.flagXe == false)
                {
                    Variables.Globals.hinhTruProperties.Refresh();
                }

                Variables.Globals.hinhTruProperties.BringToFront();
                Variables.Globals.hinhTruProperties.Visible = true;
                Variables.Globals.hinhHopChuNhatProperties.Visible = false;
            }
            else if(btn.Tag.Equals("Cube"))
            {
                this.pnl_ToolBox.Controls.Add(Variables.Globals.hinhHopChuNhatProperties);
                Variables.Globals.hinhHopChuNhatProperties.PropertyChanged += HinhHopChuNhatProperties_PropertyChanged;
                if (Variables.Globals.flagXe == false)
                {
                    Variables.Globals.hinhHopChuNhatProperties.Refresh();
                }

                Variables.Globals.hinhHopChuNhatProperties.BringToFront();
                Variables.Globals.hinhHopChuNhatProperties.Visible = true;
                Variables.Globals.hinhTruProperties.Visible = false;
            }
        }
    }
}

