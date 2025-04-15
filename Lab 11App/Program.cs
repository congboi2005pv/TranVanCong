// See https://aka.ms/new-console-template for more information
using System;

Console.OutputEncoding = System.Text.Encoding.UTF8;

//Bài 1:Viết chương trình nhập vào tên và tuổi, sau đó in ra màn hình thông báo "Xin chào [tên], bạn[tuổi] tuổi!".
//String ten;
//Console.Write("Nhập tên : ");
//ten = Console.ReadLine();
//int tuoi;
//Console.Write("Nhập tuổi : ");
//tuoi = int.Parse(Console.ReadLine() ?? "0" );
//Console.WriteLine($"Xin Chào {ten}, ban {tuoi} tuoi !");

//Bài 2: Viết chương trình tính diện tích của hình chữ nhật khi người dùng nhập chiều dài và chiều rộng. 
//double chieudai, chieurong,dientich;
//try
//{
//    Console.Write("Nhập chiều dài : ");
//    chieudai = float.Parse(Console.ReadLine() ?? "0");
//    Console.Write("Nhập chiều rộng : ");
//    chieurong = float.Parse(Console.ReadLine() ?? "0");
//    if (chieudai <= 0 || chieurong <= 0)
//        throw new Exception("Độ dài phải lớn hơn 0");
//    dientich = chieudai * chieurong;
//    Console.WriteLine($"Diện tích hình chữ nhật là : {dientich}");
//}
//catch (FormatException ex)
//{
//    Console.WriteLine($"Loi nhap lieu: {ex.Message}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//Bài 3: Viết chương trình chuyển đổi nhiệt độ từ độ C sang độ F 
//Công thức: F = (C * 9 / 5) + 32
//float f, c;
//try
//{
//    Console.Write("Nhập độ C : ");
//    c = float.Parse(Console.ReadLine() ?? "0");
//    f = (c * 9 / 5) + 32;
//    Console.Write($"Chuyển đổi từ độ C sang độ F bằng : {f}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"Lỗi nhập liệu {ex.Message}");
//}

//Bài 4: Viết chương trình nhập vào một số nguyên và kiểm tra xem số đó có phải là số chẵn hay không.
//int nhap;
//try
//{
//    Console.Write("Nhập vào một số nguyên bất kì : ");
//    nhap = int.Parse(Console.ReadLine() ?? "0");
//    if (nhap % 2 == 0)
//    {
//        if (nhap % 2 == 0 && nhap < 0)
//        {
//            Console.WriteLine("Số nguyên âm này là Số chẵn");
//        }
//        else if (nhap == 0)
//        {
//            Console.WriteLine("Số nguyên này là số chẵn");
//        }
//        else
//        {
//            Console.WriteLine("Số nguyên dương này là Số chẵn");
//        }
//    }
//    else
//    {
//        if (nhap < 0)
//        {
//            Console.WriteLine("Số nguyên âm này là Số lẻ");
//        }
//        else
//        {
//            Console.WriteLine("Số nguyên dương này là Số lẻ");
//        }
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//Bài 5: Viết chương trình tính tổng và tích của hai số nhập từ bàn phím.
//float a, b;
//try
//{
//    Console.Write($"Nhập số đầu tiên :");
//    a = float.Parse(Console.ReadLine() ?? "0");
//    Console.Write($"Nhập số thứ hai :");
//    b = float.Parse(Console.ReadLine() ?? "0");
//    float tong;
//    tong = a + b;
//    Console.WriteLine($"Tông của hai số trên là : {tong}");
//    float tich;
//    tich = a * b;
//    Console.WriteLine($"Tích của hai số trên là : {tich}");

//}
//catch (Exception ex) 
//{
//    Console.WriteLine(ex.Message);
//	//throw;
//}

//Bài 6: Viết chương trình kiểm tra xem một số nhập vào có phải là số dương, số âm hay số không.
//float nhap;
//while (true)
//{
//    Console.Write("Nhập một số bất kỳ : ");
//    try
//    {
//        nhap = float.Parse(Console.ReadLine() ?? "0");
//        if (nhap == 0)
//        {
//            Console.WriteLine($"Số 0 là số nguyên");
//        }
//        else if (nhap > 0)
//        {
//            Console.WriteLine($"{nhap} là Số  dương");
//        }
//        else
//        {
//            Console.WriteLine($"{nhap} là Số  âm");
//        }
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine(ex.Message);
//        //throw;
//    }
//}

// Bài 7: Viết chương trình kiểm tra xem một năm nhập vào có phải là năm nhuận hay không. 
//(Năm nhuận là năm chia hết cho 4, trừ các năm chia hết cho 100 nhưng không chia hết cho 400).
// tóm lại là năm chia hết cho 4 và những năm nào chia hết cho 100 nhưng không chia hết cho 400 thì không phải
//int nam;
//try
//{

//    nam = int.Parse(Console.ReadLine() ?? "0");
//    if (nam % 4 == 0 && nam % 100 != 0 || nam % 400 == 0)
//    {
//        Console.WriteLine($"Năm {nam} là năm nhuận");
//    }
//    else
//    {
//        Console.WriteLine($"Năm {nam} không phải năm nhuận");
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);

//}

//Bài 8: Viết chương trình in ra bảng cửu chương từ 1 đến 10.
//for (int i = 0; i <= 10; i++)
//{
//    for (int j = 0; j <= 10; j++)
//    {
//        Console.WriteLine($"{i}*{j} = {i*j}");
//    }
//    Console.WriteLine();
//}

//Bài 9: Viết chương trình tính giai thừa của một số nguyên dương n. 
//int nhap;
//try
//{
//    Console.WriteLine("Nhập một số bất kì : ");
//    nhap = int.Parse(Console.ReadLine() ?? "0");
//    int giaithua = 1;
//    for (int i = 1; i <= nhap; i++)
//    {
//        giaithua *= i;
//    }
//    Console.WriteLine(giaithua);

//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//	throw;
//}

//Bài 10: Viết chương trình kiểm tra xem một số có phải là số nguyên tố hay không.
int nhap;
nhap = int.Parse(Console.ReadLine() ?? "0");
if (nhap == 1)
{
    Console.WriteLine("Không phải số nguyên tố");
}
int count;
for (int i = 2; i <Math.Sqrt(nhap) ; i++)
{

}
