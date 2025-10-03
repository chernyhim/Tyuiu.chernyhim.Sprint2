using Tyuiu.chernyhim.Sprint2.Task6.V12.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int d, m, g;
        Console.WriteLine("Введите число:");
        d = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите месяц:");
        m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите год:");
        g = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Предыдущий день: " + ds.FindDateOfPreviousDay(g,m,d));
    }
}