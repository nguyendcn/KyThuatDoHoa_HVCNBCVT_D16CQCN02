using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KyThuatDoHoa_Nhom9.Variables;

namespace KyThuatDoHoa_Nhom9.Variables
{
    /// <summary>
    /// Nơi lưu toàn bộ biến toàn cục
    /// </summary>
    public static class Globals
    {
        /// <summary>
        /// Mạc định là chế độ làm việc là 2D
        /// </summary>
        public static Constants.Mode _Mode_current = Constants.Mode._2D;

        /// <summary>
        /// Chế độ hiển thị các button trong pnl_Mode kèm theo text hay không. Mạc định là có
        /// </summary>
        public static bool _btn_isShowDetails = true;

        public static int i = 0;

        /// <summary>
        /// Chiều rộng của hệ tọa độ người dùng 
        /// </summary>
        public static int widthPanel = 0;

        /// <summary>
        /// Chiều cao của hệ tọa độ người dùng
        /// </summary>
        public static int heightPanel = 0;
    }
}
