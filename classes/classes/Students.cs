namespace classes;

public class Students
{
    public string id;
    public string name;
    public string phone;
    public int age;
    public string address;

    public void input()
    {
        Console.Write("ID: ");
        this.id = Console.ReadLine();
        Console.Write("Name: ");
        this.name = Console.ReadLine();
        Console.Write("Phone: ");
        this.phone = Console.ReadLine();
        Console.Write("Age: ");
        this.age = int.Parse(Console.ReadLine());
        Console.Write("Address: ");
        this.address = Console.ReadLine();
    }

    public void output()
    {
        Console.WriteLine("Student Information:");
        Console.WriteLine("ID: " + this.id);
        Console.WriteLine("name: " + this.name);
        Console.WriteLine("phone: " + this.phone);
        Console.WriteLine("Age: " + this.age);
        Console.WriteLine("address: " + this.address);
    }
}