using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1._5App
{
    internal class hinhtron : hinh
    {
        private double banKinh;

        public hinhtron(double r)
        {
            banKinh = r;
        }

        public override double TinhChuVi()
        {
            return 2 * Math.PI * banKinh;
        }

        public override double TinhDienTich()
        {
            return Math.PI * banKinh * banKinh;
        }
    }
}
