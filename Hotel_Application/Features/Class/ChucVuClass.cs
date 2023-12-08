using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Application.Features.Class
{
    public class ChucVuClass
    {
        private int maCV;
        private string tenCV;
        private float phuCap;

        public int MaCV { get => maCV; set => maCV = value; }
        public string TenCV { get => tenCV; set => tenCV = value; }
        public float PhuCap { get => phuCap; set => phuCap = value; }
        public ChucVuClass()
        {
            
        }
    }
}
