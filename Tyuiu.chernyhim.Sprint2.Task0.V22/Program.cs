using Tyuiu.chernyhim.Sprint2.Task0.V22.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("Введите Х");
        int x, y;
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите Y");
        y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(ds.GetCompareOperations(x, y));

    }
}