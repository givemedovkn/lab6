internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("false - не сломано, true - сломано");
        CheckCar car1 = new CheckCar();
        Console.Write("Опишите состояние двигателя: ");
        bool brokenEngine = bool.Parse(Console.ReadLine());
        Console.Write("Опишите состояние колес: ");
        bool brokenPressure = bool.Parse(Console.ReadLine());
        CheckCar car2 = new CheckCar(brokenEngine, brokenPressure);
        CheckCar car3 = new CheckCar(car1);

        Console.WriteLine("Результаты: ");
        Console.WriteLine("Первая машина (по умолчанию): " + car1);
        Console.WriteLine("Вторая машина (ввод): " + car2);
        Console.WriteLine("Третья машина (копия 1): " + car3);

        Console.WriteLine("Вторая машина сломана? " + car2.IsBroken());


        DeepCheckCar deepCar4 = new DeepCheckCar();
        Console.Write("\nМашина 4 (по умолчанию): ");
        deepCar4.Recomendation();

        Console.WriteLine("Машина 5: ");
        double[] userWheels = new double[4];
        for (int i = 0; i < 4; i++)
        {
            Console.Write($"Введите давление в колесе {i + 1} (норма 2,5): ");
            userWheels[i] = double.Parse(Console.ReadLine());
        }
        DeepCheckCar deepCar5 = new DeepCheckCar(brokenEngine, userWheels);

        Console.WriteLine("\nРезультаты глубокой проверки (до запуска проверки давления):");
        Console.WriteLine(deepCar5);

        deepCar5.CheckPressure();

        Console.WriteLine("\nРезультаты после запуска проверки давления:");
        Console.WriteLine(deepCar5);
        deepCar5.Recomendation();
    }
}