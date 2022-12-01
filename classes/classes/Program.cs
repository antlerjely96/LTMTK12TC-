// See https://aka.ms/new-console-template for more information

using classes;

public class Program
{
    public static void Main()
    {
        Students student1 = new Students();
        student1.input();
        student1.output();
        Students[] studentsArray = new Students[20];
    }
}