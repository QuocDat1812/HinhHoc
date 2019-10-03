using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class HinhVuong : HinhCn
    {
        private string v;

        public double Canh
        {
            get {
                return chieudai;
            }
            set {
                chieudai = value;
            }
        }

        public HinhVuong()
        {
        }

        public HinhVuong(double canh)
        {
            chieudai = canh;
        }

        public HinhVuong(string v)
        {
            this.v = v;
        }

        public new void ChuVi()
        {
            chuvi = Dai * 4;
        }
        public new void DienTich()
        {
            dientich = Dai * Dai;
        }
    }
}
