// See https://aka.ms/new-console-template for more information


/* Khai bao struct luu thong tin sv gom: id, name, phone, address, age*/
public class Program
{
    public struct Students
    {
        public string id;
        public string name;
        public string phone;
        public int age;
        public string address;
    }
    
    //Tao 1 bien cua struct
    public static void Main()
    {
        Students s1;
        s1.id = "BKC12564";
        s1.name = "A";
        s1.phone = "0123456789";
        s1.age = 20;
        s1.address = "HN";
        //Khai bao mot mang cac bien
        Students[] student = new Students[10];
    }
}