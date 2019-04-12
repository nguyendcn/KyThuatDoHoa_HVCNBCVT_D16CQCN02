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
    public partial class frm_ChangeMode : Form
    {
        public frm_ChangeMode()
        {
            InitializeComponent();
            this.LostFocus += Frm_ChangeMode_LostFocus;
        }


        public string ReturnText { get; set; }

        private void Frm_ChangeMode_LostFocus(object sender, EventArgs e)
        {
            frm_ChangeMode fr = sender as frm_ChangeMode;
            fr.Close();
            fr.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ReturnText = Collection_Strs._2D_shapes;
            this.Visible = false;
            this.Close();
            this.Dispose();
        }
    }
}
