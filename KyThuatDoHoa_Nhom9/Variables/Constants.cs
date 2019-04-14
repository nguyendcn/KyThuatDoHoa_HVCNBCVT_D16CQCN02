using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyThuatDoHoa_Nhom9.Variables
{
    /// <summary>
    /// Nơi lưu toàn bộ hằng hoặc các kiểu định nghĩa 
    /// </summary>
    public class Constants
    {
        /// <summary>
        /// Chế độ thao làm việc
        /// </summary>
        public enum Mode { _3D, _2D };

        /// <summary>
        /// Màu background button khi focus
        /// </summary>
        private static Color background_Btn_Focus = Color.AliceBlue;

        public static Color Background_Btn_Focus { get => background_Btn_Focus; }
    }
}
