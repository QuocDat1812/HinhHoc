using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btnok_Click(object sender, RoutedEventArgs e)
        {
            HinhCn hcn = new HinhCn(4, 3);
            
            hcn.ChuVi();
            hcn.DienTich();
            MessageBox.Show("Chu vi hinh chu nhat: " + hcn.chuvi.ToString()
                            + "\nDien Tich hinh chu nhat: " + hcn.dientich.ToString());

            HinhVuong hv = new HinhVuong(3);
            hv.ChuVi();
            hv.DienTich();
            MessageBox.Show("Chu vi hinh vuong: " + hv.chuvi.ToString()
                            + "\nDien Tich hinh vuong: " + hv.dientich.ToString());
            HinhTron ht = new HinhTron(3);
            ht.ChuVi();
            ht.DienTich();
            MessageBox.Show("Chu vi hinh tron: " + ht.chuvi.ToString()
                            + "\nDien Tich hinh tron: " + ht.dientich.ToString());

            List<HinhVuong> hinhvuongList = new List<HinhVuong>();
            // Nhập tên sinh viên thứ nhất
            hinhvuongList.Add(new HinhVuong());
            List<HinhTron> hinhtronList = new List<HinhTron>();
            hinhtronList.Add(new HinhTron());

            
            foreach (HinhVuong st in hinhvuongList)
            {
                lst.Items.Add(hv.Canh);
                lst.Items.Add(hv.chuvi);
                lst.Items.Add(hv.dientich);
            }

            foreach (HinhTron st in hinhtronList)
            {
                lst2.Items.Add(ht.Bankinh);
                lst2.Items.Add(ht.chuvi);
                lst2.Items.Add(ht.dientich);
            }

        }
    }
}
