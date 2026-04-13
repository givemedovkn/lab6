internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите начало первого отрезка: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Введите конец первого отрезка: ");
        double y = double.Parse(Console.ReadLine());
        LineSegment sec1 = new LineSegment(x, y);

        Console.Write("Введите начало второго отрезка: ");
        x = double.Parse(Console.ReadLine());
        Console.Write("Введите конец второго отрезка: ");
        y = double.Parse(Console.ReadLine());
        LineSegment sec2 = new LineSegment(x, y);
        
        if (sec1 < sec2)
        {
            Console.WriteLine("Отрезки пересекаются");
        }
        else
        {
            Console.WriteLine("Отрезки не пересекаются");
        }

        Console.WriteLine("Первый отрезок: " + sec1);
        Console.WriteLine("Второй отрезок: " + sec2);
        Console.WriteLine("Длина первого отрезка: " + !sec1);
        Console.WriteLine("Длина первого отрезка: " + !sec2);
        int xSec = sec1;
        Console.WriteLine("Значение начала первого отрезка: " + xSec);
        Console.WriteLine("Значение конца первого отрезка: " + (double)sec1);
        Console.Write("Введите целое число: ");
        xSec = int.Parse(Console.ReadLine());
        Console.WriteLine("Начало первого отрезка - " + xSec + " = " + (sec1 - xSec));
        Console.WriteLine("Конец первого отрезка - " + xSec + " = " + (xSec - sec1));
    }
}