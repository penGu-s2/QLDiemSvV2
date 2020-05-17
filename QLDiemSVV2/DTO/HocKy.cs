using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDiemSVV2.DTO
{
    class HocKy
    {
        public string MaHK { get; set; }

        private string hocKy;

        public string GetHocKy()
        {
            return hocKy;
        }

        public void SetHocKy(string value)
        {
            hocKy = value;
        }
    }
}
