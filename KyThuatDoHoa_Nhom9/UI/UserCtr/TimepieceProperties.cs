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
        private Point mainLocation;
        private ClockProperties _clockProperties;
        private bool dispose;

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

        public Point MainLocation { get => mainLocation;
            set
            {
                if(value != this.mainLocation)
                {
                    this.mainLocation = value;
                    OnPropertyChanged("mainLocation");
                }
                lbl_Location.Text = value.ToString();
            }
        }

        public ClockProperties ClockProperties { get => _clockProperties; set => _clockProperties = value; }
        public bool DisposeObject { set { OnPropertyChanged("dispose"); } }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }

        private void btn_Destroy_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.DisposeObject = true;
        }

        private void btn_ChangeLocation_Click(object sender, EventArgs e)
        {
            string[] arr = txt_Location.Text.Split(',');
            this.MainLocation = new Point(int.Parse(arr[0]), int.Parse(arr[1]));
        }

        private void btn_Hide_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
