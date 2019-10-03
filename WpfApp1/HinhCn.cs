using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class HinhCn
    {
        public double chuvi;
        public double dientich;
        protected double chieudai;
        private double chieurong;

        
        public double Dai
        {
            get {
                return chieudai;
            }
            set {
                chieudai = value;
            }
        }

        public double Rong
        {
            get {
                return chieurong;
            }
            set {
                chieurong = value;
            }
        }

        public HinhCn(double dai, double rong)
        {
            chieudai = dai;
            chieurong = rong;
        }

        public HinhCn()
        {
        }

        public void ChuVi()
        {
            chuvi = (chieudai + chieurong) * 2;
        }

        public void DienTich()
        {
            dientich = chieudai * chieurong;
        }
    }
}
