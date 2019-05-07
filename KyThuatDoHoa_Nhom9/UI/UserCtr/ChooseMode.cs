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
    /// <summary>
    /// Custom control. Show and choose new mode.
    /// </summary>
    public partial class ChooseMode : UserControl
    {
        /// <summary>
        /// Construction with mode current.
        /// </summary>
        /// <param name="_mode">Used to set focus button of this mode</param>
        public ChooseMode(Variables.Constants.Mode _mode)
        {
            InitializeComponent();

            this.Return_Mode = _mode;
            SetFocusButton(_mode);

            if (mf == null)
            {
                mf = new MyFilter();
                Application.AddMessageFilter(mf);
            }

            mf.MouseDown += new MyFilter.LeftButtonDown(mf_MouseDown);
            mf.KeyUp += new MyFilter.KeyPressUp(mf_KeyUp);

        }

        #region Property

        /// <summary>
        /// Get or set Mode current
        /// </summary>
        public Variables.Constants.Mode Return_Mode { get; set; } // trả về mode khi click bnt_2d hoặc btn_3d

        private static MyFilter mf = null;

        #endregion

        #region Event

        private void mf_KeyUp(IntPtr target)
        {
            if (!target.Equals(IntPtr.Zero))
            {
                if (this.Visible)
                {
                    if (!IsTargetMine(target))
                    {
                        this.Visible = false;

                        Application.RemoveMessageFilter(mf);
                        mf = null;
                        this.Dispose();
                    }
                }
            }
        }

        private void mf_MouseDown()
        {
            if (this.Visible)
            {
                if (!this.RectangleToScreen(this.ClientRectangle).Contains(Cursor.Position))
                {
                    this.Visible = false;
                    Application.RemoveMessageFilter(mf);
                    mf = null;
                    this.DestroyHandle();
                    this.Dispose();
                }
            }
        }
        #endregion

        #region Function

        /// <summary>
        /// Select button of mode current
        /// </summary>
        /// <param name="_mode">Used to focus button</param>
        private void SetFocusButton(Variables.Constants.Mode _mode)
        {
            if(_mode == Variables.Constants.Mode._2D)
            {
                this.btn_2D.BackColor = Variables.Constants.Background_Btn_Focus;
                this.btn_2D.Focus();
            }
            else if(_mode == Variables.Constants.Mode._3D)
            {
                this.btn_3D.BackColor = Variables.Constants.Background_Btn_Focus;
                this.btn_3D.Focus();
            }
        }

        private bool IsTargetMine(IntPtr target)
        {
            return IsTargetMine(this, target);
        }

        private bool IsTargetMine(Control ctl, IntPtr target)
        {
            foreach (Control child in ctl.Controls)
            {
                if (child.Handle.Equals(target))
                {
                    return true;
                }
                else if (child.HasChildren)
                {
                    bool result = IsTargetMine(child, target);
                    if (result)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        #endregion

        #region Handl event change mode

        private void btn_2D_Click(object sender, EventArgs e)
        {
            this.Return_Mode = Variables.Constants.Mode._2D;
            Console.WriteLine("2D");
            this.Visible = false;
            this.Dispose();
        }

        private void btn_3D_Click(object sender, EventArgs e)
        {
            this.Return_Mode = Variables.Constants.Mode._3D;
            Console.WriteLine("3D");
            this.Visible = false;
            this.Dispose();
        }
        #endregion
    }

    public class MyFilter : IMessageFilter
    {

        public delegate void LeftButtonDown();
        public event LeftButtonDown MouseDown;

        public delegate void KeyPressUp(IntPtr target);
        public event KeyPressUp KeyUp;

        private const int WM_KEYUP = 0x101;
        private const int WM_LBUTTONDOWN = 0x201;

        bool IMessageFilter.PreFilterMessage(ref Message m)
        {
            switch (m.Msg)
            {
                // raise our KeyUp() event whenever a key is released in our app
                case WM_KEYUP:
                    if (KeyUp != null)
                    {
                        KeyUp(m.HWnd);
                    }
                    break;

                // raise our MouseDown() event whenever the mouse is left clicked somewhere in our app
                case WM_LBUTTONDOWN:
                    if (MouseDown != null)
                    {
                        MouseDown();
                    }
                    break;
            }
            return false;
        }

    }
}
