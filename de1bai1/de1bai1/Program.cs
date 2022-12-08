// See https://aka.ms/new-console-template for more information

//Nhap n
Console.Write("n = ");
int n = int.Parse(Console.ReadLine());
//Nhap mang
int[] arr = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write("arr[" + i + "]  = ");
    arr[i] = int.Parse(Console.ReadLine());
}
//Tinh tong
int tong = 0;
for (int i = 0; i < n; i++)
{
    if (arr[i] % 2 == 0)
    {
        tong += arr[i];
    }
}
Console.WriteLine("Tong cac phan tu chan trong mang: " + tong);
//Sap xep tang dan
int temp;
for (int i = 0; i < n - 1; i++)
{
    for (int j = i + 1; j < n; j++)
    {
        if (arr[i] > arr[j])
        {
            temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
for (int i = 0; i < n; i++)
{
    Console.Write(arr[i] + "\t");
}