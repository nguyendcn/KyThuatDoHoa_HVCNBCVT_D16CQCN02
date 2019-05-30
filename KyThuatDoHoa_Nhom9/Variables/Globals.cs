using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KyThuatDoHoa_Nhom9.Construct._2DObject;
using KyThuatDoHoa_Nhom9.Construct._3DObject;
using KyThuatDoHoa_Nhom9.UI.UserCtr;
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
        /// Kích thước mỗi điểm trong hệ tòa dộ người dùng.
        /// </summary>
        public static System.Drawing.Size sizePerPoint = new System.Drawing.Size(5, 5);

        /// <summary>
        /// Size của hệ tòa độ người dùng khi chuyển từ tọa độ máy sang. Hệ tòa độ 2D.
        /// </summary>
        public static System.Drawing.Size sizeOfNewCoor_2D;
        /// <summary>
        /// Size của hệ tòa độ người dùng khi chuyển từ tọa độ máy sang. Hệ tòa độ 3D.
        /// </summary>
        public static System.Drawing.Size sizeOfNewCoor_3D;

        /// <summary>
        /// Chua toan bo hinh tren man hinh lap viec 2D.
        /// </summary>
        public static Stack<Object> sObject_2D = new Stack<object>();

        public static HinhXe hinhXe;
        public static HinhTru hinhTru;
        public static XeProperties xe;
        public static HinhTruProperties hinhTruProperties;
        public static HinhHopChuNhatProperties hinhHopChuNhatProperties;
        public static HinhHopChuNhat hinhHopChuNhat;
        public static bool flagXe;
        public static Clock clock;
        public static ClockProperties clockProperties;
    }
}
