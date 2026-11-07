using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5001103027_TrinhMinhHuy_Lab05
{
    public class KhoaHoc
    {
        public string TenKhoaHoc 
        { 
            get; 
            set; 
        }
        public decimal HocPhiMotThang 
        { 
            get; 
            set; 
        }

        public KhoaHoc(string tenKhoaHoc, decimal hocPhiMotThang)
        {
            TenKhoaHoc = tenKhoaHoc;
            HocPhiMotThang = hocPhiMotThang;
        }

        public override string ToString()
        {
            return TenKhoaHoc;
        }
    }
}