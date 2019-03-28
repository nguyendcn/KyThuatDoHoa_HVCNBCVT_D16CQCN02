using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyThuatDoHoa_Nhom9
{
    public class Str_Collection
    {
        private Str_Collection(string val) { Value = val; }
        public string Value { get; set; }

        public static Str_Collection _Menu { get { return new Str_Collection("Menu"); } }
        public static Str_Collection _3D_shapes { get { return new Str_Collection("3D shapes"); } }
        public static Str_Collection _2D_shapes { get { return new Str_Collection("2D shapes"); } }
        public static Str_Collection _s { get { return new Str_Collection("Menu"); } }

        public override string ToString()
        {
            return Value;
        }
    }
}
