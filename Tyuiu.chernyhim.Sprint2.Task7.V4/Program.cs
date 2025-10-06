using Tyuiu.chernyhim.Sprint2.Task7.V4.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("Введите Х: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите Y: ");
        double y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Результат: " + ds.CheckDotInShadedArea(x, y));
    }
}