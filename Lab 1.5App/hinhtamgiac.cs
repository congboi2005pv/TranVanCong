using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1._5App
{
    internal class hinhtamgiac : hinh
    {
        private double a, b, c;

        public hinhtamgiac(double canh1, double canh2, double canh3)
        {
            a = canh1;
            b = canh2;
            c = canh3;
        }

        public override double TinhChuVi()
        {
            return a + b + c;
        }

        public override double TinhDienTich()
        {
            double p = TinhChuVi() / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
