using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KyThuatDoHoa_Nhom9.Variables;

namespace KyThuatDoHoa_Nhom9.UI
{
    /// <summary>
    /// Form chứa các button cho phép chọn chế độ làm vệc như: 2D, 3D
    /// </summary>
    public partial class frm_ChangeMode : Form
    {
        public frm_ChangeMode(Constants.Mode m_current)
        {
            InitializeComponent();
            this.LostFocus += Frm_ChangeMode_LostFocus; //them su kien

            Set_FocusButton(m_current); //focus vào button mode hiện tại
        }

        public Constants.Mode Return_Mode { get; set; }

        #region Event
        private void Frm_ChangeMode_LostFocus(object sender, EventArgs e) // su kien click ngoai form thi form se tu dong tat
        {
            frm_ChangeMode fr = sender as frm_ChangeMode;

            fr.Close();
            fr.Dispose();
        }

        #endregion

        private void Set_FocusButton(Constants.Mode mode)
        {
            if (mode == Constants.Mode._2D)
            {
                btn_2D.BackColor = Constants.Background_Btn_Focus;
            }
            else if (mode == Constants.Mode._3D)
            {
                btn_3D.BackColor = Constants.Background_Btn_Focus;
            }
        }

        #region Xử lý thay đổi chế độ làm việc
        private void btn_2D_Click(object sender, EventArgs e)
        {
            this.Return_Mode = Constants.Mode._2D; // thay doi che do lam viec thanh 2D

            this.Visible = false;
            this.Close();
            this.Dispose();
        }

        private void btn_3D_Click(object sender, EventArgs e)
        {
            this.Return_Mode = Constants.Mode._3D; // thay doi che do lam viec thanh 2D

            //tư dộng hủy form sau khi return
            this.Visible = false;
            this.Close();
            this.Dispose();
        }

        #endregion


    }
}
