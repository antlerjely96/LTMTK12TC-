namespace de1bai2;

public class hocSinh
{
    public string maSinhVien;
    public string hoTen;
    public double diemToan;
    public double diemVan;
    public double diemTiengAnh;
    public double diemTrungBinh;

    public void nhap()
    {
        Console.Write("Ma Sinh Vien: ");
        this.maSinhVien = Console.ReadLine();
        Console.Write("Ho ten: ");
        this.hoTen = Console.ReadLine();
        Console.Write("Diem toan: ");
        this.diemToan = Double.Parse(Console.ReadLine());
        Console.Write("Diem Van: ");
        this.diemVan = Double.Parse(Console.ReadLine());
        Console.Write("Diem Tieng Anh: ");
        this.diemTiengAnh = Double.Parse(Console.ReadLine());
    }

    public void hienThi()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Ma Sinh Vien: " + this.maSinhVien);
            Console.WriteLine("Ho ten: " + this.hoTen);
            Console.Write("Diem toan: " + this.diemToan);
            Console.Write("Diem Van: " + this.diemVan);
            Console.Write("Diem Tieng Anh: " + this.diemTiengAnh);
            Console.Write("Diem trung binh: " + this.diemTrungBinh);
        }
    }

    public void tinhDiemTrungBinh()
    {
        this.diemTrungBinh = (this.diemToan + this.diemVan + this.diemTiengAnh) / 3;
    }

    public void diemCaoNhat(hocSinh[] hs)
    {
        double max = hs[0].diemTrungBinh;
        for (int i = 0; i < 10; i++)
        {
            if (max < hs[i].diemTrungBinh)
            {
                max = hs[i].diemTrungBinh;
            }
        }

        for (int i = 0; i < 10; i++)
        {
            if (max == hs[i].diemTrungBinh)
            {
                hs[i].hienThi();
            }
        }
    }
    
    public void diemThapNhat(hocSinh[] hs)
    {
        double min = hs[0].diemTrungBinh;
        for (int i = 0; i < 10; i++)
        {
            if (min > hs[i].diemTrungBinh)
            {
                min = hs[i].diemTrungBinh;
            }
        }

        for (int i = 0; i < 10; i++)
        {
            if (min == hs[i].diemTrungBinh)
            {
                hs[i].hienThi();
            }
        }
    }
}