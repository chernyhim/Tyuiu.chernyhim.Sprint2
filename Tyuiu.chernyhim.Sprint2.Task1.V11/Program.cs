using Tyuiu.chernyhim.Sprint2.Task1.V11.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("Введите A");
        int x, y, z, w;
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите B");
        y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите C");
        z = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите D");
        w = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(ds.GetLogicOperations(x, y, z, w));
    }
}