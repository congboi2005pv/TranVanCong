using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1._5App
{
    internal class ChuongTring
    {
            static void Main(string[] args)
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;

                List<hinh> danhSachHinh = new List<hinh>();

                // Thêm các hình
                danhSachHinh.Add(new hinhtron(10));
                danhSachHinh.Add(new hinhvuong(10));
                danhSachHinh.Add(new hinhchunhat(4, 6));
                danhSachHinh.Add(new hinhtamgiac(5, 6, 5));

                double tongChuVi = 0;
                double tongDienTich = 0;

                int i = 1;
                foreach (hinh h in danhSachHinh)
                {
                    double chuVi = h.TinhChuVi();
                    double dienTich = h.TinhDienTich();
                    Console.WriteLine($"Hình {i++}: Chu vi = {chuVi:F2}, Diện tích = {dienTich:F2}");
                    tongChuVi += chuVi;
                    tongDienTich += dienTich;
                }

                Console.WriteLine($"\n🔷 Tổng chu vi các hình: {tongChuVi:F2}");
                Console.WriteLine($"🔶 Tổng diện tích các hình: {tongDienTich:F2}");
            }
    }
}
