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
    public partial class CircleProperties : UserControl , INotifyPropertyChanged
    {
        private Point coorOriginal;
        private int radius = 0;
        public CircleProperties()
        {
            InitializeComponent();
            this.AutoScroll = true;
            txt_CoorOriginalX.Text = coorOriginal.X.ToString();
            txt_CoorOriginalY.Text = coorOriginal.Y.ToString();
            txt_Radius.Text = radius.ToString();
        }

        public Point CoorOriginal { get => coorOriginal;
            set
            {
                if(value != coorOriginal)
                {
                    coorOriginal = value;
                    OnPropertyChanged("coorOriginal");
                }
            }
        }
        public int Radius { get => radius;
            set
            {
                if(radius != value)
                {
                    radius = value;
                    OnPropertyChanged("radius");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
            {
                if(PropertyName.Equals("radius"))
                {
                    txt_Radius.Text = radius.ToString();
                }
                else
                {
                    txt_CoorOriginalX.Text = CoorOriginal.X.ToString();
                    txt_CoorOriginalY.Text = CoorOriginal.Y.ToString();
                }
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }

        private void Txt_TextChanged(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txt_CoorOriginalX.Text),
                y = Convert.ToInt32(txt_CoorOriginalY.Text);
            this.CoorOriginal = new Point( x, y );

            this.Radius = Convert.ToInt32(txt_Radius.Text);
        }

    }
}
