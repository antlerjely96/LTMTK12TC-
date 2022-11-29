// See https://aka.ms/new-console-template for more information

public class Program
{
    //3 method
    //Method nhap
    public static int nhap()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        return n;
    }
    //Method tinh n!
    public static void tinhGiaiThua(int n)
    {
        int giaiThua = 1;
        if (n < 0)
        {
            Console.WriteLine("n! khong ton tai");
        }
        else if(n == 0)
        {
            giaiThua = 1;
        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                giaiThua *= i;
            }
        }
        hienThi(giaiThua);
    }
    //Method hien thi
    public static void hienThi(int giaiThua)
    {
        Console.WriteLine("n! = " + giaiThua);
    }
    public static void Main()
    {
        //Nhap mot so nguyen n. Tinh n!
        int n = nhap();
        tinhGiaiThua(n);
    }
}