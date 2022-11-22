// See https://aka.ms/new-console-template for more information

/* Nhap 1 so nguyen, kiem tra so do la so am hay duong */

//Khai bao so nguyen
int a;
//Nhap
Console.Write("Nhap a = ");
a = int.Parse(Console.ReadLine());
//Kiem tra
if (a > 0)
{
    Console.WriteLine(a + " la so duong");
} else if (a < 0)
{
    Console.WriteLine(a + " la so am");
}
else
{
    Console.WriteLine(a + " la so khong am khong duong");
}

//Nhap 3 so thuc a, b, c. Kiem tra phuong trinh a * x^2 + b * x + c = 0 co bao nhieu nghiem


