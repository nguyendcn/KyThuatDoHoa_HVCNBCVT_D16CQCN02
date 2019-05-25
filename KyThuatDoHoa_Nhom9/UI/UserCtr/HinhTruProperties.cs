using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KyThuatDoHoa_Nhom9.Construct._3DObject;

namespace KyThuatDoHoa_Nhom9.UI.UserCtr
{
    public partial class HinhTruProperties : UserControl, INotifyPropertyChanged
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

                }
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public HinhTruProperties()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            int x = Int16.Parse(txtTamX.Text),
                y = Int16.Parse(txtTamY.Text),
                z = Int16.Parse(txtTamZ.Text),
                chieuCao = Int16.Parse(txtChieuCao.Text),
                banKinhDay = Int16.Parse(txtBanKinh.Text);

            OnPropertyChanged(x + "," + y + "," + z + "," + chieuCao + "," + banKinhDay);
          
        }
        protected void OnPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void HinhTruProperties_Load(object sender, EventArgs e)
        {

        }

        private void txtTamY_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTamX_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTamZ_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtChieuCao_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBanKinh_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
