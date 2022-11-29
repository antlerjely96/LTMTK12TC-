// See https://aka.ms/new-console-template for more information

/* Nhap mot mang n phan tu. Tinh tong cac phan tu*/
//Nhap n
Console.Write("n = ");
int n = int.Parse(Console.ReadLine());
int tong = 0;
//khai bao mang co n phan tu
int[] arr = new int[n];
//Nhap mang
for (int i = 0; i < n; i++)
{
    Console.Write("arr[" + i + "] = ");
    arr[i] = int.Parse(Console.ReadLine());
}
//Tinh tong cac phan tu
for (int j = 0; j < n; j++)
{
    tong += arr[j];
}
//Hien thi tong
Console.WriteLine("Tong cac phan tu cua mang: " + tong);