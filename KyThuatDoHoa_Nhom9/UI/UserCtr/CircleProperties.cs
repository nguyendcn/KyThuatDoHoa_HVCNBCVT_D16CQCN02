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
            txt_CoorOriginal.Text = coorOriginal.X + ", " + coorOriginal.Y; 
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
                else if(PropertyName.Equals("coorOriginal"))
                {
                    txt_CoorOriginal.Text = coorOriginal.X + "," + coorOriginal.Y;
                }
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }

        private void Txt_TextChanged(object sender, EventArgs e)
        {
            this.Radius = Convert.ToInt32(txt_Radius.Text);
        }

        private void txt_CoorOriginal_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txt_CoorOriginal_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '-' || e.KeyChar == ',')
            //{
            //    e.Handled = false;
            //}
            //else if((Keys)e.KeyChar == Keys.Enter)
            //{

            //}
            //else
            //{
            //    e.Handled = true;
            //}
        }

        private void txt_CoorOriginal_TextChanged(object sender, EventArgs e)
        {
            string[] str = txt_CoorOriginal.Text.Split(',');
            this.CoorOriginal = new Point(Convert.ToInt32(str[0]), Convert.ToInt32(str[1]));
        }
    }
}
