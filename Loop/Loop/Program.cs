// See https://aka.ms/new-console-template for more information

//Nhap so nguyen n. Tinh tong cac so tu 1 den n

//Nhap n
Console.Write("n = ");
int n = int.Parse(Console.ReadLine());
//Tinh tong
int tong_for = 0;
Console.WriteLine("------- for ---------");
for (int i = 0; i < n; i++)
{
    tong_for += i;
}
Console.WriteLine("tong = " + tong_for);
Console.WriteLine("------- while --------");
int j = 0;
int tong_while = 0;
while (j < n)
{
    tong_while += j;
    j++;
}
Console.WriteLine("tong = " + tong_while);
Console.WriteLine("------- do - while --------");
int k = 0;
int tong_do_while = 0;
do
{
    tong_do_while += k;
    k++;
} while(k < n);
Console.WriteLine("tong = " + tong_do_while);