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
    public partial class HinhHopChuNhatProperties : UserControl, INotifyPropertyChanged
    {
        private int[,] _dinh;
        public int[,] Dinh
        {
            get => _dinh;
            set
            {
                if (value != null)
                {
                    _dinh = value;
                    txtDinhA.Text = _dinh[0, 0] + "," + _dinh[0, 1] + "," + _dinh[0, 2];
                    txtDinhB.Text = value[1, 0].ToString() + "," + value[1, 1].ToString() + "," + value[1, 2].ToString();
                    txtDinhC.Text = value[2, 0].ToString() + "," + value[2, 1].ToString() + "," + value[2, 2].ToString();
                    txtDinhD.Text = value[3, 0].ToString() + "," + value[3, 1].ToString() + "," + value[3, 2].ToString();
                    txtDinhE.Text = value[4, 0].ToString() + "," + value[4, 1].ToString() + "," + value[4, 2].ToString();
                    txtDinhF.Text = value[5, 0].ToString() + "," + value[5, 1].ToString() + "," + value[5, 2].ToString();
                    txtDinhG.Text = value[6, 0].ToString() + "," + value[6, 1].ToString() + "," + value[6, 2].ToString();
                    txtDinhH.Text = value[7, 0].ToString() + "," + value[7, 1].ToString() + "," + value[7, 2].ToString();

                }
            }
        }
        public HinhHopChuNhatProperties()
        {
            InitializeComponent();
        }
        protected void OnPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            int x = Int16.Parse(txtTamX.Text),
                y = Int16.Parse(txtTamY.Text),
                z = Int16.Parse(txtTamZ.Text),
                chieuDai = Int16.Parse(txtChieuDai.Text),
                chieuCao = Int16.Parse(txtChieuCao.Text),
                chieuRong = Int16.Parse(txtChieuRong.Text);

            OnPropertyChanged(x + "," + y + "," + z + "," + chieuDai + "," + chieuCao + ","+ chieuRong);
        }
    }
}
