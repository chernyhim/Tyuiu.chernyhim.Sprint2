using Tyuiu.chernyhim.Sprint2.Task4.V6.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("Введите Х");
        double x, y;
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите Y");
        y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Результат: " + ds.Calculate(x, y));
    }
}