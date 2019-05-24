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
                if (value != _dinh)
                {

                }
                    
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public HinhTruProperties()
        {
            InitializeComponent();
        }

        public void HienThi()
        {
            for(int i = 0; i < 3; i++)
            {
                txtDinhA.Text = this.Dinh[0,i].ToString();
                txtDinhB.Text = this.Dinh[1, i].ToString();
                txtDinhC.Text = this.Dinh[2, i].ToString();
                txtDinhD.Text = this.Dinh[3, i].ToString();
                txtDinhE.Text = this.Dinh[4, i].ToString();
                txtDinhF.Text = this.Dinh[5, i].ToString();
            }
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {

           // OnPropertyChanged()
        }
        protected void OnPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }

        private void HinhTruProperties_Load(object sender, EventArgs e)
        {

        }
    }
}
