using Tyuiu.chernyhim.Sprint2.Task3.V29.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("Введите Х");
        double x;
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Результат: " + ds.Calculate(x));
    }
}