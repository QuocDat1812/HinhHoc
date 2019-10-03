using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class HinhTron
    {
        public double chuvi;
        public double dientich;
        double pi = 3.14;
        private double r;

        
        public double Bankinh
        {
            get {
                return r;
            }
            set {
                r = value;
            }
        }

        public HinhTron(double r)
        {
            Bankinh = r;
        }

        public HinhTron()
        {
        }
        public void ChuVi()
        {
            chuvi = r * 2 * pi;
        }

        public void DienTich()
        {
            dientich = 2 * pi * (r * r);
        }

    }
}
