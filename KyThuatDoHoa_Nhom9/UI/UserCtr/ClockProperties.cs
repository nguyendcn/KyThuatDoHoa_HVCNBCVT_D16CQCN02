using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KyThuatDoHoa_Nhom9.Construct._2DObject;

namespace KyThuatDoHoa_Nhom9.UI.UserCtr
{
    public partial class ClockProperties : UserControl, INotifyPropertyChanged
    {
        private DateTime currenTime;
        private Line _hHours, _hMinute, _hSecond;

        public ClockProperties(Size s)
        {
            InitializeComponent();
            //this.Size = s;
            Boder.Text = this.Size.ToString();
        }

        public DateTime CurrenTime{ get => currenTime;
            set
            {
                currenTime = value;
                lbl_TimeCurrent.Text = value.ToString();
                //btn_GetTimeSystem.PerformClick();
            }
        }
        public Line HHours { get => _hHours;
            set
            {
                this._hHours = value;
                lbl_hHoursA.Text = value.A.ToString();
                lbl_hHoursB.Text = value.B.ToString();
            }
        }
        public Line HMinute { get => _hMinute;
            set
            {
                this._hMinute = value;
                lbl_hMinuteA.Text = value.A.ToString();
                lbl_hMinuteB.Text = value.B.ToString();
            }
        }
        public Line HSecond { get => _hSecond;
            set
            {
                this._hSecond = value;
                lbl_hSecondA.Text = value.A.ToString();
                lbl_hSecondB.Text = value.B.ToString();
            }
        }

        private void Btn_GetTimeSystem_Click(object sender, EventArgs e)
        {
            this.CurrenTime = DateTime.Now;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
            {
                
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }
    }
}
