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
    public partial class TimepieceProperties : UserControl, INotifyPropertyChanged
    {
        private DateTime currentTime;
        private Point mainLocation;
        private ClockProperties _clockProperties;

        public TimepieceProperties()
        {
            InitializeComponent();
            ClockProperties = new ClockProperties();
            ClockProperties.PropertyChanged += ClockProperties_PropertyChanged;
            this.panel2.Controls.Add(ClockProperties);
        }

        private void ClockProperties_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            OnPropertyChanged("timeChanged");
        }

        public DateTime CurrentTime { get => currentTime;
            set
            {
                if(value != this.currentTime)
                {
                    this.currentTime = value;
                    
                    ClockProperties.CurrentTime = value;
                    OnPropertyChanged("currentTime");
                }
            }
        }
        public Point MainLocation { get => mainLocation;
            set
            {
                if(value != this.mainLocation)
                {
                    this.mainLocation = value;
                    OnPropertyChanged("mainLocation");
                }
            }
        }

        public ClockProperties ClockProperties { get => _clockProperties; set => _clockProperties = value; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }

        private void btn_GetTimeSystem_Click(object sender, EventArgs e)
        {
            this.CurrentTime = DateTime.Now;
        }

        private void btn_ChangeTime_Click(object sender, EventArgs e)
        {
            this.CurrentTime = new DateTime(this.CurrentTime.Year, this.CurrentTime.Month, this.CurrentTime.Day,
                                            (int)this.numud_Hours.Value, (int)this.numud_Minute.Value, (int)this.numud_Second.Value);
        }
    }
}
