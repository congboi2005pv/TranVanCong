using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1._5App
{
    internal class hinhvuong : hinh
    {
        private double canh;

        public hinhvuong(double c)
        {
            canh = c;
        }

        public override double TinhChuVi()
        {
            return 4 * canh;
        }

        public override double TinhDienTich()
        {
            return canh * canh;
        }
    }
}
