// See https://aka.ms/new-console-template for more information

using de1bai2;

public class Program
{
    public static void Main()
    {
        hocSinh[] hs = new hocSinh[10];
        for (int i = 0; i < 10; i++)
        {
            hs[i] = new hocSinh();
            Console.WriteLine("Nhap thong tin " + (i + 1));
            hs[i].nhap();
            hs[i].tinhDiemTrungBinh();
        }

        hocSinh temp = new hocSinh();
        temp.diemCaoNhat(hs);
        temp.diemThapNhat(hs);
    }
}