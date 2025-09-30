using Tyuiu.chernyhim.Sprint2.Task2.V20.Lib;
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
        Console.WriteLine("Результат: " + ds.CheckDotInShadedArea(x, y));
    }
}